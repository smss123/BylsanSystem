using System;
using System.Collections.Generic;
using System.Linq;

namespace Bylsan_System.Reports.ReportsObject
{
    public class PaymentVoucherReportObj
    {
        public int PaymentVoucherNumber { get; set; }
        public string PaymentVoucherName { get; set; }
        public string Date { get; set; }
        public double Cost { get; set; }
        public double Remaining { get; set; }
    }
}
