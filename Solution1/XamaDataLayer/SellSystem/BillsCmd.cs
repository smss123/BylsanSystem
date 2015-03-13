using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.SellSystem
{
    public static  class BillsCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddBill(Bill tb)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            db.CommandTimeout = 9000;
            db.Bills.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static Bill EditBill(Bill tb, int xid)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;

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
           db = new DbDataContext();db.CommandTimeout = 9000;
            var bl = db.Bills.Where(b => b.ID == xid).SingleOrDefault();
            db.Bills.DeleteOnSubmit(bl);
            db.SubmitChanges();
        }


        public static List<Bill> GetAll()
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            return db.Bills.ToList();
        }

        public static List<Bill> GetAllByBillNumber(string str)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var lst = (from b in db.Bills
                      orderby b.ID ascending
                      where b.BillNumber == str
                      select b).ToList();
            return lst;
        }

        public static List<Bill> GetAllByUserID(int usrid )
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var lst = (from b in db.Bills
                      orderby b.ID ascending
                      where b.UserID == usrid

                      select b).ToList();
            return lst;
        }

        public static List<Bill> GetAllByDate( DateTime dat)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var lst = (from b in db.Bills
                      orderby b.ID ascending
                      where b.BillDate.Value.Year == dat.Year && b.BillDate.Value.Month==dat.Month && b.BillDate.Value.Day == dat.Day
                      select b).ToList();
            return lst;
        }

        public static int  GetMaxBill()
        {
            int xid;
           db = new DbDataContext();db.CommandTimeout = 9000;
            xid  = (from b in db.Bills
                      select b.ID).Max();
            return xid ;
        }
    }
}
