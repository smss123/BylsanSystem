using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.SellSystem
{
   public static  class SellStoreCmd
    {

       static DbDataContext db = new DbDataContext();
       public static bool AddSellStore(SellStore tb)
       {
           db = new DbDataContext();
           db.SellStores.InsertOnSubmit(tb);
           db.SubmitChanges();

           return true;
       }

       // 

       // Edit Informations 

       public static SellStore EditSellStore(SellStore tb, int xid)
       {
           db = new DbDataContext();
           var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
           sll.ItemID = tb.ItemID;
           sll.Qty = tb.Qty;
           db.SubmitChanges();
           return sll;
       }


       // Add New Qty
       public static SellStore EditQtyInSellStore(SellStore tb, int xid)
       {
           db = new DbDataContext();
           var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
           sll.ItemID = tb.ItemID;
           sll.Qty += tb.Qty;
           db.SubmitChanges();
           return sll;
       }
       // Sales 
       public static SellStore Sales_EditQtyInSellStore(SellStore tb, int xid)
       {
           db = new DbDataContext();
           var sll = db.SellStores.Where(s => s.ID == xid).SingleOrDefault();
           sll.ItemID = tb.ItemID;
           sll.Qty = tb.Qty;
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
           var lst = (from i in db.SellStores where i.ItemID == ItmId select i).Single();
           return lst;
       }

    }
}
