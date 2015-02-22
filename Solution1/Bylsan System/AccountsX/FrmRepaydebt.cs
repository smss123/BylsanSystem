using System;
using System.Drawing;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using Xprema.XExtention;

namespace Bylsan_System.AccountsX
{
    public partial class FrmRepaydebt : RadForm
    {
        public FrmRepaydebt()
        {
            InitializeComponent();
        }
        public Debtor DebtorInfo { get; set; }
        public string  Balance { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PaymenttextBox.Text == string.Empty)
            {
                PaymenttextBox.BackColor = Color.OrangeRed;

                PaymenttextBox.Focus();
                errorProvider1.SetError(PaymenttextBox, "Please Enter Payment  ");

                return;
            }
            else
            {
                PaymenttextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }



            var deptSide = new AccountDaily()
            { AccountID = DebtorInfo.AccountID,
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = 0d,
              TotalIn = PaymenttextBox.Text.Todouble(),
            };
            var tre = new AccountDaily()
            { AccountID = DebetfromcomboBox.SelectedValue.ToString().ToInt(),
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = 0d,
              TotalIn = PaymenttextBox.Text.Todouble()
            };
            Operation.BeginOperation(this);
            AccountDailyCmd.AddAccountDaily(deptSide);
            AccountDailyCmd.AddAccountDaily(tre);
            Operation.EndOperation(this);
            Operation.ShowToustOk("saved ..", this);
        }

        private void GetRemaing()
        {
            try
            {
                 var balance = double.Parse(TotalDebttextBox.Text) - double.Parse( PaymenttextBox.Text);
            RemainingtextBox.Text = balance.ToString();
            }
            catch (Exception)
            {

                return;
            }

        }
        private void FrmRepaydebt_Load(object sender, EventArgs e)
        {
            TotalDebttextBox.Text = Math.Abs(double.Parse(Balance)).ToString();
            DebetfromcomboBox.DataSource = AccountsCmd.GetAllAccounts();
            DebetfromcomboBox.DisplayMember = "AccountName"; //
            DebetfromcomboBox.ValueMember = "ID";
        }

        private void TotalDebttextBox_TextChanged(object sender, EventArgs e)
        {
            GetRemaing();
        }

        private void PaymenttextBox_TextChanged(object sender, EventArgs e)
        {
            GetRemaing();
        }
    }
}
