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
           var lst = (from i in db.Inboxes 
                      where i.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                      select i).ToList();
           return lst;
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
