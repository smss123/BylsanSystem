using System;
using System.Collections.Generic;
using System.Drawing;
using XamaDataLayer;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmPasswordEdit : Telerik.WinControls.UI.RadForm
    {
        public FrmPasswordEdit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OldPasswordText.Text == string.Empty)
            {
                OldPasswordText.BackColor = Color.OrangeRed;

                OldPasswordText.Focus();
                errorProvider1.SetError(OldPasswordText, "Please Enter OldPassword");

                return;
            }
            else
            {
                OldPasswordText.BackColor = Color.White;
                errorProvider1.Clear();
            }

            ///



            if (NewPassowrdText.Text == string.Empty)
            {
                NewPassowrdText.BackColor = Color.OrangeRed;

                NewPassowrdText.Focus();
                errorProvider1.SetError(NewPassowrdText, "Please Enter New Password");

                return;
            }
            else
            {
                NewPassowrdText.BackColor = Color.White;
                errorProvider1.Clear();
            }


            ///



            if (ConfirmPasswordText.Text == string.Empty)
            {
                ConfirmPasswordText.BackColor = Color.OrangeRed;

                ConfirmPasswordText.Focus();
                errorProvider1.SetError(ConfirmPasswordText, "Please Enter Confirm PasswordText");

                return;
            }
            else
            {
                ConfirmPasswordText.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (NewPassowrdText.Text != ConfirmPasswordText.Text)
            {
                return;
            }
            else
            {
                Operation.BeginOperation(this);
                var Tb = new User();
                Tb.Passwords = NewPassowrdText.Text;

                UserCmd.EditPassword(Tb, UserInfo.CurrentUserID);
                Operation.EndOperation(this);
                Operation.ShowToustOk("Done ... ", this);
            }
        }

        private void FrmPasswordEdit_Load(object sender, EventArgs e)
        {
            OldPasswordText.Text = XamaDataLayer.Security.UserInfo.CurrentUserPassword;
        }
    }
}
