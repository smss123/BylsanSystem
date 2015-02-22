using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using Xprema.XExtention;

namespace Bylsan_System.ProductForms
{
    public partial class frmEditProduct : RadForm
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }
        public Product TragetProduct { get; set; }

        private void FillCategoreisCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                CategoryComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                CategoryComboBox.AutoFilter = true;
                CategoryComboBox.DisplayMember = "ProductCategoryName";
                CategoryComboBox.ValueMember = "ID";
                lblstatus.Text = "Loading ...";
            });

            var q = CategoriesCmd.GetAllCategories();
            this.Invoke((MethodInvoker)delegate
            {

                CategoryComboBox.DataSource = q;
                CategoryComboBox.SelectedValue = TragetProduct.CateogryID;
                lblstatus.Text = "Compelete ..";
            });
            Operation.EndOperation(this);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (product_NameTextBox.Text == string.Empty)
            {
                product_NameTextBox.BackColor = Color.OrangeRed;

                product_NameTextBox.Focus();
                errorProvider1.SetError(product_NameTextBox, "Please Select  product name");

                return;
            }
            else
            {
                product_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (int.Parse(CategoryComboBox.SelectedValue.ToString()) != 0)
            {
                var th = new Thread(EditProdoct);
                th.Start();
            }
        }

        private void EditProdoct()
        {
            Operation.BeginOperation(this);
            var tb = new Product();
            this.Invoke((MethodInvoker)delegate
            {
                lblstatus.Text = "Editing...";
                tb = new Product
                {
                    Product_Name = product_NameTextBox.Text,
                    Product_Description = product_DescriptionTextBox.Text,
                    Img = productpictureBox.Image,
                    CateogryID = int.Parse(CategoryComboBox.SelectedValue.ToString()),
                     ProductPrice = txtprice.Text.Todouble(),
                     PublicName = publicNameTextBox.Text,
                    ProductUnit = productUnitTextBox.Text,
                    ProductType = ItemTypecomboBox.Text
                };
            });


            ProductsCmd.EditProduct(tb, TragetProduct.ID);
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                Operation.ShowToustOk("Product Has Been Edited..", this);

                lblstatus.Text = "Complete Edited ..";
            });
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
                byteImg1 = PhotosConverter.ImageToByteArray(img);
                this.Cursor = Cursors.Default;
            }
            else
            {
                byteImg1 = null;
            }
        }




        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            var th = new Thread(FillCategoreisCombo);
            th.Start();
            product_NameTextBox.Text = TragetProduct.Product_Name;
            product_DescriptionTextBox.Text = TragetProduct.Product_Description;
            productpictureBox.Image = TragetProduct.Img;
            publicNameTextBox.Text = TragetProduct.PublicName;
            productUnitTextBox.Text = TragetProduct.ProductUnit;

            txtprice.Text = TragetProduct.ProductPrice.ToString();
            Operation.EndOperation(this);
        }

        private void BrowseBtn_Click_1(object sender, EventArgs e)
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
    }
}
