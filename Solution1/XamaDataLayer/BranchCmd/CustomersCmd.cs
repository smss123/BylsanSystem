using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class CustomersCmd
    {

       static DbDataContext db = new DbDataContext();
       public static bool AddCustomer(Customer tb)
       {
           db = new DbDataContext();
           db.Customers.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public static List<Customer> GetAllCustmers()
       {
           db = new DbDataContext();
           var lst = (from c in db.Customers
                      orderby c.CustomerName ascending
                      select c).ToList();
           return lst;

       }

       public static Customer EditCustomer( Customer tb ,int xid) {
           db = new DbDataContext();
           var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();
           c.CustomerName = tb.CustomerName;
           c.PhoneNumber = tb.PhoneNumber;
           c.CreateDate = tb.CreateDate;
           c.AccountID = tb.AccountID;
           c.Points = tb.Points;
           db.SubmitChanges();
           return c;
       }

       public static void DeleteCustomer( int xid )
       {
          
               db = new DbDataContext();
               var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();
               db.Customers.DeleteOnSubmit(c);
               db.SubmitChanges();
          
       }
    }
}
