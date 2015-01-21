using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
//===========================
using System.Threading;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
//==========================
namespace Bylsan_System.AccountsX
{
    public partial class frmAccountDailySHow : Telerik.WinControls.UI.RadForm
    {
        public frmAccountDailySHow()
        {
            InitializeComponent();
        }
        void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountDailyCmd.GetAllDaily();
            this.Invoke((MethodInvoker)delegate { DGVAccountsDaily.DataSource = q; });
            Operation.EndOperation(this);
        }
        private void frmAccountDailySHow_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateGrid );
            th.Start();
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            FrmPrivatewithdrawals frm= new FrmPrivatewithdrawals();
            frm.ShowDialog();
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmAccountDailySHow_Load(null, null);
        }


    }
}
