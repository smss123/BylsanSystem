using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using Telerik.WinControls.UI;
namespace Bylsan_System.designerForms
{
    public partial class FrmOrderShow : RadForm
    {
        public FrmOrderShow()
        {
            InitializeComponent();
        }

        FrmOrderProductShow FrmProdShow = new FrmOrderProductShow();

        Thread Thr ;
        Thread CustomerThread;
        private void PopulateGrd()
        {
            
            Operation.BeginOperation(this);
            var q = new object();
            using (FactoryZoon FactoryZoonCmd = new FactoryZoon())
            { 
                q = FactoryZoonCmd.GetAllOrdersInDesigner(); 
                
            }
            this.Invoke((MethodInvoker)delegate 
            {

                DGVOrders.DataSource = q; 
            });
            Operation.EndOperation (this);
            this.Thr.Abort();
        }
        private void FrmOrderShow_Load(object sender, EventArgs e)
        {
            

            Thr = new Thread(PopulateGrd );
            Thr.Start();
        }

        public int SelectedOrderID { get; set; }
        private void DGVOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void LoadingCustomerData()
        {
            this.Invoke((MethodInvoker)delegate
           {
               FrmProdShow.labCustomerName.Text = "Loading Info ..";
               FrmProdShow.labCustomerPhone.Text = "Loading Info ..";
           });
            var Lst = (from c in OrdersCmd.GetAllOrderByID(SelectedOrderID) select c).Single();
            var cust = (from c in CustomersCmd.GetAllCustmers() where c.ID == Lst.CustomerID select c).Single();

            this.Invoke((MethodInvoker)delegate
            {
             
             FrmProdShow.labCustomerName.Text = cust.CustomerName.ToString();
             FrmProdShow.labCustomerPhone .Text = cust.PhoneNumber .ToString();
            });

            CustomerThread.Abort() ;
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVOrders.Rows.Count != 0)
                {
                    SelectedOrderID = int.Parse(DGVOrders.CurrentRow.Cells[0].Value.ToString());
                    FrmProdShow = new FrmOrderProductShow();

                    CustomerThread = new Thread(LoadingCustomerData);
                    CustomerThread.Start();

                    FrmProdShow.TaregtOrder = SelectedOrderID;
                  //  MessageBox.Show("SelectedOrderID " + SelectedOrderID.ToString());

                    FrmProdShow.ShowDialog();

                }
            }
            catch (Exception)
            {


            }
        }
        
    }
}
