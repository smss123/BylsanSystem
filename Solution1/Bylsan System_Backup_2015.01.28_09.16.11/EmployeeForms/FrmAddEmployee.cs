using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmAddEmployee : RadForm
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            var tb = new Employee() { Emp_Name = emp_NameTextBox .Text ,
            HereDate = hereDateDateTimePicker .Value,
            Personalty_ID = personalty_IDTextBox .Text ,
            Nationalty = nationaltyComboBox .Text ,
            HomeAddress = homeAddressTextBox .Text ,
            PhoneNumber = phoneNumberTextBox .Text ,
            CreateDate = DateTime .Now ,
            Job = jobTextBox .Text , };


            if (EmployeesCmd.AddEmployee(tb))
            {
                Operation.ShowToustOk("Employee Has Been Saved", this);
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
            Operation.EndOperation(this);
        }
    }
}
