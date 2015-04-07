using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmAddUser : Telerik.WinControls.UI.RadForm
    {
        private Thread th;
        public void FillBrnchCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                BranshComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                BranshComboBox.AutoFilter = true;
                BranshComboBox.DisplayMember = "Branch_Name";
                BranshComboBox.ValueMember = "ID";

            });

            var q = BranchsCmd.GetAllBranchs();
            this.Invoke((MethodInvoker)delegate
            {

                BranshComboBox.DataSource = q;
                var compositeFilter = new CompositeFilterDescriptor();
                var prodName = new FilterDescriptor("Branch_Name", FilterOperator.Contains, string.Empty);
                compositeFilter.FilterDescriptors.Add(prodName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                BranshComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

            });
            Operation.EndOperation(this);

            th.Abort();
        }
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            th = new Thread(FillBrnchCombo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == string.Empty)
            {
                userNameTextBox.BackColor = Color.OrangeRed;

                userNameTextBox.Focus();
                errorProvider1.SetError(userNameTextBox, "Please Enter UserName");

                return;
            }
            else
            {
                userNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (passwordsTextBox.Text == string.Empty)
            {
                passwordsTextBox.BackColor = Color.OrangeRed;

                passwordsTextBox.Focus();
                errorProvider1.SetError(passwordsTextBox, "Please Enter Password");

                return;
            }
            else
            {
                passwordsTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (BranshComboBox.SelectedValue == null)
            {
                BranshComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                BranshComboBox.Focus();
                errorProvider1.SetError(BranshComboBox, "Please Enter Bransh");

                return;
            }
            else
            {
                BranshComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }



            var tb = new User
            { UserName = userNameTextBox.Text,
                Passwords = passwordsTextBox.Text,
                Branch_ID = int.Parse(BranshComboBox.SelectedValue.ToString()), };
            UserCmd.AddUser(tb);
            Operation.ShowToustOk("User Has Been Saved", this);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            BranshComboBox.ResetText();
            userNameTextBox.Focus();
        }
    }
}
