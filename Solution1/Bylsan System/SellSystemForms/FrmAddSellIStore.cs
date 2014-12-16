using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.SellSystem;
using Bylsan_System.SellSystemForms;
using System.Threading;
namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSellIStore()
        {
            InitializeComponent();
        }
        public SellItem TargetItem { get; set; }

        private void FillItemsCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                this.ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                this.ItemComboBox.AutoFilter = true;
                this.ItemComboBox.DisplayMember = "ItemName";
                this.ItemComboBox.ValueMember = "ID";
            
            });

            var q = SellItemsCmd.GetAllSellItems();
            this.Invoke((MethodInvoker)delegate
            {

                ItemComboBox.DataSource = q;
                //ItemComboBox.SelectedValue = TargetItem.ID;
           
            });
            Operation.EndOperation(this);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (ItemComboBox.SelectedValue == null)
            {

                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                ItemComboBox.Focus();
                errorProvider1.SetError(this.ItemComboBox, "Please Enter Item");
                return;
            }
            else
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (qtyTextBox.Text == "")
            {

                qtyTextBox.BackColor = Color.OrangeRed;

                qtyTextBox.Focus();
                errorProvider1.SetError(this.qtyTextBox, "Please Enter Qty");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

            Operation.BeginOperation(this);

            //=====================================================================
            var ChekStore = SellStoreCmd.GetSellStoreByItemID(int.Parse(ItemComboBox.SelectedValue.ToString()));
            if (ChekStore[1].ID == 0) // New
            {
                SellStore tb = new SellStore()
                {
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text),
                };
                SellStoreCmd.AddSellStore(tb);
                Operation.ShowToustOk("Item Sell  Has Been Saved", this);
            }
            else // Edit
            {
                SellStore tb = new SellStore()
                {
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty =   int.Parse(qtyTextBox.Text) 
                };
                SellStoreCmd.EditQtyInSellStore (tb,ChekStore[1].ID);
                Operation.ShowToustOk("Item Sell Qty Has Been Updated", this);
            }
            //============================================================================
          
           
                
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
          
            Operation.EndOperation(this);
        }



        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmAddSellIStore_Load(object sender, EventArgs e)
        {
            Thread thr = new Thread(FillItemsCombo); thr.Start();
        }

    }
}
