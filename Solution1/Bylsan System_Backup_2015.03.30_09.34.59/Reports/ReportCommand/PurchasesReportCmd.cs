using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.Reports.ReportCommand
{
    public class PurchasesReportCmd
    {
        public void GetByBetweenDate(DateTime from , DateTime to)
        {
            var q = PurchasesCmd.GetAll().Where(p=>p.dateOfProcess>= from&&p.dateOfProcess<=to).ToList();
            var rs = new ReportDataSource();
            var ls = new List<PurchasesObj>();

            foreach (var item in q)
            {
                ls.Add(new PurchasesObj()
                {
                     Amount = item.CostAmount.ToString(),
                      DateOfProcess=item.dateOfProcess.Value,
                       InvoiceNo= item.BillNumber,
                        PNo = item.ID,
                         SuplierName = item.Supplier.SupplierName,
                          ItemName = item.Product.Product_Name,
                           Qty = item.Qty.ToString()
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RptPurchases.rdlc";
            frm.ShowDialog();
        }
    }
}
