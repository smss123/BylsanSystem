using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class FrmrOrderProductEdit : RadForm
    {
        private Thread th;

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
        }
    }
}
