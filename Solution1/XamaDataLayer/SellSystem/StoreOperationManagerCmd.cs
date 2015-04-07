using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.SellSystem
{
    public static  class StoreOperationManagerCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddStoreOperationManager(StoreOperationManager tb)
        {
            tb.ID = ApiCounter.GetNumber();
            db.CommandTimeout = 9000;
            db.StoreOperationManagers.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }


        public static StoreOperationManager  EditStoreOperationManager( StoreOperationManager  tb, int xid)
        {
            db.CommandTimeout = 9000;
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
            db.CommandTimeout = 9000;
            var storMang = db.StoreOperationManagers.Where(s => s.ID == xid).SingleOrDefault();
            db.StoreOperationManagers.DeleteOnSubmit(storMang);
            db.SubmitChanges();
        }



        public static List<StoreOperationManager> GetAllStoreOperationManager()
        {

           db.CommandTimeout = 9000;
            return db.StoreOperationManagers.ToList();
        }

        public static List<StoreOperationManager> GetAllStoreOperationManagerByDate( DateTime dat )
        {

            var com = CompiledQuery.Compile(
                    (DbDataContext dbx) =>
             (from s in dbx.StoreOperationManagers
              orderby s.ID ascending
              where s.ProcessDate == dat
              select s)
                 );
               {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();
         
        }

        public static List<StoreOperationManager> GetAllStoreOperationManagerByUserID( int usrId)
        {
            var com = CompiledQuery.Compile(
                 (DbDataContext dbx) =>
          (from s in dbx.StoreOperationManagers
           orderby s.ID ascending
           where s.UserID == usrId
           select s)
              );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
        }
        public static List<StoreOperationManager> GetAllStoreOperationManagerByStoreID(int StorId)
        {
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
          (from s in dbx.StoreOperationManagers
           orderby s.ID ascending
           where s.StoreID == StorId
           select s)
             );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
        }
    }
}
