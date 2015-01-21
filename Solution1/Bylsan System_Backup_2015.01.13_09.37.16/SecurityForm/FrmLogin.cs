using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Helper_Classes;
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



          

            #region "  CheckFillTextBox "

            if (UserNameTextBox.Text == "")
            {

                UserNameTextBox.BackColor = Color.FromArgb(255, 249, 179, 153);

                UserNameTextBox.Focus();
                errorProvider1.SetError(this.UserNameTextBox, "Please Enter user name");

                return;
            }
            else
            {
                UserNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            //CheckPassword


            if (PasswordTextBox.Text == "")
            {

                PasswordTextBox.BackColor = Color.FromArgb(255, 249, 179, 153); ;

                PasswordTextBox.Focus();
                errorProvider1.SetError(this.PasswordTextBox, "Please Enter password");


                return;
            }
            else
            {
                PasswordTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

            Operation.BeginOperation(this);
          var  q =   UserCmd.Login(UserNameTextBox.Text, PasswordTextBox.Text);
            if (q != null)
            {
                UserInfo.CurrnetUser = q;
              this.Text=   UserInfo.CurrentUserName;
              MainForm frm = new MainForm();
              frm.Show();
              this.Hide();
              Operation.EndOperation(this);

            }
            else
            {
                Operation.EndOperation(this);
                RadMessageBox.Show("Error in Login Info");//Load msg from Opertation Class
            }
        }
          

      
     

        private void ExitBtn_Click(object sender, EventArgs e)
        {


            //var q = RadMessageBox.Show("Sure to Exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (q == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}

        
       


