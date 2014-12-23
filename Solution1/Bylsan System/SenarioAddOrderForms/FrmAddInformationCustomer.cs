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
using Bylsan_System.SenarioAddOrderForms;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer;
using Telerik.WinControls.UI;
namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmAddInformationCustomer : RadForm
    {
        public FrmAddInformationCustomer()
        {
            InitializeComponent();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";


        }
        private List<Customer> Cust = new List<Customer>();
        private Customer CurrnetCust = new Customer();

        private void NextBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (phoneNumberTextBox.Text != null)
                {
                    var GetCurrentCustomerInfor = (from c in Cust
                                                   where c.PhoneNumber == phoneNumberTextBox.Text
                                                   select c).Single();
                    if (GetCurrentCustomerInfor.ID != 0)
                    {
                        // if Found 
                       
                        CustomerInformations.WatingCustomer = CurrnetCust;



                    } // End If 2

                }// End If 1

            }
            catch (Exception)
            {
                // Not Found { He Is a New Customer }
                CustomerInformations.CustIni();
                CustomerInformations.WatingCustomer.PhoneNumber = phoneNumberTextBox.Text;
                CustomerInformations.WatingCustomer.CustomerName = customerNameTextBox.Text;
                CustomerInformations.WatingCustomer.CreateDate = DateTime.Now;
                CustomerInformations.WatingCustomer.Points = 0;

            }

            //===================================================================
            FrmAddOrderProduct frm = new FrmAddOrderProduct();
         
            if (SpecialOrderCheckBox.CheckState == CheckState.Checked)
            { frm.OrderTypeCheckLab.Text = string.Format("Special Order"); CustomerInformations.OrdrType = "Special"; }

            if (NormalOrdercheckBox.CheckState == CheckState.Checked)
            { frm.OrderTypeCheckLab.Text = string.Format("Normal Order"); CustomerInformations.OrdrType = "Normal"; }
            //======================================================================


            frm.Show();
            this.Hide();
            Operation.EndOperation(this);
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

        //private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        private void SpecialOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            try
            {
              
                if (phoneNumberTextBox.Text != null)
                {
                    var GetCurrentCustomerInfor = (from c in Cust
                                                   where c.PhoneNumber == phoneNumberTextBox.Text
                                                   select c).Single();
                    this.CurrnetCust = GetCurrentCustomerInfor;
                    if (GetCurrentCustomerInfor.ID != 0)
                    {
                        // if Found 
                        //  أنا رحلت بيانات العميل الى الكلاس لأنه ممكن نستخدمها في الفورم التاني
                        customerNameTextBox.Text = GetCurrentCustomerInfor.CustomerName;


                        label1.Text = string.Format("Customer Account : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.AccountID, Environment.NewLine)); ;
                        label2.Text = string.Format("Customer Created Date : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.CreateDate, Environment.NewLine));

                        label3.Text = string.Format("Customer Points : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.Points, Environment.NewLine));

                        CustomerInformations.WatingCustomer.ID = GetCurrentCustomerInfor.ID;
                        CustomerInformations.WatingCustomer.PhoneNumber = GetCurrentCustomerInfor.PhoneNumber;
                        CustomerInformations.WatingCustomer.CustomerName = GetCurrentCustomerInfor.CustomerName;
                        CustomerInformations.WatingCustomer.AccountID = GetCurrentCustomerInfor.AccountID;
                        CustomerInformations.WatingCustomer.CreateDate = GetCurrentCustomerInfor.CreateDate;
                        CustomerInformations.WatingCustomer.Points = GetCurrentCustomerInfor.Points;

                    } // End If 2
               

                }
                else
                {
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";

                }

            }
            catch (Exception)
            {
                // Not Found { He Is a New Customer }
                CustomerInformations.CustmrPhone = phoneNumberTextBox.Text;
                CustomerInformations.CustmrName = customerNameTextBox.Text;

            }
            Operation.EndOperation(this);
        }

        private void FrmAddInformationCustomer_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            Cust = CustomersCmd.GetAllCustmers();
            Operation.EndOperation(this);
        }

        private void SpecialOrderCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SpecialOrderCheckBox.CheckState == CheckState.Checked) { NormalOrdercheckBox.CheckState = CheckState.Unchecked; }
        }

        private void NormalOrdercheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (NormalOrdercheckBox.CheckState == CheckState.Checked) { SpecialOrderCheckBox.CheckState = CheckState.Unchecked; }

        }
    }
}
