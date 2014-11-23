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

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmEmployeeEdit : Form
    {
        public FrmEmployeeEdit()
        {
            InitializeComponent();
        }
       
        public int EmpId { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
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

            EmpId = EmployeesCmd.GetEmployeeIdByHisName(emp_NameTextBox.Text);

            if (EmpId != 0)
            {

                Employee tb = new Employee()
                {

                    Emp_Name = emp_NameTextBox.Text,
                    HereDate = hereDateDateTimePicker.Value,
                    Personalty_ID = personalty_IDTextBox.Text,
                    Nationalty = nationaltyComboBox.Text,
                    HomeAddress = homeAddressTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                    CreateDate = DateTime.Now,
                    Job = jobTextBox.Text,
                };

                EmployeesCmd.EditEmployee (tb,EmpId );
                MessageBox.Show("Updated... ");
                this.Hide();

            }
        }
    }
}
