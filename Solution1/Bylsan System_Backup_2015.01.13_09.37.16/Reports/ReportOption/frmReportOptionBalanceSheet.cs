using Bylsan_System.Reports.ReportCommand;
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

namespace Bylsan_System.Reports.ReportOption
{
    public partial class frmReportOptionBalanceSheet : RadForm
    {
        public frmReportOptionBalanceSheet()
        {
            InitializeComponent();
        }

        private void frmReportOptionBalanceSheet_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AllYearcheckBox.Checked)
            {
                AccountReportCmd cmd = new AccountReportCmd();
                cmd.GetBalanceSheet();
            }
            else
            {
                //--
            }
        }

        private void ShowReportForBetweenYear()
        {

        }
    }
}
