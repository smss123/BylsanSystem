using System;
using System.Collections.Generic;
using System.Linq;
using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;

namespace Bylsan_System.Reports.ReportCommand
{
    public class OrderReportCmd
    {

        /// <summary>
        /// /
        /// </summary>
        public OrderReportCmd()
        {
        }

        public void GetOrderProductsByOrderId(int XOrderID)
        {
            var q = OrderProductsCmd.GetAllByOrderID(XOrderID);
            var rs = new ReportDataSource();
            var ls = new List<OrderReportObj>();

            foreach (var item in q)
            {
                ls.Add(new OrderReportObj()
                {
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
                    DeliverdToBranch = item.Order.DeliverdToBranch.ToString(),


                    ProductName = item.Product.Product_Name,
                    Qty = item.Qty.Value,
                    ProductPrice = item.Product.ProductPrice.Value,
                    PublicName = item.Product.PublicName,
                    OrderProductDescription = item.Description,
                    OrderProductStatus = item.Status,




                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepOrderFollow.rdlc";
            frm.ShowDialog();
        }


        public void GetOrderProductsCustomerPhone(string phone)
        {
            var q = OrderProductsCmd.GetOrderProductByCustomerPhone(phone);
            var rs = new ReportDataSource();
            var ls = new List<OrderReportObj>();

            foreach (var item in q)
            {
                ls.Add(new OrderReportObj()
                {
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
                    DeliverdToBranch = item.Order.DeliverdToBranch.ToString(),


                    ProductName = item.Product.Product_Name,
                    Qty = item.Qty.Value,
                    ProductPrice = item.Product.ProductPrice.Value,
                    PublicName = item.Product.PublicName,
                    OrderProductDescription = item.Description,
                    OrderProductStatus = item.Status,




                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepOrderFollow.rdlc";
            frm.ShowDialog();
        }



        public void GetOrderCustomer(string Phone)
        {
            var q = OrdersCmd.GetOrdersByCustomerPhone(Phone);
            var rs = new ReportDataSource();
            var ls = new List<OrderReportObj>();

            foreach (var item in q)
            {
                ls.Add(new OrderReportObj()
                {
                    OrderIdID = item.ID,
                    CustomerName = item.Customer.CustomerName,
                    CustomerPhoneNumber = item.Customer.PhoneNumber,
                    OrderName = item.OrderName,
                    OrderType = item.OrderType,
                    OrderDate = item.OrderDate.Value,
                    OrderDelivery = item.OrderDelivery,
                    OrderVerify = item.OrderVerify,
                    OrderDeliveryDate = item.OrderDeliveryDate.Value,
                    OrderStatus = item.OrderStatus,
                    TotalAmount = item.TotalAmount.Value,
                    DeliverdToBranch = item.DeliverdToBranch.ToString(),
                   });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepCustomerAccountOrders.rdlc";
            frm.ShowDialog();
        }



        public void GetOrderBill(int XOrderID)
        {
            var q = OrderProductsCmd.GetAllByOrderID(XOrderID);

            
            var rs = new ReportDataSource();
            var ls = new List<OrderReportObj>();
            foreach (var item in q)
            {

                string Description = "";

                foreach (var itm in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(item.ID))
                {
                    Description = Description + string .Format("Customer Text is[{0}] \n description is [{1}]\n",itm.CustomerText, itm.Description);
                }
                
                ls.Add(new OrderReportObj()
                {

                    /// information Order And Customer
                    OrderIdID = item.Order.ID,
                    CustomerName = item.Order.Customer.CustomerName,
                    CustomerPhoneNumber = item.Order.Customer.PhoneNumber,
                    OrderType = item.Order.OrderType,
                    OrderDate = item.Order.OrderDate.ToString().ToDateTime(),
                    OrderDelivery = item.Order.OrderDelivery,
                    OrderVerify = item.Order.OrderVerify,
                    OrderDeliveryDate = item.Order.OrderDeliveryDate.ToString().ToDateTime(),
                    TotalAmount = item.Order.TotalAmount.ToString().Todouble(),
                    DeliverdToBranch = BranchsCmd.GetBranchByBarnchID(item.Order.DeliverdToBranch.ToString().ToInt()).Branch_Name,
                    
                     OrderProductStatus = Description,
                    ProductName = item.Product.PublicName,
                    Qty = item.Qty.Value,
                    ProductPrice = item.Product.ProductPrice.Value,
                   
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepOrderBill.rdlc";
            frm.ShowDialog();
        }
    }
}
