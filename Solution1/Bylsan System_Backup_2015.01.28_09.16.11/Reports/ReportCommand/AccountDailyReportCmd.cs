using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.Accountant;

namespace Bylsan_System.Reports.ReportCommand
{
    public  class AccountDailyReportCmd
    {
        public AccountDailyReportCmd()
        {
        }

        public void GetExpenssesMovmentByDate(DateTime date)
        {
            var q = AccountDailyCmd.GetAllAccountDailyByDate(date);
            var rs = new ReportDataSource();
            var ls = new List<AccountDailyReportObj>();

            foreach (var item in q)
            {
                ls.Add(new AccountDailyReportObj()
                {
                AccountName = item.Account.AccountName,
                DateOfProcess = item.DateOfProcess.Value,
                TotalIn = item.TotalIn.Value,
                TotalOut = item.TotalOut.Value,
                Description = item.Description,
                CommandArg = item.CommandArg,
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepAccountDaily.rdlc";
            frm.ShowDialog();
        }



        public void GetExpenssesMovmentByDate( int AccountID)
        {
            var q = AccountDailyCmd.GetAllAccountDailyByAccountID(AccountID);
            var rs = new ReportDataSource();
            var ls = new List<AccountDailyReportObj>();

            foreach (var item in q)
            {
                ls.Add(new AccountDailyReportObj()
                {
                   AccountName = item.Account.AccountName,
                   DateOfProcess = item.DateOfProcess.Value,
                   TotalIn = item.TotalIn.Value,
                   TotalOut = item.TotalOut.Value,
                   Description = item.Description,
                   CommandArg = item.CommandArg,
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepAccountDaily.rdlc";
            frm.ShowDialog();
        }
    }
}
