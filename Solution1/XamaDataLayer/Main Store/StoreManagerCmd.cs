﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public   class StoreManagerCmd:ApiCounter
    {
     
        public static bool AddStoreManager(StoreManager tb)
        {
            tb.ID = GetNumber();
            db.StoreManagers.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Store Manager", " Add new store manager   At Main Store ");
            db.SubmitChanges();
            return  true ;
        }

        public static StoreManager EditStoreManager(StoreManager tb)
        {
          

            var q = db.StoreManagers.Where(p => p.ID == tb.ID).SingleOrDefault();
            q.ID = tb.ID;
            q.Price = tb.Price;
            q.QtyInOrOut = tb.QtyInOrOut;
            q.StoreID = tb.StoreID;

            q.ProcessType = tb.ProcessType;
            q.Description = tb.Description;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Edit  Store Manager", " Edit selected  store manager   At Main Store ");

            return q;
        }

        public void DeleteStoreManagerAt(int xid)
        {
            
                
                var q = db.StoreManagers.Where(p => p.ID == xid).SingleOrDefault();
                db.StoreManagers.DeleteOnSubmit(q);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete Store Manager", "  Delete Selected  store manager   At Main Store ");
             
        }

        public static List<StoreManager> GetAllStoreManager()
        {
            db = new DbDataContext();
            return db.StoreManagers.ToList();
        }

        public static List<StoreManager> GetAllStoreManagerByStoreID( int STorId)
        {
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                     (from m in dbx.StoreManagers
                      orderby m.DateOfProcess ascending
                      where m.StoreID == STorId
                      select m)
                );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();
        }

        public static List<StoreManager> GetAllStoreManagerByProcessType( string Procctype)
        {
            var com = CompiledQuery.Compile(
               (DbDataContext dbx) =>
                   (from m in dbx.StoreManagers
                    orderby m.DateOfProcess ascending
                    where m.ProcessType == Procctype
                    select m)
               );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

         
        }
    }
}
