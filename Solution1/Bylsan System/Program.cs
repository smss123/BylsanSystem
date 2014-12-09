using Bylsan_System.BranchForms;
using Bylsan_System.SecurityForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bylsan_System.SenarioAddOrderForms;
using Telerik.WinControls;
using Xprema.XAlerter;
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
            //XAlertManager cp = new XAlertManager();
            //cp.Alerts.Add(new XAlert() {  });
            //SettingX cc = new SettingX();
          
           // cp.OnChangeStatus += cp_OnChangeStatus;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new FrmLogin());
            //Application.Run(new Form1());
        }

        //static void cp_OnChangeStatus(object sender, string e)
        //{
        //    var q = (XAlert)sender;
    
        //}

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            RadMessageBox.Show("Oops , Same error here,\n"+e.Exception.ToString(), "error");
        }
    }
}
