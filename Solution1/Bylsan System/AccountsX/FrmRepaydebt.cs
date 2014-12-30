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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (PaymenttextBox.Text == "")
            {

                PaymenttextBox.BackColor = Color.OrangeRed;

                PaymenttextBox.Focus();
                errorProvider1.SetError(this.PaymenttextBox, "Please Enter Payment  ");

                return;
            }
            else
            {
                PaymenttextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion

            AccountDaily deptSide = new AccountDaily()
            {
                AccountID = DebtorInfo.AccountID,
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = PaymenttextBox.Text.Todouble(),
                TotalIn = 0d,

            };
            AccountDaily tre = new AccountDaily()
            {
                AccountID = DebetfromcomboBox.SelectedValue.ToString().ToInt(),
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = PaymenttextBox.Text.Todouble(),
                TotalIn = 0d,

            };
            Operation.BeginOperation(this);
            AccountDailyCmd.AddAccountDaily(deptSide);
            AccountDailyCmd.AddAccountDaily(tre);
            Operation.EndOperation(this);
            Operation.ShowToustOk("saved ..", this);
        }
    }
}
