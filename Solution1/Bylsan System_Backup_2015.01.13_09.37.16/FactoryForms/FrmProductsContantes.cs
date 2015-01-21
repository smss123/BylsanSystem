using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Main_Store;
using System.Threading;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention ;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
namespace Bylsan_System.FactoryForms
{
    public partial class FrmProductsContantes : RadForm
    {
        public FrmProductsContantes()
        {
            InitializeComponent();
        }


        void PopulateCmb()
        {
        //    Operation.BeginOperation(this);
        //    var Lstproducts = ProductsCmd.GetAllProducts();
        //    var AllItems = ItemsCmd.GetAllItemsMaterial();

        //    this .Invoke (( MethodInvoker) delegate 
        //{
        //    Cmbproducts.Items.Clear();
        //    Cmbproducts.Items.AddRange((from p in Lstproducts.ToList() select p.Product_Name).Distinct().ToArray());
        //    CmbItems.Items.Clear();
        //    CmbItems .Items .AddRange (( from i in AllItems.ToList () select i .ItemName ).Distinct ().ToArray ());
        //});
        //    Operation.EndOperation(this);

            this.Cmbproducts.MultiColumnComboBoxElement.DropDownWidth = 550;
            this.CmbItems.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.Cmbproducts.AutoFilter = true;
                this.Cmbproducts.ValueMember = "ID";
                this.Cmbproducts.DisplayMember = "Product_Name";

                ///Item
                ///

                this.CmbItems.AutoFilter = true;
                this.CmbItems.ValueMember = "ID";
                this.CmbItems.DisplayMember = "ItemName";
            });

            var q = ProductsCmd.GetAllProducts();
            var q1 = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                CmbItems.DataSource = q1;
                Cmbproducts.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.Cmbproducts.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.Cmbproducts.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
                //FilterItme

                FilterDescriptor filter1 = new FilterDescriptor();
                filter1.PropertyName = this.CmbItems.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                this.CmbItems.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);




            });
            Operation.EndOperation(this);
        }
        private void FrmProductsContantes_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateCmb);
            th.Start();
            dataGridView1.DataSource = ls;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (Cmbproducts.SelectedValue == null)
            {
                Cmbproducts.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                Cmbproducts.Focus();
                errorProvider1.SetError(this.Cmbproducts, "Please Chose Product ");

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
                errorProvider1.SetError(this.CmbItems, "Please Chose Item ");

                return;
            }
            else
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            ///

            if (txtQty.Text == "")
            {

                txtQty.BackColor = Color.OrangeRed;

                txtQty.Focus();
                errorProvider1.SetError(this.txtQty, "Please Enter Qty");

                return;
            }
            else
            {
                txtQty.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion
            try
            {
                if (txtQty.Text != "" && itmID !=0 )
                {
                     float    availQty = 0;
                    var targetStore = StoreCmd .GetAvailableQtyByItemID (itmID );
                    availQty = targetStore.AvailableQty.Value;

                    if (Convert.ToDouble(txtQty.Text.ToString()) > availQty)
                    {
                        Operation.ShowToustOk("Quantity is not available", this);
                        txtQty.Text = "";
                        return;
                    }
                    Operation.BeginOperation(this);
                    //==================================================
                    // Start Save At ProductContents Table  :
                    ProductContent tb = new ProductContent() {
                    ProductID = prdid ,
                    ContentsProductID = itmID ,
                    Qty = int .Parse (txtQty .Text .ToString ()),
                    unitOfProduct = CmbUnits .Text 
                    
                    };
                    ProductContentsCmd.AddProductContents(tb);//z
                    //===================================================
                    //TargetStore.ItemID = itmID;
                    //TargetStore.AvailableQty -= (long)(txtQty.Text).ToFloat();
                    //TargetStore.Description = "Drawal";
                    //StoreCmd.EditStore(TargetStore);
                    
                    ////==============================================================
                   

                    Operation.EndOperation(this);
                    Operation.ShowToustOk("Saved ...", this);
                    broom();

                }
            }
            catch (Exception)
            {
                
              
            }
        }
        #region "  ^^^ Get IDes           "
        public int prdid { get; set; }
        private void Cmbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Lstproducts = ProductsCmd.GetAllProducts();

                prdid = 0;
                prdid = (from p in Lstproducts.ToList() select p.ID).Single();
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
                var AllItems = ItemsCmd.GetAllItemsMaterial();
                itmID = 0;
                itmID = (from i in AllItems.ToList() select i.ID).Single();

            }
            catch (Exception)
            {
                
                
            }
        }
        #endregion 

        void broom()
        {

            prdid = 0;
            itmID = 0;
            CmbItems.Text = null;
            Cmbproducts.Text = null;
            txtQty.Text = "";
            CmbUnits.Text = "";
            FrmProductsContantes_Load(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        List<ProductContent> ls = new List<ProductContent>();

        private void btnSveToGrd_Click(object sender, EventArgs e)
        {
            ProductContent p = new ProductContent() { 
            
             ContentsProductID = CmbItems.SelectedValue.ToString().ToInt(),
             unitOfProduct = CmbUnits.Text,
              ProductID = Cmbproducts.SelectedValue.ToString().ToInt()
            
            };
            p.Qty = long.Parse(txtQty.Text);
            ls.Add(p);
         

        }
    }
}
