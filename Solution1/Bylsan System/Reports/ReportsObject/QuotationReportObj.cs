using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
 public   class QuotationReportObj
    {

        public string QuotationFor { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AddressFor { get; set; }
        public string PhoneNumber { get; set; }

     ///

        public string ProductPublicName { get; set; }
        public double ProductPrice { get; set; }
        public string QuotationDescription { get; set; }
        public string  QuotaionID { get; set; }
     

    }
}
