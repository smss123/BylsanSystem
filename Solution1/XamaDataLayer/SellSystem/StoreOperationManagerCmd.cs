using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.SellSystem
{
   public static  class StoreOperationManagerCmd
    {

       static DbDataContext db = new DbDataContext();
       public static bool AddStoreOperationManager(StoreOperationManager tb)
       {
           db = new DbDataContext();
           db.StoreOperationManagers.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }


       public static StoreOperationManager  EditStoreOperationManager( StoreOperationManager  tb, int xid)
       {
           db = new DbDataContext();
           var storMang = db.StoreOperationManagers.Where(s => s.ID == xid).SingleOrDefault();

           storMang.StoreID = tb.StoreID;
           storMang.UserID = tb.UserID;
           storMang.ProcessDate = tb.ProcessDate;
           storMang.ProcessType = tb.ProcessType;
           storMang.Qty = tb.Qty;

           db.SubmitChanges();
           return storMang;
       }

       public static void DeleteStoreOpertionManager(int xid)
       {
         
           db = new DbDataContext();
           var storMang = db.StoreOperationManagers.Where(s => s.ID == xid).SingleOrDefault();
           db.StoreOperationManagers.DeleteOnSubmit(storMang);
           db.SubmitChanges();
          
       }


       //===============================================================================
       public static List<StoreOperationManager> GetAllStoreOperationManager()
       {
           db = new DbDataContext();
           return db.StoreOperationManagers.ToList();
       }

       public static List<StoreOperationManager> GetAllStoreOperationManagerByDate( DateTime dat )
       {
           db = new DbDataContext();
           var lst = (from s in db.StoreOperationManagers
                      orderby s.ID ascending
                      where s.ProcessDate == dat
                      select s).ToList();
           return lst;
       }

       public static List<StoreOperationManager> GetAllStoreOperationManagerByUserID( int usrId)
       {
           db = new DbDataContext();
           var lst = (from s in db.StoreOperationManagers
                      orderby s.ID ascending
                      where s.UserID == usrId 
                      select s).ToList();
           return lst;
       }
       public static List<StoreOperationManager> GetAllStoreOperationManagerByStoreID(int StorId)
       {
           db = new DbDataContext();
           var lst = (from s in db.StoreOperationManagers
                      orderby s.ID ascending
                      where s.StoreID == StorId 
                      select s).ToList();
           return lst;
       }
    }
}
