using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmManageMainStore_Supplier : RadForm
    {
        public FrmManageMainStore_Supplier()
        {
            InitializeComponent();
        }
        Thread th;
        private void FrmManageMainStore_Supplier_Load(object sender, EventArgs e)
        {
            th = new Thread(Loading);
            th.Start();
        }
           private void Loading()
        {
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "Loading ...";
            });
            Operation.BeginOperation(this);
            var q = SuppliersCmd.GetAllSuppliers();
            this.Invoke((MethodInvoker)delegate
            {
                radGridView1.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }


    }
    
}
