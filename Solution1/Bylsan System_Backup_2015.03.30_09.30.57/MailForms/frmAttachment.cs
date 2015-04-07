using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
namespace Bylsan_System.MailForms
{
    public partial class frmAttachment :Form
    {
        public frmAttachment()
        {
            InitializeComponent();
        }
        public List<MailAttachment> ListOfAttachment { get; set; }
        private void frmAttachment_Load(object sender, EventArgs e)
        {
            ListOfAttachment = new List<MailAttachment>();
            mailAttachmentBindingSource.DataSource = ListOfAttachment;
        }
        OpenFileDialog p = new OpenFileDialog();
        private void attachmentXPictureBox_Click(object sender, EventArgs e)
        {
            p.Title = "Select Doc";
           if(p.ShowDialog()==System.Windows.Forms.DialogResult.OK)
           {
               attachmentXPictureBox.Image = Image.FromFile(p.FileName);
           }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MailAttachment mail = new MailAttachment() { AttachmentX=attachmentXPictureBox.Image, Description=descriptionTextBox.Text, ID = ApiCounter.GetNumber()  };
            mailAttachmentDataGridView.Rows.Add(new object[] { ApiCounter.GetNumber().ToString(), attachmentXPictureBox.Image, descriptionTextBox.Text });
           
        }
    }
}
