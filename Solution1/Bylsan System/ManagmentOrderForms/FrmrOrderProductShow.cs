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
    public partial class FrmrOrderProductShow : RadForm
    {
        public FrmrOrderProductShow()
        {
            InitializeComponent();
        }

        private void orderDeliveryDateLabel_Click(object sender, EventArgs e)
        {

        }
        Thread th;
        private void fillCombo()
        {
            this.Invoke((MethodInvoker)delegate
            {

                this.CustomerComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
                this.BranchComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                this.CustomerComboBox.AutoFilter = true;
                this.CustomerComboBox.ValueMember = "ID";
                this.CustomerComboBox.DisplayMember = "CustomerName";
                //
                this.BranchComboBox.AutoFilter = true;
                this.BranchComboBox.ValueMember = "ID";
                this.BranchComboBox.DisplayMember = "Branch_Name";
                
            });
            Operation.BeginOperation(this);
            var q = CustomersCmd.GetAllCustmers();
            var q1 = BranchsCmd.GetAllBranchs();
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                CustomerComboBox.DataSource = q;
                BranchComboBox.DataSource = q1;

                ///CustmoreFilter
                this.CustomerComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor Cusname = new FilterDescriptor("CustomerName", FilterOperator.Contains, "");
                FilterDescriptor CusPhone = new FilterDescriptor("PhoneNumber", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(Cusname);
                compositeFilter.FilterDescriptors.Add(CusPhone);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.CustomerComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);

                //BranchFilter

                this.BranchComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter1 = new CompositeFilterDescriptor();
                FilterDescriptor BrName = new FilterDescriptor("Branch_Name", FilterOperator.Contains, "");
                compositeFilter1.FilterDescriptors.Add(BrName);
              
                compositeFilter1.LogicalOperator = FilterLogicalOperator.Or;

                this.BranchComboBox.EditorControl.FilterDescriptors.Add(compositeFilter1);

            });
            th.Abort();


        }
        private void FrmrOrderProductShow_Load(object sender, EventArgs e)
        {
            th = new Thread(fillCombo);
            th.Start();
        }
    }
}
