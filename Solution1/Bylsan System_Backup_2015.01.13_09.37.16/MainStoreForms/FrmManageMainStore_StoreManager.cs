using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmManageMainStore_StoreManager : RadForm
    {
        public FrmManageMainStore_StoreManager()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        Thread th;
        private void Loading()
        {
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading ...";
            });
            Operation.BeginOperation(this);
            var q = StoreManagerCmd.GetAllStoreManager(); //StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreManagerGridView.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }
        private void FrmManageMainStore_StoreManager_Load(object sender, EventArgs e)
        {
            th = new Thread(Loading);
            th.Start();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            

        }

        private void StoreManagerGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = StoreManagerGridView.CurrentColumn.Index;

            if (col == 7)
            {
                Operation.BeginOperation(this);
                FrmEditMainStore_StoreManager frm = new FrmEditMainStore_StoreManager();
                frm.TregatStorManeger = (StoreManager)this.StoreManagerGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                this.FrmManageMainStore_StoreManager_Load(null, null);
                Operation.EndOperation(this);
            }

            if (col == 8)
            {
                if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ItemsCmd.DeleteItemAt(((StoreManager)this.StoreManagerGridView.CurrentRow.DataBoundItem).ID);
                    Operation.EndOperation(this);
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_StoreManager_Load(sender, e);
        }

      







    }
}
