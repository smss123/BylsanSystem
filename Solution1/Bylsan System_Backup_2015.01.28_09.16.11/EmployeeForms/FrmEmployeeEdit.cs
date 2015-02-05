using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmEmployeeEdit : RadForm
    {
        public FrmEmployeeEdit()
        {
            InitializeComponent();
        }

        public Employee TragetEmployee { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (emp_NameTextBox.Text == string.Empty)
            {
                emp_NameTextBox.BackColor = Color.OrangeRed;

                emp_NameTextBox.Focus();
                errorProvider1.SetError(emp_NameTextBox, "Please Enter employee name");

                return;
            }
            else
            {
                emp_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }



            Operation.BeginOperation(this);
            if (EmployeesCmd.EditEmployee(new Employee() { Emp_Name = emp_NameTextBox.Text,
             HomeAddress = homeAddressTextBox.Text,
             Job = jobTextBox.Text,
             HereDate = hereDateDateTimePicker.Value ,
             Nationalty = nationaltyComboBox.Text,
             Personalty_ID = personalty_IDTextBox.Text,
             PhoneNumber = phoneNumberTextBox.Text }, TragetEmployee.ID))
            {
                Operation.ShowToustOk("Employee Has Ben Saved", this);
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                    else
                    {
                        if (item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = -1;
                        }
                    }
                }
            }
            Operation.EndOperation(this);
        }

        private void FrmEmployeeEdit_Load(object sender, EventArgs e)
        {
            emp_NameTextBox.Text = TragetEmployee.Emp_Name;
            homeAddressTextBox.Text = TragetEmployee.HomeAddress;
            jobTextBox.Text = TragetEmployee.Job;
            nationaltyComboBox.SelectedText = TragetEmployee.Nationalty;
            personalty_IDTextBox.Text = TragetEmployee.Personalty_ID;
            phoneNumberTextBox.Text = TragetEmployee.PhoneNumber;
            hereDateDateTimePicker.Value = TragetEmployee.HereDate.Value;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void personalty_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
