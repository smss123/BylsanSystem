using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public  class OrderProuctAttachmentCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddOrderProductAttachment( OrderProuctAttachment tb){

           db = new DbDataContext();
           db.OrderProuctAttachments.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;  
       }
       public static OrderProuctAttachment EditAttachment(OrderProuctAttachment tb, int xid)
       {
           db = new DbDataContext();
           var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
           q.OrderProductID = tb.OrderProductID;
           q.imageX = tb.imageX;
           db.SubmitChanges();
             return q;
              
       }

       public static void DeleteAttachment(int xid)
       {
           db = new DbDataContext();
           var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
           db.OrderProuctAttachments.DeleteOnSubmit(q);
           db.SubmitChanges();
        
       }

       public static List<OrderProuctAttachment> GetAllAttachments() {

           db = new DbDataContext();
         return   db.OrderProuctAttachments.ToList();
       }

       public static OrderProuctAttachment GetOneAttachmentByID(int xid )
       {
           db = new DbDataContext();
           var q = db.OrderProuctAttachments.Where(c => c.ID == xid).SingleOrDefault();
           return q;

       }

       public static OrderProuctAttachment GetOneAttachmentByOrderProductID(int xid)
       {
           db = new DbDataContext();
           var q = db.OrderProuctAttachments.Where(c => c.OrderProductID  == xid).SingleOrDefault();
           return q;

       }

    }
}
