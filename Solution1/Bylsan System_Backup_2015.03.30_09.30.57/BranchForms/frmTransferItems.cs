using System;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Security;
using Xprema.XExtention;

namespace Bylsan_System.BranchForms
{
    public partial class frmTransferItems : RadForm
    {
        public frmTransferItems()
        {
            InitializeComponent();
        }

        private void frmTransferItems_Load(object sender, EventArgs e)
        {
            var q = BranchsCmd.GetAllBranchs();
            var x = BranchsCmd.GetAllBranchs();
            frombranch.DataSource = q;
            toBranch.DataSource = x;
            itemSelectedcombo.DataSource = Operation.Allproducts;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            try
            {
                BranchsCmd.TransferFromToBranch((Branch)new Branch() { ID = frombranch.SelectedValue.ToString().ToInt() },
               (Branch)new Branch() { ID = toBranch.SelectedValue.ToString().ToInt() }, (Product)new Product() { ID = itemSelectedcombo.SelectedValue.ToString().ToInt() }, qtyTextBox.Text.ToInt(), loginedUser: UserInfo.CurrnetUser.ID);
        
            }
            catch (Exception ex)
            {

                Operation.EndOperation(this);
                Operation.ShowToustOk(ex.Message, this);
                return;
            }
               Operation.EndOperation(this);
            Operation.ShowToustOk("Done", this);
        }

        private void itemSelectedcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var q = (Product)new Product() { ID = itemSelectedcombo.SelectedValue.ToString().ToInt() };
                lblItemName.Text = q.Product_Name;
                lblItemQty.Text = q.SellStores[0].Qty.ToString();

            }
            catch (Exception ex)
            {
                
            }
        }

        private void itemSelectedcombo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var q = (Product)new Product() { ID = itemSelectedcombo.SelectedValue.ToString().ToInt() };
                lblItemName.Text = q.Product_Name;
                lblItemQty.Text = q.SellStores[0].Qty.ToString();

            }
            catch (Exception ex)
            {

            }

        }

        private void itemSelectedcombo_DropDownClosed(object sender, RadPopupClosedEventArgs args)
        {
            try
            {
                var q = Operation.Allproducts.Where(p => p.ID == itemSelectedcombo.SelectedValue.ToString().ToInt()).Single();
                lblItemName.Text = q.Product_Name;
                lblItemQty.Text = q.SellStores[0].Qty.ToString();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
