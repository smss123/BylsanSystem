using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Bylsan_System.expensesFroms
{
    public partial class FrmAddExpensses : Telerik.WinControls.UI.RadForm
    {
        public FrmAddExpensses()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            #region "  CheckFillTextBox "
            if (expenssesNameTextBox.Text == "")
            {

                expenssesNameTextBox.BackColor = Color.OrangeRed;

                expenssesNameTextBox.Focus();
                errorProvider1.SetError(this.expenssesNameTextBox, "Please Enter Expensses Name");

                return;
            }
            else
            {
                expenssesNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion
        }
    }
}
