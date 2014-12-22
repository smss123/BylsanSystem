﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer;
namespace XamaDataLayer.Security
{
   public    class UserCmd   
    {
    static  DbDataContext db = new DbDataContext();

    #region "    Main Functions       "

    public static bool AddUser(User tb)
       {

           db.Users.InsertOnSubmit(tb);
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
           try
           {

               var q = db.Users.Where(p => p.ID == xid).SingleOrDefault();
               db.Users.DeleteOnSubmit(q);
               db .SubmitChanges ();
           }
           catch (Exception)
           {
               
             
           }
       }
       public static List<User> GetAllUsers()
       {
           return db.Users.ToList();
       }
    #endregion 

        #region "   ^^^  User Login  / LogOut Functions          "

       public static User Login(string usr, string pwd)
       {
         
               var q = db.Users .Where(p => p.UserName == usr && p.Passwords == pwd).ToList();
               if (q.Count == 0 || q.Count == -1)
               {
               
                   return null;
               }
               else
               {
                   //=========================================
                   UserInfo.CurrentUserID = q[0].ID;
                   UserInfo.CurrentUserName = q[0].UserName;
                   UserInfo.CurrentUserPassword = q[0].Passwords;
                   //==========================================
                   History htb = new History();
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
      
           //==========================================
           History htb = new History();
           htb.ActionName = "User LogOut";
           htb.DateOfProcess = DateTime.Now;
           htb.HistoryAction = "User LogOut ";
           htb.Description = string.Format("User : {0}  LogOut  ", UserInfo.CurrentUserName);
           htb.UserID = UserInfo.CurrentUserID;

           WriteUserHistory(htb);

           UserInfo.CurrentUserID = 0;
           UserInfo.CurrentUserName ="";
           UserInfo.CurrentUserPassword = "";
       }

       private static bool WriteUserHistory(History htb)
       {
           db = new DbDataContext();
           db.Histories.InsertOnSubmit(htb);
           db.SubmitChanges();
           return true;
       }

        #endregion 

       #region "  ^^^ History  "
      public static  void SaveHistory(string xActionName, string xHistoryAction,string descript)
       {
           db = new DbDataContext();
           History tb = new History()
           {
               ActionName = xActionName ,
               HistoryAction =  xHistoryAction ,
               Description = string.Format( descript + " | By User :  " +  XamaDataLayer.Security.UserInfo.CurrentUserName),
               DateOfProcess = DateTime.Now,
               UserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
           };
           db.Histories.InsertOnSubmit(tb);
           db.SubmitChanges();
       }


       public static List<History> GetAllUserHistories()
       {
           return db.Histories.ToList();
       
       }

       #endregion 

       public static User EditPassword(User tb, int xid)
       {
           db = new DbDataContext();
           var q = db.Users.Where(u => u.ID == xid).SingleOrDefault();
           q.Passwords = tb.Passwords;
           db.SubmitChanges();
           return q;
       }

    }
}
