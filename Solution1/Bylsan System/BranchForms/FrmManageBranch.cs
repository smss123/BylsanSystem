using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.BranchForms
{
    public partial class FrmManageBranch : RadForm
    {
        public FrmManageBranch()
        {
            InitializeComponent();
        }

        private void FrmManageBranch_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadBranches);
            th.Start();
        }

        private void LoadBranches()
        {
            Operation.BeginOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text = "Loading ..";
            });
            var q  = new  object();
            try
            {
               q=  BranchsCmd.GetAllBranchs();
            }
            catch (System.InvalidOperationException ex)
            {
               // BranchGridView.DataSource = BranchsCmd.GetAllBranchs();
            }

            statusStrip1.Invoke((MethodInvoker)delegate
            {
                BranchGridView.DataSource =q;
                txtStatus.Text = "Compelete .. ";
            });
            Operation.EndOperation(this);
        }

        private void BranchGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = BranchGridView.CurrentColumn.Index;

            if (col == 5)
            {
                var frm = new FrmEditBranch();
                frm.TragetBranch = (Branch)BranchGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadBranches();
            }

            if (col == 6)
            {
                if (RadMessageBox.Show("Want To Delete?", string.Empty, MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    BranchsCmd.DeleteBranch(((Branch)BranchGridView.CurrentRow.DataBoundItem).ID);
                    Operation.ShowToustOk("Branch Has Been Deleted", this);
                    LoadBranches();
                    Operation.EndOperation(this);
                }
            }
        }

        private void BranchGridView_Click(object sender, EventArgs e)
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddBranch();
            frm.ShowDialog();
            LoadBranches();
        }
    }
}
