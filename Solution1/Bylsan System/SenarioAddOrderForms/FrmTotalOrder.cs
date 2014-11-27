using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;

namespace Bylsan_System.SenarioAddOrderForms
{ // 1
    public partial class FrmTotalOrder : Form
    {//2
        public FrmTotalOrder()
        {
            InitializeComponent();
        }

        #region "Populate ListProducts "

        void CreateListViewProducts()
        {




            OrdersListView.View = View.Details;
            OrdersListView.Columns.Add("ID", 30, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Product", 170, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Description", 170, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Quantity", 100, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Price", 70, HorizontalAlignment.Center);

        }

        #endregion


        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            CreateListViewProducts();
            OrdersCountLab.Text = string.Format("Orders Count = {0}", OrdersListView.Items.Count.ToString());
            // ===== جاهز لغاية ما يتم أضافة حقل السعر قي الجدول
            double TotalCostPrice = (from ListViewItem li in OrdersListView.Items
                                     select
                                         Convert.ToDouble(li.SubItems[4].Text.ToString())).Sum();
            TotalPriceBox.Text = TotalCostPrice.ToString();
            OrdersCountLab.Text = OrdersListView.Items.Count.ToString();

        }

        private void OkeyBtn_Click(object sender, EventArgs e)
        {
           
        }



    }
}
