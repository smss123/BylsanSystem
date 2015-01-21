﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Security;
using XamaDataLayer.Accountant;
using Xprema.XExtention;
using Bylsan_System.Reports.ReportCommand;
using Telerik.WinControls.UI;
using System.Data.Linq;

namespace Bylsan_System.SenarioAddOrderForms
{ // 1
    public partial class FrmTotalOrder : RadForm
    {//2
        public FrmTotalOrder()
        {
            InitializeComponent();


            var ListPerm = XamaDataLayer.Security.PermessionsCmd.GetAllUserPermissonsByUserID(XamaDataLayer.Security.UserInfo.CurrnetUser.ID);
            try
            {
                if (Convert.ToBoolean(ListPerm[0].PermessionValue.ToString()) == false) { txtDiscountBox.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[4].PermessionValue.ToString()) == false) { PrintBtn.Enabled = false; }

            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                
                return;
            }

          

        }
        public string  TragetOrderType { get; set; }
      


        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            txtBranches.DataSource = Operation.AllBranches;
            txtBranches.DisplayMember = "Branch_Name";
            txtBranches.ValueMember = "ID";
            radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();
         
            float TotalPrice = 0f;
           
            foreach (var item in radGridView1.Rows)
            {


                TotalPrice += item.Cells[3].Value.ToString().ToFloat();
            }
            TotalPriceBox.Text = TotalPrice.ToString();

            Operation.EndOperation(this);
        }

        private void OkeyBtn_Click(object sender, EventArgs e)
        {
          

            Operation.BeginOperation(this);
            //========================================
            double TotalCost;
            if (txtDiscountBox.Text != "") 
            {
                TotalCost = ComputeDiscount(Convert.ToDouble(TotalPriceBox.Text.ToString()), Convert.ToDouble(txtDiscountBox.Text.ToString()));
            }
            else
            {
                TotalCost = Convert.ToDouble(TotalPriceBox.Text.ToString());
            }
           // MessageBox.Show("total Cost : " + TotalCost.ToString());
            //========================================
            // Get Branch 
            var CurrentBranch = Operation.AllBranches.Where(p => p.ID == txtBranches.SelectedValue.ToString().ToInt ()).Take(1).Single();// BranchsCmd.GetBranchByBarnchID(int.Parse(txtBranches.SelectedValue.ToString()));
            int CustId = 0;
            int? CustmerAccountID = 0;
            if(CustomerInformations.WatingCustomer.ID == 0 ){
                //===Save New Customer ___
                Customer ctb = new Customer()
                {
                    CustomerName = CustomerInformations .WatingCustomer.CustomerName , CreateDate = DateTime .Now ,
                    PhoneNumber = CustomerInformations .WatingCustomer.PhoneNumber  ,Points = 0 ,
                };
                CustomersCmd.AddCustomer(ctb);
                // === Get New Customer ID  & AccountID :
                //var q = CustomersCmd.GetAllCustmerByID(ctb.ID);
                CustId = ctb.ID;
             
                CustmerAccountID = ctb.AccountID;
            }
            else
            {
                CustId = CustomerInformations.WatingCustomer.ID;
                CustmerAccountID = CustomerInformations.WatingCustomer.AccountID;
            }

            //=== Save At Order 
            Order otb = new Order();
            DbDataContext db = new DbDataContext();
            otb.OrderName = string.Format("{0}_{1}", CustomerInformations.WatingCustomer.CustomerName, DateTime.Now.ToString());
            otb.OrderDelivery = AddresstextBox.Text;
       
             switch  (  CustomerInformations .OrdrType) {
                 case "Special":
                     otb.OrderStatus = "In Designer";   otb.OrderType = "Special";
                     break;
                 case "Normal":
                     otb.OrderStatus = "in producting ";   otb.OrderType = "Normal";
                     break;
             }
           
            otb.OrderDate = DateTime.Now;
            otb.TotalAmount =  (TotalPriceBox.Text).Todouble();
            otb.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
            otb.Comment = "";
            otb.OrderVerify = "from Branch";
            otb.CustomerID = CustId;
            otb.OrderDeliveryDate = receiptdateTimePicker.Value;
            otb.DeliverdToBranch =  (txtBranches.SelectedValue.ToString()).ToInt();

            db.Orders.InsertOnSubmit(otb);
            db.SubmitChanges();

            //=========================================================================
             xLastOrderID = otb.ID;
            //==========================================================================
            //=== Save At OrderProduct
            OrderProduct ordtb = new OrderProduct();
            foreach (var item in CustomerInformations.WaitingOrder.OrderProducts.ToList())
	        {
                ordtb = new OrderProduct();
                ordtb.OrderID = otb.ID;
                ordtb.Description = "Not Found";
                ordtb.ImageX = item.ImageX;
                ordtb.ProductID = item.ProductID;
                ordtb.Qty = item.Qty;
                ordtb.Status = item.Status;
                OrderProductsCmd.AddOrderProduct(ordtb);
  
                db = new DbDataContext();
            }
         
            //=========================================
            // == Save At AccountDaily :
            AccountDaily addOrder = new AccountDaily()
            { //500
                AccountID = otb.OrderAccount,
                // AccountID = CustmerAccountID ,
                TotalIn = TotalCost,// Convert .ToDouble ( TotalPriceBox.Text ),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), CurrentBranch.Branch_Name),

            };
            db.AccountDailies.InsertOnSubmit(addOrder); 

            //----------------------------------------------------------------------
            AccountDaily ordertrs = new AccountDaily()
            { //500
                AccountID = otb.OrderAccount,
                TotalIn = 0f,
                TotalOut = TotalCost,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), CurrentBranch.Branch_Name),
            };
            db.AccountDailies.InsertOnSubmit(ordertrs);
            //--------------------------
            AccountDaily CustomerDept = new AccountDaily()
            { //500
                AccountID = CustmerAccountID,
                TotalIn = 0f,
                TotalOut = TotalCost,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), CurrentBranch.Branch_Name),

            };
            db.AccountDailies.InsertOnSubmit(CustomerDept);

            //--------------------------
            AccountDaily CutomerPay = new AccountDaily()
            { //500
                AccountID = CustmerAccountID,              
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), CurrentBranch.Branch_Name),

            };

            db.AccountDailies.InsertOnSubmit(CutomerPay);
            AccountDaily BranchCreated = new AccountDaily()
            { //500
                AccountID = CurrentBranch.AccountID,
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), CurrentBranch.Branch_Name),

            };

            db.AccountDailies.InsertOnSubmit(BranchCreated);
            db.SubmitChanges();
         //=============================================================================
            // Save Order Prouct Attachment :
            int OrdPrd = (from o in OrderProductsCmd .GetAll ()  select o.ID ).Max ();

             OrderProuctAttachment attb = new OrderProuctAttachment();
             foreach (var item in CustomerInformations .WaitingAttachment )
             {
                 attb = new OrderProuctAttachment() { 
                 Description = item .Description ,
                 imageX = item .imageX ,
                 OrderProductID = OrdPrd ,
                 };
                 OrderProuctAttachmentCmd.AddOrderProductAttachment(attb);
             }
          
            //============================================================================
            Operation.EndOperation(this);

            Operation.ShowToustOk("Saved Successfull ....", this);

            PrintBtn.Enabled = true;
            ReceiptVoucherButton.Enabled = true;
        }


        #region " ^^^^  Compute Discount  "
        private double ComputeDiscount(double TotalCost, double DiscountValue)
        {
            // ( المبلغ الأصلي ) - ( المبلغ الأصلي * (الخصم ÷ 100) )
         
            double NetTotalCostPrice = TotalCost - (TotalCost * (DiscountValue / 100));
      
            return NetTotalCostPrice;
        }
        #endregion

        int xLastOrderID;
        private void txtDiscountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ^^^ Abu Ehab : 
            string strvalid = "0123456789.";
            if (e.KeyChar > 26)
            {
                if (((strvalid.IndexOf(e.KeyChar) + 1) == 0))
                {
                    e.KeyChar = '\0';
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            OrderReportCmd cmd = new OrderReportCmd();
            cmd.GetOrderBill(xLastOrderID);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            Application.OpenForms["FrmAddOrderProduct"].Show();
               
                
            
        }
    }
}
