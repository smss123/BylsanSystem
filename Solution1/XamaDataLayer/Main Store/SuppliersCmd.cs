using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Main_Store
{
    public   class SuppliersCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddNewSupplier(Supplier tb)
        {
            db = new DbDataContext();
            db.Suppliers.InsertOnSubmit(tb);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add Supplier ", " Add new Supplier ");
            return true;
        }

        public static Supplier EditSupplier(Supplier tb)
        {
            db = new DbDataContext();
            var q = db.Suppliers.Where(d => d.ID == tb.ID).SingleOrDefault();
            q.SupplierName = tb.SupplierName;
            q.SupplierPhone = tb.SupplierPhone;
            q.Address = tb.Address;
            q.Description = tb.Description;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", "EDIT  Supplier ", " Edit selected  Supplier ");

            return q;
        }

        public void DeleteSupplier(int xid)
        {
            try
            {
                db = new DbDataContext();
                var q = db.Suppliers.Where(d => d.ID == xid).SingleOrDefault();
                db.Suppliers.DeleteOnSubmit(q);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", "Delete  Supplier ", " Delete selected  Supplier ");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Supplier> GetAllSuppliers()
        {
            return db.Suppliers.ToList();
        }
    }
}
