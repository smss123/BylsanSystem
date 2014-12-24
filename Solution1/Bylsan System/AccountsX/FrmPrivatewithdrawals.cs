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
namespace Bylsan_System.AccountsX
{
    public partial class FrmPrivatewithdrawals : Form
    {
        public FrmPrivatewithdrawals()
        {
            InitializeComponent();
            lblAvailableAmount.Text = "";
            lblAvailableAmount.Text = Convert .ToDouble ( AccountantWatcher.GetFreeBalance()).ToString ();
            
        }

        private void FrmPrivatewithdrawals_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

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
                
                
                };
                AccountDailyCmd.AddAccountDaily(Adailytb);

                // Satrt Save At Debtors :
                Debtor dtb = new Debtor() {
                
                
                
                };
                DebtorsCmd.AddDebt(dtb);



            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
