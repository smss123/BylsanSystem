using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public  class StoreDrawalCmd:ApiCounter
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddDrawal(StoreWithDrawal tb)
        {
           
            db.StoreWithDrawals.InsertOnSubmit(tb);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Drawal", " Add New  Drawal  At Main Store ");

            return true;
        }


        public static StoreWithDrawal EditStoreWithDrawal(StoreWithDrawal tb)
        {
            
            var q = db.StoreWithDrawals.Where(d => d.ID == tb.ID).SingleOrDefault();
            q.ID = tb.ID;
            q.ProductID = tb.ProductID;
            q.Qty = tb.Qty;

            q.Comment = tb.Comment;
            q.UserID = tb.UserID;
            q.StoreID = tb.StoreID;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Edit Drawal", " Edit Selected Drawal  At Main Store ");
            return q;
        }

        public static void DeleteStoreDrawal(int xid)
        {
            try
            {
                
                var q = db.StoreWithDrawals.Where(d => d.ID == xid).SingleOrDefault();
                db.StoreWithDrawals.DeleteOnSubmit(q);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete Drawal", " Delete Selected Drawal  At Main Store ");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<StoreWithDrawal> GetAllStoreDrawals()
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
