﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class OrderProductsCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddOrderProduct(OrderProduct tb)
       {
           db = new DbDataContext();
           db.OrderProducts.InsertOnSubmit(tb);
           db.SubmitChanges();
           XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Order Product ", " Add New Order Product's Informations  ");
           return true;
       }

       public static OrderProduct EditOrderProduct(OrderProduct tb, int xid)
       {
           db = new DbDataContext();
           var ord = db.OrderProducts.Where(oo => oo.ID == xid).SingleOrDefault();
           ord.OrderID = tb.OrderID;
           ord.ProductID = tb.ProductID;
           ord.Qty = tb.Qty;
           ord.Description = tb.Description;
           ord.ImageX = tb.ImageX;

           db.SubmitChanges();
           XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", "Edit  Order Product ", " Edit Selected Order Product's Informations  ");

           return ord;
       }

       public static void DeleteOrderProduct(int xid)
       {
         
           db = new DbDataContext();
           var ord = db.OrderProducts.Where(oo => oo.ID == xid).SingleOrDefault();

           db.OrderProducts.DeleteOnSubmit(ord);
           db.SubmitChanges();
           XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete  Order Product ", "  Delete selected Order Product's Informations  ");
           
       }

       public static List<OrderProduct> GetAll()
       {
           db = new DbDataContext();
           var lst = (from c in db.OrderProducts where c.ID != 0 select c).ToList();
           return lst;
       }

       public static List<OrderProduct> GetAllByOrderID( int XID ) {
           db = new DbDataContext();
           var LST = (from p in db.OrderProducts
                      orderby p.ID
                      where p.OrderID == XID
                      select p).ToList();
           return LST;
       }

       public static List<OrderProduct> GetAllByProductID(int XID)
       {
           db = new DbDataContext();
           var LST = (from p in db.OrderProducts
                      orderby p.ID
                      where p.ProductID  == XID
                      select p).ToList();
           return LST;
       }



    }
}
