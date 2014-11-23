using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmAddInformationCustomer : Form
    {
        public FrmAddInformationCustomer()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(phoneNumberTextBox.Text);
            }
        }
    }
}
