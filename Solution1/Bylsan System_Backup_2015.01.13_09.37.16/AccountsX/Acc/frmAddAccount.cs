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
                this.CmbCategories.DisplayMember = "AccountCategoryName";
                this.CmbCategories.ValueMember = "ID";
            });


            var q = AccountCategoryCmd.GetAll();
        
            this.Invoke((MethodInvoker)delegate
            {

                CmbCategories.DataSource = q;

                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor prodName = new FilterDescriptor("AccountCategoryName", FilterOperator.Contains, "");
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
            if (AcctCategID != 0)
            {
                Operation.BeginOperation(this);
                Account tb = new Account()
                {
                    CategoryID = AcctCategID
                    ,
                    AccountName = txtAccountName.Text,
                    Description = txtDescription.Text
                };
                AccountsCmd.AddAccount(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Account Has Been Created Now ", this);
            }
        }



        #region " Save At Two Tables {Account & AccountCategory ^^^  Both} "

        public int AcctCategID { get; set; }
        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcctCategID = 0;
            AcctCategID = int.Parse(CmbCategories.SelectedValue.ToString());


        }

        
        #endregion 
    }
}
