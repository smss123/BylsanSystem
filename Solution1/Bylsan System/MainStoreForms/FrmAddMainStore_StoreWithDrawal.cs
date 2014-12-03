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
    public partial class FrmAddMainStore_StoreWithDrawal : RadForm
    {
        public FrmAddMainStore_StoreWithDrawal()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (ItemComboBox.SelectedValue == null)
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                ItemComboBox.Focus();
                errorProvider1.SetError(this.ItemComboBox, "Please Enter Item ");

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
                errorProvider1.SetError(this.qtyTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }


            if (StoreComboBox.SelectedValue == null)
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                StoreComboBox.Focus();
                errorProvider1.SetError(this.StoreComboBox, "Please Enter Store ");

                return;
            }
            else
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();

            }


 


            #endregion
        }

        private void FrmAddMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {

        }
    }
}
