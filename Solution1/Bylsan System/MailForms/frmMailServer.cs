using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;

using System.Threading;

using XamaDataLayer.Security;
using XamaDataLayer.MailServer;
using Telerik.WinControls.UI;


namespace Bylsan_System.MailForms
{
    public partial class frmMailServer : Form
    {
        public frmMailServer()
        {
            InitializeComponent();
        }
        List<Inbox> ls = new List<Inbox>();
        private void frmMailServer_Load(object sender, EventArgs e)
        {
           // LoadEmail();
            CreateListView();
            PopulateMessagesListView();

        }


        #region "    ^^^ UnUsed    "
        private void LoadEmail()
        {
            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "NotRead",
                Subject = "Hi This subject 1"
            });

            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "NotRead",
                Subject = "Hi This subject 2"
            });
            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "NotRead",
                Subject = "Hi This subject 3"
            });

            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "NotRead",
                Subject = "Hi This subject 4"
            });

            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "Readed",
                Subject = "Hi This subject 5"
            });
            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "Readed",
                Subject = "Hi This subject 6"
            });
            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "Readed",
                Subject = "Hi This subject 7"
            });
            ls.Add(new Inbox()
            {
                DateOfMessage = DateTime.Now,
                ID = 1,
                MessageText = "Message Here Now",
                ReciverUserID = 1,
                SenderUserID = 1,
                Status = "Readed",
                Subject = "Hi This subject 8"
            });
        }
        #endregion 

        private void NewBtn_Click(object sender, EventArgs e)
        {
            FrmSendMail frm = new FrmSendMail();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmMailServer_Load(sender, e);
        }


        #region "    ^^^ Create MessagesListView   "
        void CreateListView()
        {
            MessagesListView.View = View.Details;
            MessagesListView.Columns.Add("SenderID", 50, HorizontalAlignment.Center); 
            MessagesListView.Columns.Add("From", 150, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Subject", 300, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        void PopulateMessagesListView()
        {
            var GetAllInBoxMessages = ( from u in  InBoxCmd.GetAllMessages() 
                                        where u.ReciverUserID  == XamaDataLayer .Security .UserInfo .CurrentUserID
                                        select u ).ToList ();
            MessagesListView.Items.Clear();
            foreach (var item in GetAllInBoxMessages )
            {
                ListViewItem Itm = new ListViewItem(item.ID.ToString());
                
                Itm.SubItems.Add(( from u in  UserCmd .GetAllUsers() where u.ID == item .SenderUserID select u.UserName ).First () );
                Itm.SubItems.Add(item .Subject .ToString ());
                Itm.SubItems.Add(item .Status .ToString ());

                MessagesListView.Items.Add(Itm);
            }
        }

        #endregion 

    }
}
