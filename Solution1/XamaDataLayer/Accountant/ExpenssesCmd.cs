using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public class ExpenssesCmd:ApiCounter
    {
     
        public static bool AddExpensses(Expenss tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.Expensses.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }


        public static Expenss EditExpenss(Expenss tb)
        {
           
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
           
            db.CommandTimeout = 9000;
            var exp = db.Expensses.Where(x => x.ID == xid).SingleOrDefault();
            db.Expensses.DeleteOnSubmit(exp);
            db.SubmitChanges();
        }

        public static List<Expenss> GetAllExpensses()
        {
            var com = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
                      db.Expensses 
             );
            db.CommandTimeout = 9000;
            return com(db).ToList() ;
        }

        public static List<Expenss> GetExpenssesByAccountId( int ActId)
        {
            var com = CompiledQuery.Compile(
                     (DbDataContext dbx, int id) =>
                       (from i in db.Expensses
                                               where i.AccountID == id
                                               select i).ToList()
              );
            db.CommandTimeout = 9000;
            return com(db,ActId);
             
        }
    }
}
