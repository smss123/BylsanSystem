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

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_Store : RadForm
    {
        public FrmEditMainStore_Store()
        {
            InitializeComponent();
        }

        private void FrmEditMainStore_Store_Load(object sender, EventArgs e)
        {

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
        }

        private void AvailableQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
