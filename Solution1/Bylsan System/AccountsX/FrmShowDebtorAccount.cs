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
    public partial class FrmShowDebtorAccount : RadForm
    {
        public FrmShowDebtorAccount()
        {
            InitializeComponent();
        }

        private void AddDebtBtn_Click(object sender, EventArgs e)
        {
            FrmAddDebt frm = new FrmAddDebt();
            frm.ShowDialog();
        }

        private void RepaydebBtn_Click(object sender, EventArgs e)
        {
            FrmRepaydebt frm = new FrmRepaydebt();
            frm.ShowDialog();

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmShowDebtorAccount_Load(null, null);
        }

        private void FrmShowDebtorAccount_Load(object sender, EventArgs e)
        {
            
        }
    }
}
