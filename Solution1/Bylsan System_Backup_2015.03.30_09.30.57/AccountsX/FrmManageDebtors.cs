using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.AccountsX
{
    public partial class FrmManageDebtors : Telerik.WinControls.UI.RadForm
    {
        public FrmManageDebtors()
        {
            InitializeComponent();
        }
        private void PopulateDebitorsGrid()
        {
            Operation.BeginOperation(this);
            var q = DebtorsCmd.GetAllDebtors();
            this.Invoke((MethodInvoker)delegate
            {
                DGVDebitors.DataSource = q;
            });
            Operation.EndOperation(this);
        }
        private void FrmManageDebtors_Load(object sender, EventArgs e)
        {
            var DebtorsThread = new Thread(PopulateDebitorsGrid);
            DebtorsThread.Start();
        }

        private void DGVDebitors_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVDebitors.CurrentColumn.Index;
            if (col == 6)
            {
                Operation.BeginOperation(this);
                var frm = new FrmEditDebtors();
                var tb = (Debtor)DGVDebitors.CurrentRow.DataBoundItem;
                frm.TargetDebitor = tb;
                frm.ShowDialog();

                Operation.EndOperation(this);
            }



            if (col == 7)
            {
                Operation.BeginOperation(this);
                var frm = new FrmShowDebtorAccount();

                var tb = (Debtor)DGVDebitors.CurrentRow.DataBoundItem;
                frm.TargetDebtor = tb;
                frm.ShowDialog();

                Operation.EndOperation(this);
            }
        }

        private void AddDebt_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddDebtors();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageDebtors_Load(null, null);
        }
    }
}
