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
//==========================
namespace Bylsan_System.AccountsX
{
    public partial class FrmAccountTree : Form
    {
        public FrmAccountTree()
        {
            InitializeComponent();
        }
        int Indx = 0;
        void PopulateTreeAccounts()
        {
            Operation.BeginOperation(this);
            var AcctCategories = AccountCategoryCmd.GetAll();
            
        
            this.Invoke((MethodInvoker)delegate {

                foreach (var item in AcctCategories)
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
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.ExpandAll(); 
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.CollapseAll();
        }
    }
}
