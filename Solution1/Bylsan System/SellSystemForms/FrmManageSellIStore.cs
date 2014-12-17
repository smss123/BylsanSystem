using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;


using XamaDataLayer;
using XamaDataLayer.SellSystem;
using Bylsan_System.SellSystemForms;
using System.Threading;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmManageSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmManageSellIStore()
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

            var q = SellStoreCmd.GetAllSellStore();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                SellStoreGridView .DataSource = q;
              
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void FrmManageSellIStore_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillData);
            th.Start();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageSellIStore_Load( sender,  e);
        }

        private void SellStoreGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
       
           
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {

        }

        private void SellStoreGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = SellStoreGridView.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                FrmEditSellIStore frm = new FrmEditSellIStore();

                SellStore tb = (SellStore)SellStoreGridView.CurrentRow.DataBoundItem;
                frm.TargetStore = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 4)
            {

                Operation.BeginOperation(this);

                SellStoreCmd.DeleteSellStore(int.Parse(SellStoreGridView.CurrentRow.Cells[0].Value.ToString()));
                FrmManageSellIStore_Load(sender, e);

                Operation.EndOperation(this);
            }
        }



    }
}
