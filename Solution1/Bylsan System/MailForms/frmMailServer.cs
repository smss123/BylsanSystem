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
            GroupDisplayMessage.Visible = false;


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
            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "NotRead",
            //    Subject = "Hi This subject 1"
            //});

            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "NotRead",
            //    Subject = "Hi This subject 2"
            //});
            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "NotRead",
            //    Subject = "Hi This subject 3"
            //});

            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "NotRead",
            //    Subject = "Hi This subject 4"
            //});

            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "Readed",
            //    Subject = "Hi This subject 5"
            //});
            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "Readed",
            //    Subject = "Hi This subject 6"
            //});
            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "Readed",
            //    Subject = "Hi This subject 7"
            //});
            //ls.Add(new Inbox()
            //{
            //    DateOfMessage = DateTime.Now,
            //    ID = 1,
            //    MessageText = "Message Here Now",
            //    ReciverUserID = 1,
            //    SenderUserID = 1,
            //    Status = "Readed",
            //    Subject = "Hi This subject 8"
            //});
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
            MessagesListView.Columns.Clear();
            MessagesListView.View = View.Details;
            MessagesListView.Columns.Add("Serial ", 50, HorizontalAlignment.Center); 
            MessagesListView.Columns.Add("From", 150, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Subject", 300, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        void PopulateMessagesListView()
        {
            var GetAllInBoxMessages = ( from u in  InBoxCmd.GetAllMessages() 
                                        where u.ReciverUserID  == XamaDataLayer .Security .UserInfo .CurrentUserID
                                          && u.Status != "~Received"
                                        select u ).ToList ();
            MessagesListView.Items.Clear();
            foreach (var item in GetAllInBoxMessages )
            {
                ListViewItem Itm = new ListViewItem(item.ID.ToString());
                
                Itm.SubItems.Add(( from u in  UserCmd .GetAllUsers() where u.ID == item .SenderUserID select u.UserName ).First () );
                Itm.SubItems.Add(item .Subject .ToString ());
                Itm.SubItems.Add(item .Status .ToString ());

                MessagesListView.Items.Add(Itm);
                //=======================================

                ReSizeFontsAndColor();
            }
        }

        void ReSizeFontsAndColor()
        {
            if (MessagesListView.Items.Count != 0)
            {
                foreach (ListViewItem  Itm in MessagesListView .Items )
                {
                    if (Itm.SubItems[3].Text == "UnRead")
                    {
                        Itm.ForeColor = Color.Yellow; 
                        Itm.BackColor = Color.Green ;
                        Itm.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    }
                }
            }
        }
        #endregion 

        private void InBoxBtn_Click(object sender, EventArgs e)
        {
            MessagesListView.Columns.Clear();
            CreateListView();
            MessagesListView.Columns[1].Text = "From";
            frmMailServer_Load(sender, e);
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            MessagesListView.Columns.Clear();
            CreateListView();
            MessagesListView.Columns[1].Text = "Sent To";
            var GetAllInBoxMessages = (from u in OutBoxCmd.LoadAllMessages ()
                                       where u.SenderUserID  == XamaDataLayer.Security.UserInfo.CurrentUserID
                                         && u.Status != "~Sent"
                                       select u).ToList();
            MessagesListView.Items.Clear();
            foreach (var item in GetAllInBoxMessages)
            {
                ListViewItem Itm = new ListViewItem(item.ID.ToString());

                Itm.SubItems.Add((from u in UserCmd.GetAllUsers() where u.ID == item.ReciverUserID   select u.UserName).First());
                Itm.SubItems.Add(item.Subject.ToString());
                Itm.SubItems.Add(item.Status.ToString());

                MessagesListView.Items.Add(Itm);
            }
            ReSizeFontsAndColor();
            Operation.EndOperation(this);
        }

        #region "  ^^^ UnUsed       "
        void GetAllDarfts(){
             Operation.BeginOperation(this);

            int X = XamaDataLayer.Security.UserInfo.CurrentUserID;

            MessagesListView.Columns.Clear();

            CreateListView();

            MessagesListView.Columns[1].Text = "Sent To / From";

               var GetMyDrafts = (from i in InBoxCmd.GetAllMessages()
                               where i.ReciverUserID == XamaDataLayer .Security .UserInfo .CurrentUserID
                               && i.Status == "~Received" 
                               join o in OutBoxCmd.LoadAllMessages()       
                               on  i.ReciverUserID  equals (o.SenderUserID )  where o.Status == "~Sent"
                               select new { i,o }).ToList();

               Operation.EndOperation(this);
        }

        #endregion 


        private void DraftsBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
   
            MessagesListView.Columns.Clear();
            CreateListView();
            MessagesListView.Columns[1].Text = "Sent To / From";
         

            var GetAllOutBoxMessages = (from u in OutBoxCmd.LoadAllMessages()
                                        where u.SenderUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                        && u.Status == "~Sent"
                                        select u).ToList();
            MessagesListView.Items.Clear();
            foreach (var item in GetAllOutBoxMessages)
            {
                ListViewItem OutItm = new ListViewItem(item .ID .ToString ());

                OutItm.SubItems.Add((from u in UserCmd.GetAllUsers() where u.ID == item.SenderUserID  select u.UserName).First());
                OutItm.SubItems.Add(item.Subject.ToString());
                OutItm.SubItems.Add(item.Status.ToString());

                MessagesListView.Items.Add(OutItm);
           }
            ////===================================================================================================
            var GetAllInBoxMessages = (from u in InBoxCmd.GetAllMessages()
                                       where u.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                       && u.Status == "~Received"
                                       select u).ToList();

            foreach (var xitem in GetAllInBoxMessages)
            {
                ListViewItem InItm = new ListViewItem(xitem.ID.ToString());

                InItm.SubItems.Add((from u in UserCmd.GetAllUsers()
                                    where u.ID == xitem.SenderUserID
                                    select u.UserName).First());
                InItm.SubItems.Add(xitem.Subject.ToString());
                InItm.SubItems.Add(xitem.Status.ToString());

                MessagesListView.Items.Add(InItm);
            }
            ////===================================================================================================
            ReSizeFontsAndColor();
            Operation.EndOperation(this);
        }

    

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MessagesListView.Items.Clear();
        }

        
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count != 0)
            {
              
                int Indx = int .Parse (MessagesListView.SelectedItems[0].Text.ToString ()) ;
              //=====================================================================================
                if (MessagesListView.Columns[1].Text == "From")
                {
                    var GetMessage = (from m in InBoxCmd.GetAllMessages()
                                      where m.ID == Indx 
                                      && m.ReciverUserID == XamaDataLayer .Security .UserInfo .CurrentUserID                                      
                                      select m).ToList ();
                    foreach (var item in GetMessage )
                    {


                        labUserName.Text = (from u in UserCmd.GetAllUsers() where u.ID == item.SenderUserID select u.UserName).First();
                        labSubject.Text = item.Subject;
                        richTextBox1.Text = item.MessageText.ToString();
                        labMessageDate.Text = item.DateOfMessage.ToString();

                    }
              
                    GroupDisplayMessage.Visible = true;
                    //===============================================================================
                    // Edit Message Status : 
                    Inbox tb = new Inbox() {  Status = "Readed" }; InBoxCmd.EditMessage(tb,Indx );
                }
                //===================================================================================
                if (MessagesListView.Columns[1].Text == "Sent To")
                {
                    var GetMessage = (from m in OutBoxCmd .LoadAllMessages ()
                                      where m.ID == Indx
                                      && m.SenderUserID  == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      && m.Status == "Sent"
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        labUserName.Text = (from u in UserCmd.GetAllUsers() where u.ID == item.ReciverUserID  select u.UserName).First();
                        labSubject.Text = item.Subject;
                        richTextBox1.Text = item.MessageText.ToString();
                        labMessageDate.Text = item.DateOfMessage.ToString();

                    }

                    GroupDisplayMessage.Visible = true;
                }
                //===================================================
                if (MessagesListView.Columns[1].Text == "Sent To / From")
                {

                }
                

            }
        }

    
        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            labUserName.Text = "";
            labSubject.Text = "";
            GroupDisplayMessage.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count != 0)
            {

                int Indx = int.Parse(MessagesListView.SelectedItems[0].Text.ToString());
                //================================================================================
                if (MessagesListView.Columns[1].Text == "From")
                {
                 if(MessageBox .Show ("Are You Sure ?","Delete Option",MessageBoxButtons.YesNo) ==  System.Windows.Forms.DialogResult.Yes  ){
                     InBoxCmd.DeleteMsg(Indx);
                     frmMailServer_Load(sender, e);
                 }
                }
                //====================================================
                if (MessagesListView.Columns[1].Text == "Sent To")
                {
                    if (MessageBox.Show("Are You Sure ?", "Delete Option", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes )
                    {
                        OutBoxCmd.DeleteMsg(Indx);
                        frmMailServer_Load(sender, e);
                    }
                }
   

            }
        }

        private void MessagesListView_MouseHover(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count == 0)
            {
                OpenBtn.Enabled = false;
                MoveBtn.Enabled = false;
                ClearBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }

        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count != 0)
            {

                int Indx = int.Parse(MessagesListView.SelectedItems[0].Text.ToString());
                //================================================================================
                if (MessagesListView.Columns[1].Text == "From") 
                {
                    var GetMessage = (from m in InBoxCmd.GetAllMessages()
                                      where m.ID == Indx
                                      && m.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        Inbox intb = new Inbox (){
               
                         Status = "~Received"
                        };
                        InBoxCmd.EditMessage(intb, Indx);
                        Operation.ShowToustOk("Moved ...", this);

                    }
                  
                }
                //================================================================================
                if (MessagesListView.Columns[1].Text == "Sent To")
                {
                    var GetMessage = (from m in OutBoxCmd.LoadAllMessages()
                                      where m.ID == Indx
                                      && m.SenderUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        OutBox OutTb = new OutBox()
                        {

                            Status = "~Sent"
                        };
                        OutBoxCmd.EditMessage(OutTb, Indx);
                        Operation.ShowToustOk("Moved ...", this);
                    }
                    
                }






            }
        }





    }
}
