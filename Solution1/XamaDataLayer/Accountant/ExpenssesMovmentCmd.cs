using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Accountant
{
    public static class ExpenssesMovmentCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool AddExpenssesMovment( ExpenssesMovment tb )
        {
            db = new DbDataContext();
            db.ExpenssesMovments.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static ExpenssesMovment EditExpMovment(ExpenssesMovment tb)
        {
            db = new DbDataContext();
            var exp = db .ExpenssesMovments .Where (x=> x.ID == tb.ID ).SingleOrDefault ();
            exp.ID = tb.ID;
         //   exp .ExpenssesID = tb .ExpenssesID ;
            exp .Amount = tb .Amount ;
        //    exp .DateOfProcess = tb .DateOfProcess ;
            exp .Description = tb .Description  ;



            db .SubmitChanges ();
            return exp;
        }

        public static void DeleteExpMovment(int xid)
        {

            try
            {
           db = new DbDataContext();
            var exp = db .ExpenssesMovments .Where (x=> x.ID == xid ).SingleOrDefault ();
            db.ExpenssesMovments.DeleteOnSubmit(exp);
            db.SubmitChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
            
           
        }

        public static List<ExpenssesMovment> GetAll()
        {
            db = new DbDataContext();
            return db.ExpenssesMovments.ToList();
        }

        public static List<ExpenssesMovment> GetAllExpenssesMovmentByExpID(int expID)
        {
            db = new DbDataContext();

            var LST = (from c in db.ExpenssesMovments
                       where c.ExpenssesID == expID
                       select c).ToList();
            return LST;
        }
        public static List<ExpenssesMovment> GetAllExpnssesMovmentsByDate( DateTime dat )
        {
            db = new DbDataContext();
            var lst = (from d in db.ExpenssesMovments where d.DateOfProcess == dat select d).ToList();
            return lst;
           
        }




    }
}
