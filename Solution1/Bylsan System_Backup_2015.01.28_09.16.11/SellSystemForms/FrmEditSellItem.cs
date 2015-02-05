using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.SellSystem;
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
            if (SellItemBox.Text == string.Empty)
            {
                SellItemBox.BackColor = Color.OrangeRed;

                SellItemBox.Focus();
                errorProvider1.SetError(SellItemBox, "Please Enter Name");

                return;
            }
            else
            {
                SellItemBox.BackColor = Color.White;
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




            var th = new Thread(EditSellItem );
            th.Start();
        }


        private void EditSellItem()
        {
            Operation.BeginOperation(this);
            var tb = new SellItem();

            this.Invoke((MethodInvoker)delegate
            {
                lblstatus.Text = "Editing...";
                tb = new  SellItem {
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

                lblstatus.Text = "Complete Edited ..";

            });
        }


        private void itemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
