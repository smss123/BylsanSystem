using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public    class CategoriesCmd:ApiCounter
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddCategory(ProductCategory tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.ProductCategories.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Add Category ", " Add New Category At Branch  ");
            return true;
        }


       
        public static bool EditCategory(ProductCategory tb, int xid)
        {
            
            db.CommandTimeout = 9000;
            var categ = db.ProductCategories.Where(cat => cat.ID == xid).SingleOrDefault();
            categ.ProductCategoryName = tb.ProductCategoryName;
            categ.Description = tb.Description;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", "Edit Category ", " Edit Selected  Category's Informations  At Branch  ");
            return true;
        }
        public static List<ProductCategory> GetAllCategories()
        {
            var com = CompiledQuery.Compile(
                (DbDataContext dbx) =>
                 dbx.ProductCategories 
         );
            db.CommandTimeout = 9000;
            return com(db).ToList();

           
        }
        public static void DeleteCategory(int xid)
        {
            
            db.CommandTimeout = 9000;
            var categ = db.ProductCategories.Where(cat => cat.ID == xid).SingleOrDefault();
            db.ProductCategories.DeleteOnSubmit(categ);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete Category ", " Delete Selected  Category's Informations  From  Branch  ");
        }
    }
}
