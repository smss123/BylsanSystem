using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.MailServer
{
    public static class OutBoxCmd
    {
        static DbDataContext db = new DbDataContext();

        public static bool OutBoxMessage(OutBox  tb)
        {
            db = new DbDataContext();
            db.OutBoxes .InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }

        public static OutBox  EditMessage(OutBox tb, int xid)
        {
            db = new DbDataContext();
            var Msg = db.OutBoxes .Where(m => m.ID == xid).SingleOrDefault();
            Msg.Subject = tb.Subject;
            Msg.SenderUserID = tb.SenderUserID;
            Msg.DateOfMessage = tb.DateOfMessage;
            Msg.ReciverUserID = tb.ReciverUserID;
            Msg.MessageText = tb.MessageText;
            Msg.Status = tb.Status;
            db.SubmitChanges();
            return Msg;
        }

        public static void DeleteMsg(int xid)
        {
            try
            {
                db = new DbDataContext();
                var Msg = db.OutBoxes .Where(m => m.ID == xid).SingleOrDefault();
                db.OutBoxes .DeleteOnSubmit(Msg);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<OutBox> LoadAllMessages()
        {
            db = new DbDataContext();
            return db.OutBoxes.ToList();
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
