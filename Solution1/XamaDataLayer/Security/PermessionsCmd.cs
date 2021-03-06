﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Security
{
    public     class PermessionsCmd:ApiCounter
    {
     
        public static bool AddAllSystemPermessions(SystemPermession tb)
        {
            tb.ID = GetNumber();
           db.CommandTimeout = 9000;
            db.SystemPermessions.InsertOnSubmit(tb);
            db.SubmitChanges();

            UserCmd.SaveHistory("Add ", " Add New User", " Add new User To System ");

            return true;
        }

        public static List<SystemPermession> GetAllSystemPermession()
        {
           db.CommandTimeout = 9000;
            var q = db.SystemPermessions.ToList();
            return q;
        }




        public static bool AddUserPermessions(UserPermession tb)
        {
            //Violation of PRIMARY KEY
            try
            {
                db.CommandTimeout = 9000;
                db.UserPermessions.InsertOnSubmit(tb);
                db.SubmitChanges();

                UserCmd.SaveHistory("Add ", "Permessions ", "Geven User Some Of  Permessions  ");
                return true;
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    tb.ID = ApiCounter.GetNumber();
                    db.CommandTimeout = 9000;
                    db.UserPermessions.InsertOnSubmit(tb);
                    db.SubmitChanges();

                    UserCmd.SaveHistory("Add ", "Permessions ", "Geven User Some Of  Permessions  ");
                    return true;
                }
                return false;
            }
          
        }

        public static bool EditPermessionValue(UserPermession u, int xxUserID)
        {
            var q = db.UserPermessions.Where(p => p.ID == u.ID && p.UserID == xxUserID).SingleOrDefault();

            if (q != null)
            {
                q.SystemPermessionID = u.SystemPermessionID;
                q.PermessionValue = u.PermessionValue;
                q.UserID = u.UserID;
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory(" Edit", " Edit Permession", " Edit  Permession to selected user ");

                return true;
            }
            return false;
        }

        public static List<UserPermession> LoadingPermissonsOfCurrentUser()
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            var LST = (from u in db.UserPermessions
                      where u.UserID == UserInfo .CurrentUserID
                      select u).ToList();
            return LST;
        }





        public static List<UserPermession> GetAllUserPermissonsByUserID(int UsrID)
        {
            db = new DbDataContext ();
            var LST = (from u in db.UserPermessions
                        where u.UserID == UsrID
                        select u).ToList();
            return LST;
        }


        public static bool ClearAllUserPermessions(int usrid)
        {
           db = new DbDataContext();db.CommandTimeout = 9000;
            ;
            var tb = new UserPermession();
            var lst = (from u in db.UserPermessions
                        where u.UserID == usrid
                        select u).ToList();

            var IDes = new List<int>();
            IDes.Clear();
            foreach (var i in lst)
            {
                IDes.Add(i.ID);
            }
            foreach (var item in IDes)
            {
                tb = db.UserPermessions.Where(x => x.ID == item).Single();
                db.UserPermessions.DeleteOnSubmit (tb);
                db.SubmitChanges ();
            }

            return true;
        }
    }
}
