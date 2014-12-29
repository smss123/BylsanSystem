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

namespace Bylsan_System.AccountsX
{
    public partial class FrmRepaydebt : RadForm
    {
        public FrmRepaydebt()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (PaymenttextBox.Text == "")
            {

                PaymenttextBox.BackColor = Color.OrangeRed;

                PaymenttextBox.Focus();
                errorProvider1.SetError(this.PaymenttextBox, "Please Enter Payment  ");

                return;
            }
            else
            {
                PaymenttextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }
    }
}
