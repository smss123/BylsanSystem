using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;

using XamaDataLayer.Security;
using XamaDataLayer.MailServer;


namespace Bylsan_System.MailForms
{
    public partial class frmMailServer : RadForm
    {
        public frmMailServer()
        {
            InitializeComponent();
            GroupDisplayMessage.Visible = false;
        }
        private void frmMailServer_Load(object sender, EventArgs e)
        {
            CreateListView();
            PopulateMessagesListView();
        }



        private void LoadEmail()
        {
        }


        private void NewBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendMail();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmMailServer_Load(sender, e);
        }



        private void CreateListView()
        {
            MessagesListView.Columns.Clear();
            MessagesListView.View = View.Details;
            MessagesListView.Columns.Add("Serial ", 50, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("From", 150, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Subject", 300, HorizontalAlignment.Center);
            MessagesListView.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        private void PopulateMessagesListView()
        {
            var GetAllInBoxMessages = ( from u in  InBoxCmd.GetAllMessages()
                                        where u.ReciverUserID  == XamaDataLayer .Security .UserInfo .CurrentUserID
                                          && u.Status != "~Received"
                                        select u ).ToList ();
            MessagesListView.Items.Clear();
            foreach (var item in GetAllInBoxMessages )
            {
                var Itm = new ListViewItem(item.ID.ToString());

                Itm.SubItems.Add(( from u in  UserCmd .GetAllUsers()
                                    where u.ID == item .SenderUserID
                                    select u.UserName ).First () );
                Itm.SubItems.Add(item .Subject .ToString ());
                Itm.SubItems.Add(item .Status .ToString ());

                MessagesListView.Items.Add(Itm);


                ReSizeFontsAndColor();
            }
        }


        private void ReSizeFontsAndColor()
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
                var Itm = new ListViewItem(item.ID.ToString());

                Itm.SubItems.Add((from u in UserCmd.GetAllUsers()
                                   where u.ID == item.ReciverUserID
                                     select u.UserName).First());
                Itm.SubItems.Add(item.Subject.ToString());
                Itm.SubItems.Add(item.Status.ToString());

                MessagesListView.Items.Add(Itm);
            }
            ReSizeFontsAndColor();
            Operation.EndOperation(this);
        }



        private void GetAllDarfts()
        {
            Operation.BeginOperation(this);

            MessagesListView.Columns.Clear();

            CreateListView();

            MessagesListView.Columns[1].Text = "Sent To / From";

               (from i in InBoxCmd.GetAllMessages()
                               where i.ReciverUserID == XamaDataLayer .Security .UserInfo .CurrentUserID
                               && i.Status == "~Received"
                               join o in OutBoxCmd.LoadAllMessages()
                               on  i.ReciverUserID  equals (o.SenderUserID )
                               where o.Status == "~Sent"
                               select new
                { i, o }).ToList();

            Operation.EndOperation(this);
        }




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
                var OutItm = new ListViewItem(item .ID .ToString ());

                OutItm.SubItems.Add((from u in UserCmd.GetAllUsers()
                                      where u.ID == item.SenderUserID
                                       select u.UserName).First());
                OutItm.SubItems.Add(item.Subject.ToString());
                OutItm.SubItems.Add(item.Status.ToString());

                MessagesListView.Items.Add(OutItm);
            }

            var GetAllInBoxMessages = (from u in InBoxCmd.GetAllMessages()
                                       where u.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                       && u.Status == "~Received"
                                       select u).ToList();

            foreach (var xitem in GetAllInBoxMessages)
            {
                var InItm = new ListViewItem(xitem.ID.ToString());

                InItm.SubItems.Add((from u in UserCmd.GetAllUsers()
                                    where u.ID == xitem.SenderUserID
                                    select u.UserName).First());
                InItm.SubItems.Add(xitem.Subject.ToString());
                InItm.SubItems.Add(xitem.Status.ToString());

                MessagesListView.Items.Add(InItm);
            }

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
                var Indx = int .Parse (MessagesListView.SelectedItems[0].Text.ToString ()) ;

                if (MessagesListView.Columns[1].Text == "From")
                {
                    var GetMessage = (from m in InBoxCmd.GetAllMessages()
                                      where m.ID == Indx
                                      && m.ReciverUserID == XamaDataLayer .Security .UserInfo .CurrentUserID
                                      select m).ToList ();
                    foreach (var item in GetMessage )
                    {
                        labUserName.Text = (from u in UserCmd.GetAllUsers()
                                             where u.ID == item.SenderUserID
                                             select u.UserName).First();
                        labSubject.Text = item.Subject;
                        richTextBox1.Text = item.MessageText.ToString();
                        labMessageDate.Text = item.DateOfMessage.ToString();
                    }

                    GroupDisplayMessage.Visible = true;


                    var tb = new Inbox() {  Status = "Readed" };
                    InBoxCmd.EditMessage(tb, Indx );
                }

                if (MessagesListView.Columns[1].Text == "Sent To")
                {
                    var GetMessage = (from m in OutBoxCmd .LoadAllMessages ()
                                      where m.ID == Indx
                                      && m.SenderUserID  == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      && m.Status == "Sent"
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        labUserName.Text = (from u in UserCmd.GetAllUsers()
                                             where u.ID == item.ReciverUserID
                                              select u.UserName).First();
                        labSubject.Text = item.Subject;
                        richTextBox1.Text = item.MessageText.ToString();
                        labMessageDate.Text = item.DateOfMessage.ToString();
                    }

                    GroupDisplayMessage.Visible = true;
                }

                if (MessagesListView.Columns[1].Text == "Sent To / From")
                {
                    var SelectedMesageStatus = MessagesListView.SelectedItems[0].SubItems [3].Text.ToString();

                    switch (SelectedMesageStatus)
                    {
                        case "~Sent":
                            var GetMessage = (from m in OutBoxCmd .LoadAllMessages ()
                                      where m.ID == Indx
                                      && m.Status == "~Sent"
                                      select m).ToList();
                            foreach (var item in GetMessage)
                            {
                                labUserName.Text = (from u in UserCmd.GetAllUsers()
                                                     where u.ID == item.ReciverUserID
                                                      select u.UserName).First();
                                labSubject.Text = item.Subject;
                                richTextBox1.Text = item.MessageText.ToString();
                                labMessageDate.Text = item.DateOfMessage.ToString();
                            }

                            GroupDisplayMessage.Visible = true;


                            break ;

                        case "~Received":


                            var GetInBoxMessage = (from m in InBoxCmd.GetAllMessages()
                                      where m.ID == Indx
                                      && m.Status == "~Received"
                                      select m).ToList ();
                            foreach (var item in GetInBoxMessage )
                            {
                                labUserName.Text = (from u in UserCmd.GetAllUsers()
                                                     where u.ID == item.SenderUserID
                                                     select u.UserName).First();
                                labSubject.Text = item.Subject;
                                richTextBox1.Text = item.MessageText.ToString();
                                labMessageDate.Text = item.DateOfMessage.ToString();
                            }

                            GroupDisplayMessage.Visible = true;

                            break;
                    }
                }
            }
        }



        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            frmMailServer_Load(sender, e);
            richTextBox1.Text = string.Empty;
            labUserName.Text = string.Empty;
            labSubject.Text = string.Empty;
            GroupDisplayMessage.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count != 0)
            {
                var Indx = int.Parse(MessagesListView.SelectedItems[0].Text.ToString());

                if (MessagesListView.Columns[1].Text == "From")
                {
                    if (MessageBox .Show ("Are You Sure ?", "Delete Option", MessageBoxButtons.YesNo) ==  System.Windows.Forms.DialogResult.Yes  )
                    {
                        InBoxCmd.DeleteMsg(Indx);
                        frmMailServer_Load(sender, e);
                    }
                }

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
            if (MessagesListView.Columns[1].Text == "Sent To / From")
            {
                MoveBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            if (MessagesListView.Items.Count != 0)
            {
                var Indx = int.Parse(MessagesListView.SelectedItems[0].Text.ToString());

                if (MessagesListView.Columns[1].Text == "From")
                {
                    var GetMessage = (from m in InBoxCmd.GetAllMessages()
                                      where m.ID == Indx
                                      && m.ReciverUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        var intb = new Inbox () { Status = "~Received"
                        };
                        InBoxCmd.EditMessage(intb, Indx);
                        Operation.ShowToustOk("Moved ...", this);
                    }
                }

                if (MessagesListView.Columns[1].Text == "Sent To")
                {
                    var GetMessage = (from m in OutBoxCmd.LoadAllMessages()
                                      where m.ID == Indx
                                      && m.SenderUserID == XamaDataLayer.Security.UserInfo.CurrentUserID
                                      select m).ToList();
                    foreach (var item in GetMessage)
                    {
                        var OutTb = new OutBox()
                        { Status = "~Sent"
                        };
                        OutBoxCmd.EditMessage(OutTb, Indx);
                        Operation.ShowToustOk("Moved ...", this);
                    }
                }
            }
        }


        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty && labUserName.Text != string.Empty)
            {
                var frm = new FrmSendMail();
                frm.UsersAutoCompleteBox.Text = labUserName.Text;
                frm.TheMessageBox.Text = richTextBox1.Text;
                frm.SubjectBox.Text = labSubject.Text;
                frm.Show();
                GroupDisplayMessage.Visible = false;
                this.Hide();
            }
        }
    }
}
