using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using XamaDataLayer;
using System.Threading;
using Xprema.XExtention;
using XamaDataLayer.Accountant;
using Telerik.WinControls.UI;

namespace Bylsan_System.AccountsX
{
    public partial class FrmAddDebt : RadForm
    {
        public FrmAddDebt()
        {
            InitializeComponent();
        }
        public Debtor DebtorInfo { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void DebtorAmount()
        {
            DebetfromcomboBox.DataSource = AccountsCmd.GetAllAccounts();
            DebetfromcomboBox.DisplayMember = "AccountName";
            DebetfromcomboBox.ValueMember = "ID";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AmountofDebttextBox.Text == string.Empty)
            {
                AmountofDebttextBox.BackColor = Color.OrangeRed;

                AmountofDebttextBox.Focus();
                errorProvider1.SetError(AmountofDebttextBox, "Please Enter  Amount  ");

                return;
            }
            else
            {
                AmountofDebttextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            var deptSide = new AccountDaily()
            { AccountID = DebtorInfo.AccountID,
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = AmountofDebttextBox.Text.Todouble(),
                TotalIn = 0d, };
            var tre = new AccountDaily()
            { AccountID = DebetfromcomboBox.SelectedValue.ToString().ToInt(),
                DateOfProcess = DateTime.Now,
                Description = "this New Debet to Account for :" + txtDescription.Text,
                TotalOut = AmountofDebttextBox.Text.Todouble(),
                TotalIn = 0d, };
            Operation.BeginOperation(this);
            AccountDailyCmd.AddAccountDaily(deptSide);
            AccountDailyCmd.AddAccountDaily(tre);
            Operation.EndOperation(this);
            Operation.ShowToustOk("saved ..", this);
        }

        private void FrmAddDebt_Load(object sender, EventArgs e)
        {
            TotalDebttextBox.Text = "Loading ..";
            var th = new Thread(DebtorAmount);
            th.Start();
        }
    }
}
