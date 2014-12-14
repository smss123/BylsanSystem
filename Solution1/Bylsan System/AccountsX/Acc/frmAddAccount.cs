using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
//===========================
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
//==========================
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
                this.CmbCategories.MultiColumnComboBoxElement.DropDownWidth = 550;
                this.CmbCategories.AutoFilter = true;
                this.CmbCategories.DisplayMember = "ProductCategoryName";
                this.CmbCategories.ValueMember = "ID";
            });


            var q = CategoriesCmd.GetAllCategories();

            this.Invoke((MethodInvoker)delegate
            {

                CmbCategories.DataSource = q;

                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor prodName = new FilterDescriptor("ProductCategoryName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(prodName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.CmbCategories.EditorControl.FilterDescriptors.Add(compositeFilter);



            });

            Operation.EndOperation(this);

        }
      
        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            FillCategoreisCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveAtTwoTables();
        }



        #region " Save At Two Tables {Account & AccountCategory ^^^  Both} "

        public int CategID { get; set; }
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int .Parse (CmbCategories.SelectedValue.ToString()) !=0) 
            {
                CategID = 0;
                CategID = int.Parse(CmbCategories.SelectedValue.ToString());
            }


        }

        void SaveAtTwoTables()
        {
            Operation.BeginOperation(this );

            AccountCategory ActCaegTB = new AccountCategory() { AccountCategoryName = txtAccountName.Text, Description = txtDescription.Text };
            AccountCategoryCmd.AddAccountCategory(ActCaegTB);

            Account ActTb = new Account() { CategoryID = CategID, AccountName = txtAccountName.Text, Description = txtDescription.Text };
            AccountsCmd.AddAccount(ActTb);

            Operation.EndOperation(this);
            Operation.ShowToustOk("Account Was  Created Now ...", this);

            CategID = 0;
              
        }
        #endregion 
    }
}
