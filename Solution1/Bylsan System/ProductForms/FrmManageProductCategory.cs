using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ProductForms
{
    public partial class FrmManageProductCategory : RadForm
    {
        public FrmManageProductCategory()
        {
            InitializeComponent();
            radGridView1.CommandCellClick += radGridView1_CommandCellClick;
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;

            if (col == 3)
            {
                var frm = new FrmEditProductCategory();
                frm.TragetCategory = (ProductCategory)radGridView1.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadCategory();
            }
            if (col==4)
            {
                if (RadMessageBox.Show("You Are sure?","delete",MessageBoxButtons.YesNo,RadMessageIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                {
                    var TragetCategory = (ProductCategory)radGridView1.CurrentRow.DataBoundItem;
                    CategoriesCmd.DeleteCategory(TragetCategory.ID);
                    Operation.ShowToustOk("deleted ..", this);
                    LoadCategory();
                }
                   
            }
        }

        private void FrmManageProductCategory_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadCategory);
            th.Start();
        }

        private void LoadCategory()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading ....";
            });
            Operation.BeginOperation(this);
            var q =  CategoriesCmd.GetAllCategories();
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                radGridView1.DataSource = q;
                toolStrip1.Text = "Complete ....";

            });
        }
    }
}
