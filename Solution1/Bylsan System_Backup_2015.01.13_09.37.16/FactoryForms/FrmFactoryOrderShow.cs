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
namespace Bylsan_System.FactoryForms
{
    public partial class FrmFactoryOrderShow : Telerik.WinControls.UI.RadForm
    {
        public FrmFactoryOrderShow()
        {
            InitializeComponent();
        }

        Thread Thr;
       // public int SelectedOrderID { get; set; }
        private void FrmFactoryOrderShow_Load(object sender, EventArgs e)
        {
            Thr = new Thread(PopulateDGVOrders);
            Thr.Start();
            //
        }

        void PopulateDGVOrders()
        {
            Operation.BeginOperation(this);

            var q  = new object ();
            using ( FactoryZoon cmd = new FactoryZoon ()){q  = cmd.GetAllInProducting(); }

            this.Invoke((MethodInvoker)delegate {

                DGVOrders.DataSource = q;
              
            });

          
            foreach (var item in DGVOrders.Rows)
            {
                if (((Order)item.DataBoundItem).OrderStatus == "In Designer")
                {
                    var cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[0]);
                    cellPlaceHolder.DrawFill = true;
                    cellPlaceHolder.BackColor = Color.FromArgb(255, 252, 228, 149);
                    

                    cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[1]);
                    cellPlaceHolder.DrawFill = true;
                    cellPlaceHolder.BackColor = Color.FromArgb(255, 252, 228, 149);

                    cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[2]);
                    cellPlaceHolder.DrawFill = true;
                    cellPlaceHolder.BackColor = Color.FromArgb(255, 252, 228, 149);

                     cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[5]);
                     cellPlaceHolder.Enabled = false;
                }
              
                
            }
            Operation.EndOperation(this);
            Thr.Abort();
        }
        Thread CustomerThread;
        FrmFactoryOrderProductShow frmFactory = new FrmFactoryOrderProductShow();
        public int SelectedOrderID { get; set; }
    

        private void LoadingCustomerData()
        {
            this.Invoke((MethodInvoker)delegate
            {
                var Lst = (from c in OrdersCmd.GetAllOrderByID(SelectedOrderID) select c).Single();
                var cust = (from c in CustomersCmd.GetAllCustmers() where c.ID == Lst.CustomerID select c).Single();
                frmFactory.labCustomerName.Text = cust.CustomerName.ToString();
                frmFactory.labCustomerPhone.Text = cust.PhoneNumber.ToString();
            });

            CustomerThread.Abort();
        }

        private void DGVOrders_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
           
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVOrders.Rows.Count != 0)
                {
                    SelectedOrderID = int.Parse(DGVOrders.CurrentRow.Cells[0].Value.ToString());
                    frmFactory = new FrmFactoryOrderProductShow();

                    CustomerThread = new Thread(LoadingCustomerData);
                    CustomerThread.Start();

                    frmFactory.TaregtOrder = SelectedOrderID;
                    frmFactory.TagOrder = (Order)DGVOrders.CurrentRow.DataBoundItem;


                    frmFactory.ShowDialog();

                }
            }
            catch (Exception)
            {


            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            FrmFactoryOrderShow_Load(null, null);
        }
        

    }
}
