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

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmAddEmployee : RadForm
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (emp_NameTextBox.Text == "")
            {

                emp_NameTextBox.BackColor = Color.OrangeRed;

                emp_NameTextBox.Focus();
                errorProvider1.SetError(this.emp_NameTextBox, "Please Enter employee name");

                return;
            }
            else
            {
                emp_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion

            Operation.BeginOperation(this);

            Employee tb = new Employee() {
            
            Emp_Name = emp_NameTextBox .Text ,
            HereDate = hereDateDateTimePicker .Value,
            Personalty_ID = personalty_IDTextBox .Text ,
            Nationalty = nationaltyComboBox .Text ,
            HomeAddress = homeAddressTextBox .Text ,
            PhoneNumber = phoneNumberTextBox .Text ,
            CreateDate = DateTime .Now ,
            Job = jobTextBox .Text ,            
            };


            if (EmployeesCmd.AddEmployee(tb)) {

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
