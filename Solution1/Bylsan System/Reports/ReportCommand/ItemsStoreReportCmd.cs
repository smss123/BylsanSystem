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
    public class ItemsStoreReportCmd
    {
        public ItemsStoreReportCmd() { }

        public void GetItemStorByDate()
        {


            var q = StoreCmd.GetAllStores();
            ReportDataSource rs = new ReportDataSource();
            List<ItemsStoreReportObj> ls = new List<ItemsStoreReportObj>();

            foreach (var item in q)
            {

                ls.Add(new ItemsStoreReportObj()
                {
                    StorId = item.ID,
                    itemName = item.Item.ItemName,
                    Description = item.Description,
                    AvailableQty = item.AvailableQty.Value,
                    // ExpirationDate 

                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepCustomerAccountOrders.rdlc";
            frm.ShowDialog();


        }










    }
}
