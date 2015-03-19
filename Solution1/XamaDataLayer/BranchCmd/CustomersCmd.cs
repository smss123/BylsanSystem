using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public    class CustomersCmd:ApiCounter
    {
       
        public static bool AddCustomer(Customer tb)
        {
            tb.ID = GetNumber();    
            db.CommandTimeout = 9000;
            db.Customers.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Customer", " Add New Customer ");

            return true;
        }

        public static List<Customer> GetAllCustmers()
        {
            var com = CompiledQuery.Compile(
               (DbDataContext dbx) =>
                (from c in dbx.Customers
                                      orderby c.CustomerName ascending
                                      select c)
        );
            db.CommandTimeout = 9000;
            return com(db).ToList();

            
          
        }


     
     
     
     
        public static bool EditCustomer(Customer tb, int xid)
        {
            
            db.CommandTimeout = 9000;
            var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();

            c.CustomerName = tb.CustomerName;
            c.PhoneNumber = tb.PhoneNumber;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", "Edit Customer", " Edit Selected Customer's Informations  ");

            return true;
        }

        public static void DeleteCustomer( int xid )
        {
            
            db.CommandTimeout = 9000;
            var c = db.Customers.Where(cc => cc.ID == xid).SingleOrDefault();
            db.Customers.DeleteOnSubmit(c);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", "Delete Customer", " Delete Selected Customer's Informations  ");
        }
        public static List<Customer> GetCustmerByID(int CustId)
        {
            var com = CompiledQuery.Compile(
              (DbDataContext dbx) =>
              (from c in dbx.Customers
                                    orderby c.CustomerName ascending
                                    where c.ID == CustId
                                    select c).ToList ()
                                         );
            db.CommandTimeout = 9000;
            return com(db);
             
        }
    }
}
