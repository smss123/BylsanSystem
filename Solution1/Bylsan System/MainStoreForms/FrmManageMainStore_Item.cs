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
            this.InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        private void ItemGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ItemGridView.CurrentColumn.Index;

            if (col == 4)
            {

                FrmEditMainStore_Item frm = new FrmEditMainStore_Item();
                frm.TragetItem = (Item)this.ItemGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                this.FrmManageMainStore_Item_Load(null, null);

            }

            if (col == 5)
            {

               
                if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    ItemsCmd.DeleteItemAt(((Item)this.ItemGridView.CurrentRow.DataBoundItem).ID);
                    Operation.EndOperation(this);
                }

               

            }
           
        }

        private void FrmManageMainStore_Item_Load(object sender, EventArgs e)
        {
            this.th = new Thread(this.LoadingItems);
            this.th.Start();
        }

        private void LoadingItems()
        {
            this.toolStrip1.Invoke((MethodInvoker)delegate
            {
                this.lblStatus.Text = "Loading Item ..";
            });
            Operation.BeginOperation(this);
            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                this.ItemGridView.DataSource = q;
            });
            this.toolStrip1.Invoke((MethodInvoker)delegate
            {
                this.lblStatus.Text = "Complete..";
            });
            Operation.EndOperation(this);
            this.th.Abort();
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //int id = this.ItemGridView.CurrentRow.Cells[5].ColumnInfo.Index;
            
            //if (e.ColumnIndex == 4)
            //{
            //    FrmEditMainStore_Item frm = new FrmEditMainStore_Item();
            //    frm.TragetItem = (Item)this.ItemGridView.CurrentRow.DataBoundItem;
            //    frm.ShowDialog();
            //    this.FrmManageMainStore_Item_Load(null, null);
            //}
            //if (e.ColumnIndex == 5)
            //{
            //    Operation.BeginOperation(this);
            //    ItemsCmd.DeleteItemAt(((Item)this.ItemGridView.CurrentRow.DataBoundItem).ID);
            //    Operation.EndOperation(this);
            //}
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {
        }
    }
}