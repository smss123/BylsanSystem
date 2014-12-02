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
    public partial class FrmAddSellItem : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSellItem()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "


            if (itemNameTextBox.Text == "")
            {

                itemNameTextBox.BackColor = Color.OrangeRed;

                itemNameTextBox.Focus();
                errorProvider1.SetError(this.itemNameTextBox, "Please Enter Name");

                return;
            }
            else
            {
                itemNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            //
            if (itemPriceTextBox.Text == "")
            {

                itemPriceTextBox.BackColor = Color.OrangeRed;

                itemPriceTextBox.Focus();
                errorProvider1.SetError(this.itemPriceTextBox, "Please Enter item Price");

                return;
            }
            else
            {
                itemPriceTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion
        }
    }
}
