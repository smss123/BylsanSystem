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
            this.Invoke((MethodInvoker)delegate {
                this.CategoryComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                this.CategoryComboBox.AutoFilter = true;
                this.CategoryComboBox.DisplayMember = "ProductCategoryName";
                this.CategoryComboBox.ValueMember = "ID";
            });
           
           
          var q  = CategoriesCmd.GetAllCategories();

          this.Invoke((MethodInvoker)delegate {

              CategoryComboBox.DataSource = q;

              CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
              FilterDescriptor prodName = new FilterDescriptor("ProductCategoryName", FilterOperator.Contains, "");
               compositeFilter.FilterDescriptors.Add(prodName);
               compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
              this.CategoryComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);


          
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
                errorProvider1.SetError(this.product_NameTextBox, "Please Enter product name");

                return;
            }
            else
            {
                product_NameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion
           Thread th = new Thread(AddPro);
           th.Start();
          
        }

        private void AddPro()
        {
            Product tb=null;

            this.Invoke((MethodInvoker)delegate {

                tb = new Product()
                {
                    Product_Name = product_NameTextBox.Text,
                    Product_Description = product_DescriptionTextBox.Text,
                    Img = productpictureBox.Image,
                    CateogryID = CategoryComboBox.SelectedValue.ToString().ToInt(), ProductPrice=productPriceTextBox.Text.Todouble(),
                     PublicName= publicNameTextBox.Text,
                      ProductUnit= productUnitTextBox.Text,
                };
            
            
            });
            Operation.BeginOperation(this);

            if (ProductsCmd.AddProduct(tb))
            {
                this.Invoke((MethodInvoker)delegate {

                   Operation.ShowToustOk("Product Has Been Saved", this);
                    product_DescriptionTextBox.Clear();
                    product_NameTextBox.Clear();
                    productpictureBox.Image = null;
                
                });
               


            }
            Operation.EndOperation(this);
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
         private void ConvertCarsPhotoes() {
                 
            if (Op.FileName != "")
            {
            
                this.Cursor = Cursors.WaitCursor;
                Image img = Image.FromFile(Op.FileName);
                byteImg1 = PhotosConverter.ImageToByteArray(img );
                this.Cursor = Cursors.Default;

            }
            else { 
                byteImg1 = null; }

         }


        #endregion 

         private void frmAddProduct_Load(object sender, EventArgs e)
         {
           Thread th = new Thread(FillCategoreisCombo);
           th.Start();
         }

    }
}