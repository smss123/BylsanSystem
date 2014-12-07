using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
   public    class StoreCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddNewStore(Store  tb)
       {
           db = new DbDataContext();
           db.Stores.InsertOnSubmit(tb);

           db.SubmitChanges();
           return true;
       }

       public static Store EditStore(Store tb)
       {
           db = new DbDataContext();
           var q = db.Stores .Where(i => i.ID == tb.ID).SingleOrDefault();
           q.ID = tb.ID;
           q.AvailableQty = tb.AvailableQty;
           q.Description = tb.Description;
           q.ItemID = tb.ItemID;
           db.SubmitChanges();
           return q;
       }


       public static void DeleteStoreAt(int xid)
       {
          

               var q = db.Stores .Where(p => p.ID == xid).SingleOrDefault();
               db.Stores .DeleteOnSubmit(q);
               db.SubmitChanges();
          
       }


       //===============================================================
      // Important Function : 
       public static List<Store> GetAvailableQtyByItemID(int ItmId)
       {
           db = new DbDataContext();
           var lst = (from i in db.Stores
                      where i.ItemID == ItmId
                      orderby i.ID ascending
                      select i).ToList();
           return lst;
       }
       //================================================================
       public static List< Store > GetAllStores()
       {

           db = new DbDataContext();
           return db.Stores .ToList();

       }
    }
}
