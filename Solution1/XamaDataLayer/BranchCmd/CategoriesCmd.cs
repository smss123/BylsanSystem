using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class CategoriesCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddCategory(ProductCategory tb)
       {
           db = new DbDataContext();
           db.ProductCategories.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }


       public static int  GetCategoryIDByName(string CategName)
       {
           db = new DbDataContext();
           var   categ = db.ProductCategories.Where(cat => cat.ProductCategoryName == CategName ).SingleOrDefault();
           int xCategId = 0;
           xCategId = categ.ID;
           return xCategId;
       }
       public static bool EditCategory(ProductCategory tb, int xid)
       {
           db = new DbDataContext();
           var categ = db.ProductCategories.Where(cat => cat.ID == xid).SingleOrDefault();
           categ.ProductCategoryName = tb.ProductCategoryName;
           categ.Description = tb.Description;
           db.SubmitChanges();
           return true;
       }
       public static List<ProductCategory> GetAllCategories()
       {
           db = new DbDataContext();
           return db.ProductCategories.ToList();

       }
       public static void DeleteCategory(int xid)
       {
          
           db = new DbDataContext();
           var categ = db.ProductCategories.Where(cat => cat.ID == xid).SingleOrDefault();
           db.ProductCategories.DeleteOnSubmit(categ);
           db.SubmitChanges();
           
       }

      

    }
}
