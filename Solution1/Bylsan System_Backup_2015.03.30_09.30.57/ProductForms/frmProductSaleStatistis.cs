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
using XamaDataLayer;
namespace Bylsan_System.ProductForms
{

    public partial class frmProductSaleStatistis : Form
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
                  var itm =   LS.Where(p => p.ProductName == item.Product.PublicName).SingleOrDefault();
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
            radGridView1.Rows.Clear();
            var q = db.Products.ToList();
            foreach (var item in q)
            {
                var billx = item.BillItems.Where(p => p.Bill.BillDate >= txtDateFrom.Value && p.Bill.BillDate <= txtDateTo.Value);
                foreach (var itm in billx)
                {
                    if (radGridView1.Rows.Count == 0)
                    {
                        radGridView1.Rows.Add(new string[] { item.Product_Name, itm.Bill.BillDate.Value.ToShortDateString(), item.BillItems.Count.ToString() });
                    }
                    for (int i = 0; i <= radGridView1.Rows.Count; i++)
                    {
                        try
                        {
                            if (radGridView1.Rows[i].Cells[0].Value.ToString() != item.Product_Name)
                            {
                                radGridView1.Rows.Add(new string[] { item.Product_Name, itm.Bill.BillDate.Value.ToShortDateString(), item.BillItems.Count.ToString() });

                            }
                        }
                        catch (Exception)
                        {


                        }

                    }

                }
            }
        }
    }
}
