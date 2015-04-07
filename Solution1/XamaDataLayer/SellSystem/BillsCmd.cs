using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.SellSystem
{
    public    class BillsCmd:ApiCounter
    {
       
        public static bool AddBill(Bill tb)
        {
            tb.ID = GetNumber();
           db.CommandTimeout = 9000;
            db.CommandTimeout = 9000;
            db.Bills.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Bill EditBill(Bill tb, int xid)
        {
            db.CommandTimeout = 9000;
            var bl = db.Bills.Where(b => b.ID == xid).SingleOrDefault();
            bl.BillDate = tb.BillDate;
            bl.BillNumber = tb.BillNumber;
            bl.UserID = tb.UserID;
            bl.BillTotal = tb.BillTotal;
            bl.description = tb.description;
            bl.paytype = tb.paytype;
            db.SubmitChanges();
            return bl;
        }


        public static void DeleteBill(int xid)
        {
            db.CommandTimeout = 9000;
            var bl = db.Bills.Where(b => b.ID == xid).SingleOrDefault();
            db.Bills.DeleteOnSubmit(bl);
            db.SubmitChanges();
        }


        public static List<Bill> GetAll()
        {
            var com = CompiledQuery.Compile(
         (DbDataContext dbx) =>
             db.Bills
         );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();
           
        }

        public static List<Bill> GetAllByBillNumber(string str)
        {
            var com = CompiledQuery.Compile(
        (DbDataContext dbx) =>
           (from b in db.Bills
                                 orderby b.ID ascending
                                 where b.BillNumber == str
                                 select b)
        );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

          
        }

        public static List<Bill> GetAllByUserID(int usrid )
        {
            var com = CompiledQuery.Compile(
       (DbDataContext dbx) =>
          (from b in db.Bills
                                orderby b.ID ascending
                                where b.UserID == usrid
          
                                select b)
       );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

          
        }

        public static List<Bill> GetAllByDate( DateTime dat)
        {
            var com = CompiledQuery.Compile(
                    (DbDataContext dbx, DateTime d) =>
                              (from b in db.Bills
                               orderby b.ID ascending
                               where b.BillDate.Value.Year == d.Year && b.BillDate.Value.Month==d.Month && b.BillDate.Value.Day == d.Day
                               select b)
                 );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db,dat).ToList();

         
        }

        public static int  GetMaxBill()
        {
            var com = CompiledQuery.Compile(
                  (DbDataContext dbx) =>
                            (from b in db.Bills
                      select b.ID).Max()
               );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db);

            
        }
    }
}
