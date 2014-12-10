using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using XamaDataLayer.MailServer;
namespace Bylsan_System
{
    public class UserAlert
    {
        
        private RadDesktopAlert Alert = new RadDesktopAlert();
        private Timer AlertTimer = new Timer();

        int OldMessagesCountInBox ;

        #region "   Timer      "
       public   void ActivateTimer()
        {
            AlertTimer.Interval = 3000;
            AlertTimer.Enabled = true;
            OldMessagesCountInBox = (from i in InBoxCmd.GetAllMessages() select i.ID).Max();
            this.AlertTimer.Tick += AlertTimer_Tick;
            AlertTimer.Start();

        }
        void AlertTimer_Tick(object sender, EventArgs e)
        {
            
            int NewMessagesCount  = (from i in InBoxCmd.GetAllMessages() select i.ID).Max();
            if (NewMessagesCount > OldMessagesCountInBox)
            {
                this.Alert.CaptionText = "Alert";
                this.Alert.ContentText = "Hi you have anew message ..";
                this.Alert.Show();
                OldMessagesCountInBox = NewMessagesCount;
            }


        }
        #endregion

    }
}
