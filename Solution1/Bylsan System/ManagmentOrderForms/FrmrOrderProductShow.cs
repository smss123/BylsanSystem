using System;
using System.Collections.Generic;
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
    public partial class FrmrOrderProductShow : RadForm
    {
        public FrmrOrderProductShow()
        {
            InitializeComponent();
            radGridView1.CommandCellClick += radGridView1_CommandCellClick;
        }

        void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            if (radGridView1.CurrentCell.ColumnInfo.Index == 7)
            {
                OrderProduct o = (OrderProduct)radGridView1.CurrentRow.DataBoundItem;
                FrmrOrderProductEdit frm = new FrmrOrderProductEdit();
                frm.TragetOrderProduct = o;
                frm.ShowDialog();
            }
        }

        private void orderDeliveryDateLabel_Click(object sender, EventArgs e)
        {
        }
        public Order TragetOrder { get; set; }
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

            orderBindingSource.DataSource = TragetOrder;
            th.Abort();
        }
        private void FrmrOrderProductShow_Load(object sender, EventArgs e)
        {
            th = new Thread(fillCombo);
            th.Start();
            orderStatusComboBox.Text = TragetOrder.OrderStatus;
            orderVerifyTextBox.Text = TragetOrder.OrderVerify;
            totalAmountTextBox.Text = TragetOrder.TotalAmount.ToString();
            orderDeliveryTextBox.Text = TragetOrder.OrderDelivery;
            orderDeliveryDateDateTimePicker.Value = TragetOrder.OrderDeliveryDate.Value;
            BranchComboBox.Text = TragetOrder.DeliverdToBranch.ToString();
            commentTextBox.Text = commentTextBox.Text;
            radGridView1.DataSource = TragetOrder.OrderProducts;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            OrdersCmd.EditFullOrder(new Order()
            {
                CustomerID = CustomerComboBox.SelectedValue.ToString().ToInt(),
                Comment = commentTextBox.Text,
                DeliverdToBranch = BranchComboBox.SelectedValue.ToString().ToInt(),
                 OrderDate = TragetOrder.OrderDate,
                  OrderDelivery = orderDeliveryTextBox.Text,
                   OrderDeliveryDate=orderDeliveryDateDateTimePicker.Value,
                    OrderName = TragetOrder.OrderName,
                     OrderStatus = orderStatusComboBox.Text,
                      OrderType= TragetOrder.OrderType,
                       OrderVerify = orderVerifyTextBox.Text,
                TotalAmount = totalAmountTextBox.Text.Todouble(),
                
            }, TragetOrder.ID);
            Operation.EndOperation(this);
            Operation.ShowToustOk("Order Edited", this);
        }
    }
}
