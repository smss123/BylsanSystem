using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class FrmrOrderProductEdit : RadForm
    {
        private Thread th;
        public OrderProduct TragetOrderProduct { get; set; }
        public FrmrOrderProductEdit()
        {
            InitializeComponent();
        }
        private void fillCombo()
        {
            this.Invoke((MethodInvoker)delegate
            {
                ProductComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                ProductComboBox.AutoFilter = true;
                ProductComboBox.ValueMember = "ID";
                ProductComboBox.DisplayMember = "Product_Name";
            });
            Operation.BeginOperation(this);
            var q = ProductsCmd.GetAllProducts();
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                ProductComboBox.DataSource = q;
                ProductComboBox.AutoFilter = true;
                var compositeFilter = new CompositeFilterDescriptor();
                var Proname = new FilterDescriptor("Product_Name", FilterOperator.Contains, string.Empty);
                compositeFilter.FilterDescriptors.Add(Proname);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                ProductComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

            });
            th.Abort();
        }

        private void FrmrOrderProductEdit_Load(object sender, EventArgs e)
        {
            th = new Thread(fillCombo);
            th.Start();
            ProductComboBox.SelectedItem = TragetOrderProduct.Product;
            qtyTextBox.Text = TragetOrderProduct.Qty.ToString();
            statusComboBox.Text = TragetOrderProduct.Status;
            descriptionTextBox.Text = TragetOrderProduct.Description;

             
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OrderProductsCmd.EditOrderProduct(new OrderProduct() { 
             Description = descriptionTextBox.Text,
              OrderID = TragetOrderProduct.OrderID,
               ProductID = ProductComboBox.SelectedValue.ToString().ToInt(),
                Qty = qtyTextBox.Text.ToInt(),
                 Status = statusComboBox.Text,
                  ImageX = null//Abu ehab please Complete This
            
            }, TragetOrderProduct.ID);
            // here Edited OrderProduct Attachment ,complete Code Here
            
        }
    }
}
