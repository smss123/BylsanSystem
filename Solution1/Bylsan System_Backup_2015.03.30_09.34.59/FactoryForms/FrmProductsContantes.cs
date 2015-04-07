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
using XamaDataLayer.Main_Store;
using Xprema.XExtention;

namespace Bylsan_System.FactoryForms
{
    public partial class FrmProductsContantes : RadForm
    {
        public FrmProductsContantes()
        {
            InitializeComponent();
        }


        private void PopulateCmb()
        {
            Cmbproducts.MultiColumnComboBoxElement.DropDownWidth = 550;
            CmbItems.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            Invoke((MethodInvoker)delegate
            {
                Cmbproducts.AutoFilter = true;
                Cmbproducts.ValueMember = "ID";

                Cmbproducts.DisplayMember = "Product_Name";

                ///Item
                ///
                CmbItems.AutoFilter = true;
                CmbItems.ValueMember = "ID";
                CmbItems.DisplayMember = "Product_Name";
            });

            var q = Operation.Allproducts.Where(p => p.ProductType == "item product");
            var q1 = Operation.Allproducts.Where(p => p.ProductType == "All" || p.ProductType == "item row material").ToList();
            Invoke((MethodInvoker)delegate
            {
                CmbItems.DataSource = q1;
                Cmbproducts.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = Cmbproducts.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                Cmbproducts.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);


                var filter1 = new FilterDescriptor();
                filter1.PropertyName = CmbItems.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                CmbItems.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);




            });
            Operation.EndOperation(this);
        }
        private void FrmProductsContantes_Load(object sender, EventArgs e)
        {
            var th = new Thread(PopulateCmb);
            th.Start();
            dataGridView1.DataSource = ls;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Cmbproducts.SelectedValue == null)
            {
                Cmbproducts.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                Cmbproducts.Focus();
                errorProvider1.SetError(Cmbproducts, "Please Chose Product ");

                return;
            }
            else
            {
                Cmbproducts.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///
            if (CmbItems.SelectedValue == null)
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                CmbItems.Focus();
                errorProvider1.SetError(CmbItems, "Please Chose Item ");

                return;
            }
            else
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///

            if (txtQty.Text == string.Empty)
            {
                txtQty.BackColor = Color.OrangeRed;

                txtQty.Focus();
                errorProvider1.SetError(txtQty, "Please Enter Qty");

                return;
            }
            else
            {
                txtQty.BackColor = Color.White;
                errorProvider1.Clear();
            }

            try
            {
                if (txtQty.Text != string.Empty && itmID != 0 )
                {
                    var    availQty = 0f;
                    var targetStore = StoreCmd .GetAvailableQtyByItemID (itmID );
                    availQty = targetStore.AvailableQty.Value;

                    if (Convert.ToDouble(txtQty.Text.ToString()) > availQty)
                    {
                        Operation.ShowToustOk("Quantity is not available", this);
                        txtQty.Text = string.Empty;
                        return;
                    }
                    Operation.BeginOperation(this);


                    var tb = new ProductContent() { ProductID = prdid ,
                    ContentsProductID = itmID ,
                    Qty = int .Parse (txtQty .Text .ToString ()),
                    unitOfProduct = CmbUnits .Text };
                    ProductContentsCmd.AddProductContents(tb);









                    Operation.EndOperation(this);
                    Operation.ShowToustOk("Saved ...", this);
                    broom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int prdid { get; set; }
        private void Cmbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Lstproducts = ProductsCmd.GetAllProducts();

                prdid = 0;
                prdid = (from p in Lstproducts.ToList()
                          select p.ID).Single();
            }
            catch (Exception)
            {
            }
        }

        public int itmID { get; set; }
        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var AllItems = Operation.Allproducts;
                itmID = 0;
                itmID = (from i in AllItems.ToList()
                          select i.ID).Single();
            }
            catch (Exception)
            {
            }
        }


        private void broom()
        {
            prdid = 0;
            itmID = 0;
            CmbItems.Text = null;
            Cmbproducts.Text = null;
            txtQty.Text = string.Empty;
            CmbUnits.Text = string.Empty;
            FrmProductsContantes_Load(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private List<ProductContent> ls = new List<ProductContent>();

        private void btnSveToGrd_Click(object sender, EventArgs e)
        {
            var p = new ProductContent() { ContentsProductID = CmbItems.SelectedValue.ToString().ToInt(),
             unitOfProduct = CmbUnits.Text,
              ProductID = Cmbproducts.SelectedValue.ToString().ToInt()
            };
            p.Qty = long.Parse(txtQty.Text);
            ls.Add(p);
            dataGridView1.DataSource = string.Empty;
            dataGridView1.DataSource = ls;
        }
    }
}
