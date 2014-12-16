using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
    public class QuotationCmd
    {
        static DbDataContext db = new DbDataContext();


        public static bool AddQuotation(Quotation tb)
        {
            db = new DbDataContext();
            db.Quotations.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Quotation  ", " Add Quotation's Informations  ");

            return true;
        }

        public static Quotation EditQuotation(Quotation tb, int xid)
        {
            db = new DbDataContext();
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
            db = new DbDataContext();
            var q = db.Quotations.Where(qq => qq.ID == xid).SingleOrDefault();
            db.Quotations.DeleteOnSubmit(q);

            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Quotation  ", "Delete Quotation's Informations  ");
        }



        public static List<Quotation> GetAllQuotations() {
            db = new DbDataContext();
          return   db.Quotations.ToList(); }
    }
}
