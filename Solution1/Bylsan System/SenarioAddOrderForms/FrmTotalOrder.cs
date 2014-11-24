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

            ListViewProductes.View = View.Details;

            ListViewProductes.Columns.Add("ID", 30, HorizontalAlignment.Center);

            ListViewProductes.Columns.Add("Product", 230, HorizontalAlignment.Center);

            ListViewProductes.Columns.Add("Descriptoin", 300, HorizontalAlignment.Center);


        }

        #endregion


        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            CreateListViewProducts();
            label1.Text = string.Format("Orders Count = {0}", ListViewProductes.Items.Count.ToString());
        }

        private void OkeyBtn_Click(object sender, EventArgs e)
        {
            FrmOrderDate frm = new FrmOrderDate();
            frm.Show();
            this.Hide();
        }



    }
}
