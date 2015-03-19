using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public    class ProductsCmd:ApiCounter
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddProduct(Product tb)
        {
            db.CommandTimeout = 9000;
            db.Products.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Product  ", " Add New Product");
            return true;
        }


        public static bool EditProduct(Product tb, int xid)
        {
            db.CommandTimeout = 9000;
            var prd = db.Products.Where(pp => pp.ID == xid).SingleOrDefault();
            prd.Product_Name = tb.Product_Name;
            prd.Product_Description = tb.Product_Description;
            prd.CateogryID = tb.CateogryID;
            prd.Img = tb.Img;
            prd.PublicName = tb.PublicName;
            prd.ProductPrice = tb.ProductPrice;
            prd.ProductUnit = tb.ProductUnit;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Product  ", " Edit Selected Product's Informations  ");
            return true;
        }
        public static void DeleteProduct(int xid)
        {
            db.CommandTimeout = 9000;
            var prd = db.Products.Where(pp => pp.ID == xid).SingleOrDefault();
            db.Products.DeleteOnSubmit(prd);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Product  ", " Delete Selected Product's Informations  ");
        }
        public static List<Product> GetAllProducts()
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            return db.Products.ToList();
        }

        public static List<Product> GetAllProducts(bool p)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
         var q = (from i in db.Products select new { i.PublicName, i.ProductPrice, i.ID });
         List<Product> ls = new List<Product>();
         foreach (var item in q)
         {
             ls.Add(new Product() { 
              ID= item.ID,
               ProductPrice=item.ProductPrice,
                PublicName= item.PublicName
             
             });  
         }
         q = null;
         db.Dispose();
         return ls;
        }

        public static List<Product> GetProductByID(int XID)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var LST = (from p in db.Products
                      where
                          p.ID == XID
                      select p).ToList();
            return LST;
        }

        public static List<Product> GetProductByCategID(int CategID)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var LST = (from p in db.Products
                      where
                          p.CateogryID == CategID
                      select p).ToList();
            return LST;
        }
        public static List<Product> GetProductDetailsForSale()
        {
            db = new DbDataContext();
            var q = (from i in db.Products where i.ProductType=="product" select new {i.ID, i.Product_Name,i.PublicName,i.ProductPrice,i.ProductUnit,i.ProductType});
            List<Product> ls = new List<Product>();
            foreach (var item in q)
            {
                ls.Add(new Product() { 
                 ID= item.ID,
                  PublicName= item.PublicName,
                   ProductType=item.ProductType,
                    ProductUnit=item.ProductUnit,
                    Product_Name=item.Product_Name,
                    ProductPrice =item.ProductPrice
                      
                });
            }
            return ls;
        }
    }
}
