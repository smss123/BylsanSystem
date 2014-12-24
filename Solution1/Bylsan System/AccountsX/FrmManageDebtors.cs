using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
//===========================
using System.Threading;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
//==========================
namespace Bylsan_System.AccountsX
{
    public partial class FrmManageDebtors : Telerik.WinControls.UI.RadForm
    {
        public FrmManageDebtors()
        {
            InitializeComponent();
        }
        void PopulateDebitorsGrid()
        {
            Operation.BeginOperation(this);
            var q = DebtorsCmd.GetAllDebtors();
            this.Invoke((MethodInvoker)delegate { DGVDebitors.DataSource = q; });
            Operation.EndOperation(this);
        }
        private void FrmManageDebtors_Load(object sender, EventArgs e)
        {
            Thread DebtorsThread = new Thread(PopulateDebitorsGrid);
            DebtorsThread.Start();

        }

        private void DGVDebitors_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVDebitors.CurrentColumn.Index;
            if (col == 6)
            {
                Operation.BeginOperation(this);
                FrmEditDebtors frm = new FrmEditDebtors();
                Debtor tb = (Debtor)DGVDebitors.CurrentRow.DataBoundItem;
                frm.TargetDebitor = tb;
                frm.ShowDialog();
            
                Operation.EndOperation(this);
            }
        }

        private void AddDebt_Click(object sender, EventArgs e)
        {
            FrmAddDebtors frm = new FrmAddDebtors();
            frm.ShowDialog();

        }
    }
}
