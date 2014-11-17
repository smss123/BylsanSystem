﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
   public static  class SuppliersCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddNewSupplier(Supplier tb)
       {
           db = new DbDataContext();
           db.Suppliers.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public Supplier EditSupplier(Supplier tb, int xid)
       {
           db = new DbDataContext();
           var q = db.Suppliers.Where(d => d.ID == xid).SingleOrDefault();
           q.SupplierName = tb.SupplierName;
           q.SupplierPhone = tb.SupplierPhone;
           q.Address = tb.Address;
           q.Description = tb.Description;
           db.SubmitChanges();
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
