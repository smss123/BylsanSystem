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
                Deliver = Cmd.GetAllToDeliver();

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

        public  int OrderID { get; set; }
        void SaveAllChanges()
        {
            Order OrderTb = new Order();
            this.Invoke((MethodInvoker)delegate {
                foreach (var row  in  DGVDelivery .Rows )
                {         
                    
                    OrderID = int.Parse(row.Cells[0].Value.ToString());
                    if ( Convert.ToBoolean (row.Cells[8].Value.ToString()) == true)
                    {
                         
                        OrderTb = new Order() {
                        
                        OrderStatus = "Done",
                        }; 
                        
                    }
                    else
                    {
                       
                        OrderTb = new Order()
                        {

                            OrderStatus = "To Deliver",
                        };
                        
                    }
                    OrdersCmd.EditOrderStatusOnly(OrderTb, OrderID);

                }




            });

            MessageBox.Show("Saved Changes");
            ThreadChanges.Abort();
           
        }
        #endregion 

    }
}
