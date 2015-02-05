using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;

namespace Bylsan_System.designerForms
{
    public partial class FrmOrderShow : RadForm
    {
        public FrmOrderShow()
        {
            InitializeComponent();
        }

        private FrmOrderProductShow FrmProdShow = new FrmOrderProductShow();

        private Thread Thr ;
        private Thread CustomerThread;

        private void RefreshData()
        {
            Operation.BeginOperation(this);
            var q = new object();
            using (var FactoryZoonCmd = new FactoryZoon())
            {
                q = FactoryZoonCmd.GetAllOrdersInDesigner();
            }
            this.Invoke((MethodInvoker)delegate
            {

                DGVOrders.DataSource = q;
                foreach (var item in DGVOrders.Rows)
                {
                    var itm = (Order)item.DataBoundItem;
                    if (itm.OrderStatus == "In Designer")
                    {
                        item.Cells[0].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                        item.Cells[1].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                        item.Cells[2].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                    }
                }
            });
            Operation.EndOperation(this);
            Thr.Abort();
        }

        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            var q = new object();
            using (var FactoryZoonCmd = new FactoryZoon())
            {
                q = Operation.AllOrder.Where(o => o.OrderStatus == "In Designer");
            }
            this.Invoke((MethodInvoker)delegate
            {

                DGVOrders.DataSource = q;
                foreach (var item in DGVOrders.Rows)
                {
                    var itm = (Order)item.DataBoundItem;
                    if (itm.OrderStatus == "In Designer")
                    {
                        item.Cells[0].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                        item.Cells[1].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                        item.Cells[2].Style.BackColor = Color.FromArgb(255, 102, 154, 255);
                    }
                }
            });
            Operation.EndOperation (this);
            Thr.Abort();
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
            var Lst = (from c in OrdersCmd.GetAllOrderByID(SelectedOrderID)
                        select c).Single();
            var cust = (from c in CustomersCmd.GetAllCustmers()
                         where c.ID == Lst.CustomerID
                         select c).Single();

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
                    FrmProdShow.SelectedOrder = (Order)DGVOrders.CurrentRow.DataBoundItem;
                    FrmProdShow.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            Thr = new Thread(PopulateGrd);
            Thr.Start();
        }
    }
}
