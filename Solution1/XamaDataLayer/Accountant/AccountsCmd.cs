using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Accountant
{
    public static class AccountsCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool AddAccount(Account tb)        
        {
            // عارف أنه معمول له تريـــقر  ومش راح يلزم
            db = new DbDataContext();
            db.Accounts.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Account EditAccount(Account tb, int xid)
        {
            db = new DbDataContext();
            var act = db.Accounts.Where(a => a.ID == xid).SingleOrDefault();
            act.CategoryID = tb.CategoryID;
            act.AccountName = tb.AccountName;
            act.Description = tb.Description;

            db.SubmitChanges();
            return act;
        }

        public static void DeleteAccount(int xid)
        {
            try
            {
            db = new DbDataContext();
            var act = db.Accounts.Where(a => a.ID == xid).SingleOrDefault();
            db.Accounts.DeleteOnSubmit(act);

            db.SubmitChanges();
            
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static List<Account> GetAllAccounts()
        {
            db = new DbDataContext();
            return db.Accounts.ToList();
        }

        public static List<Account> GetAccountByCategoryID(int categID)
        {
            db = new DbDataContext();
            var ACT = (from g in db.Accounts where g.CategoryID == categID select g).ToList();
            return ACT;
        }


    }
}
