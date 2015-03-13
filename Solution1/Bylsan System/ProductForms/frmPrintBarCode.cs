using System;
using System.Linq;
using System.Windows.Forms;
using Bylsan_System.Reports.ReportCommand;
using Xprema.XExtention;
using System.Threading;

namespace Bylsan_System.ProductForms
{
    public partial class frmPrintBarCode : Form
    {
        public frmPrintBarCode()
        {
            InitializeComponent();
        }

        private void btnOrint_Click(object sender, EventArgs e)
        {
            var cmd = new ItemBarcodeReportCmd();
            cmd.GetItemStorByDate(comboBox1.SelectedValue.ToString().ToInt(),numericUpDown1.Value.ToString().ToInt(),dateTimePicker1.Value);
        }
        private void LoadProduct()
        {
           
            Operation.BeginOperation(this);
            var q = Operation.Allproducts;
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                productBindingSource.DataSource = q;

               

            });
        }
        private void frmPrintBarCode_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadProduct);
            th.Start();
        }
    }
}
