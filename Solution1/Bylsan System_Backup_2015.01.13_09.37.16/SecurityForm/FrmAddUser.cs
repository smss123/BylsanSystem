using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmAddUser : Telerik.WinControls.UI.RadForm
    {
        Thread th;
        public void FillBrnchCombo()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                this.BranshComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
                this.BranshComboBox.AutoFilter = true;
                this.BranshComboBox.DisplayMember = "Branch_Name";
                this.BranshComboBox.ValueMember = "ID";

            });

            var q = BranchsCmd.GetAllBranchs();
            this.Invoke((MethodInvoker)delegate
            {

                BranshComboBox.DataSource = q;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor prodName = new FilterDescriptor("Branch_Name", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(prodName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.BranshComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

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
            #region "  CheckFillTextBox "

            if (userNameTextBox.Text == "")
            {

                userNameTextBox.BackColor = Color.OrangeRed;

                userNameTextBox.Focus();
                errorProvider1.SetError(this.userNameTextBox, "Please Enter UserName");

                return;
            }
            else
            {
                userNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }


            if (passwordsTextBox.Text == "")
            {

                passwordsTextBox.BackColor = Color.OrangeRed;

                passwordsTextBox.Focus();
                errorProvider1.SetError(this.passwordsTextBox, "Please Enter Password");

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
                errorProvider1.SetError(this.BranshComboBox, "Please Enter Bransh");

                return;
            }
            else
            {
                BranshComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion

            User tb = new User
            {

                UserName = userNameTextBox.Text,
                Passwords = passwordsTextBox.Text,
                Branch_ID = int.Parse(BranshComboBox.SelectedValue.ToString()),


            };
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