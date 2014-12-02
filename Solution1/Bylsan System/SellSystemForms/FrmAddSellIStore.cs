using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSellIStore : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSellIStore()
        {
            InitializeComponent();
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
        }
    }
}
