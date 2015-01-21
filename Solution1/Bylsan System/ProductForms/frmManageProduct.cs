using Bylsan_System.FactoryForms;
using Bylsan_System.Reports.ReportCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        void ProductGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProductGridView.CurrentColumn.Index;

            if (col == 5)
            {
                frmEditProduct frm = new frmEditProduct();
                frm.TragetProduct = (Product)ProductGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadProduct();

            }
            if (col==6)
            {
                Operation.BeginOperation(this);
                var q = (Product)ProductGridView.CurrentRow.DataBoundItem;
                ProductsCmd.DeleteProduct(q.ID);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Product Deleted", this);
            }
            if (col == 8)
            {
                frmContentx frm = new frmContentx();
                frm.SelectedProduct = (Product)ProductGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
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
            var q = Operation.Allproducts; //ProductsCmd.GetAllProducts();
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
            frmAddProduct frm = new frmAddProduct();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmManageProduct_Load(null, null);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            ItemBarcodeReportCmd cmd = new ItemBarcodeReportCmd();
            cmd.GetItemStorByDate();
            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //// Set the printer name. 
            ////pd.PrinterSettings.PrinterName = "\\NS5\hpoffice
            ////pd.PrinterSettings.PrinterName = "Zebra New GK420t"               
            //pd.Print();
        }
  
     

        private void ProductManagmentBtn_Click(object sender, EventArgs e)
        {
            FrmProductsContantes frm=new FrmProductsContantes();
            frm.ShowDialog();
        
        
        }
    }
}
