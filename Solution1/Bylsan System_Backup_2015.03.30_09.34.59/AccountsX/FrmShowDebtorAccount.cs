using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using System.Threading;
using Telerik.WinControls.UI;

namespace Bylsan_System.AccountsX
{
    public partial class FrmShowDebtorAccount : RadForm
    {
        public FrmShowDebtorAccount()
        {
            InitializeComponent();
        }
        public Debtor TargetDebtor { get; set; }

        private void PopulateGrid()
        {
            var AccID = TargetDebtor.AccountID;
            var Balance = AccountDailyCmd.GetBalanceByAccountID(AccID.Value);
            var lst = AccountDailyCmd.GetAllAccountDailyByAccountID( (int)( AccID ));
            this.Invoke((MethodInvoker)delegate
            {
                DGVDebtors.DataSource = lst;
                txtbalance.Text = Balance.ToString();
            });
        }
        private void AddDebtBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddDebt();
            frm.DebtorInfo = TargetDebtor;
            frm.ShowDialog();
        }

        private void RepaydebBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmRepaydebt();
            frm.Balance = txtbalance.Text;
            frm.DebtorInfo = TargetDebtor;
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmShowDebtorAccount_Load(null, null);
        }

        private void FrmShowDebtorAccount_Load(object sender, EventArgs e)
        {
            var th = new Thread(PopulateGrid);
            th.Start();
        }
    }
}
