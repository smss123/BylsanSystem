using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.SellSystem;
using Bylsan_System.SellSystemForms;
using System.Threading;
namespace Bylsan_System.SellSystemForms
{
    public partial class FrmEditSellItem : RadForm
    {
        public FrmEditSellItem()
        {
            InitializeComponent();
        }

        public SellItem  TargetItem { get; set; }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "


            if (SellItemBox.Text == "")
            {

                SellItemBox.BackColor = Color.OrangeRed;

                SellItemBox.Focus();
                errorProvider1.SetError(this.SellItemBox, "Please Enter Name");

                return;
            }
            else
            {
                SellItemBox.BackColor = Color.White;
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

      

                Thread th = new Thread(EditSellItem );
                th.Start();
          
        }


        void EditSellItem()
        {
            Operation.BeginOperation(this);
            SellItem tb = new SellItem();

            this.Invoke((MethodInvoker)delegate
            {
                lblstatus.Text = "Editing...";
                tb = new  SellItem 
                {
                   ItemName = SellItemBox .Text ,
                   Description = descriptionTextBox .Text ,
                   ItemPrice =  int .Parse (itemPriceTextBox .Text) ,
                   ItemIcon = pictureBox1 .Image ,
                };

            });


           SellItemsCmd .EditSellItem (tb, TargetItem.ID  );
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                Operation.ShowToustOk("Sell Item  Has Been Edited..", this);

                this.lblstatus.Text = "Complete Edited ..";

            });
            
        }

        #region "  ^^^ Item Price _ KeyPress     "
        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void FrmEditSellItem_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);


            SellItemBox.Text = TargetItem.ItemName;
            itemPriceTextBox.Text =  TargetItem.ItemPrice.ToString () ;
            descriptionTextBox.Text = TargetItem.Description;
            pictureBox1.Image = TargetItem.ItemIcon;

            Operation.EndOperation(this);

        }
    }
}
