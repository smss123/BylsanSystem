using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public class QuotationCmd:ApiCounter
    {
    


        public static bool AddQuotation(Quotation tb)
        {
            
            db.CommandTimeout = 9000;
            db.Quotations.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Quotation  ", " Add Quotation's Informations  ");

            return true;
        }

        public static Quotation EditQuotation(Quotation tb, int xid)
        {
            db.CommandTimeout = 9000;
            var q = db.Quotations.Where(qq => qq.ID == xid).SingleOrDefault();
            q.PhoneNumber = tb.PhoneNumber;
            q.QuotationFor = tb.QuotationFor;
            q.CreatedDate = tb.CreatedDate;
            q.AddressFor = tb.AddressFor;

            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit ", " Quotation  ", " Edit Quotation's Informations  ");
            return q;
        }

        public static void DeleteQuotation(int xid)
        {
           db.CommandTimeout = 9000; 
            var q = db.Quotations.Where(qq => qq.ID == xid).SingleOrDefault();
            db.Quotations.DeleteOnSubmit(q);

            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Quotation  ", "Delete Quotation's Informations  ");
        }



        public static List<Quotation> GetAllQuotations()
        {
          db = new DbDataContext();db.CommandTimeout = 9000;db.CommandTimeout = 9000;
            return   db.Quotations.ToList();
        }
    }
}
