using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
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
        private Thread th;
        private void fillCombo()
        {
            this.Invoke((MethodInvoker)delegate
            {

                CustomerComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
                BranchComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;

                CustomerComboBox.AutoFilter = true;
                CustomerComboBox.ValueMember = "ID";
                CustomerComboBox.DisplayMember = "CustomerName";

                BranchComboBox.AutoFilter = true;
                BranchComboBox.ValueMember = "ID";
                BranchComboBox.DisplayMember = "Branch_Name";
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
                CustomerComboBox.AutoFilter = true;
                var compositeFilter = new CompositeFilterDescriptor();
                var Cusname = new FilterDescriptor("CustomerName", FilterOperator.Contains, string.Empty);
                var CusPhone = new FilterDescriptor("PhoneNumber", FilterOperator.Contains, string.Empty);
                compositeFilter.FilterDescriptors.Add(Cusname);
                compositeFilter.FilterDescriptors.Add(CusPhone);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                CustomerComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);



                BranchComboBox.AutoFilter = true;
                var compositeFilter1 = new CompositeFilterDescriptor();
                var BrName = new FilterDescriptor("Branch_Name", FilterOperator.Contains, string.Empty);
                compositeFilter1.FilterDescriptors.Add(BrName);

                compositeFilter1.LogicalOperator = FilterLogicalOperator.Or;

                BranchComboBox.EditorControl.FilterDescriptors.Add(compositeFilter1);

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
