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
    public partial class FrmAddMainStore_Store : RadForm
    {
        public FrmAddMainStore_Store()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            
            if (ItemColumnComboBox.SelectedValue == null)
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                
                ItemColumnComboBox.Focus();
                errorProvider1.SetError(this.ItemColumnComboBox, "Please Enter itemName name");
                
                return;
            }
            else
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
        
            #endregion
        }
        
        private void FrmAddMainStore_Store_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            var q = ItemsCmd.GetAllItems();
            ItemColumnComboBox.DataSource = q;
            Operation.EndOperation(this);
        }
    }
}