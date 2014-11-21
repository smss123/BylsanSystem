using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.BranchForms
{
    public partial class FrmManageBranch : Form
    {
        public FrmManageBranch()
        {
            InitializeComponent();
        }

        private void FrmManageBranch_Load(object sender, EventArgs e)
        {

        }

        private void BranchGridView_CommandCellClick(object sender, EventArgs e)
        {
             var col = BranchGridView.CurrentColumn.Index;

             if (col == 5)
             {
                 FrmEditBranch frm = new FrmEditBranch();
                 frm.ShowDialog();
             
             }
        }
    }
}
