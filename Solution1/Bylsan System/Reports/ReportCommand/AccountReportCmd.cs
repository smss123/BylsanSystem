using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.Accountant;

namespace Bylsan_System.Reports.ReportCommand
{
    public class AccountReportCmd : IDisposable
    {
        public void GetBalanceSheet()
        {
            var q = AccountsCmd.GetAllAccounts();




            var rs = new ReportDataSource();
            var ls = new List<BalanceSheetObj>();

            foreach (var item in q)
            {
                if (item.AccountCategory.AccountCategoryName.Contains("Orders"))
                {
                    continue;
                }
                ls.Add(new BalanceSheetObj()
                {
                    HashNumber = Guid.NewGuid().ToString(),
                     AccountCategory  = item.AccountCategory.AccountCategoryName,
                      AccountName  = item.AccountName,
                       Balance = AccountsCmd.GetAccountBalance(item.ID)
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RptBalanceSheet.rdlc";
            frm.ShowDialog();
        }
        public void GetBalanceSheet(DateTime frmx , DateTime to)
        {
            var q = AccountsCmd.GetAllAccounts();




            var rs = new ReportDataSource();
            var ls = new List<BalanceSheetObj>();

            foreach (var item in q)
            {
                if (item.AccountCategory.AccountCategoryName.Contains("Orders"))
                {
                    continue;
                }
                ls.Add(new BalanceSheetObj()
                {
                    HashNumber = Guid.NewGuid().ToString(),
                    AccountCategory = item.AccountCategory.AccountCategoryName,
                    AccountName = item.AccountName,
                    Balance = AccountsCmd.GetAccountBalance(item.ID, frmx, to)
                });
            };
            
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
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
