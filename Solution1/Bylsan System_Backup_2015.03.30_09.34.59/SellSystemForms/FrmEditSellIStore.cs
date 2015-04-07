using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Security;
using XamaDataLayer.SellSystem;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmEditSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmEditSellIStore()
        {
            InitializeComponent();
        }


          Thread th;


        public  SellStore TargetStore   { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedValue == null)
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                ItemComboBox.Focus();
                errorProvider1.SetError(ItemComboBox, "Please Enter Item");
                return;
            }
            else
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (qtyTextBox.Text == string.Empty)
            {
                qtyTextBox.BackColor = Color.OrangeRed;

                qtyTextBox.Focus();
                errorProvider1.SetError(qtyTextBox, "Please Enter Qty");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (RadMessageBox.Show(this, "Do you want to save", "Save", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);


                SellStore tb = new SellStore()
                {
                    ID=TargetStore.ID,
                    ItemID=int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty=int.Parse(qtyTextBox.Text),
                };
                SellStoreCmd.EditSellStore(tb);
                Operation.EndOperation(this);
                RadMessageBox.Show("Save Done", "Done", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }
      
        private void LoodStore()
        {
            Operation.BeginOperation(this);
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 1000;

                this.ItemComboBox.AutoFilter = true;
                this.ItemComboBox.ValueMember = "ID";
                this.ItemComboBox.DisplayMember = "Product_Name";
            });
            var q = ProductsCmd.GetAllProducts();
            this.Invoke((MethodInvoker)delegate
            {
                ItemComboBox.DataSource = q;
                this.ItemComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor ProName = new FilterDescriptor("Product_Name", FilterOperator.Contains, "");
                 compositeFilter.FilterDescriptors.Add(ProName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.ItemComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);
                //
                qtyTextBox.Text = TargetStore.Qty.ToString();
                ItemComboBox.Text = TargetStore.Product.Product_Name;
            });
            Operation.EndOperation(this);

            th.Abort();
        }

        private void FrmEditSellIStore_Load(object sender, EventArgs e)
        {
            th = new Thread(LoodStore);
            th.Start();
           
        }
    }
}
