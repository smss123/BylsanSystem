﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
using Telerik.WinControls.Data;
using XamaDataLayer.BranchCmd;
using System.Threading;
using Xprema.XExtention;
namespace Bylsan_System.AccountsX
{
    public partial class FrmPrivatewithdrawals : Form
    {
        public FrmPrivatewithdrawals()
        {
            InitializeComponent();
           
            
        }
        Thread th;
        public void FillBrnchCombo()
        {
            var q = AccountsCmd.GetAllAccounts();

            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                CmbFromAccount.Items.Clear();
                CmbFromAccount.Items.AddRange((from b in q.ToList() select b.AccountName).Distinct().ToArray());

                CmbToAccount.Items.Clear();
                CmbToAccount.Items.AddRange((from b in q.ToList() select b.AccountName ).Distinct().ToArray());

            });

      
           
            Operation.EndOperation(this);

            th.Abort();
        }
        private void FrmPrivatewithdrawals_Load(object sender, EventArgs e)
        {
            th = new Thread(FillBrnchCombo); th.Start();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 &&  txtAmount.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public int? AcctID { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbFromAccount.Text == CmbToAccount.Text) { Operation.ShowToustOk("Transfer the amount from the same account unacceptable.", this); return; }
                if(Convert.ToDouble (txtAmount .Text .ToString ()) > Convert .ToDouble (lblAvailableAmount .Text .ToString ()))
                {
                    Operation.ShowToustOk("The amount is not available.", this);
                    return ;
                }

                // Start Save AT AccountDaily :
                AccountDaily tb = new AccountDaily() {
               AccountID = FromAccount_ID ,
                 DateOfProcess = DateTime .Now ,
                  TotalIn = 0f,
                  TotalOut = txtAmount .Text .Todouble (),
                     Description = txtDescription .Text .ToString ()
                };
                AccountDailyCmd.AddAccountDaily(tb);


                AccountDaily xtb = new AccountDaily()
                {
                     AccountID = ToAccount_ID ,
                    DateOfProcess = DateTime.Now,
                    TotalIn = txtAmount.Text.Todouble(),
                    TotalOut = 0f,
                    Description = txtDescription.Text.ToString()
                };
                AccountDailyCmd.AddAccountDaily(xtb);

                //================================================
             


            }
            catch (Exception)
            {
                
                
            }
        }
        public int FromAccount_ID { get; set; }
        public int ToAccount_ID { get; set; }
        private void CmbFromAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFromAccount.Text != "")
            {
                lblAvailableAmount.Text = "";
                FromAccount_ID = 0;
                var TargetAccount = AccountsCmd.GetOneAccountByName(CmbFromAccount.Text);
                FromAccount_ID = TargetAccount.ID;
                lblAvailableAmount.Text = AccountantWatcher.GetFreeBalance(TargetAccount .ID ).ToString ();

            }
        }
        private void CmbToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbToAccount.Text != "")
            {
                ToAccount_ID = 0;
                var TargetAccount = AccountsCmd.GetOneAccountByName(CmbToAccount .Text );
                ToAccount_ID = TargetAccount.ID;
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    

      

      

      
    }
}
