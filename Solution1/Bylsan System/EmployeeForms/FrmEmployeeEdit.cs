﻿using System;
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
    public partial class FrmEmployeeEdit : Form
    {
        public FrmEmployeeEdit()
        {
            InitializeComponent();
        }

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
        }
    }
}