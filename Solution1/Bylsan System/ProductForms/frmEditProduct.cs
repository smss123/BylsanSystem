﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
namespace Bylsan_System.ProductForms
{
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }
        public Product TragetProduct { get; set; }

        private void FillCategoreisCombo()
        {

            this.CategoryComboBox.AutoFilter = true;
            this.CategoryComboBox.ValueMember = "ID";
            this.CategoryComboBox.DisplayMember = "Product_Name";




            CategoryComboBox.DataSource = ProductsCmd.GetAllProducts();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (product_NameTextBox.Text == "")
            {

                product_NameTextBox.BackColor = Color.OrangeRed;

                product_NameTextBox.Focus();
                errorProvider1.SetError(this.product_NameTextBox, "Please Select  product name");

                return;
            }
            else
            {
                product_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

            if (int.Parse(CategoryComboBox.SelectedValue.ToString()) != 0)
            {
                Product tb = new Product()
                {
                    Product_Name = product_NameTextBox.Text,
                    Product_Description = product_DescriptionTextBox.Text,
                    Img = productpictureBox.Image,
                    CateogryID = int.Parse(CategoryComboBox.SelectedValue.ToString()),
                };
                ProductsCmd.EditProduct(tb, int.Parse(CategoryComboBox.SelectedValue.ToString()));
            }
        }



        #region "    ^^^ Brwose Photo    "

        OpenFileDialog Op = new OpenFileDialog();

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
        byte[] byteImg1;
        private void ConvertCarsPhotoes()
        {

            if (Op.FileName != "")
            {

                this.Cursor = Cursors.WaitCursor;
                Image img = Image.FromFile(Op.FileName);
                byteImg1 = PhotosConverter.ImageToByteArray(img);
                this.Cursor = Cursors.Default;

            }
            else
            {
                byteImg1 = null;
            }

        }


        #endregion 

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FillCategoreisCombo();
            product_NameTextBox.Text = TragetProduct.Product_Name;
            product_DescriptionTextBox.Text = TragetProduct.Product_Description;
            productpictureBox.Image = TragetProduct.Img;
            CategoryComboBox.SelectedValue = TragetProduct.CateogryID;
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
