using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.SellSystem
{
    public    class BillItemsCmd:ApiCounter
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddBillItmes(BillItem tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.BillItems.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="tb"> أدخل أسم الجدول يا محمد</param>
        /// <param name="xid">أدخل رقم السجل</param>
        /// <param name="bllId">أدخل رقم سجل الفاتورة </param>
        /// <returns></returns>
        public static BillItem EditBillItems(BillItem tb, int xid, int bllId)
        {
             
            db.CommandTimeout = 9000;
            var bl = db.BillItems.Where(b => b.ID == xid && b.Bill_ID == bllId).SingleOrDefault();
            bl.Bill_ID = tb.Bill_ID;
            bl.ProductID = tb.ProductID;
            bl.Qty = tb.Qty;
            db.SubmitChanges();
            return bl;
        }

        public static void DeleteAt(int xid)
        {
             
            db.CommandTimeout = 9000;
            var bl = db.BillItems.Where(b => b.ID == xid ).SingleOrDefault();
            db.BillItems.DeleteOnSubmit(bl);
            db.SubmitChanges();
        }

        public static List<BillItem> LoadAllBillItemsByBill_ID(int bllId)
        {
            var com = CompiledQuery.Compile(
          (DbDataContext dbx) =>
              (from i in dbx.BillItems
               orderby i.ProductID ascending
               where i.Bill_ID == bllId
               select i)
          );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
        }
    }
}
