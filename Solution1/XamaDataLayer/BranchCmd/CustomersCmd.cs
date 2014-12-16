using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Customer", " Add New Customer ");

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


       public static int GetCustomerIDByName(string nam)
       {
           db = new DbDataContext();
           var cust = db.Customers.Where(c => c.CustomerName == nam).SingleOrDefault();
           int xCustID = cust.ID;
           return xCustID;

       }
       public static Customer GetAllCustmerByID( int CustId)
       {
           db = new DbDataContext();
           var lst = (from c in db.Customers
                      orderby c.CustomerName ascending
                      where c.ID == CustId 
                      select c).Single();
           return lst;

       }

       public static List<Customer> GetAllCustmerByAccountID(int ActId)
       {
           db = new DbDataContext();
           var lst = (from c in db.Customers
                      orderby c.CreateDate  ascending
                      where c.AccountID == ActId 
                      select c).ToList();
           return lst;

       }
       public static bool EditCustomer(Customer tb, int xid)
       {
           db = new DbDataContext();
           var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();
           
           c.CustomerName = tb.CustomerName;
           c.PhoneNumber = tb.PhoneNumber;
           db.SubmitChanges();
           XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", "Edit Customer", " Edit Selected Customer's Informations  ");

           return true;
       }

       public static void DeleteCustomer( int xid )
       {
          
               db = new DbDataContext();
               var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();
               db.Customers.DeleteOnSubmit(c);
               db.SubmitChanges();
               XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", "Delete Customer", " Delete Selected Customer's Informations  ");
       }
       public static List<Customer> GetCustmerByID(int CustId)
       {
           db = new DbDataContext();
           var lst = (from c in db.Customers
                      orderby c.CustomerName ascending
                      where c.ID == CustId
                      select c).ToList ();
           return lst;

       }
    }
}
