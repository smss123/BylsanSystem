using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Helper_Classes
{
    public   class CustomerInformations
    {
        public static void Orderini()
        {
            WaitingOrder = new Order();
        }
        public static void CustIni()
        {
            WatingCustomer = new Customer();
        }
        public static void AttachIni()
        {
            WaitingAttachment = new List<OrderProuctAttachment>();
        }
        public static  Customer  WatingCustomer  { get; set; }
        public static   Order WaitingOrder { get; set; }
        public static List<OrderProuctAttachment> WaitingAttachment { get; set; }




        public static string CustmrName { get; set; }
        public static string CustmrPhone { get; set; }
        public static  string  OrdrType { get; set; }
    }
}
