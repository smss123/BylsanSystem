using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
using System.Threading;
using Xprema.XExtention;

namespace Bylsan_System.AccountsX
{
    public partial class FrmPrivatewithdrawals : RadForm
    {
        public FrmPrivatewithdrawals()
        {
            InitializeComponent();
        }
        private Thread th;
        public void FillBrnchCombo()
        {
            CmbFromAccount.MultiColumnComboBoxElement.DropDownWidth = 550;
            CmbToAccount.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                CmbFromAccount.AutoFilter = true;
                CmbFromAccount.ValueMember = "ID";
                CmbFromAccount.DisplayMember = "AccountName";



                CmbToAccount.AutoFilter = true;
                CmbToAccount.ValueMember = "ID";
                CmbToAccount.DisplayMember = "AccountName";
            });


            var q = AccountsCmd.GetAllAccounts();
            this.Invoke((MethodInvoker)delegate
            {
                CmbFromAccount.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = CmbFromAccount.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                CmbFromAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


                CmbToAccount.DataSource = q;
                var filter1 = new FilterDescriptor();
                filter1.PropertyName = CmbToAccount.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                CmbToAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);




            });
            Operation.EndOperation(this);

            th.Abort();
        }
        private void FrmPrivatewithdrawals_Load(object sender, EventArgs e)
        {
            th = new Thread(FillBrnchCombo);
            th.Start();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;
            if (ch == 46 &&  txtAmount.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public int? AcctID { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbFromAccount.Text == CmbToAccount.Text)
                {
                    Operation.ShowToustOk("Transfer the amount from the same account unacceptable.", this);
                    return;
                }
                if (Convert.ToDouble (txtAmount .Text .ToString ()) > Convert .ToDouble (lblAvailableAmount .Text .ToString ()))
                {
                    Operation.ShowToustOk("The amount is not available.", this);
                    return ;
                }


                var tb = new AccountDaily() { AccountID = FromAccount_ID ,
                 DateOfProcess = DateTime .Now ,
                  TotalIn = 0f,
                  TotalOut = txtAmount .Text .Todouble (),
                     Description = txtDescription .Text .ToString ()
                };
                AccountDailyCmd.AddAccountDaily(tb);


                var xtb = new AccountDaily()
                { AccountID = ToAccount_ID ,
                    DateOfProcess = DateTime.Now,
                    TotalIn = txtAmount.Text.Todouble(),
                    TotalOut = 0f,
                    Description = txtDescription.Text.ToString()
                };
                AccountDailyCmd.AddAccountDaily(xtb);
            }
            catch (Exception)
            {
            }
        }
        public int FromAccount_ID { get; set; }
        public int ToAccount_ID { get; set; }
        private void CmbFromAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFromAccount.Text != string.Empty)
            {
                lblAvailableAmount.Text = string.Empty;
                FromAccount_ID = 0;
                var TargetAccount = AccountsCmd.GetOneAccountByName(CmbFromAccount.Text);
                FromAccount_ID = TargetAccount.ID;
                lblAvailableAmount.Text = AccountantWatcher.GetFreeBalance(TargetAccount .ID ).ToString ();
            }
        }
        private void CmbToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbToAccount.Text != string.Empty)
            {
                ToAccount_ID = 0;
                var TargetAccount = AccountsCmd.GetOneAccountByName(CmbToAccount .Text );
                ToAccount_ID = TargetAccount.ID;
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
