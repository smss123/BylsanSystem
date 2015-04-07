using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Accountant;



namespace Bylsan_System.AccountsX
{
    public partial class FrmAddAccountCategory : RadForm
    {
        public FrmAddAccountCategory()
        {
            InitializeComponent();
        }


        private void FrmAddAccountCategory_Load(object sender, EventArgs e)
        {
            txtAccountName.Text = string.Empty;
            txtDescriptionBox.Text = string.Empty;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtAccountBox.Text == string.Empty)
            {
                txtAccountBox.BackColor = Color.OrangeRed;

                txtAccountBox.Focus();
                errorProvider1.SetError(txtAccountBox, "Please Enter account Category Name ");

                return;
            }
            else
            {
                txtAccountBox.BackColor = Color.White;
                errorProvider1.Clear();
            }



            try
            {
                Operation.BeginOperation(this);
                var tb = new AccountCategory() { AccountCategoryName = txtAccountBox .Text , Description = txtDescriptionBox.Text  };
                AccountCategoryCmd.AddAccountCategory(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Account Was Created", this);
            }
            catch (Exception)
            {
            }
        }
    }
}
