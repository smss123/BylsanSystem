using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
    public class ProductContentsCmd
    {

        static DbDataContext db = new DbDataContext();
        public static bool AddProductContents(ProductContent tb)
        {
            db = new DbDataContext();
            db.ProductContents.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static ProductContent EditContents(ProductContent tb, int xid)
        {
            db = new DbDataContext();
            var q = db.ProductContents.Where(p => p.ID == xid).SingleOrDefault();
            q.ProductID = tb.ProductID;
            q.Qty = tb.Qty;
            q.ContentsProductID = tb.ContentsProductID;
            q.unitOfProduct = tb.unitOfProduct;
            db.SubmitChanges();
            return q;
        }

        public static void DeleteContents(int xid)
        {
            db = new DbDataContext();
            var q = db.ProductContents.Where(p => p.ID == xid).SingleOrDefault();
            db.ProductContents.DeleteOnSubmit(q);
            db.SubmitChanges();
        }
        //==================================================

        public static List<ProductContent> GetAllProductConentsByProductID(int XID ) {
            db = new DbDataContext();
            var lst = (from c in db.ProductContents where c.ProductID == XID select c).ToList();
            return lst;
        }

        public static List<ProductContent> GetAllProductConentsByContentsProductID(int XID)
        {
            db = new DbDataContext();
            var lst = (from c in db.ProductContents where c.ContentsProductID == XID select c).ToList();
            return lst;
        }

    }
}
