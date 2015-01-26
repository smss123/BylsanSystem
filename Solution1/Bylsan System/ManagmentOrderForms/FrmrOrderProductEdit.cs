using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class FrmrOrderProductEdit : RadForm
    {
       Thread th;
      
        public FrmrOrderProductEdit()
        {
            InitializeComponent();
        }
          private void fillCombo()
        {
             this.Invoke((MethodInvoker)delegate
            {
                this.ProductComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.ProductComboBox.AutoFilter = true;
                this.ProductComboBox.ValueMember = "ID";
                this.ProductComboBox.DisplayMember = "Product_Name";
            });
            Operation.BeginOperation(this);
            var q = ProductsCmd.GetAllProducts();
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                ProductComboBox.DataSource = q;
                this.ProductComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor Proname = new FilterDescriptor("Product_Name", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(Proname);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.ProductComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

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
