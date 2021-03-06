﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public  class StoreSalesCmd:ApiCounter
    {
      

        public static bool AddNewSales(Store_Sell tb)
        {
            tb.ID = GetNumber();
            db.Store_Sells.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add sell store ", " Add new sell store    At Main Store ");

            return true;
        }

        public Store_Sell EditStore_Sell(Store_Sell tb, int xid)
        {
             
            var q = db.Store_Sells .Where(i => i.ID == xid).SingleOrDefault();
            q.UserID = tb.UserID;
            q.Price = tb.Price;
            q.SupplierID = tb.SupplierID;
            q.UnitPrice = tb.UnitPrice;
            q.DateOfProcess = tb.DateOfProcess;
            q.Comment = tb.Comment;
            q.ProductID = tb.ProductID;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", " Edit  sell store ", " Edit selected  sell store    At Main Store ");
            return q;
        }
        public void DeleteStore_SellAt(int xid)
        {

          

                var q = db.Store_Sells.Where(p => p.ID == xid).SingleOrDefault();
                db.Store_Sells.DeleteOnSubmit(q);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete sell store ", " Delete selected  sell store  from  Main Store ");
             
        }





        public static List<Store_Sell> GetAllSTore_Sell()
        {
            var com = CompiledQuery.Compile(
            (DbDataContext dbx) =>
                db.Store_Sells
            );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
           
        }

        public static List<Store_Sell> GetAllSTore_SellByUserID( int xid)
        {
            var com = CompiledQuery.Compile(
           (DbDataContext dbx) =>
              (from s in dbx.Store_Sells
               orderby s.DateOfProcess ascending
               where s.UserID == xid
               select s)
           );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();

            
        }

        public static List<Store_Sell> GetAllSTore_SellBySupplierID(int xid)
        {
            var com = CompiledQuery.Compile(
          (DbDataContext dbx) =>
             (from s in dbx.Store_Sells
              orderby s.DateOfProcess ascending
              where s.SupplierID == xid
              select s)
          );
            {
                db = new DbDataContext();
            }
            db.CommandTimeout = 9000;

            return com(db).ToList();
        }



        public static Store_Sell GetAllSTore_SellByItemID(int xid)
        {
            db = new DbDataContext();
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending
                       where s.ProductID  == xid
                       select s).Single ();
            return lst;
        }

        public static List<Store_Sell> GetAllSTore_SellByDate(DateTime dat)
        {
            db = new DbDataContext();
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending
                       where s.DateOfProcess == dat
                       select s).ToList();
            return lst;
        }
    }
}
