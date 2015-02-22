using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using Xprema.XExtention;

namespace Bylsan_System.ProductForms
{
    public partial class frmAddProduct : RadForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void FillCategoreisCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                CategoryComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                CategoryComboBox.AutoFilter = true;
                CategoryComboBox.DisplayMember = "ProductCategoryName";
                CategoryComboBox.ValueMember = "ID";
            });


            var q  = CategoriesCmd.GetAllCategories();

            this.Invoke((MethodInvoker)delegate
            {

                CategoryComboBox.DataSource = q;

                var compositeFilter = new CompositeFilterDescriptor();
                var prodName = new FilterDescriptor("ProductCategoryName", FilterOperator.Contains, string.Empty);
                compositeFilter.FilterDescriptors.Add(prodName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                CategoryComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);


            });

            Operation.EndOperation(this);
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (product_NameTextBox.Text == string.Empty)
            {
                product_NameTextBox.BackColor = Color.OrangeRed;

                product_NameTextBox.Focus();
                errorProvider1.SetError(product_NameTextBox, "Please Enter product name");

                return;
            }
            else
            {
                product_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }

            var th = new Thread(AddPro);
            th.Start();
        }

        private void AddPro()
        {
            Product tb = null;

            this.Invoke((MethodInvoker)delegate
            {

                tb = new Product()
                {
                    Product_Name = product_NameTextBox.Text,
                    Product_Description = product_DescriptionTextBox.Text,
                    Img = productpictureBox.Image,
                    CateogryID = CategoryComboBox.SelectedValue.ToString().ToInt(), ProductPrice = productPriceTextBox.Text.Todouble(),
                     PublicName = publicNameTextBox.Text,
                      ProductUnit = productUnitTextBox.Text,
                };
            });
            Operation.BeginOperation(this);

            if (ProductsCmd.AddProduct(tb))
            {
                this.Invoke((MethodInvoker)delegate
                {

                    Operation.ShowToustOk("Product Has Been Saved", this);
                    product_DescriptionTextBox.Clear();
                    product_NameTextBox.Clear();
                    productpictureBox.Image = null;
                });
            }
            Operation.EndOperation(this);
        }





        private OpenFileDialog Op = new OpenFileDialog();

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                productpictureBox.Image = Image.FromFile(Op.FileName);
                this.Cursor = Cursors.Default;
            }
        }
        private byte[] byteImg1;
        private void ConvertCarsPhotoes()
        {
            if (Op.FileName != string.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                var img = Image.FromFile(Op.FileName);
                byteImg1 = PhotosConverter.ImageToByteArray(img );
                this.Cursor = Cursors.Default;
            }
            else
            {
                byteImg1 = null;
            }
        }




        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            var th = new Thread(FillCategoreisCombo);
            th.Start();
        }
    }
}
