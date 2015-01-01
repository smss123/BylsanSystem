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
            ChkToDeliver.Visible = false;
             var q = TagOrder.OrderProducts.ToList();//OrderProductsCmd.GetAllByOrderID(TaregtOrder);
            this.Invoke((MethodInvoker)delegate
            {
                foreach (var item in q)
                {
                 
                     DGVProducts.Rows.Add(new string[] { item .ID .ToString (),item .ProductID .ToString (),
                     item .Qty .ToString ()
                     });
                }
              

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
       

        }

        void LoadProdcutInformations()
        {
            PrdID = 0;
            PrdID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString());

            var lst1 = OrderProductsCmd.GetAllByProductID(PrdID);
      
            var CurrentProduct  =    ProductsCmd.GetProductByID(PrdID);         
            this.Invoke((MethodInvoker)delegate
            {
              

                    TxtDescription.Text = lst1[0].Description;
                    PhotoBox.Image = lst1[0].ImageX;
               
                // Get Main Data From Product Table {Any way} : 

                    lblPoductName.Text = CurrentProduct[0].Product_Name;
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

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Order OrderTb = new Order();

            for (int i = 0; i < DGVProducts.Rows.Count; i++)
            {
              
                DataGridViewCheckBoxCell chkchecking = DGVProducts.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    
                    int Indx = DGVProducts.CurrentRow.Index;
                    DGVProducts.Rows.RemoveAt(Indx);
                
                }
               
                // Start Edit At Order Table :
               OrderTb = new Order()
                {
                    OrderStatus = "To Deliver",
                };

                OrdersCmd.EditOrderStatusOnly(OrderTb, TaregtOrder);
            }
        }

        private void DGVProducts_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (DGVProducts.Rows.Count != 0)
            {

                LoadCleaner();

                productThread = new Thread(LoadProdcutInformations);
                productThread.Start();
            }
      
        }
    }
}
