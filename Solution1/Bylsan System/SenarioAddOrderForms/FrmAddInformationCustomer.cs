﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using XamaDataLayer.BranchCmd;
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

            
        }
        private List<Customer> Cust = new List<Customer>();
        private Customer CurrnetCust = new Customer();

        private void NextBtn_Click(object sender, EventArgs e)
        {

            if (phoneNumberTextBox.Text == "")
            {
                errorProvider1.SetError(phoneNumberTextBox, "Please Enter Phone Number");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (customerNameTextBox.Text == "")
            {
                errorProvider1.SetError(customerNameTextBox, "Please Enter Phone Number");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                var getCurrentCustomerInfor = (from c in Operation.AllCustomer
                                               where c.PhoneNumber == phoneNumberTextBox.Text
                                               select c).SingleOrDefault();
                CustomerInformations.CurrCustomer  = getCurrentCustomerInfor;
                if (getCurrentCustomerInfor==null)
                {
                    CustomerInformations.CurrCustomer = new Customer();
                    CustomerInformations.CurrCustomer.PhoneNumber = phoneNumberTextBox.Text;
                    CustomerInformations.CurrCustomer.CustomerName = customerNameTextBox.Text;
                    CustomerInformations.CurrCustomer.CreateDate = DateTime.Now;
                    CustomerInformations.CurrCustomer.Points = 0;
                    CustomerInformations.CurrCustomer.ID = ApiCounter.GetNumber();
                }

            }
            catch (Exception)
            {

                CustomerInformations.CurrCustomer.PhoneNumber = phoneNumberTextBox.Text;
                CustomerInformations.CurrCustomer.CustomerName = customerNameTextBox.Text;
                CustomerInformations.CurrCustomer.CreateDate = DateTime.Now;
                CustomerInformations.CurrCustomer.Points = 0;
                CustomerInformations.CurrCustomer.ID = ApiCounter.GetNumber();
            }
            

            Operation.BeginOperation(this);
            
            var frm = new FrmAddOrderProduct();
            if (SpecialOrderCheckBox.CheckState == CheckState.Checked)
            {
                frm.OrderTypeCheckLab.Text = string.Format("Special Order");
                CustomerInformations.OrdrType = "Special";
            }

            if (NormalOrdercheckBox.CheckState == CheckState.Checked)
            {
                frm.OrderTypeCheckLab.Text = string.Format("Normal Order");
                CustomerInformations.OrdrType = "Normal";
            }
            frm.Show();
            this.Hide();
            Operation.EndOperation(this);
            
            //try
            //{
            //    if (phoneNumberTextBox.Text != null)
            //    {
            //        var GetCurrentCustomerInfor = (from c in Cust
            //                                       where c.PhoneNumber == phoneNumberTextBox.Text
            //                                       select c).Single();
            //        if (GetCurrentCustomerInfor.ID != 0)
            //        {
            //            CustomerInformations.WatingCustomer = CurrnetCust;
            //            CustomerInformations.WaitingOrder.Customer = GetCurrentCustomerInfor;
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    CustomerInformations.CustIni();
            //    CustomerInformations.WatingCustomer.PhoneNumber = phoneNumberTextBox.Text;
            //    CustomerInformations.WatingCustomer.CustomerName = customerNameTextBox.Text;
            //    CustomerInformations.WatingCustomer.CreateDate = DateTime.Now;
            //    CustomerInformations.WatingCustomer.Points = 0;
            //    CustomerInformations.WaitingOrder.Customer = CustomerInformations.WatingCustomer;
            //}


            //var frm = new FrmAddOrderProduct();

            //if (SpecialOrderCheckBox.CheckState == CheckState.Checked)
            //{
            //    frm.OrderTypeCheckLab.Text = string.Format("Special Order");
            //    CustomerInformations.OrdrType = "Special";
            //}

            //if (NormalOrdercheckBox.CheckState == CheckState.Checked)
            //{
            //    frm.OrderTypeCheckLab.Text = string.Format("Normal Order");
            //    CustomerInformations.OrdrType = "Normal";
            //}



            //frm.ShowDialog();
            //this.Hide();
            //Operation.EndOperation(this);
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                     var q = Operation.AllCustomer.Where(p => p.PhoneNumber == phoneNumberTextBox.Text).SingleOrDefault();
                     customerNameTextBox.Text = q.CustomerName;
                     phoneNumberTextBox.Text = q.PhoneNumber;
                     InformationsBox.Text = string.Format("Customer Name is :{0} \n phone Number is {1} \n Total Point is {2}",q.CustomerName,q.PhoneNumber,q.Points);
                }
                catch (Exception)
                {

                    MessageBox.Show("This customer does not exist,  will be affixed now");
                }
            }
        }






        private void SpecialOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void phoneNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //Operation.BeginOperation(this);
            //try
            //{
            //    if (phoneNumberTextBox.Text != null)
            //    {
            //        var GetCurrentCustomerInfor = (from c in Cust
            //                                       where c.PhoneNumber == phoneNumberTextBox.Text
            //                                       select c).Single();
            //        if (GetCurrentCustomerInfor == null)
            //        {
            //            return;
            //        }
            //        CurrnetCust = GetCurrentCustomerInfor;
            //        if (GetCurrentCustomerInfor.ID != 0)
            //        {
            //            customerNameTextBox.Text = GetCurrentCustomerInfor.CustomerName;


            //            label1.Text = string.Format("Customer Account : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.AccountID, Environment.NewLine));
            //            ;
            //            label2.Text = string.Format("Customer Created Date : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.CreateDate, Environment.NewLine));

            //            label3.Text = string.Format("Customer Points : {0} ", String.Format("{0} {1}", GetCurrentCustomerInfor.Points, Environment.NewLine));

            //            CustomerInformations.WatingCustomer.ID = GetCurrentCustomerInfor.ID;
            //            CustomerInformations.WatingCustomer.PhoneNumber = GetCurrentCustomerInfor.PhoneNumber;
            //            CustomerInformations.WatingCustomer.CustomerName = GetCurrentCustomerInfor.CustomerName;
            //            CustomerInformations.WatingCustomer.AccountID = GetCurrentCustomerInfor.AccountID;
            //            CustomerInformations.WatingCustomer.CreateDate = GetCurrentCustomerInfor.CreateDate;
            //            CustomerInformations.WatingCustomer.Points = GetCurrentCustomerInfor.Points;
            //        }
            //    }
            //    else
            //    {
            //        label1.Text = string.Empty;
            //        label2.Text = string.Empty;
            //        label3.Text = string.Empty;
            //    }
            //}
            //catch (Exception)
            //{
            //    CustomerInformations.CustmrPhone = phoneNumberTextBox.Text;
            //    CustomerInformations.CustmrName = customerNameTextBox.Text;
            //}
            //Operation.EndOperation(this);
        }

        private void FrmAddInformationCustomer_Load(object sender, EventArgs e)
        {
            CustomerInformations.CurOrder = new Order();
            CustomerInformations.CurrCustomer = new Customer();

            //CustomerInformations.WaitingOrder = new Order();
            //Operation.BeginOperation(this);
            //Cust = CustomersCmd.GetAllCustmers();
            //foreach (var item in Cust)
            //{
            //    phoneNumberTextBox.AutoCompleteCustomSource.Add(item.PhoneNumber);
            //    customerNameTextBox.AutoCompleteCustomSource.Add(item.CustomerName);
            //}
            //Operation.EndOperation(this);
           // Operation.BeginOperation(this);

            foreach (var item in Operation.AllCustomer)
            {
                phoneNumberTextBox.AutoCompleteCustomSource.Add(item.PhoneNumber);
                customerNameTextBox.AutoCompleteCustomSource.Add(item.CustomerName);
            }
            phoneNumberTextBox.Focus();
        }

        private void SpecialOrderCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SpecialOrderCheckBox.CheckState == CheckState.Checked)
            {
                NormalOrdercheckBox.CheckState = CheckState.Unchecked;
            }
        }

        private void NormalOrdercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalOrdercheckBox.CheckState == CheckState.Checked)
            {
                SpecialOrderCheckBox.CheckState = CheckState.Unchecked;
            }
        }

        private void customerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    var q = Operation.AllCustomer.Where(p => p.PhoneNumber == phoneNumberTextBox.Text).SingleOrDefault();
                    customerNameTextBox.Text = q.CustomerName;
                    phoneNumberTextBox.Text = q.PhoneNumber;
                    InformationsBox.Text = string.Format("Customer Name is :{0} \n phone Number is {1} \n Total Point is {2}", q.CustomerName, q.PhoneNumber, q.Points);
 
                }
                catch (Exception)
                {

                    MessageBox.Show("This customer does not exist,  will be affixed now");
                }
            }
        }
    }
}
