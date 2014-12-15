using Bylsan_System.Reports.ReportsObject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;

namespace Bylsan_System.Reports.ReportCommand
{
   public class CustmoerReportCmd
    {

           
            public CustmoerReportCmd() { }
            CustomerReportObj xx = new CustomerReportObj();
       public void GetAllCoustmer()
       {//
           var q = CustomersCmd.GetAllCustmers();
           ReportDataSource rs = new ReportDataSource();
           List<CustomerReportObj> ls = new List<CustomerReportObj>();
         
           foreach (var item in q)
           {
             
               ls.Add(new CustomerReportObj()
               {
                 CustomerID=item.ID,
                 CustomerName=item.CustomerName,
                 CreateDate=item.CreateDate.Value,
                 PhoneNumber=item.PhoneNumber,
                 Points=item.Points.Value,
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
