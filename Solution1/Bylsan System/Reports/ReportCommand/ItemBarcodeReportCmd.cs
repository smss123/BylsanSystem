﻿using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;
namespace Bylsan_System.Reports.ReportCommand
{
    public class ItemBarcodeReportCmd
    {
        public void GetItemStorByDate()
        {


            var q = ProductsCmd.GetAllProducts(true);
            ReportDataSource rs = new ReportDataSource();
            List<ItemBarcodeReportObj> ls = new List<ItemBarcodeReportObj>();

            foreach (var item in q)
            {

                ls.Add(new ItemBarcodeReportObj()
                {
                    itemID = item.ID,
                    ItemName = item.PublicName,
                    ItemPrice = item.ProductPrice.ToString().Todouble()
                    // ExpirationDate 

                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepItemBarCod.rdlc";
            frm.ShowDialog();


        }
    }
}
