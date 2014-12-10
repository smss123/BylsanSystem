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
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
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
                SupplierGridView.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }

           private void SupplierGridView_CommandCellClick(object sender, EventArgs e)
           {
               var col = SupplierGridView.CurrentColumn.Index;

               if (col == 5)
               {
                   Operation.BeginOperation(this);
                   FrmEditMainStore_Supplier frm = new FrmEditMainStore_Supplier();
                   frm.TreagetSupplier = (Supplier)this.SupplierGridView.CurrentRow.DataBoundItem;
                   frm.ShowDialog();
                   this.FrmManageMainStore_Supplier_Load(null, null);
                   Operation.EndOperation(this);
               }

               if (col == 6)
               {
                   if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                   {
                       Operation.BeginOperation(this);
                       ItemsCmd.DeleteItemAt(((StoreManager)this.SupplierGridView.CurrentRow.DataBoundItem).ID);
                       Operation.EndOperation(this);
                   }
               }
           }

           private void Addbtn_Click(object sender, EventArgs e)
           {
               FrmAddMainStore_Supplier frm = new FrmAddMainStore_Supplier();
               frm.ShowDialog();
           }

           private void RefreshBtn_Click(object sender, EventArgs e)
           {
               FrmManageMainStore_Supplier_Load(sender, e);
           }


    }
    
}
