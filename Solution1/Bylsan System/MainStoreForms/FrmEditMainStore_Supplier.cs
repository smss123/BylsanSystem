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

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_Supplier : RadForm
    {
        public FrmEditMainStore_Supplier()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "


            if (supplierNameTextBox.Text == "")
            {

                supplierNameTextBox.BackColor = Color.OrangeRed;

                supplierNameTextBox.Focus();
                errorProvider1.SetError(this.supplierNameTextBox, "Please Enter Name");

                return;
            }
            else
            {
                supplierNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }

        private void FrmEditMainStore_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
