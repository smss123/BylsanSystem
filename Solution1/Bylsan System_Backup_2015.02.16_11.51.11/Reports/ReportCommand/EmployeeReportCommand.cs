using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.Reports.ReportCommand
{
    public class EmployeeReportCommand
    {
        public EmployeeReportCommand()
        {
        }
        /// <summary>
        /// /
        /// </summary>
        public void GetAllCoustmer()
        {///
            var q = EmployeesCmd.GetAllEmployees();
            var rs = new ReportDataSource();
            var ls = new List<EmployeeReportObj>();

            foreach (var item in q)
            {
                ls.Add(new EmployeeReportObj()
                {
                 EmpID = item.ID,
                 EmpName = item.Emp_Name,
                 CreateDate = item.CreateDate.Value,
                 HereDate = item.HereDate.Value,
                 HomeAddress = item.HomeAddress,
                 Job = item.Job,
                 PhoneNumber = item.PhoneNumber,
                 Nationalty = item.Nationalty,
                 PersonaltyID = item.Personalty_ID,
                 });
            }
            rs.Name = string.Empty;
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "UcasProWindowsForm.Reports.00000000.rdlc";
            frm.ShowDialog();
        }
    }
}
