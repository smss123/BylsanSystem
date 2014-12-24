using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public    class ItemsCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddNewItem(Item tb)
        {
            db = new DbDataContext();
            db.Items.InsertOnSubmit(tb);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Item", " Add New Item At Main Store ");

            return true;
        }

        public  static bool  EditItem(Item tb , int xid )
        {
            db = new DbDataContext();
            var q = db.Items.Where(i => i.ID == xid).SingleOrDefault();
            q.ItemName = tb.ItemName;
            q.ItemDescription = tb.ItemDescription;
            q.ItemType = tb.ItemType;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Edit Item", " Edit Selected Item At Main Store ");
            return true;
        }


        public static void DeleteItemAt(int xid)
        {
            try
            {
                var  tb = db.Items .Where(p => p.ID == xid).SingleOrDefault();
                db.Items .DeleteOnSubmit(tb);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete Item", " Delete selected Item At Main Store ");
            }
            catch (Exception)
            {
            }
        }

        public static Item ChekByName(string nam)
        {
            db = new DbDataContext();
            var xItem = (from c in db.Items
                          where c.ItemName == nam
                          select c).Single();
            return xItem;
        }
        public static List<Item> GetAllItems()
        {
            db = new DbDataContext();
            return db.Items.ToList();
        }
    }
}
