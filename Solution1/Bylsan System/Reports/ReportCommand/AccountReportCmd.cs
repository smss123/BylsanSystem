using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.Accountant;

namespace Bylsan_System.Reports.ReportCommand
{
    public class AccountReportCmd : IDisposable
    {
        public void GetBalanceSheet()
        {
            var q = AccountsCmd.GetAllAccounts();//.GetAllAccountDailyByDate(date);




            ReportDataSource rs = new ReportDataSource();
            List<BalanceSheetObj> ls = new List<BalanceSheetObj>();

            foreach (var item in q)
            {

                ls.Add(new BalanceSheetObj()
                {
                    HashNumber= Guid.NewGuid().ToString(),
                     AccountCategory  = item.AccountCategory.AccountCategoryName,
                      AccountName  = item.AccountName,
                       Balance = AccountsCmd.GetAccountBalance(item.ID)
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            RebortView frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RptBalanceSheet.rdlc";
            frm.ShowDialog();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
