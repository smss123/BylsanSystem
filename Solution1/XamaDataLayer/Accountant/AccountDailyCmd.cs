using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public static  class AccountDailyCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddAccountDaily(AccountDaily tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.AccountDailies.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static AccountDaily EditAccountDaily(AccountDaily tb, int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
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
            db.CommandTimeout = 9000;
            var dy = db.AccountDailies.Where(d => d.ID == xid).SingleOrDefault();
            db.AccountDailies.DeleteOnSubmit(dy);
            db.SubmitChanges();
        }

        public static List<AccountDaily> GetAllDaily()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            return db.AccountDailies.ToList();
        }

        public static List<AccountDaily> GetAllAccountDailyByDate( DateTime dat )
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var dy = (from d in db.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.DateOfProcess == dat
                     select d).ToList();
            return dy;
        }



        public static List<AccountDaily> GetAllAccountDailyByAccountID(int actid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var dy = (from d in db.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.AccountID == actid
                     select d).ToList();
            return dy;
        }
        public static double  GetBalanceByAccountID(int ACTID)
        {
            double netBalance = 0;
            try
            {
                db = new DbDataContext();
                db.CommandTimeout = 9000;
                var  totIn = (from d in db.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.AccountID == ACTID
                     select  d.TotalIn ).Sum (  );

                var totOut = (from d in db.AccountDailies
                         orderby d.DateOfProcess ascending
                         where d.AccountID == ACTID
                         select d.TotalOut).Sum();
                netBalance = totIn.Value - totOut.Value;

                return netBalance;
            }
            catch (Exception)
            {
                return  netBalance = 0;
            }
        }
    }
}
