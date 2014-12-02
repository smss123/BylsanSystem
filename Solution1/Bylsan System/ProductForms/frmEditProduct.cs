using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using Xprema.XExtention;
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
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate {

                this.CategoryComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                this.CategoryComboBox.AutoFilter = true;
                this.CategoryComboBox.DisplayMember = "ProductCategoryName";
                this.CategoryComboBox.ValueMember = "ID";
                this.lblstatus.Text = "Loading ...";
            });
           
          var q = CategoriesCmd.GetAllCategories();
          this.Invoke((MethodInvoker)delegate {

              CategoryComboBox.DataSource = q;
              CategoryComboBox.SelectedValue = TragetProduct.CateogryID;
              this.lblstatus.Text = "Compelete ..";
          });
          Operation.EndOperation(this);
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
              Thread th = new Thread(EditProdoct);
              th.Start();
            }
        }

        private void EditProdoct()
        {
            Operation.BeginOperation(this);
            Product tb = new Product();
            this.Invoke((MethodInvoker)delegate{
                lblstatus.Text = "Editing...";
                tb = new Product
                {
                    Product_Name = product_NameTextBox.Text,
                    Product_Description = product_DescriptionTextBox.Text,
                    Img = productpictureBox.Image,
                    CateogryID = int.Parse(CategoryComboBox.SelectedValue.ToString()),
                     ProductPrice = txtprice.Text.Todouble()
                }; 
            
            });

           
            ProductsCmd.EditProduct(tb, TragetProduct.ID);
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate {

                Operation.ShowToustOk("Product Has Been Edited..", this);

                this.lblstatus.Text = "Complete Edited ..";
            
            });
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
          Thread th = new Thread(FillCategoreisCombo);
          th.Start();
            product_NameTextBox.Text = TragetProduct.Product_Name;
            product_DescriptionTextBox.Text = TragetProduct.Product_Description;
            productpictureBox.Image = TragetProduct.Img;
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
