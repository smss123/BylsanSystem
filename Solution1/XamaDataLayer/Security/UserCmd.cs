using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Security
{
    public    class UserCmd : ApiCounter
    {
        public static bool AddUser(User tb)
        {
            tb.ID = GetNumber();
            db.Users.InsertOnSubmit(tb);
            db.SubmitChanges();


            var parmList = db.SystemPermessions.ToList();

            foreach (var item in parmList)
            {
                var userprm = new UserPermession()
                { ID=ApiCounter.GetNumber(),
                    PermessionValue = false.ToString(),
                   SystemPermession = item,
                   User = tb
                };
                db.UserPermessions.InsertOnSubmit(userprm);
            }
            db.SubmitChanges();



            return true;
        }


        public List<User> GetUserByID( int xid)
        {
            var q = db.Users.Where(p => p.ID == xid).ToList ();


            db.SubmitChanges();
            return q;
        }




        public User  EditUser(User tb, int xid)
        {
            var q = db.Users.Where(p => p.ID == xid).SingleOrDefault();
            q.UserName = tb.UserName;
            q.Passwords = tb.Passwords;
            db.SubmitChanges();
            return  q ;
        }

        public  static  void DeleteUserAt(int xid)
        {
            
                var q = db.Users.Where(p => p.ID == xid).SingleOrDefault();
                db.Users.DeleteOnSubmit(q);
                db .SubmitChanges ();
            
        }
        public static List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }




        public static User Login(string usr, string pwd)
        {

            var q = db.Users .Where(p => p.UserName == usr && p.Passwords == pwd).ToList();
            if (q.Count == 0 || q.Count == -1)
            {
                return null;
            }
            else
            {
                UserInfo.CurrentUserID = q[0].ID;
                UserInfo.CurrentUserName = q[0].UserName;
                UserInfo.CurrentUserPassword = q[0].Passwords;

                var htb = new History();
                htb.ID = GetNumber();
                htb.ActionName = "User LogIn";
                htb.DateOfProcess = DateTime.Now;
                htb.HistoryAction = "User LogIn ";
                htb.Description = string.Format("User : {0}  LogIn And Started Use The System Now", q[0].UserName);
                htb.UserID = q[0].ID;

                WriteUserHistory(htb);
                return q[0];
            }
        }

        public  static  void UserLogOut()
        {
            var htb = new History();
            htb.ID = GetNumber();
            htb.ActionName = "User LogOut";
            htb.DateOfProcess = DateTime.Now;
            htb.HistoryAction = "User LogOut ";
            htb.Description = string.Format("User : {0}  LogOut  ", UserInfo.CurrentUserName);
            htb.UserID = UserInfo.CurrentUserID;

            WriteUserHistory(htb);

            UserInfo.CurrentUserID = 0;
            UserInfo.CurrentUserName = string.Empty;
            UserInfo.CurrentUserPassword = string.Empty;
        }

        private static bool WriteUserHistory(History htb)
        {
            try
            {
                db.CommandTimeout = 9000;
                htb.ID = GetNumber();
                db.Histories.InsertOnSubmit(htb);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
              if(ex.Message.Contains("Violation of PRIMARY KEY"))
              {
                  db.CommandTimeout = 9000;
                  htb.ID = GetNumber();
                  db.Histories.InsertOnSubmit(htb);
                  db.SubmitChanges();
                  return true;
              }
                //Violation of PRIMARY KEY
            }
            return false;
        }




        public static  void SaveHistory(string xActionName, string xHistoryAction, string descript)
        {
            try
            {
                db = new DbDataContext();
                var tb = new History()
                {
                    ID = GetNumber(),
                    ActionName = xActionName,
                    HistoryAction = xHistoryAction,
                    Description = string.Format("{0} | By User :  {1}", descript, XamaDataLayer.Security.UserInfo.CurrentUserName),
                    DateOfProcess = DateTime.Now,
                    UserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
                };
                db.Histories.InsertOnSubmit(tb);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    db = new DbDataContext();
                    var tb = new History()
                    {
                        ID = GetNumber(),
                        ActionName = xActionName,
                        HistoryAction = xHistoryAction,
                        Description = string.Format("{0} | By User :  {1}", descript, XamaDataLayer.Security.UserInfo.CurrentUserName),
                        DateOfProcess = DateTime.Now,
                        UserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
                    };
                    db.Histories.InsertOnSubmit(tb);
                    db.SubmitChanges();

                }
                return;
            }
           
        }


        public static List<History> GetAllUserHistories()
        {
            return db.Histories.ToList();
        }



        public static User EditPassword(User tb, int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var q = db.Users.Where(u => u.ID == xid).SingleOrDefault();
            q.Passwords = tb.Passwords;
            db.SubmitChanges();
            return q;
        }
    }
}
