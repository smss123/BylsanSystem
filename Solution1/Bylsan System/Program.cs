using Bylsan_System.BranchForms;
using Bylsan_System.SecurityForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bylsan_System.SenarioAddOrderForms;
using Telerik.WinControls;
namespace Bylsan_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new FrmLogin());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            RadMessageBox.Show("Oops , Same error here,\n"+e.Exception.ToString(), "error");
        }
    }
}
