using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.CustomerForms
{
    public partial class FrmAddCustomer : RadForm
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == string.Empty)
            {
                customerNameTextBox.BackColor = Color.OrangeRed;

                customerNameTextBox.Focus();
                errorProvider1.SetError(customerNameTextBox, "Please Enter Customer name");

                return;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }




            Operation.BeginOperation(this);




            if ( CustomersCmd.AddCustomer(new XamaDataLayer.Customer()
            {
                CustomerName = customerNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                 Points = 0
                  }))
            {
                Operation.ShowToustOk("Customer Has Been Saved", this);
                customerNameTextBox.Clear();
                phoneNumberTextBox.Clear();
            }

            Operation.EndOperation(this);
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
