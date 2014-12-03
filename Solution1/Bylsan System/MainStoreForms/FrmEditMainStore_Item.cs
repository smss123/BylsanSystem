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
            #region "  CheckFillTextBox "

            if (itemNameTextBox.Text == "")
            {

                itemNameTextBox.BackColor = Color.OrangeRed;

                itemNameTextBox.Focus();
                errorProvider1.SetError(this.itemNameTextBox, "Please Enter itemName name");

                return;
            }
            else
            {
                itemNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion

            Operation.BeginOperation(this);
           if( ItemsCmd.EditItem(new Item() {
             ItemName= itemNameTextBox.Text,
              ItemDescription= itemDescriptionTextBox.Text,
               ItemType = ItemTypecomboBox.Text
           }, this.TragetItem.ID))
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
            itemNameTextBox.Text = this.TragetItem.ItemName;
            itemDescriptionTextBox.Text = this.TragetItem.ItemDescription;
            ItemTypecomboBox.SelectedText = this.TragetItem.ItemType;
        }
    }
}
