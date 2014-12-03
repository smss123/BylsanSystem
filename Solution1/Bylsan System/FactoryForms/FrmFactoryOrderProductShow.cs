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

        Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            var q = new object();
            q = OrderProductsCmd.GetAllByOrderID(TaregtOrder);
            this.Invoke((MethodInvoker)delegate
            {
                DGVProducts.DataSource = q;

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

        public int PrdID { get; set; }
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PrdID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString());
            var lst = OrderProductsCmd.GetAllByProductID(PrdID);
            foreach (var item in lst)
            {
                TxtDescription.Text = item.Description;
               PhotoBox.Image = item.ImageX;
            }

        }
    }
}
