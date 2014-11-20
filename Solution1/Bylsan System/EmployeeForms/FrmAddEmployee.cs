using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (Emp_NameTextBox.Text == "")
            {

                Emp_NameTextBox.BackColor = Color.OrangeRed;

                Emp_NameTextBox.Focus();
                errorProvider1.SetError(this.Emp_NameTextBox, "Please Enter Employee name");

                return;
            }
            else
            {
                Emp_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }
    }
}
