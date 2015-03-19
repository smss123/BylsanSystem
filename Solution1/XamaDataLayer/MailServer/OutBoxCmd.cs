using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.MailServer
{
    public static class OutBoxCmd
    {
        private static DbDataContext db = new DbDataContext();

        public static bool OutBoxMessage(OutBox  tb)
        {
            
            db.OutBoxes .InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Send ", " Message  ", " Sent Message  ");
            return true;
        }

        public static OutBox  EditMessage(OutBox tb, int xid)
        {
             
            var Msg = db.OutBoxes .Where(m => m.ID == xid).SingleOrDefault();

            Msg.Status = tb.Status;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit", " Message  ", " Edit Message Status ");

            return Msg;
        }

        public static void DeleteMsg(int xid)
        {
            try
            {
                
                var Msg = db.OutBoxes .Where(m => m.ID == xid).SingleOrDefault();
                db.OutBoxes .DeleteOnSubmit(Msg);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Message  ", " Delete OutBox Message  ");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<OutBox> LoadAllMessages()
        {
            db = new DbDataContext();
            var lst = (from m in db.OutBoxes
                       orderby m.DateOfMessage descending
                       where m.SenderUserID == XamaDataLayer .Security .UserInfo .CurrentUserID
                       select m).ToList();
            return lst;
        }

        public static List<OutBox> LoadAllMessagesByDate( DateTime dat)
        {
            db = new DbDataContext();
            var lst = (from m in db.OutBoxes
                       orderby m.ID ascending
                       where m.DateOfMessage == dat
                       select m).ToList();
            return lst;
        }
    }
}
