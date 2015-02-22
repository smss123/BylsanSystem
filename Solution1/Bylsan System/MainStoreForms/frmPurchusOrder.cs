using Bylsan_System.Reports.ReportCommand;
using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using Xprema.XExtention;

namespace Bylsan_System.MainStoreForms
{
    public partial class frmPurchusOrder : RadForm
    {
        public frmPurchusOrder()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();

        private void frmPurchusOrder_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            productBindingSource.DataSource = Operation.Allproducts;
            orderPurchBindingSource.DataSource = db.OrderPurches;
            supplierBindingSource.DataSource = db.Suppliers;

            Operation.EndOperation(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            this.Validate();
            var q = (OrderPurch)this.orderPurchBindingSource.Current;
            q.OrderDate = orderDateDateTimePicker.Value;
            this.productOrderPurchusBindingSource.EndEdit();
            this.orderPurchBindingSource.EndEdit();
                db.SubmitChanges();
                Operation.ShowToustOk("Saved", this);
            Operation.EndOperation(this);
        }

        private void btnLookFor_Click(object sender, EventArgs e)
        {
            orderPurchBindingSource.DataSource = db.OrderPurches.Where(p => p.ID == txtID.Text.ToInt());
        }

        private void txtID_Click(object sender, EventArgs e)
        {
           
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                frmPurchusOrder_Load(null, null);
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                OrderPurchesesCmd cmd = new OrderPurchesesCmd();
                cmd.ShowReport(int.Parse(txtID.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter th Number of Order");
            }
           
        }
    }
}
