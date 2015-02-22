using System;
using System.Collections.Generic;
using System.Linq;

namespace Bylsan_System.Reports.ReportsObject
{
    public class BalanceSheetObj
    {
        public string HashNumber { get; set; }
        public string  AccountCategory { get; set; }
        public string  AccountName { get; set; }
        public double? Balance { get; set; }
    }
}
