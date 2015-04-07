using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;

namespace Bylsan_System.Reports.ReportCommand
{
    public class ItemBarcodeReportCmd
    {
        public void GetItemStorByDate(int id, int counter, DateTime dt)
        {
            var q = ProductsCmd.GetProductByID(id);
            var rs = new ReportDataSource();
            var ls = new List<ItemBarcodeReportObj>();

            for (int i = 0; i <= counter; i++)
            {
                foreach (var item in q)
                {
                    ls.Add(new ItemBarcodeReportObj()
                    {
                        itemID = item.ID,
                        ItemName = item.PublicName,
                        ItemPrice = item.ProductPrice.ToString().Todouble(),
                         ExpriedDate = dt.ToShortDateString()
                    });
                }
            }
            
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepItemBarCod.rdlc";
            frm.ShowDialog();
        }
    }
}
