using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using Bylsan_System.expensesFroms;
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

            Operation.BeginOperation(this);
            Expenss extb = new Expenss() { ExpenssesName = expenssesNameTextBox.Text, Description = descriptionTextBox.Text };

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
