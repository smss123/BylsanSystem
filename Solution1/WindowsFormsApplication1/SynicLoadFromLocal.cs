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

        public void LoadFromRemote()
        {
            DbDataContext remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
            DbDataContext localdb = new DbDataContext(Properties.Settings.Default.LocalConnection);
          
            foreach (var item in remotedb.AccountCategories)
            {
                try
                {
                    var q = localdb.AccountCategories.Where(p => p.ID == item.ID).Single();
                    q.AccountCategoryName = item.AccountCategoryName;
                    q.Description=item.Description ;
                    q.ID = item.ID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.AccountCategories.InsertOnSubmit(new AccountCategory() { 
                     AccountCategoryName = item.AccountCategoryName,
                      Description= item.Description,
                       ID = item.ID
                    });
                    localdb.SubmitChanges();
                }
            }

            

            
            
        }
    }
}
