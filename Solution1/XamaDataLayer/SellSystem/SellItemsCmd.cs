using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.SellSystem
{
   public static  class SellItemsCmd
    {
       static DbDataContext db = new DbDataContext();
      
       public static bool AddSellItems(SellItem tb)
       {
           db = new DbDataContext();
           db.SellItems.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }


       public static SellItem EditSellItem(SellItem tb, int xid)
       {
           db = new DbDataContext();
           var sell = db.SellItems.Where(s => s.ID == xid).SingleOrDefault();

           sell.ItemName = tb.ItemName;
           sell.ItemPrice = tb.ItemPrice;
           sell.Description = tb.Description;

           db.SubmitChanges();
           return sell;
       }

       public static void DeleteSellItem(int xid)
       {
           try
           {
           db = new DbDataContext();
           var sell = db.SellItems.Where(s => s.ID == xid).SingleOrDefault();

           db.SellItems.DeleteOnSubmit(sell);

           db.SubmitChanges();
          
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       // == Loading Data 
       public static List<SellItem> GetAllSellItems() {
           db = new DbDataContext();
           var lst = (from i in db.SellItems select i).ToList();
           return lst;
       }

       public static SellItem GetSellItemByName(string ItmName)
       {
           db = new DbDataContext();
           var lst = (from i in db.SellItems
                      orderby i.ID ascending
                      where i.ItemName == ItmName
                      select i).Single();
           return lst;
       }


       public static List<SellStore> GetSellStoreByItemID(int ItmId)
       {
           db = new DbDataContext();
           var lst = (from i in db.SellStores where i.ItemID == ItmId select i).ToList();
           return lst;
       }

       public static List<SellItem> GetSellItemByID(int  ItmId)
       {
           db = new DbDataContext();
           var lst = (from i in db.SellItems
                      orderby i.ID ascending
                      where i.ID == ItmId 
                      select i).ToList();
           return lst;
       }

    }
}
