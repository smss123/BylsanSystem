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
    public partial class frmAddExpenssesMovment : Telerik.WinControls.UI.RadForm
    {
        public frmAddExpenssesMovment()
        {
            InitializeComponent();
        }
        public ExpenssesMovment TragetExpenssesMovment { get; set; }
        public int ExpenssId { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
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
            Operation.BeginOperation(this);
            ExpenssesMovment tb = new ExpenssesMovment
            {
                ExpenssesID=ExpenssId,
                Amount=double.Parse(amountTextBox.Text),
                DateOfProcess=DateTime.Now,
                Description=descriptionTextBox.Text,


            };

            ExpenssesMovmentCmd.AddExpenssesMovment(tb);
            Operation.ShowToustOk("Expenss Has Been Saved", this);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                amountTextBox.Focus();
                Operation.BeginOperation(this);
            }
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

        private void frmAddExpenssesMovment_Load(object sender, EventArgs e)
        {
            ExpenssId = TragetExpenssesMovment.ExpenssesID.Value;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
