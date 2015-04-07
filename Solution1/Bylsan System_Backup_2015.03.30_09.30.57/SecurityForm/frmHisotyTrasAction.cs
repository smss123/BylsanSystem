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
namespace Bylsan_System.SecurityForm
{
    public partial class frmHisotyTrasAction : RadForm
    {
        public frmHisotyTrasAction()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();
        private void frmHisotyTrasAction_Load(object sender, EventArgs e)
        {
            historyBindingSource.DataSource = db.Histories.ToList();
        }
    }
}
