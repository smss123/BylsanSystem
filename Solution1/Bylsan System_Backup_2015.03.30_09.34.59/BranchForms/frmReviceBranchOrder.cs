using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer.BranchCmd;
namespace Bylsan_System.BranchForms
{
    public partial class frmReviceBranchOrder : Form
    {
        public frmReviceBranchOrder()
        {
            InitializeComponent();
        }

        private void frmReviceBranchOrder_Load(object sender, EventArgs e)
        {
            var q = OrdersCmd.GetAllOrders().Where(p => p.isOrderBranch == "yes").ToList();
            radGridView1.DataSource = q;
        }
    }
}
