using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.BranchForms
{
    public partial class FrmDeliveryOrderShowInfo : RadForm
    {
        public FrmDeliveryOrderShowInfo()
        {
            InitializeComponent();
        }
        public Order TargetOrder { get; set; }


        private void FrmDeliveryOrderShowInfo_Load_1(object sender, EventArgs e)
        {
            var custid = TargetOrder.CustomerID;

            labCustomerName.Text = (from c in CustomersCmd.GetAllCustmers()
                                     where c.ID == custid
                                     select c.CustomerName).Single();
            labCustomerPhone.Text = (from c in CustomersCmd.GetAllCustmers()
                                      where c.ID == custid
                                      select c.PhoneNumber).Single();
            TotaltextBox.Text = TargetOrder.TotalAmount.ToString();
            var lstproducts = OrderProductsCmd.GetAllByOrderID(TargetOrder.ID);
            dgvproducts.DataSource = lstproducts;
        }

        private void OkyBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
