using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using Bylsan_System.Reports.ReportsObject;

namespace Bylsan_System.Reports.ReportCommand
{
    public class BillReportCommand
    {
        
        //استخراج كافة فاتورة خاصة بناء على رقم الفاتورة
        public void PrintBill(List<RptBillObj> bill)
        {
            
            ReportDataSource rs = new ReportDataSource();
            List<RptBillObj> ls = new List<RptBillObj>();
            ls.AddRange(bill);
            //foreach (var item in q)
            //{

            //    ls.Add(new OrderReportObj()
            //    {////////////
            //        /// information Order And Customer
            //        OrderIdID = item.Order.ID,
            //        CustomerName = item.Order.Customer.CustomerName,
            //        CustomerPhoneNumber = item.Order.Customer.PhoneNumber,
            //        OrderName = item.Order.OrderName,
            //        OrderType = item.Order.OrderType,
            //        OrderDate = item.Order.OrderDate.Value,
            //        OrderDelivery = item.Order.OrderDelivery,
            //        OrderVerify = item.Order.OrderVerify,
            //        OrderDeliveryDate = item.Order.OrderDeliveryDate.Value,
            //        OrderStatus = item.Order.OrderStatus,
            //        TotalAmount = item.Order.TotalAmount.Value,
            //        DeliverdToBranch = item.Order.DeliverdToBranch.Value,

            //        ////informationOrderPrduct
            //        ProductName = item.Product.Product_Name,
            //        Qty = item.Qty.Value,
            //        ProductPrice = item.Product.ProductPrice.Value,
            //        PublicName = item.Product.PublicName,
            //        OrderProductDescription = item.Description,
            //        OrderProductStatus = item.Status,




            //    });
            //}
            rs.Name = "DataSet1";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepBillPrint.rdlc";
            frm.ShowDialog();


        }
    }
}
