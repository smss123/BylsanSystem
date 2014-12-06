using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using XamaDataLayer;
using XamaDataLayer.SellSystem;
using Bylsan_System.SellSystemForms;
using System.Threading;

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

        }


        void EditStore()
        {
            Operation.BeginOperation(this);
            SellStore tb = new SellStore();

            this.Invoke((MethodInvoker)delegate
            {
          
                tb = new  SellStore 
                {
                    ItemID =  int .Parse (ItemComboBox .SelectedValue .ToString ()) , Qty  = int .Parse (qtyTextBox .Text ),  
                };
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
