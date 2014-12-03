using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
//using Microsoft.Synchronization.Data.SqlServer;
using System.Data.SqlClient;
using Microsoft.Synchronization.Data;

namespace XamaDataLayer.Helper_Classes
{
    public class DataBaseSynic
    {
        static readonly string sServerConnection = @"Data Source=jasmine.arvixe.com;Initial Catalog=Cloud_Bylsan;User ID=xama;Password=Pa$$w0rd;Connect Timeout=60";
        static readonly string sClientConnection = @"Data Source=SEZEROFFICE-PC\SQL2008;Initial Catalog=soft_Bylsan;Integrated Security=True;Connect Timeout=60";
        static readonly string sScope = "EmployeeScope";

        public static void Sync()
        {
            SqlConnection serverConn = new SqlConnection(sServerConnection);
            SqlConnection clientConn = new SqlConnection(sClientConnection);

            //SyncOrchestrator syncOrchestrator = new SyncOrchestrator();

            //syncOrchestrator.LocalProvider = new SqlSyncProvider(sScope, clientConn,"",".dbo");
            //syncOrchestrator.RemoteProvider = new SqlSyncProvider(sScope, serverConn,"",".dbo");
           
            //syncOrchestrator.Direction = SyncDirectionOrder.UploadAndDownload;

            //((SqlSyncProvider)syncOrchestrator.LocalProvider).ApplyChangeFailed += new EventHandler<DbApplyChangeFailedEventArgs>(Program_ApplyChangeFailed);

            //SyncOperationStatistics syncStats = syncOrchestrator.Synchronize();

            //Console.WriteLine("Start Time: " + syncStats.SyncStartTime);
            //Console.WriteLine("Total Changes Uploaded: " + syncStats.UploadChangesTotal);
            //Console.WriteLine("Total Changes Downloaded: " + syncStats.DownloadChangesTotal);
            //Console.WriteLine("Complete Time: " + syncStats.SyncEndTime);
            //Console.WriteLine(String.Empty);
        }
        public static void ProvisionServer()
        {
            SqlConnection serverConn = new SqlConnection(sServerConnection);

            //DbSyncScopeDescription scopeDesc = new DbSyncScopeDescription(sScope);
           
            //DbSyncTableDescription tableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable("Product", serverConn);
          
            //scopeDesc.Tables.Add(tableDesc);

            //SqlSyncScopeProvisioning serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);
            //serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);
            //serverProvision.Apply();
        }
        //public static void ProvisionClient()
        //{
        //    SqlConnection serverConn = new SqlConnection(sServerConnection);
        //    SqlConnection clientConn = new SqlConnection(sClientConnection);

        //    DbSyncScopeDescription scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(sScope, serverConn);
        //    SqlSyncScopeProvisioning clientProvision = new SqlSyncScopeProvisioning(clientConn, scopeDesc);

        //    clientProvision.Apply();
        //}
        private static void Program_ApplyChangeFailed(object sender, DbApplyChangeFailedEventArgs e)
        {
            
        }

        public static void ProvisionClient()
        {
            SqlConnection serverConn = new SqlConnection(sServerConnection);
            SqlConnection clientConn = new SqlConnection(sClientConnection);

            //DbSyncScopeDescription scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(sScope, serverConn);
            //SqlSyncScopeProvisioning clientProvision = new SqlSyncScopeProvisioning(clientConn, scopeDesc);

           // clientProvision.Apply();
        }
 
        public static void Begin()
        {
            //ProvisionServer();

            //ProvisionClient();

                        //ProvisionClient();
            Sync();
        }
    }
}
