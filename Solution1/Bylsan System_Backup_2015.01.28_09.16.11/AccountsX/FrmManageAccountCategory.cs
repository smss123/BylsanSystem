using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.AccountsX
{
    public partial class FrmManageAccountCategory : Telerik.WinControls.UI.RadForm
    {
        public FrmManageAccountCategory()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountCategoryCmd.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                DGVAccountsCategories.DataSource = q;
            });
            Operation.EndOperation(this);
        }
        private void FrmManageAccountCategory_Load(object sender, EventArgs e)
        {
            var th = new Thread(PopulateGrid);
            th.Start();
        }

        private void DGVAccountsCategories_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVAccountsCategories.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                var frm = new FrmEditAccountCategory();
                var tb = (AccountCategory)DGVAccountsCategories.CurrentRow.DataBoundItem;
                frm.TragetActCategory = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddAccountCategory();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageAccountCategory_Load(null, null);
        }
    }
}
