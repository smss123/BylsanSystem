using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;
using Bylsan_System.Reports.ReportsObject;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Bylsan_System.Reports.ReportCommand
{
    public class BillReportCommand
    {
        public void PrintBill(List<RptBillObj> bill)
        {
            if (File.Exists(Application.StartupPath + @"\SalesBill.PNG"))
            {
                File.Delete(Application.StartupPath + @"\SalesBill.PNG");
            }
            var rs = new ReportDataSource();
            var ls = new List<RptBillObj>();
            ls.AddRange(bill);
            rs.Name = "DataSet1";
            rs.Value = ls;
            var frm = new RebortView();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Bylsan_System.Reports.Sheets.RepBillPrint.rdlc";
            //frm.ShowDialog();
            //Export to PDF. Get binary content.
            byte[] pdfContent = frm.reportViewer1.LocalReport.Render("IMAGE");

            //Creatr PDF file on disk
            var pdfPath = "SalesBill.PNG";
            var pdfFile = new System.IO.FileStream(pdfPath, System.IO.FileMode.Create);
            pdfFile.Write(pdfContent, 0, pdfContent.Length);
            Application.DoEvents();
            pdfFile.Close();
           
            Application.DoEvents();
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PrinterSettings.PrinterName = Properties.Settings.Default.SmallPrinter;
            pd.DefaultPageSettings.Landscape = false; //or false!
            pd.PrintPage += (send, args) =>
            {
                Image i = Image.FromFile(Application.StartupPath + @"\SalesBill.PNG");
                Rectangle m = args.MarginBounds;

                if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                {
                    m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                }
                else
                {
                    m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                }
                args.Graphics.DrawImage(i, m);
            };
            pd.Print();
        }
    }
}
