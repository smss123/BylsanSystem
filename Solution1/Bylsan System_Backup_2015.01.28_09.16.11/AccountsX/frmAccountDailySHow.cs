using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading;
using XamaDataLayer.Accountant;

namespace Bylsan_System.AccountsX
{
    public partial class frmAccountDailySHow : Telerik.WinControls.UI.RadForm
    {
        public frmAccountDailySHow()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountDailyCmd.GetAllDaily();
            this.Invoke((MethodInvoker)delegate
            {
                DGVAccountsDaily.DataSource = q;
            });
            Operation.EndOperation(this);
        }
        private void frmAccountDailySHow_Load(object sender, EventArgs e)
        {
            var th = new Thread(PopulateGrid );
            th.Start();
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmPrivatewithdrawals();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmAccountDailySHow_Load(null, null);
        }
    }
}
