using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
namespace Bylsan_System
{
    public partial class frmShowHistory : RadForm
    {
        public frmShowHistory()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();
        private void frmShowHistory_Load(object sender, EventArgs e)
        {
            historyBindingSource.DataSource =  db.Histories;
        }
    }
}
