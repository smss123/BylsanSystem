using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//===========================
using System.Threading;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
using Bylsan_System.Reports.ReportOption;
//==========================
namespace Bylsan_System.AccountsX
{
    public partial class FrmAccountTree : RadForm
    {
        public FrmAccountTree()
        {
            InitializeComponent();
        }
        int Indx = 0;
        void PopulateTreeAccounts()
        {
            Operation.BeginOperation(this);
            var acctCategories = AccountCategoryCmd.GetAll();
            
        
            this.Invoke((MethodInvoker)delegate {

                foreach (var item in acctCategories)
                {
                    
                    TreeAccounts.Nodes[0].Nodes.Add("" ,item.AccountCategoryName, 1);
                    var Accts = AccountsCmd .GetAccountByCategoryID (item .ID );
                    foreach (var Actitem in Accts)
                    {
                        TreeAccounts.Nodes[0].Nodes[Indx].Nodes.Add("", Actitem.AccountName, 2);
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
            Thread TreeThread = new Thread(PopulateTreeAccounts); 
            TreeThread.Start();
            //===============================
            DGVAccountsDaily.Rows.Clear();
        }
        #region "     Tree Controler      "
        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.ExpandAll();
            Broom();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.CollapseAll(); Broom();

        }
        #endregion 


        #region "  ^^^  Get Account Details        "
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
            
                Thread DGVThread = new Thread(GetAccountDetails);
                DGVThread.Start();
            }
        }
        void GetAccountDetails()
        {
            Operation.BeginOperation(this);
            var getCurrentAccount = AccountDailyCmd .GetAllAccountDailyByAccountID(AcctID );
            this.Invoke((MethodInvoker)delegate {
                DGVAccountsDaily.DataSource = getCurrentAccount;
               double balance = AccountDailyCmd.GetBalanceByAccountID (AcctID );
               txtBalance.Text = balance.ToString();
            });
            Operation.EndOperation(this);
        }

        void Broom() { txtDescription.Text = ""; txtAccountName.Text = ""; txtBalance.Text = ""; DGVAccountsDaily.Rows.Clear(); }
        #endregion 

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportOptionBalanceSheet frm = new frmReportOptionBalanceSheet();
            frm.ShowDialog();
        }

      

       


    }
}
