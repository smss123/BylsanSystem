using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using XamaDataLayer;
using XamaDataLayer.SellSystem;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmEditSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmEditSellIStore()
        {
            InitializeComponent();
        }





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
        }


        private void EditStore()
        {
            Operation.BeginOperation(this);
            var tb = new SellStore();

            this.Invoke((MethodInvoker)delegate
            {
                tb = new  SellStore {
                    ItemID =  int .Parse (ItemComboBox .SelectedValue .ToString ()) , Qty  = int .Parse (qtyTextBox .Text ), };
                SellStoreCmd.EditSellStore(tb, TargetStore.ID);

            });


            SellStoreCmd.EditSellStore(tb, TargetStore.ID);
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                Operation.ShowToustOk("Sell Store  Has Been Edited..", this);


            });
        }

        private void FrmEditSellIStore_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            qtyTextBox.Text = TargetStore.Qty.ToString ();
            ItemComboBox.Text = TargetStore.ItemID.ToString();

            Operation.EndOperation(this);
        }
    }
}
