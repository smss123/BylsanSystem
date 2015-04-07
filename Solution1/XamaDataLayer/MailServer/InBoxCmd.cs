using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.MailServer
{
    public    class InBoxCmd:ApiCounter
    {
      

        public static bool InsertMassegeInBox(Inbox tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.Inboxes.InsertOnSubmit(tb);
            db.SubmitChanges();


            return true;
        }

        public static Inbox EditMessage(Inbox tb, int xid)
        {
           
            db.CommandTimeout = 9000;
            var Msg = db.Inboxes.Where(m => m.ID == xid).SingleOrDefault();

            Msg.Status = tb.Status;
            db.SubmitChanges();

            XamaDataLayer.Security.UserCmd.SaveHistory("Edit", " Message  ", " Edit InBox Message Status ");
            return Msg;
        }

        public static void DeleteMsg( int xid)
        {
            try
            {
               
                db.CommandTimeout = 9000;
                var Msg = db.Inboxes.Where(m => m.ID == xid).SingleOrDefault();
                db.Inboxes.DeleteOnSubmit(Msg);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete", " Message  ", " Delete InBox Message  ");
            }
            catch (Exception)
            {
                
            }
        }

        public static List<Inbox> GetAllMessages()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from i in db.Inboxes
                      where i.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                      select i).ToList();
            return lst;
        }

        public static List<Inbox > LoadAllMessagesByDate(DateTime dat)
        {
             
            db.CommandTimeout = 9000;
            var lst = (from m in db.Inboxes
                      orderby m.ID ascending
                      where m.DateOfMessage == dat
                      select m).ToList();
            return lst;
        }
    }
}
