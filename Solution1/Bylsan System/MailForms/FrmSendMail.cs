using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using XamaDataLayer;
using XamaDataLayer.Security;
using XamaDataLayer.MailServer;
using Telerik.WinControls.UI;

namespace Bylsan_System.MailForms
{
    public partial class FrmSendMail : Form
    {
        public FrmSendMail()
        {
            InitializeComponent();

        }

        private void FrmSendMail_Load(object sender, EventArgs e)
        {
            Thread thr = new Thread(GetListUsers); thr.Start();
        }

        #region "  ^^^^ Users      "
        void GetListUsers()
        {
            Operation.BeginOperation(this);
            var AllUsers = UserCmd.GetAllUsers();

            this.Invoke((MethodInvoker)delegate
            {
                foreach (var item in AllUsers)
                {
                    RadListDataItemCollection items = this.UsersAutoCompleteBox.AutoCompleteItems;
                    items.Add(new RadListDataItem(item.UserName.ToString(), item.ID.ToString()));

                }

            });
            Operation.EndOperation(this);
        }
        #endregion

        #region "  ^^^ Send Message   "
        private void SendBtn_Click(object sender, EventArgs e)
        {

            #region "  CheckFillTextBox "

            if (SubjectBox.Text == "")
            {

                SubjectBox.BackColor = Color.OrangeRed;

                SubjectBox.Focus();
                errorProvider1.SetError(this.SubjectBox, "Please Enter The Subject");

                return;
            }
            else
            {
                SubjectBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

           //-------------
            if (TheMessageBox.Text == "")
            {

                TheMessageBox.BackColor = Color.OrangeRed;

                TheMessageBox.Focus();
                errorProvider1.SetError(this.TheMessageBox, "Please Enter The Message");

                return;
            }
            else
            {
                TheMessageBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

           

            #endregion       

          if(UsersAutoCompleteBox. Text != ""){
              Inbox InBoxTb = new Inbox();
              OutBox OutBoxTb = new OutBox();
              foreach (var item in UsersAutoCompleteBox.Items)
              {
                  InBoxTb = new Inbox() 
                  {  
                      Subject  =  SubjectBox.Text ,
                       DateOfMessage = DateTime .Now ,
                        MessageText = TheMessageBox.Text ,
                         ReciverUserID = int .Parse (item .Value.ToString ()),
                         SenderUserID = XamaDataLayer .Security .UserInfo .CurrentUserID ,
                          Status = "UnRead",

                  };
                  InBoxCmd.InsertMassegeInBox(InBoxTb);
                  //=================================
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

        #endregion 

        #region " ^^^ Auto Complate   "
        private void radAutoCompleteBox1_TextBlockFormatting(object sender, Telerik.WinControls.UI.TextBlockFormattingEventArgs e)
        {
            TokenizedTextBlockElement token = e.TextBlock as TokenizedTextBlockElement;
            if (token != null)
            {
                token.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                token.BackColor = Color.Yellow;
            }
        }

        #endregion
     

    }
}
