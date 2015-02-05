using System;
using System.Collections.Generic;
using System.Drawing;
using XamaDataLayer;
using XamaDataLayer.Accountant;

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
            if (txtDebtorName.Text == string.Empty)
            {
                txtDebtorName.BackColor = Color.OrangeRed;

                txtDebtorName.Focus();
                errorProvider1.SetError(txtDebtorName, "Please Enter account Debtor Name  ");

                return;
            }
            else
            {
                txtDebtorName.BackColor = Color.White;
                errorProvider1.Clear();
            }


            Operation.BeginOperation(this);
            var dtb = new Debtor() { DebtorName =  txtDebtorName .Text , Addresss = txtAddress .Text ,
                PhoneNumber = txtPhone .Text , DebtorDescription = txtDescription .Text };
            DebtorsCmd.AddDebt(dtb);
            Operation.EndOperation(this);
            Operation.ShowToustOk("Save successfull ..", this);
        }

        private void FrmAddDebtors_Load(object sender, EventArgs e)
        {
        }
    }
}
