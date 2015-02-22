using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using System.Linq;

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
            if (expenssesNameTextBox.Text == string.Empty)
            {
                expenssesNameTextBox.BackColor = Color.OrangeRed;

                expenssesNameTextBox.Focus();
                errorProvider1.SetError(expenssesNameTextBox, "Please Enter Expensses Name");

                return;
            }
            else
            {
                expenssesNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            Operation.BeginOperation(this);
            var extb = new Expenss() { ExpenssesName = expenssesNameTextBox.Text, Description = descriptionTextBox.Text };

            if (ExpenssesCmd.AddExpensses(extb))
            {
                Operation.ShowToustOk("Expenss Has Been Saved", this);
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
