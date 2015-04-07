using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using XamaDataLayer.Main_Store;

namespace XamaDataLayer.BranchCmd
{
    public    class BranchsCmd:ApiCounter
    {
    
        public static bool AddNewBranch(Branch tb)
        {
           
            db.CommandTimeout = 9000;
            var MyTable =  db.Branches .Where (b => b.Branch_Name .Contains (tb.Branch_Name )).Take(1).SingleOrDefault () ;
            if (MyTable == null)
            {
                tb.ID = GetNumber();
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
            try
            {
                var com = CompiledQuery.Compile(
                  (DbDataContext dbx) =>
                   (from b in dbx.Branches
                    orderby b.CreatedDate ascending
                    select b)
           );
                db.CommandTimeout = 9000;
                return com(db).ToList();
            }
            catch (Exception)
            {

                db = new DbDataContext();
                var com = CompiledQuery.Compile(
                  (DbDataContext dbx) =>
                   (from b in dbx.Branches
                    orderby b.CreatedDate ascending
                    select b)
           );
                db.CommandTimeout = 9000;
                return com(db).ToList();
            }
           
        }


        public static List<Branch> GetAllBranchByAccountID( int AcctId)
        {
            var com = CompiledQuery.Compile(
                  (DbDataContext dbx, int id) =>
                   (from b in dbx.Branches
                                         orderby b.CreatedDate ascending
                                         where b.AccountID == id
                                         select b).ToList()
           );
            db.CommandTimeout = 9000;
            return com(db,AcctId);
        }

        public static List<Branch> GetAllBranchByManagerID(int MangrId)
        {
            var com = CompiledQuery.Compile(
                  (DbDataContext dbx, int id) =>
                   (from b in dbx.Branches
                                         orderby b.CreatedDate ascending
                                         where b.Manager_ID == id
                                         select b).ToList()
           );
            db.CommandTimeout = 9000;
            return com(db, MangrId);
        }
        public static Branch GetBranchByBarnchID(int xid)
        {
            var com = CompiledQuery.Compile(
                  (DbDataContext dbx, int id) =>
                   (from b in dbx.Branches
                                         orderby b.CreatedDate ascending
                                         where b.ID ==  id
                                         select b).Single()
           );
            db.CommandTimeout = 9000;
            return com(db, xid);
        }
        public static bool EditBranch(Branch tb, int xid)
        {
            
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
           
            db.CommandTimeout = 9000;
            var b = db.Branches.Where(n => n.ID == xid).SingleOrDefault();
            db.Branches.DeleteOnSubmit(b);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delete Branch ", " Delete Selected  Branch's Informations  ");
        }

        public static bool TransferFromToBranch(Branch frmBranch, Branch toBranch, Product itemID, int qty,int loginedUser)
        {
            var storeInfo = db.SellStores.Where(p => p.branchID == frmBranch.ID && p.ItemID == itemID.ID).Take(1).Single();
            if (storeInfo.Qty<qty)
            {
                throw new Exception("this Qty is Greater than Avaliable ");
            }
            var toStore = db.SellStores.Where(p => p.branchID == toBranch.ID && p.ItemID == itemID.ID).Take(1).Single();
            if (toStore == null)
            {

                db.SellStores.InsertOnSubmit(new SellStore() { 
                    
                     ID = GetNumber(),
                 branchID= toBranch.ID,
                  Qty= qty,
                   ItemID=itemID.ID,
                });

            }
            else
            {
                storeInfo.Qty =(int)storeInfo.Qty - qty;
                db.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager() { 
                     ID=ApiCounter.GetNumber(),
                 ProcessDate = DateTime.Now,
                 ProcessType = "Darwal",
                   Qty=qty,
                    StoreID = storeInfo.ID,
                     UserID= loginedUser
                
                });
                toStore.Qty = (int)toStore.Qty + qty;
                db.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager()
                {
                     ID= ApiCounter.GetNumber(),
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
