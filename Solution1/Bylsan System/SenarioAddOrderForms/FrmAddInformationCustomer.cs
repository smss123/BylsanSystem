﻿using System;
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
            Form frm = new FrmAddOrderProduct();
            frm.Show();
            this.Hide();
            Operation.EndOperation(this);
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (phoneNumberTextBox.Text != null)
                {
                    var GetCurrentCustomerInfor = (from c in CustomersCmd.GetAllCustmers()
                                                   where c.PhoneNumber == phoneNumberTextBox.Text
                                                   select c).Single();
                    if (GetCurrentCustomerInfor.ID != 0)
                    {
                        // if Found 
                        //  أنا رحلت بيانات العميل الى الكلاس لأنه ممكن نستخدمها في الفورم التاني
                        customerNameTextBox.Text = GetCurrentCustomerInfor.CustomerName;
                        CustomerInformations.WatingCustomer.ID = GetCurrentCustomerInfor.ID;
                        CustomerInformations.WatingCustomer.PhoneNumber = GetCurrentCustomerInfor.PhoneNumber;
                        CustomerInformations.WatingCustomer.CustomerName = GetCurrentCustomerInfor.CustomerName;
                        CustomerInformations.WatingCustomer.AccountID = GetCurrentCustomerInfor.AccountID;
                        CustomerInformations.WatingCustomer.CreateDate = GetCurrentCustomerInfor.CreateDate;
                        CustomerInformations.WatingCustomer.Points = GetCurrentCustomerInfor.Points;
                        //=======================================================================================
                        InformationsBox.Text  = GetCurrentCustomerInfor.AccountID + " " + Environment.NewLine;
                        InformationsBox.Text = GetCurrentCustomerInfor.CreateDate + " " + Environment.NewLine;
                        InformationsBox.Text = GetCurrentCustomerInfor.Points  + " " + Environment.NewLine;
                    } // End If 2
                 
                }// End If 1

            }
            catch (Exception)
            {
                // Not Found { He Is New Customer }
                CustomerInformations.WatingCustomer.PhoneNumber = phoneNumberTextBox.Text.ToString();
                CustomerInformations.WatingCustomer.CustomerName = customerNameTextBox.Text.ToString();
                
            }
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
