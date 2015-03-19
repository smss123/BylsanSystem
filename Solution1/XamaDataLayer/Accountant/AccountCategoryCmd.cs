using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using XamaDataLayer.Helper_Classes;

namespace XamaDataLayer.Accountant
{
    public    class AccountCategoryCmd:ApiCounter
    {
     
        public static bool AddAccountCategory(AccountCategory tb)
        {
           
            db.CommandTimeout = 9000;


            tb.ID = ApiCounter.GetNumber();
            db.AccountCategories.InsertOnSubmit(tb);
            db.SubmitChanges();
           
            return true;
        }


        public static AccountCategory EditAccountCategory(AccountCategory tb, int xid)
        {
            db.CommandTimeout = 9000;
            var act = db.AccountCategories.Where(a => a.ID == xid).SingleOrDefault();
            act.AccountCategoryName = tb.AccountCategoryName;
            act.Description = tb.Description;

            db.SubmitChanges();
          
            return act;
        }


        public static void DeleteAccountCategory(int xid)
        {
            db.CommandTimeout = 9000;
            var act = db.AccountCategories.Where(a => a.ID == xid).SingleOrDefault();
            db.AccountCategories.DeleteOnSubmit(act);

            db.SubmitChanges();
        }

        public static List<AccountCategory> GetAll()
        {
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                    ( from a in  dbx.AccountCategories
                                             select a ).ToList()
                );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;
            var Lst = com(db);
            return Lst;
        }
    }
}
