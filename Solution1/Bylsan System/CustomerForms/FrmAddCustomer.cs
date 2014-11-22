using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.CustomerForms
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (customerNameTextBox.Text == "")
            {

                customerNameTextBox.BackColor = Color.OrangeRed;

                customerNameTextBox.Focus();
                errorProvider1.SetError(this.customerNameTextBox, "Please Enter Branch name");

                return;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion

            Customer tb = new Customer();
            tb.CustomerName = customerNameTextBox.Text;
            tb.PhoneNumber = phoneNumberTextBox.Text;
            CustomersCmd.AddCustomer(tb);
            MessageBox.Show("Saved ..");
            this. Hide ();

        }
    }
}
