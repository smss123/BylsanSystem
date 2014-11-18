using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.MailServer
{
   public static  class InBoxCmd
    {
       static DbDataContext db = new DbDataContext();

       public static bool InsertMassegeInBox(Inbox tb) 
       {
           db = new DbDataContext();
           db.Inboxes.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public static Inbox EditMessage(Inbox tb, int xid)
       {
           db = new DbDataContext();
           var Msg = db.Inboxes.Where(m => m.ID == xid).SingleOrDefault();
           Msg.Subject = tb.Subject;
           Msg.SenderUserID = tb.SenderUserID;
           Msg.DateOfMessage = tb.DateOfMessage;
           Msg.ReciverUserID = tb.ReciverUserID;
           Msg.MessageText = tb.MessageText;
           Msg.Status = tb.Status;
           db.SubmitChanges();
           return Msg;
       }

       public static void DeleteMsg( int xid)
       {
           try
           {
           db = new DbDataContext();
           var Msg = db.Inboxes.Where(m => m.ID == xid).SingleOrDefault();
           db.Inboxes.DeleteOnSubmit(Msg);
           db.SubmitChanges();
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public static List<Inbox> GetAllMessages()
       {
           db = new DbDataContext();
           return db.Inboxes.ToList();
       }

       public static List<Inbox > LoadAllMessagesByDate(DateTime dat)
       {
           db = new DbDataContext();
           var lst = (from m in db.Inboxes 
                      orderby m.ID ascending
                      where m.DateOfMessage == dat
                      select m).ToList();
           return lst;
       }

    }
}
