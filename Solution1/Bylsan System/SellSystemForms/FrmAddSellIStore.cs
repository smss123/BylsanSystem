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

       
            try
            {
                Operation.BeginOperation(this);
                var ChekStore = SellStoreCmd.GetSellStoreByItemID(int.Parse(ItemComboBox.SelectedValue.ToString()));
                // Edit
                SellStore Oldtb = new SellStore()
                {
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text)
                };
                SellStoreCmd.EditQtyInSellStore(Oldtb, ChekStore.ID);
               

                WriteStore();
                Operation.ShowToustOk("Item Sell Qty Has Been Updated", this);
                Operation.EndOperation(this);

            }
            catch (Exception)
            {
                // Add New
                SellStore Newtb = new SellStore()
                {
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text),
                };
                SellStoreCmd.AddSellStore(Newtb);
                

                WriteStore();
                Operation.ShowToustOk("Item Sell  Has Been Saved", this);
                Operation.EndOperation(this);

            }

          
           
                
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
          
            Operation.EndOperation(this);
        }

        void WriteStore()
        {
            // Save At : StoreOperationManager
            var xSellStore = SellStoreCmd.GetSellStoreByItemID(int.Parse(ItemComboBox.SelectedValue.ToString()));
           StoreOperationManager OptrTb = new StoreOperationManager()
            {
                StoreID = xSellStore.ID,
                ProcessType = "Deposit", // أيداع
                ProcessDate = DateTime.Now,
                Qty =  int.Parse(qtyTextBox.Text),
                UserID = XamaDataLayer.Security.UserInfo.CurrentUserID
            };
            StoreOperationManagerCmd.AddStoreOperationManager(OptrTb);
            //=======================================================

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
