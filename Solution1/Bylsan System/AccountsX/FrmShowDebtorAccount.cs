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
using XamaDataLayer.Accountant;
using System.Threading;
namespace Bylsan_System.AccountsX
{
    public partial class FrmShowDebtorAccount : RadForm
    {
        public FrmShowDebtorAccount()
        {
            InitializeComponent();
        }
        public Debtor TargetDebtor { get; set; }

        void PopulateGrid()
        {
            int? AccID = TargetDebtor.AccountID;
            var lst = AccountDailyCmd.GetAllAccountDailyByAccountID( (int)( AccID ));
            this.Invoke((MethodInvoker)delegate { DGVDebtors.DataSource = lst; });


        }
        private void AddDebtBtn_Click(object sender, EventArgs e)
        {
          
            FrmAddDebt frm = new FrmAddDebt();
            frm.DebtorInfo = TargetDebtor;
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
            Thread th = new Thread(PopulateGrid); th.Start();
        }
    }
}
