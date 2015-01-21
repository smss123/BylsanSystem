using Bylsan_System.Reports;
using Bylsan_System.Reports.ReportsObject;
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
using XamaDataLayer.BranchCmd;


namespace Bylsan_System.CustomerForms
{
    public partial class FrmCustomerManage : RadForm
    {
        public FrmCustomerManage()
        {
            InitializeComponent();
            DGVCustomers.CommandCellClick += CustomerGridView_CommandCellClick;
        }

        void CustomerGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVCustomers.CurrentColumn.Index;
            if (col == 5)
            {
                FrmCustomerEdit frm = new FrmCustomerEdit();
                frm.TragetCustomer = (Customer)DGVCustomers.CurrentRow.DataBoundItem;
                frm.ShowDialog();
            }
        }

        private void FrmCustomerManage_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LoadCustomers);
            th.Start();
        }

        private void LoadCustomers()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading Customer";
            });
            Operation.BeginOperation(this);
            
            DGVCustomers.DataSource = CustomersCmd.GetAllCustmers();
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loaded ..";
            });
        }

        private void CustomerGridView_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
            LoadCustomers();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVCustomers_CommandCellClick(object sender, EventArgs e)
        {
            var COL = DGVCustomers.CurrentRow.Index;
            if (COL == 5)
            {
                Operation.BeginOperation(this);
                FrmCustomerEdit frm = new FrmCustomerEdit();
                frm.TragetCustomer = (Customer)this.DGVCustomers.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                this.FrmCustomerManage_Load(null, null);

                Operation.EndOperation(this);
            }
            Application.DoEvents();
            //if (COL == 6)
            //{
            //    if (RadMessageBox.Show(this, "Do you want to delete", "Delete", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            //    {
            //        Operation.BeginOperation(this);
            //         CustomersCmd .DeleteCustomer (((Customer )this.DGVCustomers .CurrentRow.DataBoundItem).ID);
            //        Operation.EndOperation(this);
            //    }
            //}

        }
    }
}
