using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
    public static class StoreDrawalCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool AddDrawal(StoreWithDrawal tb)
        {
            db = new DbDataContext();
            db.StoreWithDrawals.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }


        public StoreWithDrawal EditStoreWithDrawal(StoreWithDrawal tb, int xid)
        {
            db = new DbDataContext();
            var q = db.StoreWithDrawals.Where(d => d.ID == xid).SingleOrDefault();
            q.ItemID = tb.ItemID;
            q.Qty = tb.Qty;
            q.DateOfProcess = tb.DateOfProcess;
            q.Comment = tb.Comment;
            q.UserID = tb.UserID;
            q.StoreID = tb.StoreID;
            db.SubmitChanges();
            return q;
        }

        public static void DeleteStoreDrawal(int xid)
        {
            try
            {
                db = new DbDataContext();
                var q = db.StoreWithDrawals.Where(d => d.ID == xid).SingleOrDefault();
                db.StoreWithDrawals.DeleteOnSubmit(q);
                db.SubmitChanges();

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public static List<StoreWithDrawal> GetAllStoreDrawal()
        {
            return db.StoreWithDrawals.ToList();
        }

        public static List<StoreWithDrawal> GetAllStoreDrawalByUserID( int XID )
        {
            var LST = (from u in db.StoreWithDrawals
                       orderby u.DateOfProcess ascending 
                       where u.UserID == XID
                       select u).ToList();
            return LST;
        }

        public static List<StoreWithDrawal> GetAllStoreDrawalByStoreID(int XID)
        {
            var LST = (from u in db.StoreWithDrawals
                       orderby u.DateOfProcess ascending
                       where u.StoreID == XID
                       select u).ToList();
            return LST;
        }

    }
}
