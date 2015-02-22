using System;
using System.Collections.Generic;
using System.Windows.Forms;

using XamaDataLayer;
using XamaDataLayer.SellSystem;
using System.Threading;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmManageSellItem : Telerik.WinControls.UI.RadForm
    {
        public FrmManageSellItem()
        {
            InitializeComponent();
        }
        private void FillData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();

            var q = SellItemsCmd.GetAllSellItems();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                SellitmeGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void FrmManageSellItem_Load(object sender, EventArgs e)
        {
            var th = new Thread(FillData);
            th.Start();
        }

        private void SellitmeGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageSellItem_Load(sender, e);
        }

        private void SellitmeGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = SellitmeGridView.CurrentColumn.Index;
            if (col == 5)
            {
                Operation.BeginOperation(this);
                var frm = new FrmEditSellItem();
                var tb = (SellItem)SellitmeGridView.CurrentRow.DataBoundItem;
                frm.TargetItem = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }

            if (col == 6)
            {
                Operation.BeginOperation(this);

                SellItemsCmd.DeleteSellItem(int.Parse(SellitmeGridView.CurrentRow.Cells[0].Value.ToString()));
                FrmManageSellItem_Load(sender, e);

                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSellItem();
            frm.ShowDialog();
        }
    }
}
