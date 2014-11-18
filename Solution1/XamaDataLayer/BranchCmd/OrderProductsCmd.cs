using System;
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
           return ord;
       }

       public static void DeleteOrderProduct(int xid)
       {
           try
           {
           db = new DbDataContext();
           var ord = db.OrderProducts.Where(oo => oo.ID == xid).SingleOrDefault();

           db.OrderProducts.DeleteOnSubmit(ord);
           db.SubmitChanges();
       
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public static List<OrderProduct> GetAll() { db = new DbDataContext(); return db.OrderProducts.ToList(); }

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
