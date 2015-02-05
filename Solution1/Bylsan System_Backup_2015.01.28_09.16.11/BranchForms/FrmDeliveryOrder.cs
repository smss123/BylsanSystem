using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using System.Threading;
using XamaDataLayer.Helper_Classes;

namespace Bylsan_System.BranchForms
{
    public partial class FrmDeliveryOrder : Telerik.WinControls.UI.RadForm
    {
        public FrmDeliveryOrder()
        {
            InitializeComponent();
        }
        private Thread ThreadDelivery;



        private void PopualteGrid()
        {
            var Deliver = new object();
            using (var Cmd = new FactoryZoon())
            {
                Deliver = Cmd.GetAllInProducting();
            }

            this.Invoke((MethodInvoker)delegate
            {
                DGVDelivery.DataSource = Deliver;
            });
            ThreadDelivery.Abort();
        }


        private void FrmDeliveryOrder_Load(object sender, EventArgs e)
        {
            ThreadDelivery = new Thread(PopualteGrid);
            ThreadDelivery.Start();
        }




        private Thread ThreadChanges;
        private void OkeyBtn_Click(object sender, EventArgs e)
        {
            ThreadChanges = new Thread(SaveAllChanges);
            ThreadChanges.Start();
        }

        public int OrderID { get; set; }
        public Order MyOrder { get; set; }
        private void SaveAllChanges()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    foreach (var row in DGVDelivery.Rows)
                    {
                        OrderID = int.Parse(row.Cells[0].Value.ToString());
                        MyOrder = (Order)row.DataBoundItem;

                        if (Convert.ToBoolean(row.Cells[7].Value.ToString()) == true)
                        {
                            MyOrder. OrderStatus = "Done";

                            MyOrder.OrderDeliveryDate = DateTime.Now;
                        }
                        else
                        {
                            MyOrder.OrderStatus = "To Deliver";
                        }
                        OrdersCmd.EditOrderStatusOnly(MyOrder, MyOrder.ID);
                    }





                });
            }
            catch (Exception)
            {
            }

            MessageBox.Show("Saved Changes");
            ThreadChanges.Abort();
        }


        private void DGVDelivery_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVDelivery.CurrentColumn.Index;

            if (col == 8)
            {
                Operation.BeginOperation(this);
                var frm = new FrmDeliveryOrderShowInfo();
                var tb = (Order)DGVDelivery.CurrentRow.DataBoundItem;
                frm.TargetOrder = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmDeliveryOrder_Load(null, null);
        }
    }
}
