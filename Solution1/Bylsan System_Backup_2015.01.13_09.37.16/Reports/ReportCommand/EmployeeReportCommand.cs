using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.Reports.ReportCommand
{
   public class EmployeeReportCommand
    {

       public EmployeeReportCommand() { }
        /// <summary>
        /// /
        /// </summary>
       public void GetAllCoustmer()
       {///
           var q = EmployeesCmd.GetAllEmployees();
           ReportDataSource rs = new ReportDataSource();
           List<EmployeeReportObj> ls = new List<EmployeeReportObj>();
         
           foreach (var item in q)
           {

               ls.Add(new EmployeeReportObj()
               {
                 EmpID=item.ID,
                 EmpName=item.Emp_Name,
                 CreateDate=item.CreateDate.Value,
                 HereDate=item.HereDate.Value,
                 HomeAddress=item.HomeAddress,
                 Job=item.Job,
                 PhoneNumber=item.PhoneNumber,
                 Nationalty=item.Nationalty,
                 PersonaltyID=item.Personalty_ID,
                 
               }); 
           }
           rs.Name = "";
           rs.Value = ls;
           RebortView frm = new RebortView();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.00000000.rdlc";
           frm.ShowDialog();


       }
    }
}
