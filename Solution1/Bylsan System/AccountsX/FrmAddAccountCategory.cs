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
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
//==========================


namespace Bylsan_System.AccountsX
{
    public partial class FrmAddAccountCategory : RadForm
    {
        public FrmAddAccountCategory()
        {
            InitializeComponent();
        }

      
        private void FrmAddAccountCategory_Load(object sender, EventArgs e)
        {
            txtAccountName.Text = ""; txtDescriptionBox.Text = "";
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Operation.BeginOperation(this);
                AccountCategory tb = new AccountCategory() 
                { AccountCategoryName = txtAccountBox .Text , Description = txtDescriptionBox.Text  };
                AccountCategoryCmd.AddAccountCategory(tb);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Account Was Created", this);
            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
