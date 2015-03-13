﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public    class StoreCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddNewStore(Store  tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.Stores.InsertOnSubmit(tb);

            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Store ", " Add New Store At Main Store ");

            return true;
        }

        public static Store EditStore(Store tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var q = db.Stores .Where(i => i.ID == tb.ID).SingleOrDefault();
            q.ID = tb.ID;
            q.AvailableQty = tb.AvailableQty;
            q.Description = tb.Description;
            q.ProductID = tb.ProductID;
          //  q.ItemID = tb.ItemID;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Edit Item", "  Edit selected  store At Main Store ");

            return q;
        }


        public static void DeleteStoreAt(int xid)
        {
            db.CommandTimeout = 9000;
            var q = db.Stores .Where(p => p.ID == xid).SingleOrDefault();
            db.Stores .DeleteOnSubmit(q);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete Item", " Delete  selected  store At Main Store ");
        }




        public static Store GetAvailableQtyByItemID(int ItmId)
        {
            try
            {
                db = new DbDataContext();
                db.CommandTimeout = 9000;
                var lst = (from i in db.Stores
                           where i.ProductID == ItmId
                           orderby i.ID ascending
                           select i).Single();
                return lst;
            }
            catch (Exception)
            {
                
                throw new Exception("this product not aviable in Stock");
            }
           
        }

        public static Store ChekByItemID(int ItmId)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var Rec = (from i in db.Stores
                       where i.ProductID == ItmId
                      select i).Single ();
            return Rec;
        }




        public static List< Store > GetAllStores()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            return db.Stores .ToList();
        }
    }
}
