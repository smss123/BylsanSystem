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
    public partial class FrmAddMainStore_Item : Form
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
        }
    }
}
