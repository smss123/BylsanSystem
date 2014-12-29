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
using XamaDataLayer.BranchCmd;
using System.Threading;
namespace Bylsan_System.AccountsX
{
    public partial class FrmAddDebt : RadForm
    {
        public FrmAddDebt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void DebtorAmount()
        {

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddDebt_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(DebtorAmount); th.Start();
        }
    }
}
