using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Threading;

using XamaDataLayer;
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
        private void FrmFactoryOrderShow_Load(object sender, EventArgs e)
        {
            Thr = new Thread(PopulateDGVOrders);
            Thr.Start();
        }

        void PopulateDGVOrders()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate {
                FactoryZoon cmd = new FactoryZoon ();
                DGVOrders.DataSource = cmd.GetAllInProducting();
              
            });
            Operation.EndOperation(this);
            Thr.Abort();
        }
    }
}
