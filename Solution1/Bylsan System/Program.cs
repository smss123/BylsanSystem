using Bylsan_System.SecurityForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using Telerik.WinControls;

namespace Bylsan_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new FrmLogin());
        }







        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            RadMessageBox.Show("Oops , Same error here,\n" + e.Exception.Message, "error");

            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                            Screen.PrimaryScreen.Bounds.Height,
                            PixelFormat.Format32bppArgb);


            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);


            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);



            bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);
            Application.DoEvents();
            var mail = new MailMessage();
            var SmtpServer = new SmtpClient("smtp.xprema.net");
            mail.From = new MailAddress("support@xprema.net");
            mail.To.Add("support@xprema.net");
            mail.Subject = "Exception from System " + Application.ProductName;
            mail.Body = string.Format("Exption is \n{0}\n----------------------------------------------------------------\n{1}", e.Exception.ToString(), string.Empty);

            var attachment = new System.Net.Mail.Attachment("Screenshot.png");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("support@xprema.net", "1234");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);
        }
    }
}
