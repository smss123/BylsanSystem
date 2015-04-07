using Bylsan_System.Reports.ReportsObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using XamaDataLayer;
namespace Bylsan_System.Reports.ReportCommand
{
    public class OrderPurchesesCmd
    {
        public void ShowReport(int id)
        {
            DbDataContext db = new DbDataContext();
            var q = db.ProductOrderPurchus.Where(p => p.OrderPurchusID == id).ToList();
            var rs = new ReportDataSource();
            var ls = new List<OrderPurchesesObj>();
            foreach (var item in q)
            {
                ls.Add(new OrderPurchesesObj() {
                 ID= item.OrderPurchusID.Value,
                  OrderDate = item.OrderPurch.OrderDate.Value,
                   Product = item.Product.Product_Name,
                    Qty = item.Qty,
                     Supplaier = item.OrderPurch.Supplier.SupplierName,
                      Unit = item.Unit



                
                });
            }
           
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.rptOrderPurcheses.rdlc";
            frm.ShowDialog();
        }
    }
}
