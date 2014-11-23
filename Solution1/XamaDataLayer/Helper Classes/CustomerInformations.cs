using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Helper_Classes
{
   public   class CustomerInformations
    {
        public static  Customer  WatingCustomer  { get; set; }
        public static   Order WaitingOrder { get; set; }


       //========================================================
       // if not Exiest :
        public static string CustmrName { get; set; }
        public static string CustmrPhone { get; set; }

       //=========================================================
    }
}
