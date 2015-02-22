using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

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
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}
