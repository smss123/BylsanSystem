using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;

namespace Bylsan_System.BranchForms
{
    public partial class FrmEditBranch : RadForm
    {
        public FrmEditBranch()
        {
            InitializeComponent();
        }
        public Branch TragetBranch { get; set; }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (txtBranchName.Text == string.Empty)
            {
                txtBranchName.BackColor = Color.OrangeRed;

                txtBranchName.Focus();
                errorProvider1.SetError(txtBranchName, "Please Enter Branch name");

                return;
            }
            else
            {
                txtBranchName.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (EmployeeManagerComboBox.SelectedValue == null)
            {
                EmployeeManagerComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                EmployeeManagerComboBox.Focus();
                errorProvider1.SetError(EmployeeManagerComboBox, "Please Manager Branch name");
                return;
            }
            else
            {
                EmployeeManagerComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }


            Operation.BeginOperation(this);
            if (BranchsCmd.EditBranch(new XamaDataLayer.Branch() {
                Branch_Name = txtBranchName.Text,
                 Branch_Description = txtBranchDescription.Text,
                  Manager_ID = EmployeeManagerComboBox.SelectedValue.ToString().ToInt() }, TragetBranch.ID))
            {
                Operation.ShowToustOk("Branch Has Been Saved", this);
                txtBranchName.Clear();
                txtBranchDescription.Clear();
            }
            Operation.EndOperation(this);
        }

        private void FrmEditBranch_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            txtBranchName.Text = TragetBranch.Branch_Name;
            txtBranchDescription.Text = TragetBranch.Branch_Description;
            EmployeeManagerComboBox.SelectedValue = TragetBranch.Manager_ID;
        }

        private void LoadEmployee()
        {
            EmployeeManagerComboBox.MultiColumnComboBoxElement.DropDownWidth = 1000;
            EmployeeManagerComboBox.AutoFilter = true;
            EmployeeManagerComboBox.DisplayMember = "Emp_Name";

            this.Enabled = false;



            this.Cursor = Cursors.WaitCursor;
            EmployeeManagerComboBox.DataSource = EmployeesCmd.GetAllEmployees();
            EmployeeManagerComboBox.DisplayMember = "Emp_Name";
            EmployeeManagerComboBox.ValueMember = "ID";
            this.Cursor = Cursors.Default;
            this.Enabled = true;



            EmployeeManagerComboBox.AutoFilter = true;
            var compositeFilter = new CompositeFilterDescriptor();
            var prodName = new FilterDescriptor("Emp_Name", FilterOperator.Contains, string.Empty);
            var prodQuantity = new FilterDescriptor("PhoneNumber", FilterOperator.Contains, string.Empty);
            compositeFilter.FilterDescriptors.Add(prodName);
            compositeFilter.FilterDescriptors.Add(prodQuantity);
            compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

            EmployeeManagerComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);
        }
    }
}
