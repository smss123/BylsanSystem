using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
    public   class StoreManagerCmd
    {

        static DbDataContext db = new DbDataContext();
        public static bool AddStoreManager(StoreManager tb)
        {
            db = new DbDataContext();
            db.StoreManagers.InsertOnSubmit(tb);
            db.SubmitChanges();
            return  true ;
        }

        public StoreManager EditStoreManager(StoreManager tb, int xid)
        {
            db = new DbDataContext();

            var q = db.StoreManagers.Where(p => p.ID == xid).SingleOrDefault();

            q.Price = tb.Price;
            q.QtyInOrOut = tb.QtyInOrOut;
            q.StoreID = tb.StoreID;
            q.DateOfProcess = tb.DateOfProcess;
            q.ProcessType = tb.ProcessType;
            q.Description = tb.Description;

            return q;
        }

        public void DeleteStoreManagerAt(int xid)
        {
            try
            {
                db = new DbDataContext();
                var q = db.StoreManagers.Where(p => p.ID == xid).SingleOrDefault();
                db.StoreManagers.DeleteOnSubmit(q);
           
            }
            catch (Exception)
            {     
            }
        }

        public static List<StoreManager> GetAllStoreManager()
        {
            db = new DbDataContext();
            return db.StoreManagers.ToList();
        }

        public static List<StoreManager> GetAllStoreManagerByStoreID( int STorId)
        {
            db = new DbDataContext();
            var lst = (from m in db.StoreManagers
                       orderby m.DateOfProcess ascending
                       where m.StoreID == STorId
                       select m).ToList();
            return lst;
        }

        public static List<StoreManager> GetAllStoreManagerByProcessType( string Procctype)
        {
            db = new DbDataContext();
            var lst = (from m in db.StoreManagers
                       orderby m.DateOfProcess ascending
                       where m.ProcessType == Procctype  
                       select m).ToList();
            return lst;
        }

    }
}
