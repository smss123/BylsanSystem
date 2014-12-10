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
    public partial class FrmManageMainStore_StoreWithDrawal : RadForm
    {
        public FrmManageMainStore_StoreWithDrawal()
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
            var q = StoreDrawalCmd.GetAllStoreDrawals(); //StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreWithDrawalGridView.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }
        private void FrmManageMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            th = new Thread(Loading);
            th.Start();
        }

        private void StoreWithDrawalGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = StoreWithDrawalGridView.CurrentColumn.Index;

            if (col == 7)
            {
                Operation.BeginOperation(this);
                FrmEditMainStore_StoreWithDrawal frm = new FrmEditMainStore_StoreWithDrawal();
                frm.TregatDrawal = (StoreWithDrawal)this.StoreWithDrawalGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                this.FrmManageMainStore_StoreWithDrawal_Load(null, null);
                Operation.EndOperation(this);
            }

            if (col == 8)
            {
                if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ItemsCmd.DeleteItemAt(((StoreWithDrawal)this.StoreWithDrawalGridView.CurrentRow.DataBoundItem).ID);
                    Operation.EndOperation(this);
                }
            }
        }



    }
}
