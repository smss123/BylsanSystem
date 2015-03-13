using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public static  class OrdersCmd
    {
        private static DbDataContext db = new DbDataContext();


        public static bool AddNewOrder(Order tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.Orders.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Add Order ", " Add New Order ");
            return true;
        }

        public static Order EditOrderStatusOnly(Order tb, int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var ord = db.Orders.Where(oo => oo.ID == xid).SingleOrDefault();
            ord.OrderStatus = tb.OrderStatus;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", "Edit  Order ", " Edit Selected  Order ");

            return ord;
        }

        public static Order EditFullOrder(Order tb, int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
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
            ord.OrderDate = tb.OrderDate;
            ord.OrderDeliveryDate = tb.OrderDeliveryDate;
            ord.DeliverdToBranch = tb.DeliverdToBranch;

            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", "Edit  Order ", " Edit Selected  Order ");
            return ord;
        }


        public static void DeleteOrder(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var ord = db.Orders.Where(oo => oo.ID == xid).SingleOrDefault();
            db.Orders.DeleteOnSubmit(ord);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete  Order ", " Delete Selected  Order ");
        }


        public static List<Order> GetAllOrders()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            return db.Orders.ToList();
        }

        public static List<Order> GetAllOrdersInDesigner()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var Lst = (from o in db.Orders
                      orderby o.OrderDate ascending
                      where
                          o.OrderStatus == "In Designer"
                      select o).ToList();
            return Lst;
        }

        public static List<Order> GetAllOrderByID( int xid  )
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var Lst = (from o in db.Orders
                      where
                          o.ID == xid
                      select o).ToList();
            return Lst;
        }


        public static List<Order> GetAllOrdersByBranchID(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
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
            db.CommandTimeout = 9000;
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
            db.CommandTimeout = 9000;
            var Lst = (from o in db.Orders
                      orderby o.OrderDate ascending
                      where
                          o.OrderDate == dat
                      select o).ToList();
            return Lst;
        }

        public static List<Order> GetOrdersByCustomerPhone(string phone)
        {
            db.CommandTimeout = 9000;
            return db.Customers.Where(p => p.PhoneNumber == phone).Take(1).Single().Orders.ToList();
        }
    }
}
