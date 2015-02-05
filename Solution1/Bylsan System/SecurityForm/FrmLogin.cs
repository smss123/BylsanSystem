using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmLogin : RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == string.Empty)
            {
                UserNameTextBox.BackColor = Color.FromArgb(255, 249, 179, 153);

                UserNameTextBox.Focus();
                errorProvider1.SetError(UserNameTextBox, "Please Enter user name");

                return;
            }
            else
            {
                UserNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }




            if (PasswordTextBox.Text == string.Empty)
            {
                PasswordTextBox.BackColor = Color.FromArgb(255, 249, 179, 153);
                ;

                PasswordTextBox.Focus();
                errorProvider1.SetError(PasswordTextBox, "Please Enter password");


                return;
            }
            else
            {
                PasswordTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            Operation.BeginOperation(this);
            var  q =   UserCmd.Login(UserNameTextBox.Text, PasswordTextBox.Text);
            if (q != null)
            {
                UserInfo.CurrnetUser = q;
                this.Text =   UserInfo.CurrentUserName;
                var frm = new MainForm();
                frm.Show();
                this.Hide();
                Operation.EndOperation(this);
            }
            else
            {
                Operation.EndOperation(this);
                RadMessageBox.Show("Error in Login Info");
            }
        }





        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





