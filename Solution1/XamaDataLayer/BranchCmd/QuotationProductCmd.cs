using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public  class QuotationProductCmd
    {
        private static DbDataContext db = new DbDataContext();

        public static bool AddQuotationProduct(QuotationProduct tb)
        {
            db = new DbDataContext();
            db.QuotationProducts.InsertOnSubmit(tb);
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "Quotation  Product  ", " Add Product's Quotation Informations  ");
            return true;
        }

        public static QuotationProduct EditQuotationProduct(QuotationProduct tb, int xid)
        {
            db = new DbDataContext();
            var q = db.QuotationProducts.Where(n => n.id == xid).SingleOrDefault();
            q.ProductID = tb.ProductID;
            q.QuotationID = tb.QuotationID;
            q.Description = tb.Description;

            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", "  Quotation Product  ", " Edit Selected  Product's Quotation Informations  ");

            return q;
        }


        public static void DeleteQuotationProduct(int xid)
        {
            db = new DbDataContext();
            var q = db.QuotationProducts.Where(n => n.id == xid).SingleOrDefault();
            db.QuotationProducts.DeleteOnSubmit(q);

            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Quotation Product  ", " Delete selected  Product's Quotation Informations  ");
        }



        public static List<QuotationProduct> GetAllQuotationProducts()
        {
            db = new DbDataContext();
            return db.QuotationProducts.ToList();
        }

        public static List<QuotationProduct> GetQuotationProductByProductID( int ProdctId)
        {
            db = new DbDataContext();
            var LST = (from i in db.QuotationProducts
                        where i.ProductID == ProdctId
                        select i).ToList();
            return LST;
        }

        public static List<QuotationProduct> GetQuotationProductByQuotationID(int QuotionId)
        {
            db = new DbDataContext();
            var LST = (from i in db.QuotationProducts
                        where i.QuotationID  == QuotionId
                        select i).ToList();
            return LST;
        }
    }
}
