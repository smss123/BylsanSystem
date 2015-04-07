using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private Thread Thr;

        private void FrmFactoryOrderShow_Load(object sender, EventArgs e)
        {
            Thr = new Thread(PopulateDGVOrders);
            Thr.Start();
        }

        private void PopulateDGVOrders()
        {
            Operation.BeginOperation(this);

            var q  = new object ();

            q = Operation.AllOrder.Where(o => o.OrderStatus.Contains("in producting ") || o.OrderStatus.Contains("In Designer")).ToList(); //cmd.GetAllInProducting();
          

            this.Invoke((MethodInvoker)delegate
            {

                DGVOrders.DataSource = q;
            });


            //foreach (var item in DGVOrders.Rows)
            //{
            //    if (((Order)item.DataBoundItem).OrderStatus == "In Designer")
            //    {
            //        try
            //        {
            //            var cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[0]);
            //        cellPlaceHolder.DrawFill = true;
            //        cellPlaceHolder.BackColor = Color.FromArgb(0xDB, 0xA8, 0x00);


            //        cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[1]);
            //        cellPlaceHolder.DrawFill = true;
            //        cellPlaceHolder.BackColor = Color.FromArgb(0xDB, 0xA8, 0x00);

            //        cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[2]);
            //        cellPlaceHolder.DrawFill = true;
            //        cellPlaceHolder.BackColor = Color.FromArgb(0xDB, 0xA8, 0x00);

            //        cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[3]);
            //        cellPlaceHolder.DrawFill = true;
            //        cellPlaceHolder.BackColor = Color.FromArgb(0xDB, 0xA8, 0x00);
                    
            //        cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[4]);
            //        cellPlaceHolder.DrawFill = true;
            //        cellPlaceHolder.BackColor = Color.FromArgb(0xDB, 0xA8, 0x00);

            //        cellPlaceHolder = DGVOrders.TableElement.GetCellElement(item, DGVOrders.Columns[5]);
            //        ///cellPlaceHolder.Enabled = false;
            //        ///
            //        }catch(Exception ex)
            //        {
            //            return;
            //        }
                    
                    
            //    }
           // }
            Operation.EndOperation(this);
            Thr.Abort();
        }
        private Thread CustomerThread;
        private FrmFactoryOrderProductShow frmFactory = new FrmFactoryOrderProductShow();
        public int SelectedOrderID { get; set; }


        private void LoadingCustomerData()
        {
            this.Invoke((MethodInvoker)delegate
            {
                var Lst = (from c in Operation.AllOrder.Where(p=>p.ID==SelectedOrderID)
                            select c).Single();
                var cust = Lst.Customer;
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
