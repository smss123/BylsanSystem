using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.Main_Store;

namespace XamaDataLayer.BranchCmd
{
    public static  class BranchsCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddNewBranch(Branch tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var MyTable =  db.Branches .Where (b => b.Branch_Name .Contains (tb.Branch_Name )).Take(1).SingleOrDefault () ;
            if (MyTable == null)
            {
                db.Branches.InsertOnSubmit(tb);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Branch ", " Add New Branch's Informations  ");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Branch> GetAllBranchs()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      select b).ToList();
            return lst;
        }


        public static List<Branch> GetAllBranchByAccountID( int AcctId)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.AccountID == AcctId
                      select b).ToList();
            return lst;
        }

        public static List<Branch> GetAllBranchByManagerID(int MangrId)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.Manager_ID == MangrId
                      select b).ToList();
            return lst;
        }
        public static Branch GetBranchByBarnchID(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var lst = (from b in db.Branches
                      orderby b.CreatedDate ascending
                      where b.ID ==  xid
                      select b).Single();
            return lst;
        }
        public static bool EditBranch(Branch tb, int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
            b.Branch_Name = tb.Branch_Name;
            b.Branch_Description = tb.Branch_Description;
            b.CreatedDate = tb.CreatedDate;
            b.Manager_ID = tb.Manager_ID;
            b.AccountID = tb.AccountID;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit   ", "Edit Branch ", " Edit Selected Branch's Informations  ");

            return true;
        }

        public static void DeleteBranch(int xid)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
            db.Branches.DeleteOnSubmit(b);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete Branch ", " Delete Selected  Branch's Informations  ");
        }

        public static bool TransferFromToBranch(Branch frmBranch, Branch ToBranch, Product itemID, int qty,int loginedUser)
        {
            var StoreInfo = db.SellStores.Where(p => p.branchID == frmBranch.ID && p.ItemID == itemID.ID).Take(1).Single();
            if (StoreInfo.Qty<qty)
            {
                throw new Exception("this Qty is Greater than Avaliable ");
            }
            var toStore = db.SellStores.Where(p => p.branchID == frmBranch.ID && p.ItemID == itemID.ID).Take(1).Single();
            if (toStore == null)
            {
                db.SellStores.InsertOnSubmit(new SellStore() { 
                 branchID= ToBranch.ID,
                  Qty= qty,
                   ItemID=itemID.ID,
                });

            }
            else
            {
                StoreInfo.Qty =(int)StoreInfo.Qty - qty;
                db.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager() { 
                 ProcessDate = DateTime.Now,
                 ProcessType = "Darwal",
                   Qty=qty,
                    StoreID = StoreInfo.ID,
                     UserID= loginedUser
                
                });
                toStore.Qty = (int)toStore.Qty + qty;
                db.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager()
                {
                    ProcessDate = DateTime.Now,
                    ProcessType = "Deposit",
                    Qty = qty,
                    StoreID = toStore.ID,
                    UserID = loginedUser

                });
                db.SubmitChanges();
            }

            return true;
        }
    }
}
