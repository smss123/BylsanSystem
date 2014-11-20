using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.ProductForms
{
    public partial class FrmAddProductCategory : Form
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
                errorProvider1.SetError(this.productCategoryNameTextBox, "Please Enter Branch name");

                return;
            }
            else
            {
                productCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }
    }
}
