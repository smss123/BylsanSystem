using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Main_Store;
using Xprema.XExtention;

namespace Bylsan_System.MainStoreForms
{
    public partial class frmMainToBranchTranfer : RadForm
    {

        protected DbDataContext db = new DbDataContext();
        public frmMainToBranchTranfer()
        {
            InitializeComponent();
        }

        private void frmMainToBranchTranfer_Load(object sender, EventArgs e)
        {
            ProductCmb.DataSource = Operation.Allproducts;
            BranchCmb.DataSource = BranchsCmd.GetAllBranchs();
        }

        private void btnOky_Click(object sender, EventArgs e)
        {
            int proID = ProductCmb.SelectedValue.ToString().ToInt();
            int branchID = BranchCmb.SelectedValue.ToString().ToInt();
            try
            {
                var q = db.SellStores.Where(p => p.ItemID == proID && p.branchID == branchID).SingleOrDefault();
                var stor = db.Stores.Where(p => p.ProductID == proID).SingleOrDefault();
                stor.AvailableQty = long.Parse((stor.AvailableQty.ToString().Todouble() - Qty.Value.ToString().Todouble()).ToString());
                q.Qty = long.Parse((q.Qty.ToString().Todouble() + Qty.Value.ToString().Todouble()).ToString());
                db.SubmitChanges();
                RadMessageBox.Show("Done");
            }
            catch (Exception ex)
            {

              //  RadMessageBox.Show(ex.Message);
                RadMessageBox.ThemeName = this.ThemeName;
                RadMessageBox.Show("Oh, no Store to This Product in Branch , \n please let branch define store to this product");
            }
        }

        private void ProductCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Operation.BeginOperation(this);
                var pro = ProductCmb.SelectedValue.ToString().ToInt();
                var qq = Operation.Allproducts.Where(p => p.ID == pro).SingleOrDefault();
                txtProduct.Text = qq.Product_Name;
                var store = StoreCmd.GetAllStores().Where(p => p.ProductID == pro).SingleOrDefault();
                txtQty.Text = store.AvailableQty.ToString();
                Operation.EndOperation(this);
            }
            catch (Exception ex)
            {

                txtQty.Text = "";
                txtProduct.Text = "";
               // MessageBox.Show(ex.Message);
            }
            Operation.EndOperation(this);

        }
    }
}
