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
        public Order TagOrder { get; set; }
        public int PrdID { get; set; }
        Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            DGVProducts.Rows.Clear();
            var q = new object();
            q = TagOrder.OrderProducts.ToList();//OrderProductsCmd.GetAllByOrderID(TaregtOrder);
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

        
        Thread productThread;
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVProducts.Rows.Count != 0)
            {

                LoadCleaner();

                productThread = new Thread(LoadProdcutInformations);
                productThread.Start();
            }
      

        }

        void LoadProdcutInformations()
        {
            //PrdID = 0;
            //PrdID = int.Parse(DGVProducts.CurrentRow.Cells[4].Value.ToString());

            var lst1 = (OrderProduct)DGVProducts.CurrentRow.DataBoundItem; //OrderProductsCmd.GetAllByProductID(PrdID);
            var lst2 = lst1.Product; //ProductsCmd.GetProductByID(PrdID);

            
            this.Invoke((MethodInvoker)delegate
            {
              

                    TxtDescription.Text = lst1.Description;
                    PhotoBox.Image = lst1.ImageX;
               
                // Get Main Data From Product Table {Any way} : 

                    lblPoductName.Text = lst2.Product_Name;
                    lblPrice.Text = "[none]";
              

                productThread.Abort();
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
            if ( TaregtOrder != 0)
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

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.ShowDialog();
            PhotoBox.Image.Save(op.FileName);

        }
    }
}
