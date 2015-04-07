using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public    class StoreCmd:ApiCounter
    {
       
        public static bool AddNewStore(Store  tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.Stores.InsertOnSubmit(tb);

            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Store ", " Add New Store At Main Store ");

            return true;
        }

        public static Store EditStore(Store tb)
        {
             
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
               
                db.CommandTimeout = 9000;
                var com = CompiledQuery.Compile(
                            (DbDataContext dbx) =>
                                 (from i in dbx.Stores
                                  where i.ProductID == ItmId
                                  orderby i.ID ascending
                                  select i).Single()
                             );
                {
                    db = new DbDataContext();
                }
                db.CommandTimeout = 9000;

                return com(db);
                
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
            var com = CompiledQuery.Compile(
                        (DbDataContext dbx) =>
                            (from i in dbx.Stores
                             where i.ProductID == ItmId
                             select i)
                         );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).Single();

             
        }




        public static List< Store > GetAllStores()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var com = CompiledQuery.Compile(
                        (DbDataContext dbx) =>
                            dbx.Stores
                         );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
        }
    }
}
