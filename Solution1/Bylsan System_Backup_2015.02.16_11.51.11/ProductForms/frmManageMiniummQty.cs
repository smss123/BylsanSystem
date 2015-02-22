using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
namespace Bylsan_System.ProductForms
{
    public partial class frmManageMiniummQty : RadForm
    {
        public frmManageMiniummQty()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();
        private void frmManageMiniummQty_Load(object sender, EventArgs e)
        {
            
            var q = (GridViewComboBoxColumn)productMinimummQtyRadGridView.Columns[1];
            q.DataSource = db.Products;
            q.DisplayMember="Product_Name";
            q.ValueMember = "ID";
            productMinimummQtyBindingSource.DataSource = db.ProductMinimummQties;
        }

        private void productMinimummQtyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productMinimummQtyBindingSource.EndEdit();
            db.SubmitChanges();
            Operation.ShowToustOk("Saved", this);
        }
    }
}
