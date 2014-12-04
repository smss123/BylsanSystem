using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer.Helper_Classes;

using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.FactoryForms
{
    public partial class FrmFactoryOrderProductShow : Telerik.WinControls.UI.RadForm
    {
        public FrmFactoryOrderProductShow()
        {
            InitializeComponent();
        }
        public int TaregtOrder { get; set; }
        public int PrdID { get; set; }
        Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            DGVProducts.Rows.Clear();
            var q = new object();
            q = OrderProductsCmd.GetAllByOrderID(TaregtOrder);
            this.Invoke((MethodInvoker)delegate
            {
                DGVProducts.DataSource = q;

            });
            Operation.EndOperation(this);
            this.Thr.Abort();
        }

 

        private void FrmFactoryOrderProductShow_Load(object sender, EventArgs e)
        {
            PhotoBox.Image = null;
            //================================
            Thr = new Thread(PopulateGrd);
            Thr.Start();
            //
        }

        
        Thread ProductThread;
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVProducts.Rows.Count != 0)
            {

                LoadCleaner();

                ProductThread = new Thread(LoadProdcutInformations);
                ProductThread.Start();
            }
      

        }

        void LoadProdcutInformations()
        {
            PrdID = 0;
            PrdID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString());
            var lst1 = OrderProductsCmd.GetAllByProductID(PrdID);
            var lst2 = ProductsCmd.GetProductByID(PrdID);
            this.Invoke((MethodInvoker)delegate
            {
                // Get Data from OrderProduct Table { After Desinging }  :
                foreach (var item in lst1)
                {
                    TxtDescription.Text = item.Description;
                    PhotoBox.Image = item.ImageX;
                }
                // Get Main Data From Product Table {Any way} : 
                foreach (var Prd in lst2)
                {
                    lblPoductName .Text = Prd.Product_Name;
                    lblPrice.Text = Prd.ProductPrice.ToString ();
                }

                ProductThread.Abort();
            });
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void LoadCleaner()
        {
            PhotoBox.Image = null;
            TxtDescription.Text = "";
            lblPrice.Text = "";
            lblPoductName.Text = "";
        }

        private void ChkToDeliver_CheckedChanged(object sender, EventArgs e)
        {
            if (PrdID != 0 && TaregtOrder != 0)
            {
                // Start Edit At Order Table :
                Order OrderTb = new Order()
                {
                    OrderStatus = "To Deliver",
                };
                OrdersCmd.EditOrderStatusOnly(OrderTb, TaregtOrder);
                MessageBox.Show("The current product is ready to be sent to the customer");
               
            }
        }
    }
}
