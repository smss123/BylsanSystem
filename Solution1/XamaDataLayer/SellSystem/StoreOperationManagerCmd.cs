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
           var StorMang = db.StoreOperationManagers.Where(s => s.ID == xid).SingleOrDefault();

           StorMang.StoreID = tb.StoreID;
           StorMang.UserID = tb.UserID;
           StorMang.ProcessDate = tb.ProcessDate;
           StorMang.ProcessType = tb.ProcessType;
           StorMang.Qty = tb.Qty;

           db.SubmitChanges();
           return StorMang;
       }

       public static void DeleteStoreOpertionManager(int xid)
       {
           try
           {
           db = new DbDataContext();
           var StorMang = db.StoreOperationManagers.Where(s => s.ID == xid).SingleOrDefault();
           db.StoreOperationManagers.DeleteOnSubmit(StorMang);
           db.SubmitChanges();
           }
           catch (Exception)
           {
               
               throw;
           }
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

    }
}
