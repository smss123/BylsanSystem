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


            Operation.BeginOperation(this);
           
           
         

            if ( CustomersCmd.AddCustomer(new XamaDataLayer.Customer()
            {
                CustomerName = customerNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                 Points=0
                  
               
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
