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
namespace Bylsan_System.ProductForms
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "Loading...";

            });
            Operation.BeginOperation(this);
            ProductGridView.DataSource = ProductsCmd.GetAllProducts();
            Operation.EndOperation(this);
        }
    }
}
