using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;
using Bylsan_System.Reports.ReportsObject;

namespace Bylsan_System.Reports.ReportCommand
{
    public class BillReportCommand
    {
        public void PrintBill(List<RptBillObj> bill)
        {
            var rs = new ReportDataSource();
            var ls = new List<RptBillObj>();
            ls.AddRange(bill);
































            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepBillPrint.rdlc";
            frm.ShowDialog();
        }
    }
}
