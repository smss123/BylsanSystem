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

       public static List<SellItem> GetAllSellItems() { db = new DbDataContext(); return db.SellItems.ToList(); }
    }
}
