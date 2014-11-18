using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Accountant
{
   public static  class AccountDailyCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddAccountDaily(AccountDaily tb)
       {
           db = new DbDataContext();
           db.AccountDailies.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }
       public static AccountDaily EditAccountDaily(AccountDaily tb, int xid)
       {
           db = new DbDataContext();
           var dy = db.AccountDailies.Where(d => d.ID == xid).SingleOrDefault();
           dy.AccountID = tb.AccountID;
           dy.TotalIn = tb.TotalIn;
           dy.TotalOut = tb.TotalOut;
           dy.Description = tb.Description;
           dy.DateOfProcess = tb.DateOfProcess;
           tb.CommandArg = tb.CommandArg;
           db.SubmitChanges();
           return dy;
       }

       public static void DeleteAccountDaily(int xid)
       {
          
                db = new DbDataContext();
           var dy = db.AccountDailies.Where(d => d.ID == xid).SingleOrDefault();
           db.AccountDailies.DeleteOnSubmit(dy);
           db.SubmitChanges();
          
           
       }

       public static List<AccountDaily> GetAllDaily()
       {
           db = new DbDataContext();
           return db.AccountDailies.ToList();
       }

       public static List<AccountDaily> GetAllAccountDailyByDate( DateTime dat )
       {
           db = new DbDataContext();
           var dy = (from d in db.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.DateOfProcess == dat 
                     select d).ToList();
           return dy;
       }

   
    }
}
