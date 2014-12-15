using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bylsan_System.Reports.ReportsObject
{
  public  class ProductReportObj
    {
      /// <summary>/////
      /// /
      /// </summary>
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Image ProductImage { get;set;}
        public string PublicName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductUnit { get; set; }
        public string CateogryName { get; set; }
    }
}
