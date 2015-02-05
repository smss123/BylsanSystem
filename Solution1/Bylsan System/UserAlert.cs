using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.MailServer;
using Xprema.XExtention;

namespace Bylsan_System
{
    public class UserAlert
    {
        private RadDesktopAlert Alert = new RadDesktopAlert();
        private Timer AlertTimer = new Timer();

        private int OldMessagesCountInBox ;



        public   void ActivateTimer()
        {
            AlertTimer.Interval = 5000;
            AlertTimer.Enabled = true;
            try
            {
                OldMessagesCountInBox = (from i in InBoxCmd.GetAllMessages()
                                          select i.ID).Max();
                
            }
            catch (System.InvalidOperationException ex )
            {
                //MessageBox.Show(ex.ToString());
                //return;
            }
            AlertTimer.Tick += AlertTimer_Tick;
            AlertTimer.Start();
        }
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var NewMessagesCount = (from i in InBoxCmd.GetAllMessages()
                                        select i.ID).Max();
                if (NewMessagesCount > OldMessagesCountInBox)
                {
                    Alert = new RadDesktopAlert();
                    Alert.CaptionText = "Alert";
                    Alert.ContentText = "Hi you have anew message ..";
                    Alert.AutoCloseDelay = 3000;
                    Alert.Show();
                    OldMessagesCountInBox = NewMessagesCount;
                }
            }
            catch (Exception)
            {
                
               
            }
           

            var db = new DbDataContext();
            foreach (var item in db.Stores)
            {
                if (item.AvailableQty <= db.ProductMinimummQties.Where(p => p.ID == item.ProductID).Single().MinimumQty.ToInt())
                {
                    Alert = new RadDesktopAlert();
                    Alert.AutoCloseDelay = 3;
                    Alert.CaptionText = "Minimum stock Qty";
                    Alert.ContentText = string .Format("the item {0} now Qty is {1} \n that means its very low.",item.Product.Product_Name,item.AvailableQty.ToString());
                    Alert.Show();
                    
                }
            }
        }
    }
}
