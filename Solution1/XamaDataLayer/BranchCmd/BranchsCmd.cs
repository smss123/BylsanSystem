using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
   public static  class BranchsCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddNewBranch(Branch tb)
       {
           db = new DbDataContext();
           var MyTable =  db.Branches .Where (b=> b.Branch_Name .Contains (tb.Branch_Name )).SingleOrDefault () ;
           if (MyTable.Branch_Name == null)
           {
               db.Branches.InsertOnSubmit(tb);
               db.SubmitChanges();
               return true;
           }
           else { return false; }
          
       }
       public static List<Branch> GetAllBranchs()
       {
           db = new DbDataContext();
           var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      select b).ToList();
           return lst;
       }


       public static List<Branch> GetAllBranchByAccountID( int AcctId)
       {
           db = new DbDataContext();
           var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.AccountID == AcctId 
                      select b).ToList();
           return lst;
       }

       public static List<Branch> GetAllBranchByManagerID(int MangrId)
       {
           db = new DbDataContext();
           var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.Manager_ID == MangrId 
                      select b).ToList();
           return lst;
       }
       public static List<Branch> GetAllBranchByBarnchID(int BranId)
       {
           db = new DbDataContext();
           var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.ID == BranId 
                      select b).ToList();
           return lst;
       }
       public static bool EditBranch(Branch tb, int xid)
       {
           db = new DbDataContext();
           var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
           b.Branch_Name = tb.Branch_Name;
           b.Branch_Description = tb.Branch_Description;
           b.CreatedDate = tb.CreatedDate;
           b.Manager_ID = tb.Manager_ID;
           b.AccountID = tb.AccountID;
           db.SubmitChanges();
           return true;
       }

       public static void DeleteBranch(int xid)
       {

          
           db = new DbDataContext();
           var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
           db.Branches.DeleteOnSubmit(b);
           db.SubmitChanges();
          
       }
    }
}
