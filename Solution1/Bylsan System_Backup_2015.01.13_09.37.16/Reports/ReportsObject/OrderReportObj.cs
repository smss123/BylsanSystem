using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer;

namespace Bylsan_System.Reports.ReportsObject
{
    public class OrderReportObj
    {
        //Order/////
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int OrderIdID { get; set; }
        public string OrderName { get; set; }
        public string OrderType { get; set; }
        public string OrderVerify { get; set; }
        public string OrderDelivery { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string Comment { get; set; }
        public string OrderStatus { get; set; }
        public double TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int DeliverdToBranch { get; set; }


        ////////////////OrderProduct


        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double ProductPrice { get; set; }
        public string ProductUnit { get; set; }
        public string PublicName { get; set; }
        public string OrderProductDescription { get; set; }
        public string OrderProductStatus { get; set; }


    }
}
