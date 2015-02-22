using Bylsan_System.FactoryForms;
using Bylsan_System.Reports.ReportCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ProductForms
{
    public partial class frmManageProduct : RadForm
    {
        public frmManageProduct()
        {
            InitializeComponent();
            ProductGridView.CommandCellClick += ProductGridView_CommandCellClick;
        }

        private void ProductGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProductGridView.CurrentColumn.Index;

            if (col == 5)
            {
                var frm = new frmEditProduct();
                frm.TragetProduct = (Product)ProductGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadProduct();
            }
            if (col == 6)
            {
                Operation.BeginOperation(this);
                var q = (Product)ProductGridView.CurrentRow.DataBoundItem;
                ProductsCmd.DeleteProduct(q.ID);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Product Deleted", this);
            }
            if (col == 8)
            {
                var frm = new frmContentx();
                frm.SelectedProduct = (Product)ProductGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
            }
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadProduct);
            th.Start();
        }

        private void LoadProduct()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "Loading...";

            });
            Operation.BeginOperation(this);
            var q = Operation.Allproducts;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmAddProduct();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmManageProduct_Load(null, null);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            frmPrintBarCode frm = new frmPrintBarCode();
            frm.ShowDialog();
        }



        private void ProductManagmentBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductsContantes();
            frm.ShowDialog();
        }
    }
}
