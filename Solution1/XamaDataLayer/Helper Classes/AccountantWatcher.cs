using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Helper_Classes
{
   public static  class AccountantWatcher
    {
       //=====================================================
       static DbDataContext db = new DbDataContext();
       static  AccountDaily tb = new AccountDaily();
       //=====================================================

       #region " ^^^ Active's Accounts ^^^  "

       public static AccountDaily GetMaxTotalInAccount()
       {
           db = new DbDataContext();
           double MaxTotalIn = 0;
           tb = new AccountDaily();
           MaxTotalIn = (from d in db.AccountDailies
                         select d.TotalIn).Max().Value;
           tb = db.AccountDailies.Where(Mx => Mx.TotalIn == MaxTotalIn).SingleOrDefault();
           return tb;
       }

       public static AccountDaily GetMaxTotalOutAccount()
       {
           db = new DbDataContext();
           double MaxTotalOut = 0;
           tb = new AccountDaily();
           MaxTotalOut = (from d in db.AccountDailies
                         select d.TotalOut).Max().Value;
           tb = db.AccountDailies.Where(Mx => Mx.TotalOut== MaxTotalOut).SingleOrDefault();
           return tb;
       }

       #endregion 

        #region "   ^^^   Weekly Accounts ^^^    "
       public static AccountDaily GetMinTotalInAccount()
       {
           db = new DbDataContext();
           double MinTotalIn = 0;
            tb = new AccountDaily();
           MinTotalIn = (from d in db.AccountDailies
                         select d.TotalIn).Min().Value;
           tb = db.AccountDailies.Where(Mn => Mn.TotalIn == MinTotalIn).SingleOrDefault();
           return tb;
       }

       public static AccountDaily GetMinTotalOutAccount()
       {
           db = new DbDataContext();
           double MinTotalOut = 0;
            tb = new AccountDaily();
           MinTotalOut = (from d in db.AccountDailies
                          select d.TotalOut).Min().Value;
           tb = db.AccountDailies.Where(Mn => Mn.TotalOut == MinTotalOut).SingleOrDefault();
           return tb;
       }



        #endregion


    }
}
