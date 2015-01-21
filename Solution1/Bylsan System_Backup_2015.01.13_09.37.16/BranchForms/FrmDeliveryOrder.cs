using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
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
        Thread ThreadDelivery;

        #region "    ^^^ Populate Delivery Grid     "

        void PopualteGrid()
        {
            var Deliver = new object();
            using (FactoryZoon Cmd = new FactoryZoon())
            {
                Deliver = Cmd.GetAllInProducting();

            }

            this.Invoke((MethodInvoker)delegate { DGVDelivery.DataSource = Deliver; }); ThreadDelivery.Abort();
        }
        #endregion

        private void FrmDeliveryOrder_Load(object sender, EventArgs e)
        {
            ThreadDelivery = new Thread(PopualteGrid);
            ThreadDelivery.Start();
        }


        #region "     Save Changes    "

        Thread ThreadChanges;
        private void OkeyBtn_Click(object sender, EventArgs e)
        {
            ThreadChanges = new Thread(SaveAllChanges);
            ThreadChanges.Start();
        }

        public int OrderID { get; set; }
        public Order MyOrder { get; set; }
        void SaveAllChanges()
        {
            Order OrderTb = new Order();
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
        #endregion

        private void DGVDelivery_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVDelivery.CurrentColumn.Index;

            if (col == 8)
            {

                Operation.BeginOperation(this);
                FrmDeliveryOrderShowInfo frm = new FrmDeliveryOrderShowInfo();
                Order tb = (Order)DGVDelivery.CurrentRow.DataBoundItem;
                frm.TargetOrder = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);

            }

        }


    }
}
