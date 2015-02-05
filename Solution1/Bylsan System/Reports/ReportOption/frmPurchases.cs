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
    public partial class frmPurchases : RadForm
    {
        public frmPurchases()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            PurchasesReportCmd cmd = new PurchasesReportCmd();
            cmd.GetByBetweenDate(dtFrom.Value, dtTo.Value);
        }

        private void frmPurchases_Load(object sender, EventArgs e)
        {

        }
    }
}
