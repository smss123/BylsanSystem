using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
   public  static  class ItemsCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddNewItem(Item tb)
       {
           db = new DbDataContext();
           db.Items.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public  Item  EditItem(Item tb , int xid )
       {
           db = new DbDataContext();
           var q = db.Items.Where(i => i.ID == xid).SingleOrDefault();
           q.ItemName = tb.ItemName;
           q.ItemDescription = tb.ItemDescription;
           q.ItemType = tb.ItemType;
           db.SubmitChanges();
           return q;
       }


       public void DeleteItemAt(int xid)
       {
           try
           {

               var q = db.Items .Where(p => p.ID == xid).SingleOrDefault();
               db.Items .DeleteOnSubmit(q);
               db.SubmitChanges();
           }
           catch (Exception)
           {


           }
       }

       public static List<Item> GetAllItems() { 
           
           db = new DbDataContext();
           return db.Items.ToList();

       }
    }
}
