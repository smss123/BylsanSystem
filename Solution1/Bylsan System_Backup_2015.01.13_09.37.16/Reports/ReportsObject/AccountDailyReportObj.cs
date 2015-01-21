using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
     public class AccountDailyReportObj
    {

        public string AccountName { get; set; }
        public double TotalIn { get; set; }
        public double TotalOut { get; set; }
        public DateTime DateOfProcess  { get; set; }
        public string Description { get; set; }
        public string CommandArg { get; set; }


    }
}
