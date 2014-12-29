using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.Reports.ReportCommand
{
    public  class QuotationReportCmd
    {
        public QuotationReportCmd() { }
        //استخراج كافة فاتورة خاصة بناء على رقم الفاتورة
        public void GetOrderProductsByOrderId(int XQuotationID)
        {
            var q = QuotationProductCmd.GetQuotationProductByQuotationID(XQuotationID);
            ReportDataSource rs = new ReportDataSource();
            List<QuotationReportObj> ls = new List<QuotationReportObj>();

            foreach (var item in q)
            {

                ls.Add(new QuotationReportObj()
                {////////////
                    /// information Order And Customer
                 QuotationFor=item.Quotation.QuotationFor,
                 CreatedDate=item.Quotation.CreatedDate.Value,
                 PhoneNumber=item.Quotation.PhoneNumber,
                 AddressFor=item.Quotation.AddressFor,
                 ///
                 ProductPublicName=item.Product.PublicName,
                 ProductPrice=item.Product.ProductPrice.Value,
                 QuotationDescription=item.Description,






                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepOrderBill.rdlc";
            frm.ShowDialog();


        }

    }
}
