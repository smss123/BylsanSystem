using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XamaDataLayer.SellSystem
{
    public static  class SellStoreCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddSellStore(SellStore tb)
        {
            db = new DbDataContext();
            db.SellStores.InsertOnSubmit(tb);
            db.SubmitChanges();

            return true;
        }





        public static SellStore EditSellStore(SellStore tb, int xid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
            sll.ItemID = tb.ItemID;
            sll.Qty = tb.Qty;
            sll.branchID = tb.branchID;
            db.SubmitChanges();
            return sll;
        }



        public static SellStore EditQtyInSellStore(SellStore tb, int xid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
            sll.ItemID = tb.ItemID;
            sll.Qty += tb.Qty;
            sll.branchID = tb.branchID;
            db.SubmitChanges();
            return sll;
        }

        public static SellStore Sales_EditQtyInSellStore(SellStore tb, int xid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
            sll.ItemID = tb.ItemID;
            sll.Qty = tb.Qty;
            sll.branchID = tb.branchID;
            db.SubmitChanges();
            return sll;
        }
        public static void DeleteSellStore(int xid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
            db.SellStores.DeleteOnSubmit(sll);
            db.SubmitChanges();
        }

        public static List<SellStore> GetAllSellStore()
        {
            db = new DbDataContext();
            return db.SellStores.ToList();
        }

        public static SellStore GetSellStoreByItemID( int ItmId)
        {
            db = new DbDataContext();
             var lst = (from i in db.SellStores
                        where i.ItemID == ItmId
                        select i).Single();
            return lst;
        }

        public static void EditQty(int productID, int branchID, long editedQty)
        {
            var q = new SellStore();
            try
            {
                 q = db.SellStores.Where(p => p.ItemID == productID && p.branchID == branchID).Take(1).Single();

                int qty = int.Parse( q.Qty.Value.ToString());
                if (editedQty > qty)
                {
                   if( MessageBox.Show("Your product not availble in your store\n you want to continue ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                   {
                       q.Qty = qty - editedQty;
                       db.SubmitChanges();
                   }
                }
               

            }
            catch (Exception)
            {

                throw new Exception("Your product not availble in your store");
            }
        }
    }
}
