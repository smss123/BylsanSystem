using System;
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
            var q = BranchsCmd.GetAllBranchs();

            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                CmbBranches.Items.Clear();
                CmbBranches.Items.AddRange((from b in q.ToList() select b.Branch_Name).Distinct().ToArray());

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

        }

        public int? AcctID { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble (txtAmount .Text .ToString ()) > Convert .ToDouble (lblAvailableAmount .Text .ToString ()))
                {
                    return ;
                }

                // Start Save AT AccountDaily :
                AccountDaily Adailytb = new AccountDaily() {
               // الحفظ في جدول اليومية بعد الخصم
                
                };
                AccountDailyCmd.AddAccountDaily(Adailytb);

                // Satrt Save At Debtors :
                Debtor dtb = new Debtor() {
                
               // تسجيل الدين على المدين
                // لكن ما قدرت أجيب رقم حساب الخزينه
                };
                DebtorsCmd.AddDebt(dtb);



            }
            catch (Exception)
            {
                
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbBranches.Text != "")
                {
                    AcctID = 0;
                   var q  = (from i in BranchsCmd.GetAllBranchs() 
                              where i.Branch_Name == CmbBranches.Text 
                              select i).Single();
                   AcctID = q.AccountID;
                   lblAvailableAmount.Text = "";
                   lblAvailableAmount.Text = Convert.ToDouble(AccountantWatcher.GetFreeBalance(AcctID )).ToString();
                }
            }
            catch (Exception)
            {
                
              
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
