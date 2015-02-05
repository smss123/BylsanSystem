using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmManageMainStore_Store : RadForm
    {
        public FrmManageMainStore_Store()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        private Thread th;
        private void FrmManageMainStore_Store_Load(object sender, EventArgs e)
        {
            th = new Thread(Loading);
            th.Start();
        }

        private void Loading()
        {
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading ...";
            });
            Operation.BeginOperation(this);
            var q = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreGridView.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            var frm = new FrmAddMainStore_Store();
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void StoreGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = StoreGridView.CurrentColumn.Index;

            if (col == 4)
            {
                Operation.BeginOperation(this);
                var frm = new FrmEditMainStore_Store();
                frm.treagtStore = (Store)StoreGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                FrmManageMainStore_Store_Load(null, null);
                Operation.EndOperation(this);
            }

            if (col == 5)
            {
                if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ItemsCmd.DeleteItemAt(((Store)StoreGridView.CurrentRow.DataBoundItem).ID);
                    Operation.EndOperation(this);
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Store_Load(sender, e);
        }

        private void btnStorePurchases_Click(object sender, EventArgs e)
        {
            var frm = new frmStorePurchases();
            frm.ShowDialog();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
