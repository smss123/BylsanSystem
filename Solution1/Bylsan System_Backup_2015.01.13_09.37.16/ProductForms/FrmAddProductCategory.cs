using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            #region "  CheckFillTextBox "

            if (productCategoryNameTextBox.Text == "")
            {

                productCategoryNameTextBox.BackColor = Color.OrangeRed;

                productCategoryNameTextBox.Focus();
                errorProvider1.SetError(this.productCategoryNameTextBox, "Please Enter Category name");

                return;
            }
            else
            {
                productCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

            ProductCategory tb = new ProductCategory()
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
