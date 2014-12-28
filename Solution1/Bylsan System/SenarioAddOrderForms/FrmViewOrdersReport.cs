using Bylsan_System.Reports.ReportCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;

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
                OrderReportCmd cmd = new OrderReportCmd();
                cmd.GetOrderProductsByOrderId(int.Parse(OrderIDtextBox.Text));
                e.Handled = true;
            }
        }

        private void Accountstatementbtn_Click(object sender, EventArgs e)
        {
            OrderReportCmd cmd = new OrderReportCmd();
            cmd.GetOrderCustomer(phoneNumberTextBox.Text);
        }

        private void DetailedReportBtn_Click(object sender, EventArgs e)
        {
            OrderReportCmd cmd = new OrderReportCmd();
            cmd.GetOrderProductsCustomerPhone(phoneNumberTextBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            
        }
    }
}