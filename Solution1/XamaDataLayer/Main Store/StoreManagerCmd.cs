﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public   class StoreManagerCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddStoreManager(StoreManager tb)
        {
            db = new DbDataContext();
            db.StoreManagers.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Store Manager", " Add new store manager   At Main Store ");

            return  true ;
        }

        public static StoreManager EditStoreManager(StoreManager tb)
        {
            db = new DbDataContext();

            var q = db.StoreManagers.Where(p => p.ID == tb.ID).SingleOrDefault();
            q.ID = tb.ID;
            q.Price = tb.Price;
            q.QtyInOrOut = tb.QtyInOrOut;
            q.StoreID = tb.StoreID;

            q.ProcessType = tb.ProcessType;
            q.Description = tb.Description;
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Edit  Store Manager", " Edit selected  store manager   At Main Store ");
            return q;
        }

        public void DeleteStoreManagerAt(int xid)
        {
            try
            {
                db = new DbDataContext();
                var q = db.StoreManagers.Where(p => p.ID == xid).SingleOrDefault();
                db.StoreManagers.DeleteOnSubmit(q);
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete Store Manager", "  Delete Selected  store manager   At Main Store ");
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
