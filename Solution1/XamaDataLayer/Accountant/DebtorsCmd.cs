using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public  class DebtorsCmd
    {
        private static DbDataContext db = new DbDataContext();

        public static bool AddDebt(Debtor tb)
        {
            db = new DbDataContext();
            db.Debtors.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Debtor EditDebtor(Debtor tb, int xid)
        {
            db = new DbDataContext();
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
            db = new DbDataContext();
            var q = db.Debtors.Where(d => d.ID == xid).SingleOrDefault();
            db.Debtors.DeleteOnSubmit(q);

            db.SubmitChanges();
        }


        public static List<Debtor> GetAllDebtors()
        {
            db = new DbDataContext();
            return db.Debtors.ToList();
        }
    }
}
