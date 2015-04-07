using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Security;
using XamaDataLayer.SellSystem;
using Xprema.XExtention;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSellIStore()
        {
            InitializeComponent();
        }
        public Product TargetItem { get; set; }

        private void FillItemsCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                ItemComboBox.AutoFilter = true;
                //ItemComboBox.DisplayMember = "ItemName";
                //ItemComboBox.ValueMember = "ID";
            });

           // var q = Operation.GetAllSellItems();
            var q = Operation.Allproducts;
            this.Invoke((MethodInvoker)delegate
            {

                ItemComboBox.DataSource = q;// q;
            });
            Operation.EndOperation(this);
        }
        private void AddBtn_Click(object sender, EventArgs e)
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



            try
            {
                Operation.BeginOperation(this);
                var chekStore = SellStoreCmd.GetSellStoreByItemID(int.Parse(ItemComboBox.SelectedValue.ToString()), UserInfo.CurrnetUser.Branch_ID.ToString().ToInt());
                var oldtb = new SellStore()
                { 
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text),
                    branchID = UserInfo.CurrnetUser .Branch_ID };
                SellStoreCmd.EditQtyInSellStore(oldtb, chekStore.ID, UserInfo.CurrnetUser.Branch_ID.Value);


                WriteStore();
                Operation.ShowToustOk("Item Sell Qty Has Been Updated", this);
                Operation.EndOperation(this);
            }
            catch (Exception)
            {
                var Newtb = new SellStore()
                { ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text),
                    branchID = UserInfo.CurrnetUser.Branch_ID };
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

        private void WriteStore()
        {
            //int.Parse(ItemComboBox.SelectedValue.ToString()), UserInfo.CurrnetUser.Branch_ID.ToString().ToInt()
            var xSellStore = SellStoreCmd.GetSellStoreByItemID(int.Parse(ItemComboBox.SelectedValue.ToString()), UserInfo.CurrnetUser.Branch_ID.ToString().ToInt());
            var OptrTb = new StoreOperationManager()
            { 
                StoreID = xSellStore.ID,
                ProcessType = "Deposit",
                ProcessDate = DateTime.Now,
                Qty =  int.Parse(qtyTextBox.Text),
                UserID = XamaDataLayer.Security.UserInfo.CurrnetUser.ID.ToString().ToInt()
            };
            StoreOperationManagerCmd.AddStoreOperationManager(OptrTb);
        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmAddSellIStore_Load(object sender, EventArgs e)
        {
            var thr = new Thread(FillItemsCombo);
            thr.Start();
        }
    }
}
