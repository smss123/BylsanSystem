using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Linq;
using XamaDataLayer;
using XamaDataLayer.SellSystem;

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
            if (itemNameTextBox.Text == string.Empty)
            {
                itemNameTextBox.BackColor = Color.OrangeRed;

                itemNameTextBox.Focus();
                errorProvider1.SetError(itemNameTextBox, "Please Enter Name");

                return;
            }
            else
            {
                itemNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (itemPriceTextBox.Text == string.Empty)
            {
                itemPriceTextBox.BackColor = Color.OrangeRed;

                itemPriceTextBox.Focus();
                errorProvider1.SetError(itemPriceTextBox, "Please Enter item Price");

                return;
            }
            else
            {
                itemPriceTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }






            try
            {
                Operation.BeginOperation(this);
                SellItemsCmd.GetSellItemByName(itemNameTextBox.Text);
                Operation.ShowToustOk("........Item Sell  Has Been Exist  .......", this);
                Operation.EndOperation(this);
                return;
            }
            catch (Exception)
            {
                var tb = new SellItem()
                { ItemName = itemNameTextBox.Text,
                    ItemIcon = pictureBox1.Image,
                    Description = descriptionTextBox.Text,
                    ItemPrice = int.Parse(itemPriceTextBox.Text), };

                SellItemsCmd.AddSellItems(tb);

                Operation.ShowToustOk("Item Sell  Has Been Saved", this);
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                    pictureBox1.Image = null;
                }
                Operation.EndOperation(this);
            }
        }





        private OpenFileDialog Op = new OpenFileDialog();
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                pictureBox1.Image = Image.FromFile(Op.FileName);
                this.Cursor = Cursors.Default;
            }
        }





        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void FrmAddSellItem_Load(object sender, EventArgs e)
        {
            DGVSellItems.DataSource = SellItemsCmd.GetAllSellItems();
        }
    }
}
