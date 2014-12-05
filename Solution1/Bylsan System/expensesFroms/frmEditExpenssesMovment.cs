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

namespace Bylsan_System.expensesFroms
{
    public partial class frmEditExpenssesMovment : Telerik.WinControls.UI.RadForm
    {
        public ExpenssesMovment TragetExpenssesMovment { get; set; }
        public int XId { get; set; }
        public frmEditExpenssesMovment()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (amountTextBox.Text == "")
            {

                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(this.amountTextBox, "Please Enter Amount ");

                return;
            }
            else
            {
                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion
            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                ExpenssesMovment tb = new ExpenssesMovment()
                {
                    ID = XId,
                    Amount = double.Parse(amountTextBox.Text),
                    Description = descriptionTextBox.Text,

                };
                ExpenssesMovmentCmd.EditExpMovment(tb);
            }
             Operation.EndOperation(this);
             Operation.ShowToustOk("Expenss Has Been Saved", this);
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && amountTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frmEditExpenssesMovment_Load(object sender, EventArgs e)
        {
            XId = TragetExpenssesMovment.ID;
            amountTextBox.Text = TragetExpenssesMovment.Amount.Value.ToString();
            descriptionTextBox.Text = TragetExpenssesMovment.Description;
        }
    }
}
