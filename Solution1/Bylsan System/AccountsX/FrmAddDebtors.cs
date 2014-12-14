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
    public partial class FrmAddDebtors : Telerik.WinControls.UI.RadForm
    {
        public FrmAddDebtors()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            Debtor dtb = new Debtor() 
            {
                DebtorName =  txtDebtorName .Text , Addresss = txtAddress .Text ,
                PhoneNumber = txtPhone .Text , DebtorDescription = txtDescription .Text 
            };
            DebtorsCmd.AddDebt(dtb);
            Operation.EndOperation(this);
            Operation.ShowToustOk("Save successfull ..", this);
        }

        private void FrmAddDebtors_Load(object sender, EventArgs e)
        {

        }


    }
}
