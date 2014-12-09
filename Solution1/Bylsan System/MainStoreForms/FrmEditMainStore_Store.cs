using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_Store : RadForm
    {
        public FrmEditMainStore_Store()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        public int XStorId { get; set; }
        public Store treagtStore { get; set; }
        private void FillComboBoxItme()
        {

            this.ItemColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.ItemColumnComboBox.AutoFilter = true;
                this.ItemColumnComboBox.ValueMember = "ID";
                this.ItemColumnComboBox.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                ItemColumnComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.ItemColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.ItemColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void FrmEditMainStore_Store_Load(object sender, EventArgs e)
        {
            FillComboBoxItme();
            XStorId = treagtStore.ID;
            ItemColumnComboBox.Text = treagtStore.Item.ItemName;
            AvailableQtyTextBox.Text = treagtStore.AvailableQty.ToString();
            DescriptiontextBox.Text = treagtStore.Description;

   
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (ItemColumnComboBox.SelectedValue == null)
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                ItemColumnComboBox.Focus();
                errorProvider1.SetError(this.ItemColumnComboBox, "Please Enter itemName name");

                return;
            }
            else
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (AvailableQtyTextBox.Text == "")
            {

                AvailableQtyTextBox.BackColor = Color.OrangeRed;

                AvailableQtyTextBox.Focus();
                errorProvider1.SetError(this.AvailableQtyTextBox, "Please Enter Qty");

                return;
            }
            else
            {
                AvailableQtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion


            Operation.BeginOperation(this);

            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Store tb = new Store
                {
                    ID = XStorId,
                    ItemID = int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                    AvailableQty = int.Parse(AvailableQtyTextBox.Text),
                    Description = DescriptiontextBox.Text


                };
                StoreCmd.EditStore(tb);

                Operation.ShowToustOk("Store Saved", this);

                Operation.EndOperation(this);


            }
        }
        private void AvailableQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
