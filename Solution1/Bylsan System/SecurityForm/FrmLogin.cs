using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
          
            #region "  CheckFillTextBox "
            
            if (UserNameTextBox.Text == "")
            {

                UserNameTextBox.BackColor = Color.OrangeRed;

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

                PasswordTextBox.BackColor = Color.OrangeRed;

                PasswordTextBox.Focus();
                errorProvider1.SetError(this.PasswordTextBox, "Please Enter password");


                return;
            }
            else
            {
                PasswordTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
        }
         #endregion

        }
     
       
    }

