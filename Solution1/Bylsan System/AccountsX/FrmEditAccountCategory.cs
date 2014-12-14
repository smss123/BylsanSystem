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
    public partial class FrmEditAccountCategory : Telerik.WinControls.UI.RadForm
    {
        public FrmEditAccountCategory()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (accountCategoryNameTextBox.Text == "")
            {

                accountCategoryNameTextBox.BackColor = Color.OrangeRed;

                accountCategoryNameTextBox.Focus();
                errorProvider1.SetError(this.accountCategoryNameTextBox, "Please Enter account Category Name ");

                return;
            }
            else
            {
                accountCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }
    }
}
