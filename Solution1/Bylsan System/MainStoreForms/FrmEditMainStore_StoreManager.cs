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
    public partial class FrmEditMainStore_StoreManager : RadForm
    {
        public FrmEditMainStore_StoreManager()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

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


            if (qtyInOrOutTextBox.Text == "")
            {

                qtyInOrOutTextBox.BackColor = Color.OrangeRed;

                qtyInOrOutTextBox.Focus();
                errorProvider1.SetError(this.qtyInOrOutTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyInOrOutTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }


            if (priceTextBox.Text == "")
            {

                priceTextBox.BackColor = Color.OrangeRed;

                priceTextBox.Focus();
                errorProvider1.SetError(this.priceTextBox, "Please Enter price");

                return;
            }
            else
            {
                priceTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }

        private void FrmEditMainStore_StoreManager_Load(object sender, EventArgs e)
        {

        }
    }
}
