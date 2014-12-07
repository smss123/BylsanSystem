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
         if(   XamaDataLayer.Main_Store.ItemsCmd.AddNewItem(new XamaDataLayer.Item() { 
            
             ItemDescription = itemDescriptionTextBox.Text,
              ItemName= itemNameTextBox.Text,
               ItemType = ItemTypecomboBox.Text
            
            }))
            {
                Operation.ShowToustOk("Item Saved", this);
            }


         Operation.EndOperation(this);

        }

        private void FrmAddMainStore_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
