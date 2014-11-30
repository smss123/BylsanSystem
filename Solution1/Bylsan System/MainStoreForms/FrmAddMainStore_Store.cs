using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_Store : Form
    {
        public FrmAddMainStore_Store()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (ItemColumnComboBox.SelectedValue==null)
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
    }
}
