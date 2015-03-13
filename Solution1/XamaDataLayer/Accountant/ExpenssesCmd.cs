using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public static     class ExpenssesCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddExpensses(Expenss tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.Expensses.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }


        public static Expenss EditExpenss(Expenss tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var exp = db.Expensses.Where(p => p.ID == tb.ID).SingleOrDefault();
            exp.ID = tb.ID;
            exp.ExpenssesName = tb.ExpenssesName;
            exp.Description = tb.Description;


            db.SubmitChanges();
            return exp;
        }


        public static void DeleteExpenses(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var exp = db.Expensses.Where(x => x.ID == xid).SingleOrDefault();
            db.Expensses.DeleteOnSubmit(exp);
            db.SubmitChanges();
        }

        public static List<Expenss> GetAllExpensses()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            return db.Expensses.ToList();
        }

        public static List<Expenss> GetExpenssesByAccountId( int ActId)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from i in db.Expensses
                        where i.AccountID == ActId
                        select i).ToList();
            return lst;
        }
    }
}
