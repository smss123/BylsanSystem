using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.AccountsX.Acc
{
    public partial class frmAddAccount : Telerik.WinControls.UI.RadForm
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }
        private void FillCategoreisCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                CmbCategories.MultiColumnComboBoxElement.DropDownWidth = 550;
                CmbCategories.AutoFilter = true;
                CmbCategories.DisplayMember = "AccountCategoryName";
                CmbCategories.ValueMember = "ID";
            });


            var q = AccountCategoryCmd.GetAll();

            this.Invoke((MethodInvoker)delegate
            {

                CmbCategories.DataSource = q;

                var compositeFilter = new CompositeFilterDescriptor();
                var prodName = new FilterDescriptor("AccountCategoryName", FilterOperator.Contains, string.Empty);
                compositeFilter.FilterDescriptors.Add(prodName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                CmbCategories.EditorControl.FilterDescriptors.Add(compositeFilter);



            });

            Operation.EndOperation(this);
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            FillCategoreisCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AcctCategID != 0)
            {
                Operation.BeginOperation(this);
                var tb = new Account()
                { CategoryID = AcctCategID
                ,
                    AccountName = txtAccountName.Text,
                    Description = txtDescription.Text
                };
                AccountsCmd.AddAccount(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Account Has Been Created Now ", this);
            }
        }





        public int AcctCategID { get; set; }
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcctCategID = 0;
            AcctCategID = int.Parse(CmbCategories.SelectedValue.ToString());
        }
    }
}
