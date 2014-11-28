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
        
           
          //  CustomerInformations.WaitingOrder.Customer = CustomerInformations.WatingCustomer;
          ////  CustomerInformations.WaitingOrder.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
          //  CustomerInformations.WaitingOrder.DeliverdToBranch =  txtBranches.SelectedValue.ToString().ToInt();
          //  CustomerInformations.WaitingOrder.OrderDate = DateTime.Now;
          //  CustomerInformations.WaitingOrder.OrderDelivery = AddresstextBox.Text;
          //  CustomerInformations.WaitingOrder.OrderDeliveryDate = receiptdateTimePicker.Value;
          //  CustomerInformations.WaitingOrder.OrderName=CustomerInformations.WatingCustomer.CustomerName+"_"+DateTime.Now.ToString();
          //  CustomerInformations.WaitingOrder.OrderStatus="Designer";
          //  CustomerInformations.WaitingOrder.OrderType=this.TragetOrderType;
          //  CustomerInformations.WaitingOrder.OrderVerify="from Branch";
          //  CustomerInformations.WaitingOrder.TotalAmount = TotalPriceBox.Text.Todouble();
            ////OrdersCmd.AddNewOrder(CustomerInformations.WaitingOrder);
           // DbDataContext db = new DbDataContext();
            //db.DeferredLoadingEnabled = false;
            //db.Orders.InsertOnSubmit(CustomerInformations.WaitingOrder);

            Order otb = new Order();
            DbDataContext db = new DbDataContext();
            otb.OrderName = CustomerInformations.WatingCustomer.CustomerName + "_" + DateTime.Now.ToString();
            otb.OrderDelivery = AddresstextBox.Text;
            otb.OrderStatus = "Designer";
            otb.OrderDate = DateTime.Now;
            otb.TotalAmount = Convert.ToDouble (TotalPriceBox.Text);
            otb.Branch_ID = 13; // UserInfo.CurrnetUser.Branch_ID
            otb.Comment = "Xprema";
            otb.OrderVerify = "from Branch";
            otb.CustomerID = CustomerInformations.WatingCustomer.ID;
            otb.OrderDeliveryDate = receiptdateTimePicker.Value;
            otb.DeliverdToBranch = int .Parse (txtBranches.SelectedValue.ToString());

            db.Orders.InsertOnSubmit(otb);
            db.SubmitChanges();
            MessageBox.Show("Saved ");

        }



    }
}
