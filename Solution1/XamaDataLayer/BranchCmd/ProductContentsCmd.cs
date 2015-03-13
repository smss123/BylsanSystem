using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public class ProductContentsCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddProductContents(ProductContent tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.ProductContents.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Product Content ", " Add New Product Content ");
            return true;
        }
        public static ProductContent EditContents(ProductContent tb, int xid)
        {
        db = new DbDataContext();db.CommandTimeout = 9000;db.CommandTimeout = 9000;db.CommandTimeout = 9000;db.CommandTimeout = 9000;
            var q = db.ProductContents.Where(p => p.ID == xid).SingleOrDefault();
            q.ProductID = tb.ProductID;
            q.Qty = tb.Qty;
            q.ContentsProductID = tb.ContentsProductID;
            q.unitOfProduct = tb.unitOfProduct;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Product Content ", " Edit Selected  Product Content ");
            return q;
        }

        public static void DeleteContents(int xid)
        {
         db = new DbDataContext();db.CommandTimeout = 9000;db.CommandTimeout = 9000;db.CommandTimeout = 9000;
            var q = db.ProductContents.Where(p => p.ID == xid).SingleOrDefault();
            db.ProductContents.DeleteOnSubmit(q);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Product Content ", " Delete Product Content ");
        }


        public static List<ProductContent> GetAllProductConentsByProductID(int XID )
        {
         db = new DbDataContext();db.CommandTimeout = 9000;db.CommandTimeout = 9000;db.CommandTimeout = 9000;
            var lst = (from c in db.ProductContents
                        where c.ProductID == XID
                        select c).ToList();
            return lst;
        }

        public static List<ProductContent> GetAllProductConentsByContentsProductID(int XID)
        {
         db = new DbDataContext();db.CommandTimeout = 9000;db.CommandTimeout = 9000;db.CommandTimeout = 9000;
            var lst = (from c in db.ProductContents
                        where c.ContentsProductID == XID
                        select c).ToList();
            return lst;
        }
    }
}
