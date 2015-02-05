using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_Item : RadForm
    {
        public FrmAddMainStore_Item()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (itemNameTextBox.Text == string.Empty)
            {
                itemNameTextBox.BackColor = Color.OrangeRed;

                itemNameTextBox.Focus();
                errorProvider1.SetError(itemNameTextBox, "Please Enter itemName name");

                return;
            }
            else
            {
                itemNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }



            Operation.BeginOperation(this);
            try
            {
                ItemsCmd.ChekByName(itemDescriptionTextBox.Text);
                Operation.ShowToustOk("Item Existed .... ", this);
                Operation.EndOperation(this);
                return;
            }
            catch (Exception)
            {
                if (ItemsCmd.AddNewItem(new XamaDataLayer.Item()
                {

                    ItemDescription = itemDescriptionTextBox.Text,
                    ItemName = itemNameTextBox.Text,
                    ItemType = ItemTypecomboBox.Text

                }))
                {
                    Operation.ShowToustOk("Item Saved", this);
                }
                Operation.EndOperation(this);
            }


            Operation.EndOperation(this);
        }

        private void FrmAddMainStore_Item_Load(object sender, EventArgs e)
        {
        }
    }
}
