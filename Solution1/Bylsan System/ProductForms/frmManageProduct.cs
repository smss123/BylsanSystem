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
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
namespace Bylsan_System.ProductForms
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
            ProductGridView.CommandCellClick += ProductGridView_CommandCellClick;
        }

        void ProductGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProductGridView.CurrentColumn.Index;

            if (col == 4)
            {
                frmEditProduct frm = new frmEditProduct();
                frm.TragetProduct = (Product)ProductGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadProduct();

            }
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
          Thread th = new Thread(LoadProduct);
          th.Start();
        }

        private void LoadProduct()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "Loading...";

            });
            Operation.BeginOperation(this);
            var q = ProductsCmd.GetAllProducts();
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                ProductGridView.DataSource = q;

                toolStripStatusLabel1.Text = "Compelete...";

            });
        }

        private void ProductGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
