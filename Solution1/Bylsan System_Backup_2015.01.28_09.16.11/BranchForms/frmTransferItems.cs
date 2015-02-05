using System;
using System.Linq;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

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
            frombranch.DataSource = q;
            toBranch.DataSource = q;
            itemSelectedcombo.DataSource = ProductsCmd.GetAllProducts();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BranchsCmd.TransferFromToBranch((Branch)new Branch() { ID = frombranch.SelectedValue.ToString().ToInt() },
                (Branch)new Branch() { ID = toBranch.SelectedValue.ToString().ToInt() }, (Product)new Product() { ID = itemSelectedcombo.SelectedValue.ToString().ToInt() }, 1, 1);
        }
    }
}
