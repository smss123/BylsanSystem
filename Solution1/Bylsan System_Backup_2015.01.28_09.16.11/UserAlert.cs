using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer.MailServer;

namespace Bylsan_System
{
    public class UserAlert
    {
        private RadDesktopAlert Alert = new RadDesktopAlert();
        private Timer AlertTimer = new Timer();

        private int OldMessagesCountInBox ;



        public   void ActivateTimer()
        {
            AlertTimer.Interval = 3000;
            AlertTimer.Enabled = true;
            try
            {
                OldMessagesCountInBox = (from i in InBoxCmd.GetAllMessages()
                                          select i.ID).Max();
                AlertTimer.Tick += AlertTimer_Tick;
                AlertTimer.Start();
            }
            catch (System.InvalidOperationException ex )
            {
                return;
            }
        }
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            var NewMessagesCount  = (from i in InBoxCmd.GetAllMessages()
                                     select i.ID).Max();
            if (NewMessagesCount > OldMessagesCountInBox)
            {
                Alert.CaptionText = "Alert";
                Alert.ContentText = "Hi you have anew message ..";
                Alert.Show();
                OldMessagesCountInBox = NewMessagesCount;
            }
        }
    }
}
