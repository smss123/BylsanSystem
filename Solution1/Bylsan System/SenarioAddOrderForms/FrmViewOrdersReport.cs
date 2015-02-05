using Bylsan_System.Reports.ReportCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmViewOrdersReport : RadForm
    {
        public FrmViewOrdersReport()
        {
            InitializeComponent();
        }

        private void OrderIDtextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void OrderIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var cmd = new OrderReportCmd();
                cmd.GetOrderProductsByOrderId(int.Parse(OrderIDtextBox.Text));
                e.Handled = true;
            }
        }

        private void Accountstatementbtn_Click(object sender, EventArgs e)
        {
            var cmd = new OrderReportCmd();
            cmd.GetOrderCustomer(phoneNumberTextBox.Text);
        }

        private void DetailedReportBtn_Click(object sender, EventArgs e)
        {
            var cmd = new OrderReportCmd();
            cmd.GetOrderProductsCustomerPhone(phoneNumberTextBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
