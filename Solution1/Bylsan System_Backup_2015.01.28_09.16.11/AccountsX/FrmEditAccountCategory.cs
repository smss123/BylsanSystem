using System;
using System.Collections.Generic;
using System.Drawing;
using XamaDataLayer;
using XamaDataLayer.Accountant;

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
            if (accountCategoryNameTextBox.Text == string.Empty)
            {
                accountCategoryNameTextBox.BackColor = Color.OrangeRed;

                accountCategoryNameTextBox.Focus();
                errorProvider1.SetError(accountCategoryNameTextBox, "Please Enter account Category Name ");

                return;
            }
            else
            {
                accountCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }





            Operation.BeginOperation(this);

            TragetActCategory.AccountCategoryName = accountCategoryNameTextBox.Text ;
            TragetActCategory.Description = descriptionTextBox.Text ;
            AccountCategoryCmd.EditAccountCategory(TragetActCategory, TragetActCategory.ID);

            Operation.EndOperation(this);

            Operation.ShowToustOk("Accout Category Has Been Updated  Successfull", this);
        }
        public AccountCategory  TragetActCategory  { get; set; }
        private void FrmEditAccountCategory_Load(object sender, EventArgs e)
        {
            accountCategoryNameTextBox.Text = TragetActCategory.AccountCategoryName;
            descriptionTextBox.Text = TragetActCategory.Description;
        }
    }
}
