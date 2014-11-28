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
                CustId = (from i in CustomersCmd.GetAllCustmers() select i.ID).Max();
                CustmerAccountID = (from i in CustomersCmd.GetAllCustmers() select i.AccountID ).Max();
            
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
            otb.OrderStatus = "Designer";
            otb.OrderDate = DateTime.Now;
            otb.TotalAmount = Convert.ToDouble (TotalPriceBox.Text);
            otb.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
            otb.Comment = "Xprema";
            otb.OrderVerify = "from Branch";
            otb.CustomerID = CustId;
            otb.OrderDeliveryDate = receiptdateTimePicker.Value;
            otb.DeliverdToBranch = int .Parse (txtBranches.SelectedValue.ToString());

            db.Orders.InsertOnSubmit(otb);
            db.SubmitChanges();

            //=========================================================================
            int xLastOrderID = (from o in OrdersCmd.GetAllOrders() select o.ID).Max ();
            //==========================================================================
            //=== Save At OrderProduct
            
            foreach (var   rw in radGridView1 .Rows )
            {
       
                OrderProduct ordtb = new OrderProduct() { 
                   OrderID  = xLastOrderID ,
                   ProductID = int.Parse(rw.Cells[4].Value.ToString()),
                   Qty =  int .Parse (rw.Cells [1].Value .ToString ()),
                   Status = "Normal Order",

                };
                OrderProductsCmd.AddOrderProduct(ordtb);
          
            }
            //=========================================
            // == Save At AccountDaily :
            AccountDaily DyTb = new AccountDaily() { 
                AccountID = CustmerAccountID ,
                TotalIn = Convert .ToDouble ( TotalPriceBox.Text ),
                DateOfProcess = DateTime .Now ,
                Description = "It;s  A Normal Order",
            };
            AccountDailyCmd.AddAccountDaily(DyTb);
            //=========================================
            var CurrentBranch = BranchsCmd.GetBranchByBarnchID(int.Parse (txtBranches.SelectedValue.ToString ()));

            AccountDaily xDyTb = new AccountDaily()
            {
                AccountID = CurrentBranch [1].AccountID ,
                TotalIn = Convert.ToDouble(TotalPriceBox.Text),
                DateOfProcess = DateTime.Now,
                Description = "It;s  A Normal Order",
            };
            AccountDailyCmd.AddAccountDaily(xDyTb);


            MessageBox.Show("Saved ");

        }


      

        private void txtBranches_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }
    }
}
