using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Accountant
{
   public static  class AccountCategoryCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddAccountCategory(AccountCategory tb)
       {
           db = new DbDataContext();
           db.AccountCategories.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }


       public static AccountCategory EditAccountCategory(AccountCategory tb, int xid)
       {
           db = new DbDataContext();
           var act = db.AccountCategories.Where(a => a.ID == xid).SingleOrDefault();
           act.AccountCategoryName = tb.AccountCategoryName;
           act.Description = tb.Description;

           db.SubmitChanges();
           return act;
       }


       public static void DeleteAccountCategory(int xid)
       {
         
           db = new DbDataContext();
           var act = db.AccountCategories.Where(a => a.ID == xid).SingleOrDefault();
           db.AccountCategories.DeleteOnSubmit(act);

           db.SubmitChanges();
          
       }

       public static List<AccountCategory> GetAll()
       {
           db = new DbDataContext();
           return db.AccountCategories.ToList();
       }
    }
}
