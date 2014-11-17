﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
    public static  class StoreManagerCmd
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
            return db.StoreManagers.ToList();
        }


    }
}
