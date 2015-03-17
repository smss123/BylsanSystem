using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer;

namespace WindowsFormsApplication1
{
    public class SynicLoadFromRemote
    {
        public void LoadFromLocal()
        {
            DbDataContext remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
            DbDataContext localdb = new DbDataContext(Properties.Settings.Default.LocalConnection);

            foreach (var item in localdb.AccountCategories)
            {
                try
                {
                    var q = remotedb.AccountCategories.Where(p => p.ID == item.ID).Single();
                    q.AccountCategoryName = item.AccountCategoryName;
                    q.Description = item.Description;
                    q.ID = item.ID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.AccountCategories.InsertOnSubmit(new AccountCategory()
                    {
                        AccountCategoryName = item.AccountCategoryName,
                        Description = item.Description,
                        ID = item.ID
                    });
                    remotedb.SubmitChanges();
                }
            }





        }
    }
}
