using System;
using System.Collections.Generic;
using System.Windows.Forms;


using Telerik.WinControls;
using XamaDataLayer;
using XamaDataLayer.SellSystem;
using System.Threading;
using System.Linq;
using System.Data.Linq;
using XamaDataLayer.Security;
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

            var q = Operation.AllSellStore; //SellStoreCmd.GetAllSellStore(UserInfo.CurrnetUser.Branch_ID.Value);
           
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
            var th = new Thread(FillData);
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
            if (col == 4)
            {
                Operation.BeginOperation(this);
                var frm = new FrmEditSellIStore();

                var tb = (SellStore)SellStoreGridView.CurrentRow.DataBoundItem;
                frm.TargetStore = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 5)
            {
                try
                {
                    Operation.BeginOperation(this);

                    SellStoreCmd.DeleteSellStore(int.Parse(SellStoreGridView.CurrentRow.Cells[0].Value.ToString()), UserInfo.CurrnetUser.Branch_ID.Value);
                    FrmManageSellIStore_Load(sender, e);

                    Operation.EndOperation(this);
                }
                catch (Exception ex)
                {

                    RadMessageBox.ThemeName = this.ThemeName;
                    RadMessageBox.Show("Can't Delete Because its link on other processes in stock an sales");
                    Operation.EndOperation(this);
                }
               
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddSellIStore frm = new FrmAddSellIStore();
            frm.ShowDialog();
        }
    }
}
