using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public  class DebtorsCmd:ApiCounter
    {
      

        public static bool AddDebt(Debtor tb)
        {
            tb.ID = ApiCounter.GetNumber();
            db.CommandTimeout = 9000;
            db.Debtors.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Debtor EditDebtor(Debtor tb, int xid)
        {
           
            db.CommandTimeout = 9000;
            var q = db.Debtors.Where(d => d.ID == xid).SingleOrDefault();
            q.DebtorName = tb.DebtorName;
            q.Addresss = tb.Addresss;
            q.PhoneNumber = tb.PhoneNumber;
            q.AccountID = tb.AccountID;
            q.DebtorDescription = tb.DebtorDescription;

            db.SubmitChanges();

            return q;
        }

        public static void DeleteDebtor(int xid)
        {
          
            db.CommandTimeout = 9000;
            var q = db.Debtors.Where(d => d.ID == xid).SingleOrDefault();
            db.Debtors.DeleteOnSubmit(q);

            db.SubmitChanges();
        }


        public static List<Debtor> GetAllDebtors()
        {
            var com = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                       dbx.Debtors 
             );
            db.CommandTimeout = 9000;
            return com(db).ToList() ;
        }

        public static Debtor  GetOneDebtorByID( int xid )
        {
            Func<DbDataContext, int, Debtor> com = CompiledQuery.Compile(
                (DbDataContext dbx, int id) => dbx.Debtors.Where(d => d.ID == id).Single());
            db.CommandTimeout = 9000;
            return com(db,xid); 
        }
    }
}
