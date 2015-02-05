using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_Item : RadForm
    {
        public FrmEditMainStore_Item()
        {
            InitializeComponent();
        }
        public Item TragetItem { get; set; }

        private void SaveBtn_Click(object sender, EventArgs e)
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
            if ( ItemsCmd.EditItem(new Item() {
             ItemName = itemNameTextBox.Text,
              ItemDescription = itemDescriptionTextBox.Text,
               ItemType = ItemTypecomboBox.Text
            }, TragetItem.ID))
            {
                Operation.ShowToustOk("Item Has Been Saved..", this);
            }
            itemNameTextBox.Clear();
            itemDescriptionTextBox.Clear();
            ItemTypecomboBox.SelectedIndex = -1;
            Operation.EndOperation(this);
        }

        private void FrmEditMainStore_Item_Load(object sender, EventArgs e)
        {
            itemNameTextBox.Text = TragetItem.ItemName;
            itemDescriptionTextBox.Text = TragetItem.ItemDescription;
            ItemTypecomboBox.SelectedText = TragetItem.ItemType;
        }
    }
}
