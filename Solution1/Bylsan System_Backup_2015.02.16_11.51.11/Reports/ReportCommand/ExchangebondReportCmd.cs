using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer;
using Xprema.XExtention;
namespace Bylsan_System.Reports.ReportCommand
{
    public  class ExchangebondReportCmd
    {
        public static void ShowPayment(string cost, DateTime Dt, string customerName,string vnumber, string payVouterCost, string rema)
        {

            var ls = new List<PaymentVoucherReportObj>();
            var rs = new ReportDataSource();

            PaymentVoucherReportObj p = new PaymentVoucherReportObj();
            p.Cost = cost.Todouble();
            p.Date = Dt.ToString();
            p.PaymentVoucherName = customerName;
            p.PaymentVoucherNumber = vnumber.ToInt();
            p.Remaining = rema.Todouble();

            ls.Add(p);

            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepExchangebond.rdlc";
            frm.ShowDialog();
        }
    }
}
