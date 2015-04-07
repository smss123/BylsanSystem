using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public    class AccountDailyCmd:ApiCounter
    {
     
        public static bool AddAccountDaily(AccountDaily tb)
        {
             tb.ID = ApiCounter.GetNumber();
            db.CommandTimeout = 9000;
            db.AccountDailies.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static AccountDaily EditAccountDaily(AccountDaily tb, int xid)
        {
           
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
          
            db.CommandTimeout = 9000;
            var dy = db.AccountDailies.Where(d => d.ID == xid).SingleOrDefault();
            db.AccountDailies.DeleteOnSubmit(dy);
            db.SubmitChanges();
        }
        public static List<AccountDaily> GetAllDaily()
        {
             
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                    dbx.AccountDailies
                );
            db.CommandTimeout = 9000;
            return com(db).ToList();
        }
        public static List<AccountDaily> GetAllAccountDailyByDate( DateTime dat )
        {
             
            
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                   (from d in dbx.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.DateOfProcess == dat
                     select d).ToList()
                );
            db.CommandTimeout = 9000;
            return com(db);
        }
        public static List<AccountDaily> GetAllAccountDailyByAccountID(int actid)
        {

            var com = CompiledQuery.Compile(
               (DbDataContext dbx) =>
                  (from d in dbx.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.AccountID == actid
                     select d)
               );
            db.CommandTimeout = 9000;
            return com(db).ToList();
        }
        public static double  GetBalanceByAccountID(int ACTID)
        {
            double netBalance = 0;
            try
            {
                
                db.CommandTimeout = 9000;
                var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                 (from d in dbx.AccountDailies
                     orderby d.DateOfProcess ascending
                     where d.AccountID == ACTID
                     select  d.TotalIn ).Sum (  )
                 );
                db.CommandTimeout = 9000;
                var totIn = com(db);

                var com1 = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                 (from d in dbx.AccountDailies
                         orderby d.DateOfProcess ascending
                         where d.AccountID == ACTID
                         select d.TotalOut).Sum()
                 );
                var totOut = com1(db);
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
