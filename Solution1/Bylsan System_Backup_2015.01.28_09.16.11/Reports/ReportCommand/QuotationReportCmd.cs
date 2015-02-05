using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.BranchCmd;
using XamaDataLayer;

namespace Bylsan_System.Reports.ReportCommand
{
    public  class QuotationReportCmd
    {
        public QuotationReportCmd()
        {
        }

        public void GetOrderProductsByOrderId(int XQuotationID)
        {
            var q = QuotationProductCmd.GetQuotationProductByQuotationID(XQuotationID);
            var rs = new ReportDataSource();
            var ls = new List<QuotationReportObj>();

            foreach (var item in q)
            {
                ls.Add(new QuotationReportObj()
                {
                    /// information Order And Customer
                 QuotationFor = item.Quotation.QuotationFor,
                 CreatedDate = item.Quotation.CreatedDate.Value,
                 PhoneNumber = item.Quotation.PhoneNumber,
                 AddressFor = item.Quotation.AddressFor,
                 ///
                 ProductPublicName = item.Product.PublicName,
                 ProductPrice = item.Product.ProductPrice.Value,
                 QuotationDescription = item.Description,
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepQuotation.rdlc";
            frm.ShowDialog();
        }

        public void GetOrderProductsByOrderId(Quotation q)
        {
            var rs = new ReportDataSource();
            var ls = new List<QuotationReportObj>();

            foreach (var item in q.QuotationProducts)
            {
                ls.Add(new QuotationReportObj()
                {
                    /// information Order And Customer
                    QuotationFor = item.Quotation.QuotationFor,
                    CreatedDate = item.Quotation.CreatedDate.Value,
                    PhoneNumber = item.Quotation.PhoneNumber,
                    AddressFor = item.Quotation.AddressFor,
                    ///
                    ProductPublicName = item.Product.PublicName,
                    ProductPrice = item.Product.ProductPrice.Value,
                    QuotationDescription = item.Description,
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepQuotation.rdlc";
            frm.ShowDialog();
        }
    }
}
