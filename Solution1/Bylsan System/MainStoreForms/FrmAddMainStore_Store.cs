using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_Store : RadForm
    {
        public FrmAddMainStore_Store()
        {
            InitializeComponent();
        }
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
        private void Addbtn_Click(object sender, EventArgs e)
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
          

            Store tb=new Store
            {
                ItemID=int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                AvailableQty=int.Parse(AvailableQtyTextBox.Text),
                Description = DescriptiontextBox.Text
               

            };
            StoreCmd.AddNewStore(tb);

            Operation.ShowToustOk("Item Saved", this);
            ItemColumnComboBox.ResetText();
            AvailableQtyTextBox.Clear();
            DescriptiontextBox.Clear();
            ItemColumnComboBox.Focus();
            Operation.EndOperation(this);
          
        }

        private void FrmAddMainStore_Store_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillComboBoxItme);
            th.Start();
        }
        private void AvailableQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}