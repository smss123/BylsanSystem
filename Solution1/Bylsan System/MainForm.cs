using Bylsan_System.BranchForms;
using Bylsan_System.CustomerForms;
using Bylsan_System.designerForms;
using Bylsan_System.EmployeeForms;
using Bylsan_System.expensesFroms;
using Bylsan_System.MailForms;
using Bylsan_System.MainStoreForms;
using Bylsan_System.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Bylsan_System
{
    public partial class MainForm : RadForm

    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddEmloyeebtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.ShowDialog();
        }

        private void managementEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeManage empfrm = new FrmEmployeeManage();
            empfrm.ShowDialog();
        }

        private void addBranchBtn_Click(object sender, EventArgs e)
        {
            FrmAddBranch frm = new FrmAddBranch();
            frm.ShowDialog();
        }

        private void ManagementBranchBtn_Click(object sender, EventArgs e)
        {
            FrmManageBranch frm = new FrmManageBranch();
            frm.ShowDialog();
        }

        private void addProductCategoryBtn_Click(object sender, EventArgs e)
        {
            FrmAddProductCategory frm = new FrmAddProductCategory();
            frm.ShowDialog();
        }

        private void MangeProductCategoryBtn_Click(object sender, EventArgs e)
        {
            FrmManageProductCategory frm = new FrmManageProductCategory();
            frm.ShowDialog();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            frm.ShowDialog();

        }

        private void managementProductBtn_Click(object sender, EventArgs e)
        {
            frmManageProduct frm = new frmManageProduct();
            frm.ShowDialog();
        }

        private void addCustomerbtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();

        }

        private void customerManagementBtn_Click(object sender, EventArgs e)
        {
            FrmCustomerManage frm = new FrmCustomerManage();
            frm.ShowDialog();
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            frmMailServer frm = new frmMailServer();
            frm.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bylsan_System.SenarioAddOrderForms.FrmAddInformationCustomer frm = new SenarioAddOrderForms.FrmAddInformationCustomer();
            frm.Show();
        }

        private void BtnDesinger_Click(object sender, EventArgs e)
        {
            FrmOrderShow frm = new FrmOrderShow();
            frm.ShowDialog();

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainStoreForms.FrmAddMainStore_Item frm = new MainStoreForms.FrmAddMainStore_Item();
            frm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void storeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        
        }

        private void addItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddMainStore_Item frm = new FrmAddMainStore_Item();
            frm.ShowDialog();
        }

        private void manageItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Item frm = new MainStoreForms.FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void storeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Store frm = new FrmManageMainStore_Store();
            frm.ShowDialog();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddMainStore_Supplier frm = new FrmAddMainStore_Supplier();
            frm.ShowDialog();
        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Supplier frm = new FrmManageMainStore_Supplier();
            frm.ShowDialog();
        }

        private void expensesShowBtn_Click(object sender, EventArgs e)
        {
            FrmexpensesShow frm = new FrmexpensesShow();
            frm.ShowDialog();
        }
    }
}
