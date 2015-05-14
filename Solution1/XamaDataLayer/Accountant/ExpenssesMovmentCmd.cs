using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Accountant
{
    public   class ExpenssesMovmentCmd:ApiCounter
    {
     
        public static bool AddExpenssesMovment( ExpenssesMovment tb )
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.ExpenssesMovments.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static ExpenssesMovment EditExpMovment(ExpenssesMovment tb)
        {
           
            db.CommandTimeout = 9000;
            var exp = db .ExpenssesMovments .Where (x => x.ID == tb.ID ).SingleOrDefault ();
            exp.ID = tb.ID;

            exp .Amount = tb .Amount ;

            exp .Description = tb .Description  ;



            db .SubmitChanges ();
            return exp;
        }

        public static void DeleteExpMovment(int xid)
        {
          
                
                db.CommandTimeout = 9000;
                var exp = db .ExpenssesMovments .Where (x => x.ID == xid ).SingleOrDefault ();
                db.ExpenssesMovments.DeleteOnSubmit(exp);
                db.SubmitChanges();
           
        }

        public static List<ExpenssesMovment> GetAll()
        {
            var com = CompiledQuery.Compile(
                     (DbDataContext dbx) =>
                       dbx.ExpenssesMovments.ToList()
              );
            db.CommandTimeout = 9000;
            return com(db);
 
        }

        public static List<ExpenssesMovment> GetAllExpenssesMovmentByExpID(int expID)
        {
            var com = CompiledQuery.Compile(
                    (DbDataContext dbx, int id) =>
                     (from c in dbx.ExpenssesMovments
                                            where c.ExpenssesID == id
                                            select c).ToList()
             );
            db.CommandTimeout = 9000;
            return com(db,expID).ToList();
        }
        public static List<ExpenssesMovment> GetAllExpnssesMovmentsByDate( DateTime dat )
        {
            var com = CompiledQuery.Compile(
                   (DbDataContext dbx ) =>
                    (from d in dbx.ExpenssesMovments
                                            where d.DateOfProcess.Value.Year == dat.Year&&d.DateOfProcess.Value.Month==dat.Month&&d.DateOfProcess.Value.Day==dat.Day
                                            select d).ToList()
            );
            db.CommandTimeout = 9000;
            return com(db );

            
        }
    }
}
