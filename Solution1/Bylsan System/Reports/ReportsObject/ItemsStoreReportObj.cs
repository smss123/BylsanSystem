using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
    public class ItemsStoreReportObj
    {/////
        public int StorId { get; set; }
        public string itemName { get; set; }
        public Int64 AvailableQty { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }


    }
}
