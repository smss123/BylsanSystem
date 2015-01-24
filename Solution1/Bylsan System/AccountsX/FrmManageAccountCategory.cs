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
    public partial class FrmManageAccountCategory : Telerik.WinControls.UI.RadForm
    {
        public FrmManageAccountCategory()
        {
            InitializeComponent();
        }
        void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountCategoryCmd.GetAll();
            this.Invoke((MethodInvoker)delegate { DGVAccountsCategories.DataSource = q; });
            Operation.EndOperation(this);
        }
        private void FrmManageAccountCategory_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateGrid); th.Start();
        }

        private void DGVAccountsCategories_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVAccountsCategories.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                FrmEditAccountCategory frm = new FrmEditAccountCategory();
                AccountCategory tb = (AccountCategory)DGVAccountsCategories.CurrentRow.DataBoundItem;
                frm.TragetActCategory = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddAccountCategory frm = new FrmAddAccountCategory();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageAccountCategory_Load(null, null);
        }



    }
}
