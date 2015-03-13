using System;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Security;
using Xprema.XExtention;

namespace Bylsan_System.BranchForms
{
    public partial class FrmDeliveryOrderShowInfo : RadForm
    {
        public FrmDeliveryOrderShowInfo()
        {
            InitializeComponent();
        }
        public Order TargetOrder { get; set; }


        private void FrmDeliveryOrderShowInfo_Load_1(object sender, EventArgs e)
        {
            var custid = TargetOrder.CustomerID;

            //labCustomerName.Text = (from c in CustomersCmd.GetAllCustmers()
            //                         where c.ID == custid
            //                         select c.CustomerName).Single();
            //labCustomerPhone.Text = (from c in CustomersCmd.GetAllCustmers()
            //                          where c.ID == custid
            //                          select c.PhoneNumber).Single();
            labCustomerName.Text = TargetOrder.Customer.CustomerName;
            labCustomerPhone.Text = TargetOrder.Customer.PhoneNumber;
            remainingtextBox.Text = AccountsCmd.GetCustomerPayment(TargetOrder.Customer.AccountID.Value,TargetOrder.ID).ToString();
         
            TotaltextBox.Text = TargetOrder.TotalAmount.ToString();
            PaymenttextBox.Text = (remainingtextBox.Text.Todouble() + TotaltextBox.Text.Todouble()).ToString();
            var lstproducts = OrderProductsCmd.GetAllByOrderID(TargetOrder.ID);
            dgvproducts.DataSource = lstproducts;
        }

        private void OkyBtn_Click(object sender, EventArgs e)
        {

            Operation.BeginOperation(this);
            AccountDailyCmd.AddAccountDaily(new AccountDaily() { 
            AccountID = TargetOrder.Customer.AccountID,
             CommandArg = TargetOrder.ID.ToString(),
              DateOfProcess = DateTime.Now,
               Description="دفعية عند الاستلام",
            TotalIn = PaymentRemainingtextBox.Text.Todouble(),
             TotalOut= 0d,
             
            });

            AccountDailyCmd.AddAccountDaily(new AccountDaily()
            {
                AccountID = UserInfo.CurrnetUser.Branch.AccountID,
                CommandArg = TargetOrder.ID.ToString(),
                DateOfProcess = DateTime.Now,
                Description = "دفعية عند الاستلام",
                TotalIn = PaymentRemainingtextBox.Text.Todouble(),
                TotalOut = 0d,

            });
            Operation.EndOperation(this);
            Operation.ShowToustOk("Customer Pay complete ", this);

        }
    }
}
