using System;
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
namespace Bylsan_System.SenarioAddOrderForms
{ // 1
    public partial class FrmTotalOrder : Form
    {//2
        public FrmTotalOrder()
        {
            InitializeComponent();
        }
        public string  TragetOrderType { get; set; }
      


        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            txtBranches.DataSource = BranchsCmd.GetAllBranchs();
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




            // Get Branch 
            var CurrentBranch = BranchsCmd.GetBranchByBarnchID(int.Parse(txtBranches.SelectedValue.ToString()));
            int CustId = 0;
            int? CustmerAccountID = 0;
            if(CustomerInformations.WatingCustomer.ID == 0 ){
                //===Save New Customer ___
                Customer ctb = new Customer()
                {
                    CustomerName = CustomerInformations .CustmrName , CreateDate = DateTime .Now ,
                    PhoneNumber = CustomerInformations .CustmrPhone ,Points = 0 ,
                };
                CustomersCmd.AddCustomer(ctb);
                // === Get New Customer ID  & AccountID :
                var q = CustomersCmd.GetAllCustmerByID(ctb.ID);
                CustId = ctb.ID;
             
                CustmerAccountID = q.AccountID;
            }
            else
            {
                CustId = CustomerInformations.WatingCustomer.ID;
                CustmerAccountID = CustomerInformations.WatingCustomer.AccountID;
            }

            //=== Save At Order 
            Order otb = new Order();
            DbDataContext db = new DbDataContext();
            otb.OrderName = CustomerInformations.WatingCustomer.CustomerName + "_" + DateTime.Now.ToString();
            otb.OrderDelivery = AddresstextBox.Text;
       
             switch  (  CustomerInformations .OrdrType) {
                 case "Special":
                     otb.OrderStatus = "In Designer";   otb.OrderType = "Special";
                     break;
                 case "Normal":
                     otb.OrderStatus = "Printing";   otb.OrderType = "Normal";
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
            int xLastOrderID = otb.ID;
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
            AccountDaily DyTb = new AccountDaily() { 
                AccountID = CustmerAccountID ,
                TotalIn = Convert .ToDouble ( TotalPriceBox.Text ),
                DateOfProcess = DateTime .Now ,
                Description = "Payment Of  A Normal Order",
                
            };
            AccountDailyCmd.AddAccountDaily(DyTb);
            //=========================================
            
            
           AccountDaily  RDyTb = new AccountDaily()
            {
                AccountID = CurrentBranch .AccountID ,
                TotalIn = Convert.ToDouble(TotalPriceBox.Text),
                DateOfProcess = DateTime.Now,
                Description = "Income payment  A Normal Order",
            };
            AccountDailyCmd.AddAccountDaily(RDyTb);
            //==========================================================




            MessageBox.Show("Saved ");

        }


      

        private void txtBranches_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }
    }
}
