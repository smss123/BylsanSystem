using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Security;
using Xprema.XExtention;
using Bylsan_System.Reports.ReportCommand;
using Telerik.WinControls.UI;
using XamaDataLayer.SettingX;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmTotalOrder : RadForm
    {
        public FrmTotalOrder()
        {
            InitializeComponent();


            var ListPerm = XamaDataLayer.Security.PermessionsCmd.GetAllUserPermissonsByUserID(XamaDataLayer.Security.UserInfo.CurrnetUser.ID);
            try
            {
                if (Convert.ToBoolean(ListPerm[0].PermessionValue.ToString()) == false)
                {
                    txtDiscountBox.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[4].PermessionValue.ToString()) == false)
                {
                    PrintBtn.Enabled = false;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return;
            }
        }
        public string  TragetOrderType { get; set; }


        string orderID;
        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            txtBranches.DataSource = Operation.AllBranches;
            txtBranches.DisplayMember = "Branch_Name";
            txtBranches.ValueMember = "ID";
            radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();

            var TotalPrice = 0f;

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

            double totalCost;
            if (txtDiscountBox.Text != string.Empty)
            {
                totalCost = ComputeDiscount(Convert.ToDouble(TotalPriceBox.Text.ToString()), Convert.ToDouble(txtDiscountBox.Text.ToString()));
            }
            else
            {
                totalCost = Convert.ToDouble(TotalPriceBox.Text.ToString());
            }



            var currentBranch = Operation.AllBranches.Where(p => p.ID == txtBranches.SelectedValue.ToString().ToInt ()).Take(1).Single();
            var custId = 0;
            var custmerAccountID = (int? )0;
            if (CustomerInformations.WatingCustomer.ID == 0)
            {
                var ctb = new Customer()
                {
                    ID=ApiCounter.GetNumber(),
                    CustomerName = CustomerInformations.WatingCustomer.CustomerName,
                    CreateDate = DateTime.Now,
                    PhoneNumber = CustomerInformations.WatingCustomer.PhoneNumber,
                    Points = (TotalPriceBox.Text.Todouble() * SettingCmd.GetSettingByID(2).SettingValue.Todouble()).ToString().ToInt(),
                };
                CustomersCmd.AddCustomer(ctb);


                custId = ctb.ID;

                custmerAccountID = ctb.AccountID;
            }
            else
            {
                custId = CustomerInformations.WatingCustomer.ID;
                double custom =  SettingCmd.GetSettingByID(2).SettingValue.Todouble();
                custmerAccountID = CustomerInformations.WatingCustomer.AccountID;
                CustomerInformations.WatingCustomer.Points = CustomerInformations.WatingCustomer.Points + (TotalPriceBox.Text.Todouble() * custom).ToString().ToInt();
                CustomersCmd.EditCustomer(CustomerInformations.WatingCustomer, CustomerInformations.WatingCustomer.ID);
            }


            var otb = new Order();
            var db = new DbDataContext();

       
            otb.OrderName = string.Format("{0}_{1}", CustomerInformations.WatingCustomer.CustomerName, DateTime.Now.ToString());
            otb.OrderDelivery = AddresstextBox.Text;

            switch  (  CustomerInformations .OrdrType)
            {
                case "Special":
                    otb.OrderStatus = "In Designer";
                    otb.OrderType = "Special";
                    break;
                case "Normal":
                    otb.OrderStatus = "in producting ";
                    otb.OrderType = "Normal";
                    break;
            }
            
            otb.OrderDate = DateTime.Now;
            otb.TotalAmount =  (TotalPriceBox.Text).Todouble();
            otb.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
            otb.Comment = txtCommint.Text;
            otb.OrderVerify = "from Branch";
            //otb.CustomerID = custId;
            otb.OrderDeliveryDate = receiptdateTimePicker.Value;
            otb.DeliverdToBranch =  (txtBranches.SelectedValue.ToString()).ToInt();
            otb.CustomerID = custId;

            if (otb.ID==0)
            
           {
               otb.ID = ApiCounter.GetNumber();
                db.Orders.InsertOnSubmit(otb);
                db.SubmitChanges();
            }
            else
            {
                db.Orders.Attach(otb, true);

            }

            orderID = otb.ID.ToString();
         


            xLastOrderID = otb.ID;


            var ordtb = new OrderProduct();
            foreach (var item in CustomerInformations.WaitingOrder.OrderProducts.ToList())
            {
                ordtb = new OrderProduct();
                ordtb.OrderID = otb.ID;
                ordtb.Description = item.Description;
                ordtb.ImageX = item.ImageX;
                ordtb.ProductID = item.ProductID;
                ordtb.Qty = item.Qty;
                ordtb.Status = item.Status;
                ordtb.ID = ApiCounter.GetNumber();
                OrderProductsCmd.AddOrderProduct(ordtb);
                foreach (var atta in item.OrderProuctAttachments.ToList())
                {

                    var attb = new OrderProuctAttachment()
                                 {
                                     Description = atta.Description,
                                      CustomerText = atta.CustomerText,
                                     imageX = atta.imageX,
                                     OrderProductID = ordtb.ID,
                                      ID= ApiCounter.GetNumber()
                                 };

                    OrderProuctAttachmentCmd.AddOrderProductAttachment(attb);
                    
                }
                
                
            }



            var addOrder = new AccountDaily()
            {
                 ID=ApiCounter.GetNumber(),
                AccountID = otb.OrderAccount,
                TotalIn = totalCost,
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), currentBranch.Branch_Name),
             CommandArg= otb.ID.ToString()};
            db.AccountDailies.InsertOnSubmit(addOrder);


            var ordertrs = new AccountDaily()
            { 
                  ID=ApiCounter.GetNumber(),
                AccountID = otb.OrderAccount,
                TotalIn = 0f,
                TotalOut = totalCost,
                DateOfProcess = DateTime.Now,
              Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), currentBranch.Branch_Name),
              CommandArg = otb.ID.ToString()
            };
            db.AccountDailies.InsertOnSubmit(ordertrs);

            var CustomerDept = new AccountDaily()
            {  ID=ApiCounter.GetNumber(),
                AccountID = custmerAccountID,
                TotalIn = 0f,
                TotalOut = totalCost,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), currentBranch.Branch_Name),
              CommandArg = otb.ID.ToString()
            };
            db.AccountDailies.InsertOnSubmit(CustomerDept);


            var CutomerPay = new AccountDaily()
            { 
                  ID=ApiCounter.GetNumber(),
                AccountID = custmerAccountID,
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), currentBranch.Branch_Name),
              CommandArg = otb.ID.ToString()
            };

            db.AccountDailies.InsertOnSubmit(CutomerPay);
            var BranchCreated = new AccountDaily()
            {
                 ID=ApiCounter.GetNumber(),
                AccountID = currentBranch.AccountID,
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", otb.OrderName, DateTime.Now.ToString(), currentBranch.Branch_Name),
              CommandArg = otb.ID.ToString()
            };

            db.AccountDailies.InsertOnSubmit(BranchCreated);
            db.SubmitChanges();





            Operation.EndOperation(this);

            Operation.ShowToustOk("Saved Successfull ....", this);

            PrintBtn.Enabled = true;
            ReceiptVoucherButton.Enabled = true;
            OkeyBtn.Enabled = false;
        }



        private double ComputeDiscount(double totalCost, double discountValue)
        {
            var netTotalCostPrice = totalCost - (totalCost * (discountValue / 100));

            return netTotalCostPrice;
        }


        private int xLastOrderID;
        private void txtDiscountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var strvalid = "0123456789.";
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
            var cmd = new OrderReportCmd();
            cmd.GetOrderBill(xLastOrderID);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmAddOrderProduct"].Show();
            this.Close();
        }

        private void ReceiptVoucherButton_Click(object sender, EventArgs e)
        {
            //ExchangebondReportCmd.ShowPayment//(TotalPriceBox.Text);
            ExchangebondReportCmd.ShowPayment(cost: txtPayment.Text, Dt: DateTime.Now, customerName: NameLab.Text, vnumber: orderID, payVouterCost: "0", rema: (TotalPriceBox.Text.Todouble() - txtPayment.Text.Todouble()).ToString());
        }
    }
}
