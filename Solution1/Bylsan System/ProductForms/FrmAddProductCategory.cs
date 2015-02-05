using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ProductForms
{
    public partial class FrmAddProductCategory : RadForm
    {
        public FrmAddProductCategory()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (productCategoryNameTextBox.Text == string.Empty)
            {
                productCategoryNameTextBox.BackColor = Color.OrangeRed;

                productCategoryNameTextBox.Focus();
                errorProvider1.SetError(productCategoryNameTextBox, "Please Enter Category name");

                return;
            }
            else
            {
                productCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            var tb = new ProductCategory()
            { ProductCategoryName = productCategoryNameTextBox.Text, Description = descriptionTextBox.Text };
            Operation.BeginOperation(this);
            if (CategoriesCmd.AddCategory(tb))
            {
                Operation.ShowToustOk("Category Has Been Saved", this);
                productCategoryNameTextBox.Clear();
                descriptionTextBox.Clear();
            }
            Operation.EndOperation(this);
        }

        private void FrmAddProductCategory_Load(object sender, EventArgs e)
        {
        }
    }
}
