using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using XamaDataLayer.Accountant;
using Bylsan_System.Reports.ReportOption;
using Telerik.WinControls.UI;

namespace Bylsan_System.AccountsX
{
    public partial class FrmAccountTree : RadForm
    {
        public FrmAccountTree()
        {
            InitializeComponent();
        }
        private int Indx = 0;
        private void PopulateTreeAccounts()
        {
            Operation.BeginOperation(this);
            var acctCategories = AccountCategoryCmd.GetAll();


            this.Invoke((MethodInvoker)delegate
            {

                foreach (var item in acctCategories)
                {
                    TreeAccounts.Nodes[0].Nodes.Add(string.Empty, item.AccountCategoryName, 1);
                    var Accts = AccountsCmd .GetAccountByCategoryID (item .ID );
                    foreach (var Actitem in Accts)
                    {
                        TreeAccounts.Nodes[0].Nodes[Indx].Nodes.Add(string.Empty, Actitem.AccountName, 2);
                    }
                    Indx++;
                }
            });
            Operation.EndOperation(this);
        }

        private void FrmAccountTree_Load(object sender, EventArgs e)
        {
            TreeAccounts.Nodes.Clear();
            TreeAccounts.ImageList = imageList1;
            TreeAccounts.Nodes.Add("AbuEhab", "Accounts Categories", 0);
            var TreeThread = new Thread(PopulateTreeAccounts);
            TreeThread.Start();

            DGVAccountsDaily.Rows.Clear();
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.ExpandAll();
            Broom();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.CollapseAll();
            Broom();
        }




        public int AcctID { get; set; }

        private void TreeAccounts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeAccounts.Nodes.Count != 0)
            {
                Broom();
                var accts = AccountsCmd.GetAccountByName(e.Node.Text);
                foreach (var actitem in accts)
                {
                    AcctID = actitem.ID;
                    txtAccountName.Text = actitem.AccountName;
                    txtDescription.Text = actitem.Description;
                }

                var DGVThread = new Thread(GetAccountDetails);
                DGVThread.Start();
            }
        }
        private void GetAccountDetails()
        {
            Operation.BeginOperation(this);
            var getCurrentAccount = AccountDailyCmd .GetAllAccountDailyByAccountID(AcctID );
            this.Invoke((MethodInvoker)delegate
            {
                DGVAccountsDaily.DataSource = getCurrentAccount;
                var balance = AccountDailyCmd.GetBalanceByAccountID (AcctID );
                txtBalance.Text = balance.ToString();
            });
            Operation.EndOperation(this);
        }

        private void Broom()
        {
            txtDescription.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtBalance.Text = string.Empty;
            DGVAccountsDaily.Rows.Clear();
        }


        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmReportOptionBalanceSheet();
            frm.ShowDialog();
        }
    }
}
