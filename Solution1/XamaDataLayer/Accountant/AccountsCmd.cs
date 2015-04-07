using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public   class AccountsCmd:ApiCounter
    {
       
        public static bool AddAccount(Account tb)
        {
            tb.ID = ApiCounter.GetNumber();
            db.CommandTimeout = 9000;
            db.Accounts.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Account EditAccount(Account tb, int xid)
        {
          
            db.CommandTimeout = 9000;
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
              
                db.CommandTimeout = 9000;
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
            
           var com = CompiledQuery.Compile(
               (DbDataContext dbx) =>
                dbx.Accounts.OrderByDescending(p=>p.CategoryID)
                );
            db.CommandTimeout = 9000;
            return com(db).ToList() ;
        }

        public static List<Account> GetAccountByCategoryID(int categID)
        { 
           var com = CompiledQuery.Compile(
             (DbDataContext dbx, int id) =>
              (from g in dbx.Accounts
                                      where g.CategoryID == id
                                      select g) 
              );
            db.CommandTimeout = 9000;
            return com(db,categID).ToList();
        }

        public static List<Account> GetAccountByID(int xID)
        {
            var com = CompiledQuery.Compile(
            (DbDataContext dbx, int id) =>
             (from ac in dbx.Accounts
              where ac.ID == id
              select ac) 
             );
            db.CommandTimeout = 9000;
            return com(db,xID).ToList();

        }
        public static List<Account> GetAccountByName(string nam)
        {
            var com = CompiledQuery.Compile(
            (DbDataContext dbx, string n) =>
             (from ac in dbx.Accounts
                        where ac.AccountName  == n
                         select ac)
             );
            db.CommandTimeout = 9000;
            return com(db,nam).ToList();
            
        }
        public static Account GetOneAccountByName(string nam)
        {
            var com = CompiledQuery.Compile(
            (DbDataContext dbx, string na) =>
             (from ac in db.Accounts
                                    where ac.AccountName == na
                                    select ac).Single ()
             );
            db.CommandTimeout = 9000;
            return com(db,nam); 
        }
        public static double? GetAccountBalance(int accountID)
        {
            var balance = (double? )0d;

            var totalIn = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                        db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalIn)
             );
            var allTotalIn = totalIn(db);

            var totalOut = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                        db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalOut)
             );

            var allTotalOut = totalOut(db);

            balance = allTotalIn - allTotalOut;

            return balance;
        }

        public static double? GetCustomerPayment(int accountID, int orderID)
        {
            var balance = (double?)0d;
            var totalIn = CompiledQuery.Compile(
                   (DbDataContext dbx,int accid,int orderid) =>
                      db.AccountDailies.Where(p => p.AccountID == accid&&p.CommandArg==orderid.ToString()).Sum(p => p.TotalIn)
            );

            var allTotalIn = totalIn(db, accountID, orderID);

            var TotalOut = CompiledQuery.Compile(
                  (DbDataContext dbx, int accid, int orderid) =>
                   db.AccountDailies.Where(p => p.AccountID == accid && p.CommandArg == orderid.ToString()).Sum(p => p.TotalOut)
           );

            var allTotalOut = TotalOut(db, accountID, orderID);
            balance = allTotalIn - allTotalOut;

            return balance;
        }

        public static double? GetAccountBalance(int accountID, DateTime fromDate, DateTime toDate)
        {
            var balance = (double? )0d;

            var totalIn = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                       db.AccountDailies.Where(
                                   p => p.AccountID == accountID &&
                                        p.DateOfProcess.Value.Year >= fromDate.Year
                                        && p.DateOfProcess.Value.Month >= fromDate.Month &&
                                        p.DateOfProcess.Value.Day >= fromDate.Day &&
                       
                                         p.DateOfProcess.Value.Year <= toDate.Year
                                        && p.DateOfProcess.Value.Month <= toDate.Month &&
                                        p.DateOfProcess.Value.Day <= toDate.Day
                       
                                        ).Sum(p => p.TotalIn)
             );


            var allTotalIn = totalIn(db);

            var totalOut = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                      db.AccountDailies.Where(p => p.AccountID == accountID &&
                                       p.DateOfProcess.Value.Year >= fromDate.Year
                                       && p.DateOfProcess.Value.Month >= fromDate.Month &&
                                       p.DateOfProcess.Value.Day >= fromDate.Day &&
                      
                                        p.DateOfProcess.Value.Year <= toDate.Year
                                       && p.DateOfProcess.Value.Month <= toDate.Month &&
                                       p.DateOfProcess.Value.Day <= toDate.Day
                                       ).Sum(p => p.TotalOut)
             );

            var allTotalOut =totalOut(db) ;
            balance = allTotalIn - allTotalOut;

            return balance;
        }
    }
}
