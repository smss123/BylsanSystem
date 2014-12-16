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
namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSellItem : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSellItem()
        {
            InitializeComponent();
        }

        #region "    ^^^ Save Process  "
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

            

      

            try
            {
                Operation.BeginOperation(this);
                var ChkItemByItName = SellItemsCmd.GetSellItemByName(itemNameTextBox.Text);
                 Operation.ShowToustOk("........Item Sell  Has Been Exist  .......", this);
                 Operation.EndOperation(this);
                 return;
            }
            catch (Exception)
            {
                
                SellItem tb = new SellItem()
                {
                    ItemName = itemNameTextBox.Text,
                    ItemIcon = pictureBox1.Image,
                    Description = descriptionTextBox.Text,
                    ItemPrice = int.Parse(itemPriceTextBox.Text),
                };

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

        #endregion 

        #region "    ^^^ Brwose Photo    "

        OpenFileDialog Op = new OpenFileDialog();
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


        #endregion

        #region "  ^^^ Item Price _ KeyPress     "
        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
    }
}
