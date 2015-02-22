using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;

namespace Bylsan_System
{
    public class Operation
    {
        public static List<Product> Allproducts { get; set; }
        public static List<ProductCategory>  Allcategorys { get; set; }
        public static List <Branch >  AllBranches { get; set; }
        public static List <Product > AllSellItems  { get; set; }
        public static List<Debtor> AllDebetor { get; set; }

        public static List<Order> AllOrder = new List<Order>();
        public static List<Customer> AllCustomer = new List<Customer>();



        public static void ShowToustOk(string msg, Control frm)
        {
            MessageBox.Show(msg, string.Empty);
        }

        public static void BeginOperation(Control frm)
        {
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = false;
                frm.Cursor = Cursors.WaitCursor;
            });
        }

        public static void EndOperation(Control frm)
        {
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = true;
                frm.Cursor = Cursors.Default;

            });
        }
    }
}
