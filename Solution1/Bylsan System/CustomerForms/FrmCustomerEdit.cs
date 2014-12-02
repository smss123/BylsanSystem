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
using XamaDataLayer.BranchCmd;


namespace Bylsan_System.CustomerForms
{
    public partial class FrmCustomerEdit : RadForm
    {
        public FrmCustomerEdit()
        {
            InitializeComponent();
        }


        public int CustmrID { get; set; }
        public Customer TragetCustomer { get; set; }

        private void Addbtn_Click(object sender, EventArgs e)
        {
          

         
        }

    

        private void FrmCustomerEdit_Load(object sender, EventArgs e)
        {
            customerNameTextBox.Text = TragetCustomer.CustomerName;
            phoneNumberTextBox.Text = TragetCustomer.PhoneNumber;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            #region "  CheckFillTextBox "

            if (customerNameTextBox.Text == "")
            {

                customerNameTextBox.BackColor = Color.OrangeRed;

                customerNameTextBox.Focus();
                errorProvider1.SetError(this.customerNameTextBox, "Please Enter Customer Name");

                return;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            if (phoneNumberTextBox.Text == "")
            {

                phoneNumberTextBox.BackColor = Color.OrangeRed;

                phoneNumberTextBox.Focus();
                errorProvider1.SetError(this.phoneNumberTextBox, "Please Enter PhoneNumber");

                return;
            }
            else
            {
                phoneNumberTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion


            if (CustomersCmd.EditCustomer(new Customer()
            {
                CustomerName = customerNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text
            }, TragetCustomer.ID))
            {
                Operation.ShowToustOk("Customer Has Been Saved", this);
                customerNameTextBox.Clear();
                phoneNumberTextBox.Clear();
            }
        }
    }
}
