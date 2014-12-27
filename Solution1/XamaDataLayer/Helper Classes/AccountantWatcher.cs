using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Helper_Classes
{
    public static  class AccountantWatcher
    {
        private static DbDataContext db = new DbDataContext();
        private static  AccountDaily tb = new AccountDaily();




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
            tb = db.AccountDailies.Where(Mx => Mx.TotalOut == MaxTotalOut).SingleOrDefault();
            return tb;
        }




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

        public static  double  GetFreeBalance( int? actid)
        {
            double NetBalance = 0;
            try
            {
                db = new DbDataContext();

                var TotIn = (from d in db.AccountDailies
                             where d.AccountID == actid 
                             select d.TotalIn).Sum();

                var TotOut = (from d in db.AccountDailies
                              where d.AccountID == actid 
                              select d.TotalOut).Sum();
                NetBalance = TotIn.Value - TotOut.Value;

                return NetBalance;
            }
            catch (Exception)
            {
                return NetBalance = 0;
            }
        }


    }
}
