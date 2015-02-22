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
using System.Linq;
using XamaDataLayer.Security;
using System.Windows.Forms;
using Bylsan_System.AccountsX;
using Bylsan_System.SellSystemForms;
using Bylsan_System.SenarioAddOrderForms;
using Bylsan_System.AccountsX.Acc;
using Bylsan_System.SecurityForm;
using Bylsan_System.FactoryForms;
using XamaDataLayer.Helper_Classes;
using System.Threading;

using XamaDataLayer.BranchCmd;
using XamaDataLayer.SellSystem;
using Telerik.WinControls.UI;
using Bylsan_System.ManagmentOrderForms;
using XamaDataLayer.Accountant;

namespace Bylsan_System
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            btnManagecustomerPoint.Click += btnManagecustomerPoint_Click;
            storeBtn.Click += storeBtn_Click;
            btnHistory.Click += btnHistory_Click;
            btnEditOrder.Click += btnEditOrder_Click;
            txtTransfer.Click += txtTransfer_Click;
            btnReturnBill.Click += btnReturnBill_Click;
            btnBranchStore.Click += btnBranchStore_Click;
            
        }

        void btnBranchStore_Click(object sender, EventArgs e)
        {
            FrmManageSellIStore frm = new FrmManageSellIStore();
            frm.ShowDialog();
        }

        void btnReturnBill_Click(object sender, EventArgs e)
        {
            frmReturnBill frm = new frmReturnBill();
            frm.ShowDialog();
        }

        void txtTransfer_Click(object sender, EventArgs e)
        {
            frmTransferItems frm = new frmTransferItems();
            frm.ShowDialog();
        }

        void btnEditOrder_Click(object sender, EventArgs e)
        {
            FrmOrderManage frm = new FrmOrderManage();
            frm.ShowDialog();
        }

        void btnHistory_Click(object sender, EventArgs e)
        {
            frmHisotyTrasAction frm = new frmHisotyTrasAction();
            frm.ShowDialog();
        }

        private void btnManagecustomerPoint_Click(object sender, EventArgs e)
        {
            var frm = new frmManagePoint();
            frm.ShowDialog();
        }

        private void PopulateAll()
        {
            Operation.Allcategorys = CategoriesCmd.GetAllCategories();
            Operation.Allproducts = ProductsCmd.GetAllProducts();
            Operation.AllBranches = BranchsCmd.GetAllBranchs();
           // Operation.AllSellItems = SellItemsCmd.GetAllSellItems();
            Operation.AllOrder = OrdersCmd.GetAllOrders();
            Operation.AllCustomer = CustomersCmd.GetAllCustmers();
            Operation.AllDebetor = DebtorsCmd.GetAllDebtors();
        }
        private void ActivatePermessions()
        {
            var ListPerm = XamaDataLayer.Security.PermessionsCmd.GetAllUserPermissonsByUserID(XamaDataLayer.Security.UserInfo.CurrnetUser.ID);
            try
            {
                if (Convert.ToBoolean(ListPerm[1].PermessionValue.ToString()) == false)
                {
                    BranchDropDownButton.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[2].PermessionValue.ToString()) == false)
                {
                    UserDropDownButton.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[3].PermessionValue.ToString()) == false)
                {
                    EmployeeDropDownButton.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[5].PermessionValue.ToString()) == false)
                {
                    NewOrderBtn.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[6].PermessionValue.ToString()) == false)
                {
                    FactoryOrderBtn.Enabled = false;
                }

                if (Convert.ToBoolean(ListPerm[7].PermessionValue.ToString()) == false)
                {
                    DesignerOrderBtn.Enabled = false;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return;
            }
        }


        private void AddEmloyeebtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddEmployee();
            frm.ShowDialog();
        }

        private void managementEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empfrm = new FrmEmployeeManage();
            empfrm.ShowDialog();
        }

        private void addBranchBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddBranch();
            frm.ShowDialog();
        }

        private void ManagementBranchBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageBranch();
            frm.ShowDialog();
        }

        private void addProductCategoryBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddProductCategory();
            frm.ShowDialog();
        }

        private void MangeProductCategoryBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageProductCategory();
            frm.ShowDialog();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var frm = new frmAddProduct();
            frm.ShowDialog();
        }

        private void managementProductBtn_Click(object sender, EventArgs e)
        {
            var frm = new frmManageProduct();
            frm.ShowDialog();
        }

        private void addCustomerbtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddCustomer();
            frm.ShowDialog();
        }

        private void customerManagementBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmCustomerManage();
            frm.ShowDialog();
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            var frm = new frmMailServer();
            frm.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SenarioAddOrderForms.FrmAddInformationCustomer();
            frm.Show();
        }

        private void BtnDesinger_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrderShow();
            frm.ShowDialog();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new MainStoreForms.FrmAddMainStore_Item();
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
            var frm = new FrmAddMainStore_Item();
            frm.ShowDialog();
        }

        private void manageItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new MainStoreForms.FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void storeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_StoreManager();
            frm.ShowDialog();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddMainStore_Supplier();
            frm.ShowDialog();
        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Supplier();
            frm.ShowDialog();
        }

        private void expensesShowBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmexpensesShow();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSellItem();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSellIStore();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageSellIStore();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageSellItem();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSales();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }


        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
        }

        private void InBoxMassagesBtn_Click(object sender, EventArgs e)
        {
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            var frm = new FactoryForms.FrmFactoryOrderShow();
            frm.ShowDialog();
        }

        private void addIteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSellItem();
            frm.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSales();
            frm.Show();
        }

        private void quotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmPrintQuotation();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Alert = new UserAlert();
            Alert.ActivateTimer();
            XpremaTrack.WriteTrack();


            var th = new Thread(PopulateAll);
            th.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void manageItemsBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void AddStoreBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddMainStore_Store();
            frm.ShowDialog();
        }

        private void manageStoreBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Store();
            frm.ShowDialog();
        }

        private void AddWithDrawalBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void ManageWithDrawalBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void addStoreManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageStoreManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_StoreManager();
            frm.ShowDialog();
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddMainStore_Supplier();
            frm.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var FrmAccount = new frmAddAccount();
            FrmAccount.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var FRM = new FrmAddAccountCategory();
            FRM.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var frm = new FrmManageAccountCategory();
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var Tree = new FrmAccountTree();
            Tree.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageDebtors();
            frm.Show();
        }

        private void addItemsQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSellIStore();
            frm.Show();
        }

        private void manageSupplierBtn_Click(object sender, EventArgs e)
        {
            var f = new FrmManageMainStore_Supplier();
            f.Show();
        }

        private void tileGroupElement1_Click(object sender, EventArgs e)
        {
        }

        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmUserShow();
            frm.ShowDialog();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddInformationCustomer();
            frm.ShowDialog();
        }

        private void ManagmentOrderBtn_Click(object sender, EventArgs e)
        {
            var rpt = new FrmViewOrdersReport();
            rpt.ShowDialog();
        }

        private void FactoryOrderBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmFactoryOrderShow();
            frm.ShowDialog();
        }

        private void DesignerOrderBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrderShow();
            frm.ShowDialog();
        }

        private void SellItemsTileElement_Click(object sender, EventArgs e)
        {

            var frm = new FrmOrderManage();
            frm.ShowDialog();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Item();
            frm.ShowDialog();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Store();
            frm.ShowDialog();
        }

        private void storeManagerBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_StoreManager();
            frm.ShowDialog();
        }

        private void WithDrawalBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_StoreWithDrawal();
            frm.ShowDialog();
        }

        private void SupplierTileElement_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageMainStore_Supplier();
            frm.ShowDialog();
        }

        private void AccountTreeBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAccountTree();
            frm.ShowDialog();
        }

        private void AccountCategoryTileElement3_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageAccountCategory();
            frm.ShowDialog();
        }

        private void DebitorsTileElement_Click(object sender, EventArgs e)
        {
            var frm = new FrmManageDebtors();
            frm.ShowDialog();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmexpensesShow();
            frm.ShowDialog();
        }

        private void AccountDailyBtn_Click(object sender, EventArgs e)
        {
            var frm = new frmAccountDailySHow();
            frm.ShowDialog();
        }

        private void SalesTileElement_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSales();
            frm.ShowDialog();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            var f = new FrmPrivatewithdrawals();
            f.Show();
        }

        private void deliveryOrderBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmDeliveryOrder();
            frm.ShowDialog();
        }

        private void PrintQuotationBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmPrintQuotation();
            frm.ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            var frm = new FrmAddMainStore_Item();
            frm.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            var frm = new FrmProductsContantes();
            frm.Show();
        }

        private void editpassordBtn_Click(object sender, EventArgs e)
        {
            var f = new FrmPasswordEdit();
            f.Show();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            var FRM = new FrmAddSellIStore();
            FRM.Show();
        }

        private void Lessthanquantityinstock_Click(object sender, EventArgs e)
        {
            frmManageMiniummQty frm = new frmManageMiniummQty();
            frm.ShowDialog();
        }

        private void checkSalesStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductSaleStatistis frm = new frmProductSaleStatistis();
            frm.ShowDialog();
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectPrinter frm = new frmSelectPrinter();
            frm.Show();
        }

        private void radPanorama1_Click(object sender, EventArgs e)
        {

        }

        private void OrderAndSalesGroup_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }

       
    }
}
