using Bylsan_System.Reports.ReportOption;
using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer.Accountant;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Main_Store;
using Xprema.XExtention;

namespace Bylsan_System.MainStoreForms
{
    public partial class frmStorePurchases : RadForm
    {
        public frmStorePurchases()
        {
            InitializeComponent();
        }

        private void frmStorePurchases_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = ProductsCmd.GetAllProducts();
            productIDComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

            supplierBindingSource.DataSource = SuppliersCmd.GetAllSuppliers();
            supplierIDComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

            accountBindingSource.DataSource = AccountsCmd.GetAllAccounts();
            accountIDComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
            purchaseBindingSource.DataSource = PurchasesCmd.GetAll();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if ( PurchasesCmd.NewPurchases(new XamaDataLayer.Purchase() { AccountID = accountIDComboBox.SelectedValue.ToString().ToInt(),
              CostAmount = costAmountNumericUpDown.Value.ToString().Todouble(),
               ProductID = productIDComboBox.SelectedValue.ToString().ToInt(),
                SupplierID = supplierIDComboBox.SelectedValue.ToString().ToInt(),
                 Qty = qtyTextBox.Text,
                  BillNumber = billNumberTextBox.Text,
                   expierdDate = expierdDateDateTimePicker.Value,
                    ProductBarcode = productBarcodeTextBox.Text,
                     SerialNumber = Guid.NewGuid()
            }))
            {
                RadMessageBox.Show("Saved", "_");
            }
        }

        private void productBarcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var q = PurchasesCmd.GetAll().Where(p => p.ProductBarcode == productBarcodeTextBox.Text).Take(1).Single();
                    productIDComboBox.SelectedValue = q.ProductID;
                    qtyTextBox.Text = "1";
                    costAmountNumericUpDown.Value = 0;
                }
                catch (Exception ex)
                {
                    productBarcodeTextBox.Text = ex.Message;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmPurchases frm = new frmPurchases();
            frm.ShowDialog();
        }
    }
}
