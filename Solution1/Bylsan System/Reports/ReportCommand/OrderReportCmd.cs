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
    public class OrderReportCmd
    {

        /// <summary>
        /// /
        /// </summary>
        public OrderReportCmd() { }

        public void GetOrderProductsByOrderId(int XOrderID)
        {
            var q = OrderProductsCmd.GetAllByOrderID(XOrderID);
            ReportDataSource rs = new ReportDataSource();
            List<OrderReportObj> ls = new List<OrderReportObj>();

            foreach (var item in q)
            {

                ls.Add(new OrderReportObj()
                {////////////
                    /// information Order And Customer
                    OrderIdID = item.Order.ID,
                    CustomerName = item.Order.Customer.CustomerName,
                    CustomerPhoneNumber = item.Order.Customer.PhoneNumber,
                    OrderName = item.Order.OrderName,
                    OrderType = item.Order.OrderType,
                    OrderDate = item.Order.OrderDate.Value,
                    OrderDelivery = item.Order.OrderDelivery,
                    OrderVerify = item.Order.OrderVerify,
                    OrderDeliveryDate = item.Order.OrderDeliveryDate.Value,
                    OrderStatus = item.Order.OrderStatus,
                    TotalAmount = item.Order.TotalAmount.Value,
                    DeliverdToBranch = item.Order.DeliverdToBranch.Value,

                    ////informationOrderPrduct
                    ProductName = item.Product.Product_Name,
                    Qty = item.Qty.Value,
                    ProductPrice = item.Product.ProductPrice.Value,
                    PublicName = item.Product.PublicName,
                    OrderProductDescription = item.Description,
                    OrderProductStatus = item.Status,




                });
            }
            rs.Name = "";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.00000000.rdlc";
            frm.ShowDialog();


        }





    }
}
