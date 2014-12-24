using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public  class OrderProuctAttachmentCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddOrderProductAttachment( OrderProuctAttachment tb)
        {
            db = new DbDataContext();
            db.OrderProuctAttachments.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Attachment ", " Add New Attachment   ");
            return true;
        }
        public static OrderProuctAttachment EditAttachment(OrderProuctAttachment tb, int xid)
        {
            db = new DbDataContext();
            var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
            q.OrderProductID = tb.OrderProductID;
            q.imageX = tb.imageX;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", "Edit Attachment ", " Edit selected  Attachment's Informations    ");
            return q;
        }

        public static void DeleteAttachment(int xid)
        {
            db = new DbDataContext();
            var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
            db.OrderProuctAttachments.DeleteOnSubmit(q);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete  Attachment ", " Delete selected  Attachment   ");
        }

        public static List<OrderProuctAttachment> GetAllAttachments()
        {
            db = new DbDataContext();
            return   db.OrderProuctAttachments.ToList();
        }

        public static OrderProuctAttachment GetOneAttachmentByID(int xid )
        {
            db = new DbDataContext();
            var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
            return q;
        }

        public static  List <OrderProuctAttachment> GetOneAttachmentByOrderProductID(int xid)
        {
            db = new DbDataContext();
            var q = (from p in db.OrderProuctAttachments
                      where p.OrderProductID == xid
                      select p).ToList();
            return q;
        }
    }
}
