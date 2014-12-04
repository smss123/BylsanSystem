using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

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

    }
}
