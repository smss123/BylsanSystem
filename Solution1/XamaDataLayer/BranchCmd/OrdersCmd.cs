using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class OrdersCmd
    {

       static DbDataContext db = new DbDataContext();
       public static bool AddNewOrder(Order tb)
       {
           db = new DbDataContext();
           db.Orders.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public static Order EditOrder(Order tb, int xid)
       {
           db = new DbDataContext();
           var ord = db.Orders.Where(oo => oo.ID == xid).SingleOrDefault();

           ord.Branch_ID = tb.Branch_ID;
           ord.CustomerID = tb.CustomerID;
           ord.OrderName = tb.OrderName;
           ord.OrderType = tb.OrderType;
           ord.OrderVerify = tb.OrderVerify;
           ord.OrderDelivery = tb.OrderDelivery;
           ord.Comment = tb.Comment;
           ord.OrderStatus = tb.OrderStatus;
           ord.TotalAmount = tb.TotalAmount;
           ord.OrderAccount = tb.OrderAccount;
           ord.OrderDate = tb.OrderDate;
           ord.OrderDeliveryDate = tb.OrderDeliveryDate;
           ord.DeliverdToBranch = tb.DeliverdToBranch;

           db.SubmitChanges();
           return ord;
       }

       public static void DeleteOrder(int xid)
       {
          
           db = new DbDataContext();
           var ord = db.Orders.Where(oo => oo.ID == xid).SingleOrDefault();
           db.Orders.DeleteOnSubmit(ord);
           db.SubmitChanges();
          
       }


       public static List<Order> GetAllOrders()
       {
           db = new DbDataContext();
           return db.Orders.ToList();
       }


       public static List<Order> GetAllOrderByID( int xid  )
       {
           db = new DbDataContext();
           var Lst = (from o in db.Orders
                      where
                          o.ID == xid
                      select o).ToList();
           return Lst;
       }


       public static List<Order> GetAllOrdersByBranchID(int xid)
       {
           db = new DbDataContext();
           var Lst = (from o in db.Orders
                      orderby o.OrderDate ascending 
                      where
                          o.Branch_ID == xid
                      select o).ToList();
           return Lst;
       }

       public static List<Order> GetAllOrdersByCustomerID(int xid)
       {
           db = new DbDataContext();
           var Lst = (from o in db.Orders
                      orderby o.OrderDate ascending 
                      where
                          o.CustomerID  == xid
                      select o).ToList();
           return Lst;
       }

       public static List<Order> GetAllOrdersByDate(DateTime dat)
       {
           db = new DbDataContext();
           var Lst = (from o in db.Orders
                      orderby o.OrderDate ascending
                      where
                          o.OrderDate == dat 
                      select o).ToList();
           return Lst;
       }

    }
   

}
