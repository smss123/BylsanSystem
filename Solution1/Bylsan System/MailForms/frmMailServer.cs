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
            LoadEmail();

        }

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

        private void NewBtn_Click(object sender, EventArgs e)
        {
            FrmSendMail frm = new FrmSendMail();
            frm.ShowDialog();
        }
    }
}
