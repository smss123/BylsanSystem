using System;
using System.Collections.Generic;
using System.Linq;

namespace Bylsan_System.Reports.ReportsObject
{
    public class RptBillObj
    {
        public int ID { get; set; }
        public double? Total { get; set; }
        public DateTime? BillDate { get; set; }
        public string  User { get; set; }
        public string  ItemName { get; set; }
        public string  Qty { get; set; }
        public  double? UnitPrice { get; set; }
        public double? Amount { get; set; }
    }
}
