using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
 public   class Rpt_SalesByDates
    {
        public  int ID { get; set; }
     public string  ProductName { get; set; }
     public double TotalSales { get; set; }
     public DateTime Mounth { get; set; }
    }
}
