using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public    class OrderProductsCmd:ApiCounter
    {
     

        public static bool AddOrderProduct(OrderProduct tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.OrderProducts.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Order Product ", " Add New Order Product's Informations  ");
            return true;
        }

        public static OrderProduct EditOrderProduct(OrderProduct tb, int xid)
        {
            
                 
                db.CommandTimeout = 9000;
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
        public static OrderProduct EditOrderProductStatus(OrderProduct tb, int xid)
        {
             
            db.CommandTimeout = 9000;
            var ord = db.OrderProducts.Where(oo => oo.ID == xid).SingleOrDefault();
            ord.ProductID = tb.ProductID;
            ord.ImageX = tb.ImageX;
            ord.Status = tb.Status;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", "Edit  Order Product ", " Edit Selected Order Product's Informations  ");

            return ord;
        }
        public static void DeleteOrderProduct(int xid)
        {
             
            db.CommandTimeout = 9000;
            var ord = db.OrderProducts.Where(oo => oo.ID == xid).SingleOrDefault();

            db.OrderProducts.DeleteOnSubmit(ord);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete  Order Product ", "  Delete selected Order Product's Informations  ");
        }

        public static List<OrderProduct> GetAll()
        {
            var com = CompiledQuery.Compile(
             (DbDataContext dbx) =>
            (from c in dbx.OrderProducts
                                    where c.ID != 0
                                    select c).ToList()
                                        );
            db.CommandTimeout = 9000;
            return com(db);
        }

        public static List<OrderProduct> GetAllByOrderID( int XID )
        {
            var com = CompiledQuery.Compile(
              (DbDataContext dbx, int id) =>
             db.OrderProducts.Where(p => p.OrderID == id)
                                         );
            db.CommandTimeout = 9000;
            return com(db, XID).ToList();
             
        }

        public static List<OrderProduct> GetAllByProductID(int XID)
        {
              var com = CompiledQuery.Compile(
              (DbDataContext dbx, int id) =>
                    (from p in db.OrderProducts
                      orderby p.ID
                      where p.ProductID  == id
                      select p)
                                         );
            db.CommandTimeout = 9000;
            return com(db, XID).ToList();
             
           
        }

        public static OrderProduct GetOneByProductID(int XID)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var LST = (from p in db.OrderProducts
                       orderby p.ID
                       where p.ProductID == XID
                       select p).Single();
            return LST;
        }

        public static List<OrderProduct> GetOrderProductByCustomerPhone(  string Phon)
        {
            var com_ = CompiledQuery.Compile(
                
                (DbDataContext dbx,string ph)=>
                    dbx.Customers.Where(p => p.PhoneNumber == ph).Single()
            );
            var q = com_(db,Phon);
            var lst = new List<OrderProduct>();

            foreach (var item in q.Orders)
            {
                lst.AddRange(item.OrderProducts.ToList());
            }

            //db = new DbDataContext();
            //db.CommandTimeout = 9000;

            //var com = CompiledQuery.Compile(
            // (DbDataContext dbx, string  id) =>
            //       (from c in CustomersCmd.GetAllCustmers()
            //                                              where c.PhoneNumber == Phon
            //                                                select c).Single()
            //                            );
            //db.CommandTimeout = 9000;

            //var getcustomeridbyphone = com(db, Phon);

            //var CustmrID = getcustomeridbyphone.ID;

            //var com1 = CompiledQuery.Compile(
            // (DbDataContext dbx, int id) =>
            //       (from o in OrdersCmd.GetAllOrders()
            //                                           where  o.CustomerID == id
            //                                        select o).ToList ()
            //                            );

            //var GetAllOrders = com1(db,CustmrID);


            //var lst = new List<OrderProduct>();
            ////foreach (var item in  GetAllOrders)
            ////{
            ////    Lst = (from p in db.OrderProducts
            ////               orderby p.ID
            ////               where p.OrderID == item .ID
            ////               select p).ToList();
            ////}



            return lst;
        }
    }
}
