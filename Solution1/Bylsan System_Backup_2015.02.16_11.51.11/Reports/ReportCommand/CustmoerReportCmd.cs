using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.Reports.ReportCommand
{
    public class CustmoerReportCmd
    {

        /// <summary>
        /// //
        /// </summary>
        public CustmoerReportCmd()
        {
        }
        public void GetAllCoustmer()
        {
            var q = CustomersCmd.GetAllCustmers();
            var rs = new ReportDataSource();
            var ls = new List<CustomerReportObj>();

            foreach (var item in q)
            {
                ls.Add(new CustomerReportObj()
                {
                 CustomerID = item.ID,
                 CustomerName = item.CustomerName,
                 CreateDate = item.CreateDate.Value,
                 PhoneNumber = item.PhoneNumber,
                 Points = item.Points.Value,
                });
            }
            rs.Name = string.Empty;
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.00000000.rdlc";
            frm.ShowDialog();
        }
    }
}
