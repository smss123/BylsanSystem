using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Bylsan_System.Reports
{
    public partial class RebortView : Telerik.WinControls.UI.RadForm
    {
        public RebortView()
        {
            InitializeComponent();
        }

        private void RebortView_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
