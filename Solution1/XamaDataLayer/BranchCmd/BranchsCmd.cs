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
           db.Branches.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }
       public static List<Branch> GetAllBranchs()
       {
           db = new DbDataContext();
           var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      select b).ToList();
           return lst;
       }

       public Branch EditBranch(Branch tb, int xid)
       {
           db = new DbDataContext();
           var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
           b.Branch_Name = tb.Branch_Name;
           b.Branch_Description = tb.Branch_Description;
           b.CreatedDate = tb.CreatedDate;
           b.Manager_ID = tb.Manager_ID;
           b.AccountID = tb.AccountID;
           db.SubmitChanges();
           return b;
       }

       public static void DeleteBranch(int xid)
       {

           try
           {
           db = new DbDataContext();
           var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
           db.Branches.DeleteOnSubmit(b);
           db.SubmitChanges();
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
