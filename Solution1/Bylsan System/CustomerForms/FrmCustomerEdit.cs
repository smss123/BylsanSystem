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
    public partial class FrmCustomerEdit : Form
    {
        public FrmCustomerEdit()
        {
            InitializeComponent();
        }


        public int CustmrID { get; set; }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            //#region "  CheckFillTextBox "

            //if (customerNameTextBox.Text == "")
            //{

            //    customerNameTextBox.BackColor = Color.OrangeRed;

            //    customerNameTextBox.Focus();
            //    errorProvider1.SetError(this.customerNameTextBox, "Please Enter Branch name");

            //    return;
            //}
            //else
            //{
            //    customerNameTextBox.BackColor = Color.White;
            //    errorProvider1.Clear();

            //}

            //#endregion

          CustmrID = 0;
          CustmrID = CustomersCmd.GetCustomerIDByName(customerNameTextBox.Text);
          if(CustmrID != 0){

            Customer tb = new Customer();
            tb.CustomerName = customerNameTextBox.Text;
            tb.PhoneNumber = phoneNumberTextBox.Text;
            CustomersCmd.EditCustomer (tb,CustmrID );
            MessageBox.Show("Updated ...");
            this.Hide();


          }

        }
    }
}
