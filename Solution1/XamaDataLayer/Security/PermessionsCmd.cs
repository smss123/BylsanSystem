using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Security
{
   public  static  class PermessionsCmd
   {
       #region "  System Permession "
       static DbDataContext db = new DbDataContext();
       public static bool AddAllSystemPermessions(SystemPermession tb)
       {
           db = new DbDataContext();
           db.SystemPermessions.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public static List<SystemPermession> GetAllSystemPermession()
       {
           db = new DbDataContext();
           var q = db.SystemPermessions.ToList();
           return q;

       }

       #endregion

       #region "  User Permession "
       public static bool AddUserPermessions(UserPermession tb)
       {
           db = new DbDataContext();
           db.UserPermessions .InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       public static bool EditPermessionValue(UserPermession u, int xxUserID)
       {
           var q = db.UserPermessions.Where(p => p.ID == u.ID && p.UserID == xxUserID).SingleOrDefault();
          
               if (q!= null)
               {
                   q.SystemPermessionID = u.SystemPermessionID;
                   q.PermessionValue = u.PermessionValue;
                   q.UserID = u.UserID;
                   db.SubmitChanges();
                   return true;
               }
               return false;
          
         
       }

       public static List<UserPermession> LoadingPermissonsOfCurrentUser()
       {
           db = new DbDataContext();
           var LST = (from u in db.UserPermessions 
                      where u.UserID == UserInfo .CurrentUserID 
                      select u).ToList();
           return LST;
       }

       #endregion


       #region "   Searching & Clear   "
       public static List<UserPermession> GetAllUserPermissonsByUserID(int UsrID)
       {
           db = new DbDataContext ();
           var LST = (from u in db.UserPermessions where u.UserID == UsrID select u).ToList();
           return LST;
       }


       public static bool ClearAllUserPermessions(int usrid)
       {
           db = new DbDataContext(); ;
           UserPermession tb = new UserPermession();
           var lst = (from u in db.UserPermessions where u.UserID == usrid select u).ToList();

           List<int> IDes = new List<int>();
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
       #endregion 




   }
}
