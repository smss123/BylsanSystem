using Bylsan_System.Reports.ReportCommand;
using Bylsan_System.Reports.ReportsObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
namespace Bylsan_System.ProductForms
{

    public partial class frmProductSaleStatistis : RadForm
    {
        private DbDataContext db = new DbDataContext();
        public frmProductSaleStatistis()
        {
            InitializeComponent();
        }

        private void frmProductSaleStatistis_Load(object sender, EventArgs e)
        {
            var q = db.BillItems.ToList();
            List<ProductDetails> LS = new List<ProductDetails>();
            foreach (var item in q)
            {

                try
                {
                    var itm = LS.Where(p => p.ProductName == item.Product.PublicName).SingleOrDefault();
                    //  itm.DateOfProcess="";

                }
                catch (Exception)
                {

                    throw;
                }



            }


            //GroupDescriptor descriptor = new GroupDescriptor();
            //descriptor.GroupNames.Add("ProductName", ListSortDirection.Ascending);
            //descriptor.Aggregates.Add("Count(ProductName)");
            //descriptor.Format = "{0}: {1} has {2} records in its group.";

            //this.radGridView1.GroupDescriptors.Add(descriptor);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
          
            var q = db.Products.ToList();
            List<Rpt_SalesByDates> ls = new List<Rpt_SalesByDates>();
            foreach (var item in q)
            {
                var billx = item.BillItems.Where(p => p.Bill.BillDate >= txtDateFrom.Value && p.Bill.BillDate <= txtDateTo.Value);
                foreach (var itm in billx)
                {
                    ls.Add(new Rpt_SalesByDates()
                    {
                        ID = itm.ProductID.HasValue?itm.ProductID.Value:0,
                        Mounth = itm.Bill.BillDate.HasValue?DateTime.Parse(itm.Bill.BillDate.Value.ToShortDateString()):DateTime.Now,
                        ProductName = itm.Product.Product_Name,
                        TotalSales = item.BillItems.Where(p => p.Bill.BillDate >= txtDateFrom.Value && p.Bill.BillDate <= txtDateTo.Value).Where(p => p.ProductID == itm.ProductID).Sum(p => p.Product.ProductPrice).Value
                    });
                }

            }

            AccountDailyReportCmd cmd = new AccountDailyReportCmd();
            cmd.GetSales(ls);
        }

    }
}
