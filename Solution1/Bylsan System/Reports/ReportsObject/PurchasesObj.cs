using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
    public class PurchasesObj
    {
        public int PNo { get; set; }
        public DateTime DateOfProcess { get; set; }
        public string  InvoiceNo { get; set; }
        public string  SuplierName { get; set; }
        public string  Amount { get; set; }
        public string  ItemName { get; set; }
        public string  Qty { get; set; }
    }
}
