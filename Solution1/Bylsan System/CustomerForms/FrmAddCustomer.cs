using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer.BranchCmd;
using DevComponents.DotNetBar;
namespace Bylsan_System.CustomerForms
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
               #region "  CheckFillTextBox "
            
            if (CustomerNameTxtBox.Text == "")
            {

                CustomerNameTxtBox.BackColor = Color.OrangeRed;

                CustomerNameTxtBox.Focus();
                errorProvider1.SetError(this.CustomerNameTxtBox, "Please Enter Customer name");

                return;
            }
            else
            {
                CustomerNameTxtBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            //CheckPassword


            if (PhoneTextBox.Text == "")
            {

                PhoneTextBox.BackColor = Color.OrangeRed;

                PhoneTextBox.Focus();
                errorProvider1.SetError(this.PhoneTextBox, "Please Enter Phone");


                return;
            }
            else
            {
                PhoneTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
               #endregion
            Operation.BeginOperation(this);
            if (CustomersCmd.AddCustomer(new XamaDataLayer.Customer()
            {
                CustomerName = CustomerNameTxtBox.Text,
                PhoneNumber = PhoneTextBox.Text,
                Points = 0
            })
                )
            {
                Operation.ShowToustOk("Customer has been Saved", this);

            }
            Operation.EndOperation(this);
           
        }
        
       
       

        }
    }

