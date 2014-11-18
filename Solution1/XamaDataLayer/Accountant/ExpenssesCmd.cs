using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Accountant
{
    public static     class ExpenssesCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool AddExpensses(Expenss tb)
        {
            db = new DbDataContext();
            db.Expensses.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }


        public static Expenss EditExpenss(Expenss tb, int xid)
        {
            db = new DbDataContext();
            var exp = db.Expensses.Where(x => x.ID == xid).SingleOrDefault();
            exp.ExpenssesName = tb.ExpenssesName;
            exp.Description = tb.Description;
            exp.AccountID = tb.AccountID;

            db.SubmitChanges();
            return exp;
        }


        public static void DeleteExpenses(int xid)
        {
           
            db = new DbDataContext();
            var exp = db.Expensses.Where(x => x.ID == xid).SingleOrDefault();
            db.Expensses.DeleteOnSubmit(exp);
            db.SubmitChanges();
            
           
        }

        public static List<Expenss> GetAllExpensses()
        {
            db = new DbDataContext();
            return db.Expensses.ToList();
        }

    }
}
