using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Bylsan_System.AccountsX
{
    public partial class FrmEditDebtors : Telerik.WinControls.UI.RadForm
    {
        public FrmEditDebtors()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (debtorNameTextBox.Text == "")
            {

                debtorNameTextBox.BackColor = Color.OrangeRed;

                debtorNameTextBox.Focus();
                errorProvider1.SetError(this.debtorNameTextBox, "Please Enter Debtor name");

                return;
            }
            else
            {
                debtorNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }

       
    }
}
