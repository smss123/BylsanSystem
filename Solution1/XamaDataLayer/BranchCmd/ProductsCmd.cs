using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class ProductsCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddProduct(Product tb)
       {
           db = new DbDataContext();
           db.Products.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }


       public static bool EditProduct(Product tb, int xid) {
           db = new DbDataContext();
           var prd = db.Products.Where(pp => pp.ID == xid).SingleOrDefault();
           prd.Product_Name = tb.Product_Name;
           prd.Product_Description = tb.Product_Description;
           prd.CateogryID = tb.CateogryID;
           prd.Img = tb.Img;
           db.SubmitChanges();
           return true;
           }
       public static void DeleteProduct(int xid)
       {
          
           db = new DbDataContext();
           var prd = db.Products.Where(pp => pp.ID == xid).SingleOrDefault();
           db.Products.DeleteOnSubmit(prd);
           db.SubmitChanges();
          
       }
       public static List<Product> GetAllProducts()
       {
           db = new DbDataContext();
           return db.Products.ToList();

       }

       public static List<Product> GetProductByID(int XID)
       {
           db = new DbDataContext();
           var LST = (from p in db.Products
                      where
                          p.ID == XID
                      select p).ToList();
           return LST;

       }

       public static List<Product> GetProductByCategID(int CategID)
       {
           db = new DbDataContext();
           var LST = (from p in db.Products
                      where
                          p.CateogryID == CategID 
                      select p).ToList();
           return LST;

       }
    }
}
