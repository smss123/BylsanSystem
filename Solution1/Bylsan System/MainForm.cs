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
using XamaDataLayer.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Bylsan_System.AccountsX;
using XamaDataLayer.MailServer;
using Bylsan_System.SellSystemForms;
using Bylsan_System.SenarioAddOrderForms;
using Bylsan_System.AccountsX.Acc;
using Bylsan_System.SecurityForm;
using Bylsan_System.FactoryForms;
namespace Bylsan_System
{
    public partial class MainForm : RadForm

    {
        public MainForm()
        {
            InitializeComponent();
            ActivatePermessions();
            btnManagecustomerPoint.Click += btnManagecustomerPoint_Click;
        }

        void btnManagecustomerPoint_Click(object sender, EventArgs e)
        {
            frmManagePoint frm = new frmManagePoint();
            frm.ShowDialog();
        }


        void ActivatePermessions()
        {
            var ListPerm = XamaDataLayer.Security.PermessionsCmd.GetAllUserPermissonsByUserID(XamaDataLayer.Security.UserInfo.CurrnetUser.ID);
            try
            {
                if (Convert.ToBoolean(ListPerm[1].PermessionValue.ToString()) == false) { BranchDropDownButton.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[2].PermessionValue.ToString()) == false) { UserDropDownButton.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[3].PermessionValue.ToString()) == false) { EmployeeDropDownButton.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[5].PermessionValue.ToString()) == false) { NewOrderBtn.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[6].PermessionValue.ToString()) == false) { FactoryOrderBtn.Enabled = false; }

                if (Convert.ToBoolean(ListPerm[7].PermessionValue.ToString()) == false) { DesignerOrderBtn.Enabled = false; }

            }
            catch (System.ArgumentOutOfRangeException ex)
            {

                return;
            }
          
        }

        #region "    "
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
            frm.Show();
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
            UserCmd.UserLogOut();

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddSellItem frm = new FrmAddSellItem();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddSellIStore frm = new FrmAddSellIStore();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmManageSellIStore frm = new FrmManageSellIStore();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmManageSellItem frm = new FrmManageSellItem();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAddSales frm = new FrmAddSales();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
        #endregion 
        #region "           "
        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void InBoxMassagesBtn_Click(object sender, EventArgs e)
        {
         
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            FactoryForms.FrmFactoryOrderShow frm = new FactoryForms.FrmFactoryOrderShow();
            frm.ShowDialog();

        }

        private void addIteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSellItem frm = new FrmAddSellItem();
            frm.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSales frm = new FrmAddSales();
            frm.Show();
        }

        private void quotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrintQuotation frm = new FrmPrintQuotation();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserAlert Alert = new UserAlert();
            Alert.ActivateTimer();
          
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void manageItemsBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Item frm = new FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void AddStoreBtn_Click(object sender, EventArgs e)
        {
            FrmAddMainStore_Store frm = new FrmAddMainStore_Store();
            frm.ShowDialog();
        }

        private void manageStoreBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Store frm = new FrmManageMainStore_Store();
            frm.ShowDialog();
        }

        private void AddWithDrawalBtn_Click(object sender, EventArgs e)
        {
            FrmAddMainStore_StoreWithDrawal frm = new FrmAddMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void ManageWithDrawalBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_StoreWithDrawal frm = new FrmManageMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void addStoreManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void manageStoreManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_StoreManager frm = new FrmManageMainStore_StoreManager();
            frm.ShowDialog();
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            FrmAddMainStore_Supplier frm = new FrmAddMainStore_Supplier();
            frm.ShowDialog();
        }
        #endregion
        private void button1_Click_2(object sender, EventArgs e)
        {
            frmAddAccount FrmAccount = new frmAddAccount();
            FrmAccount.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FrmAddAccountCategory FRM = new FrmAddAccountCategory();
            FRM.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //frmAccountDailySHow frm = new frmAccountDailySHow();
            //frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmManageAccountCategory frm = new FrmManageAccountCategory();
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FrmAccountTree Tree = new FrmAccountTree();
            Tree.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmManageDebtors frm = new FrmManageDebtors();
            frm.Show();
        }

        private void addItemsQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSellIStore frm = new FrmAddSellIStore();
            frm.Show();
        }

        private void manageSupplierBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Supplier f = new FrmManageMainStore_Supplier();
            f.Show();
        }

        private void tileGroupElement1_Click(object sender, EventArgs e)
        {

        }

        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            FrmUserShow frm = new FrmUserShow();
            frm.ShowDialog();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            FrmAddInformationCustomer frm = new FrmAddInformationCustomer();
            frm.ShowDialog();
        }

        private void ManagmentOrderBtn_Click(object sender, EventArgs e)
        {

        }

        private void FactoryOrderBtn_Click(object sender, EventArgs e)
        {
            FrmFactoryOrderShow frm = new FrmFactoryOrderShow();
            frm.ShowDialog();
        }

        private void DesignerOrderBtn_Click(object sender, EventArgs e)
        {
            FrmOrderShow frm = new FrmOrderShow();
            frm.ShowDialog();

        }

        private void SellItemsTileElement_Click(object sender, EventArgs e)
        {
            FrmManageSellItem frm = new FrmManageSellItem();
            frm.ShowDialog();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Item frm = new FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Store frm = new FrmManageMainStore_Store();
            frm.ShowDialog();
        }

        private void storeManagerBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_StoreManager frm = new FrmManageMainStore_StoreManager();
            frm.ShowDialog();
        }

        private void WithDrawalBtn_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_StoreWithDrawal frm = new FrmManageMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void SupplierTileElement_Click(object sender, EventArgs e)
        {
            FrmManageMainStore_Supplier frm = new FrmManageMainStore_Supplier();
            frm.ShowDialog();
        }

        private void AccountTreeBtn_Click(object sender, EventArgs e)
        {
            FrmAccountTree frm = new FrmAccountTree();
            frm.ShowDialog();
        }

        private void AccountCategoryTileElement3_Click(object sender, EventArgs e)
        {
            FrmManageAccountCategory frm = new FrmManageAccountCategory();
            frm.ShowDialog();
        }

        private void DebitorsTileElement_Click(object sender, EventArgs e)
        {
            FrmManageDebtors frm = new FrmManageDebtors();
            frm.ShowDialog();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            FrmexpensesShow frm = new FrmexpensesShow();
            frm.ShowDialog();
        }

        private void AccountDailyBtn_Click(object sender, EventArgs e)
        {
            frmAccountDailySHow frm = new frmAccountDailySHow();
            frm.ShowDialog();
        }

        private void SalesTileElement_Click(object sender, EventArgs e)
        {
            SellSystemForms.FrmAddSales frm = new FrmAddSales();
            frm.ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FrmPasswordEdit f = new FrmPasswordEdit();
            f.Show();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            FrmPrivatewithdrawals f = new FrmPrivatewithdrawals();
            f.Show();
        }

        private void deliveryOrderBtn_Click(object sender, EventArgs e)
        {
            FrmDeliveryOrder frm = new FrmDeliveryOrder();
            frm.ShowDialog();
        }
    }
}
