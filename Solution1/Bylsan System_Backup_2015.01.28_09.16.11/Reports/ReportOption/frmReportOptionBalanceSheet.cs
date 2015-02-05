using Bylsan_System.Reports.ReportCommand;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var cmd = new AccountReportCmd();
                cmd.GetBalanceSheet();
            }
            else
            {
            }
        }

        private void ShowReportForBetweenYear()
        {
        }
    }
}
