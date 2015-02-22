using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmManageMainStore_Item : RadForm
    {
        private Thread th;

        public FrmManageMainStore_Item()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        private void ItemGridView_CommandCellClick(object sender, EventArgs e)
        {
        }

        private void FrmManageMainStore_Item_Load(object sender, EventArgs e)
        {
            th = new Thread(LoadingItems);
            th.Start();
        }

        private void LoadingItems()
        {
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading Item ..";
            });
            Operation.BeginOperation(this);
            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                DGVItems.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Complete..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }





        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVItems.CurrentColumn.Index;

            if (col == 4)
            {
                var frm = new FrmEditMainStore_Item();
                frm.TragetItem = (Item)DGVItems.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                FrmManageMainStore_Item_Load(null, null);
            }

            if (col == 5)
            {
                if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ItemsCmd.DeleteItemAt(int .Parse ( DGVItems .CurrentRow .Cells [0].Value .ToString ()));
                    Operation.EndOperation(this);
                }
            }
        }





        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {
        }
    }
}
