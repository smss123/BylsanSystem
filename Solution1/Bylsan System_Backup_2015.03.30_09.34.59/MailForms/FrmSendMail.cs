using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using XamaDataLayer;
using XamaDataLayer.Security;
using XamaDataLayer.MailServer;
using Telerik.WinControls.UI;

namespace Bylsan_System.MailForms
{
    public partial class FrmSendMail : RadForm
    {
        public FrmSendMail()
        {
            InitializeComponent();
        }

        private void FrmSendMail_Load(object sender, EventArgs e)
        {
            var thr = new Thread(GetListUsers);
            thr.Start();
        }


        private void GetListUsers()
        {
            Operation.BeginOperation(this);
            var AllUsers = UserCmd.GetAllUsers();

            this.Invoke((MethodInvoker)delegate
            {
                foreach (var item in AllUsers)
                {
                    var items = UsersAutoCompleteBox.AutoCompleteItems;
                    items.Add(new RadListDataItem(item.UserName.ToString(), item.ID.ToString()));
                }

            });
            Operation.EndOperation(this);
        }



        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (SubjectBox.Text == string.Empty)
            {
                SubjectBox.BackColor = Color.OrangeRed;

                SubjectBox.Focus();
                errorProvider1.SetError(SubjectBox, "Please Enter The Subject");

                return;
            }
            else
            {
                SubjectBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (TheMessageBox.Text == string.Empty)
            {
                TheMessageBox.BackColor = Color.OrangeRed;

                TheMessageBox.Focus();
                errorProvider1.SetError(TheMessageBox, "Please Enter The Message");

                return;
            }
            else
            {
                TheMessageBox.BackColor = Color.White;
                errorProvider1.Clear();
            }





            if (UsersAutoCompleteBox. Text != string.Empty)
            {
                var InBoxTb = new Inbox();
                var OutBoxTb = new OutBox();
                foreach (var item in UsersAutoCompleteBox.Items)
                {
                    InBoxTb = new Inbox() { Subject  =  SubjectBox.Text ,
                       DateOfMessage = DateTime .Now ,
                        MessageText = TheMessageBox.Text ,
                         ReciverUserID = int .Parse (item .Value.ToString ()),
                         SenderUserID = XamaDataLayer .Security .UserInfo .CurrentUserID ,
                          Status = "UnRead",

                    };
                    InBoxCmd.InsertMassegeInBox(InBoxTb);

                    OutBoxTb = new OutBox()
                    {
                      Subject = SubjectBox.Text,
                      DateOfMessage = DateTime.Now,
                      MessageText = TheMessageBox.Text,
                      ReciverUserID = int.Parse(item.Value.ToString()),
                      SenderUserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
                      Status = "Sent",

                    };
                    OutBoxCmd.OutBoxMessage(OutBoxTb);
                }
                Operation.ShowToustOk("Your Message Has Been Sent >>>", this);
            }
        }




        private void radAutoCompleteBox1_TextBlockFormatting(object sender, Telerik.WinControls.UI.TextBlockFormattingEventArgs e)
        {
            var token = e.TextBlock as TokenizedTextBlockElement;
            if (token != null)
            {
                token.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                token.BackColor = Color.Yellow;
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            frmAttachment frm = new frmAttachment();
            frm.ShowDialog();
        }
    }
}
