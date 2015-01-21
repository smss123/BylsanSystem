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
     public  class ExpenssesMovmenReportCmd
    {

         public ExpenssesMovmenReportCmd(){}
                     
       public void GetExpenssesMovmentByDate(DateTime date)
       {//
           var q = ExpenssesMovmentCmd.GetAllExpnssesMovmentsByDate(date);
           ReportDataSource rs = new ReportDataSource();
           List<ExpenssesMovmentReportObj> ls = new List<ExpenssesMovmentReportObj>();
         
           foreach (var item in q)
           {

               ls.Add(new ExpenssesMovmentReportObj()
               {
               ExpenssesName=item.Expenss.ExpenssesName,
               ExpnessID=item.ID,
               Amount=item.Amount.Value,
               Description=item.Description,
               DateOfProcess=item.DateOfProcess.Value,
               }); 
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           RebortView frm = new RebortView();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepExpenssesMovment.rdlc";
           frm.ShowDialog();


       }


       public void GetExpenssesAll()
       {//
           var q = ExpenssesMovmentCmd.GetAll();
           ReportDataSource rs = new ReportDataSource();
           List<ExpenssesMovmentReportObj> ls = new List<ExpenssesMovmentReportObj>();

           foreach (var item in q)
           {

               ls.Add(new ExpenssesMovmentReportObj()
               {
                   ExpenssesName = item.Expenss.ExpenssesName,
                   ExpnessID = item.ID,
                   Amount = item.Amount.Value,
                   Description = item.Description,
                   DateOfProcess = item.DateOfProcess.Value,
               });
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           RebortView frm = new RebortView();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepExpenssesMovment.rdlc";
           frm.ShowDialog();


       }

    }
}
