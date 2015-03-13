using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public static  class CategoriesCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddCategory(ProductCategory tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.ProductCategories.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Add Category ", " Add New Category At Branch  ");
            return true;
        }


        public static int  GetCategoryIDByName(string CategName)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var   categ = db.ProductCategories.Where(cat => cat.ProductCategoryName == CategName ).SingleOrDefault();
            var xCategId = 0;
            xCategId = categ.ID;
            return xCategId;
        }
        public static bool EditCategory(ProductCategory tb, int xid)
        {
            db = new DbDataContext();
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
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            return db.ProductCategories.ToList();
        }
        public static void DeleteCategory(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var categ = db.ProductCategories.Where(cat => cat.ID == xid).SingleOrDefault();
            db.ProductCategories.DeleteOnSubmit(categ);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete Category ", " Delete Selected  Category's Informations  From  Branch  ");
        }
    }
}
