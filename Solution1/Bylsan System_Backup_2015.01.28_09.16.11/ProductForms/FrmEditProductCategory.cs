using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ProductForms
{
    public partial class FrmEditProductCategory : RadForm
    {
        public FrmEditProductCategory()
        {
            InitializeComponent();
        }

        public int CategID { get; set; }
        public ProductCategory TragetCategory { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
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




            var tb = new ProductCategory() { ProductCategoryName = productCategoryNameTextBox.Text, Description = descriptionTextBox.Text };
            Operation.BeginOperation(this);
            if ( CategoriesCmd.EditCategory(tb, TragetCategory.ID))
            {
                Operation.ShowToustOk("Category Has Been saved", this);
                productCategoryNameTextBox.Clear();
                descriptionTextBox.Clear();
            }
            Operation.EndOperation(this);
        }

        private void FrmEditProductCategory_Load(object sender, EventArgs e)
        {
            productCategoryNameTextBox.Text = TragetCategory.ProductCategoryName;
            descriptionTextBox.Text = TragetCategory.Description;
        }
    }
}

