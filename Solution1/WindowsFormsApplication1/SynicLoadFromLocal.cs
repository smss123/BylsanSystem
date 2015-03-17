using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer;
namespace WindowsFormsApplication1
{
    public class SynicLoadFromLocal : IDisposable
    {
        public DbDataContext Remotedb = new DbDataContext();

        public void Dispose()
        {
            if (Remotedb != null)
            {
                Remotedb.Dispose();
                Remotedb = null;
            }
        }
        public SynicLoadFromLocal()
        {
        }

        //public void LoadFromRemote()
        //{
        //    Remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
        //    Remotedb.Connection.ConnectionString = Properties.Settings.Default.LocalConnection;
        //    Remotedb.SubmitChanges();
        //}

        public void LoadFromLocal()
        {
            DbDataContext localdb = new DbDataContext(Properties.Settings.Default.LocalConnection);
            DbDataContext remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
            foreach (var item in localdb.AccountCategories)
            {
                try
                {
                    var q = remotedb.AccountCategories.Where(p => p.ID == item.ID).Single();
                    item.AccountCategoryName = q.AccountCategoryName;
                    item.Description = q.Description;
                    item.ID = q.ID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.AccountCategories.InsertOnSubmit(new AccountCategory() { 
                     AccountCategoryName = item.AccountCategoryName,
                      Description= item.Description,
                       ID = item.ID
                    });
                    remotedb.SubmitChanges();
                }
            }

            foreach (var item in localdb.Accounts)
            {
                try
                {
                    var q = remotedb.Accounts.Where(p => p.ID == item.ID).Single();
                    item.AccountName = q.AccountName;
                    item.CategoryID = q.CategoryID;
                    item.ID = q.ID;
                    item.Description = q.Description;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Accounts.InsertOnSubmit(new Account()
                    {
                        AccountName = item.AccountName,
                        CategoryID = item.CategoryID,
                        ID = item.ID,
                        Description = item.Description,
                    });
                    remotedb.SubmitChanges();
                }
            }

            //foreach (var item in localdb.AccountDailies)
            //{
            //    try
            //    {
            //        var q = remotedb.AccountDailies.Where(p => p.ID == item.ID).Single();
            //        item.AccountID = q.AccountID;
            //        item.CommandArg = q.CommandArg;
            //        item.DateOfProcess = q.DateOfProcess;
            //        item.Description = q.Description;
            //        localdb.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        remotedb.AccountDailies.InsertOnSubmit(new AccountDaily()
            //        {
            //            AccountName = item.AccountName,
            //            CategoryID = item.CategoryID,
            //            ID = item.ID,
            //            Description = item.Description,
            //        });
            //        remotedb.SubmitChanges();
            //    }
            //}
            
        }
    }
}
