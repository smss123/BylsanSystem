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
using XamaDataLayer.Main_Store;
using Xprema.XExtention ;
namespace Bylsan_System.FactoryForms
{
    public partial class FrmProductsContantes : Form
    {
        public FrmProductsContantes()
        {
            InitializeComponent();
        }


        void PopulateCmb()
        {
            Operation.BeginOperation(this);
            var Lstproducts = ProductsCmd.GetAllProducts();
            var AllItems = ItemsCmd.GetAllItemsMaterial();

            this .Invoke (( MethodInvoker) delegate 
        {
            Cmbproducts.Items.Clear();
            Cmbproducts.Items.AddRange((from p in Lstproducts.ToList() select p.Product_Name).Distinct().ToArray());
            CmbItems.Items.Clear();
            CmbItems .Items .AddRange (( from i in AllItems.ToList () select i .ItemName ).Distinct ().ToArray ());
        });
            Operation.EndOperation(this);
        }
        private void FrmProductsContantes_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateCmb);
            th.Start();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text != "" && itmID !=0 )
                {
                     float    AvailQty = 0;
                    var TargetStore = StoreCmd .GetAvailableQtyByItemID (itmID );
                    AvailQty = TargetStore.AvailableQty.Value;

                    if (Convert.ToDouble(txtQty.Text.ToString()) > AvailQty)
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
                    ProductContentsCmd.AddProductContents(tb);
                    //===================================================
                    TargetStore.ItemID = itmID;
                    TargetStore.AvailableQty -= (long)(txtQty.Text).ToFloat();
                    TargetStore.Description = "Drawal";
                    StoreCmd.EditStore(TargetStore);
                    
                    //==============================================================
                   

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
    }
}
