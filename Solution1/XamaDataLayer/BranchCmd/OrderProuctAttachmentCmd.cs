using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public  class OrderProuctAttachmentCmd:ApiCounter
    {
      
        public static bool AddOrderProductAttachment( OrderProuctAttachment tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.OrderProuctAttachments.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Attachment ", " Add New Attachment   ");
            return true;
        }
        public static OrderProuctAttachment EditAttachment(OrderProuctAttachment tb, int xid)
        {
            
            db.CommandTimeout = 9000;
            var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
            q.OrderProductID = tb.OrderProductID;
            q.imageX = tb.imageX;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", "Edit Attachment ", " Edit selected  Attachment's Informations    ");
            return q;
        }

        public static void DeleteAttachment(int xid)
        {
             
            db.CommandTimeout = 9000;
            var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
            db.OrderProuctAttachments.DeleteOnSubmit(q);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete  Attachment ", " Delete selected  Attachment   ");
        }

        public static List<OrderProuctAttachment> GetAllAttachments()
        {
            var com = CompiledQuery.Compile(
             (DbDataContext dbx) =>
            dbx.OrderProuctAttachments.ToList()
                                        );
            db.CommandTimeout = 9000;
            return com(db);
             
        }

        public static OrderProuctAttachment GetOneAttachmentByID(int xid )
        {
            var com = CompiledQuery.Compile(
            (DbDataContext dbx) =>
                        dbx.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault()
                                       );
            db.CommandTimeout = 9000;
            return com(db);

           
        }

        public static  List <OrderProuctAttachment> GetOneAttachmentByOrderProductID(int xid)
        {
            var com = CompiledQuery.Compile(
           (DbDataContext dbx) =>
                       (from p in dbx.OrderProuctAttachments
                        where p.OrderProductID == xid
                        select p).ToList()

                                      );
            db.CommandTimeout = 9000;
            return com(db);

             
        }
    }
}
