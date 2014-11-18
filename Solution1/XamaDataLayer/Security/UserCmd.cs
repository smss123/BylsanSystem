using System;
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


       public User  EditUser(User tb, int xid)
       {
        
           var q = db.Users.Where(p => p.ID == xid).SingleOrDefault();
       
               q.UserName = tb.UserName;
               q.Passwords = tb.Passwords;
               db.SubmitChanges();
               return  q ;
       }

       public   void DeleteUserAt(int xid)
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
                   //=========================================
                   UserInfo.CurrentUserID = q[1].ID;
                   UserInfo.CurrentUserName = q[1].UserName;
                   UserInfo.CurrentUserPassword = q[1].Passwords;
                   //==========================================
                   History htb = new History();
                   htb.ActionName = "User LogIn";
                   htb.DateOfProcess = DateTime.Now;
                   htb.HistoryAction = "User LogIn ";
                htb.Description = string.Format("User : {0}  LogIn And Started Use The System Now", q[1].UserName);
                htb.UserID = q[1].ID;

                   WriteUserHistory (htb);
                   return  q[0]();
               }
               else
               {
                   return new User();
               }

          
       }

       

       private static bool WriteUserHistory(History htb)
       {
           db = new DbDataContext();
           db.Histories.InsertOnSubmit(htb);
           db.SubmitChanges();
           return true;
       }

        #endregion 

    }
}
