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
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_Store : RadForm
    {
        public FrmAddMainStore_Store()
        {
            InitializeComponent();
        }
        private void FillComboBoxItme()
        {

            this.ItemColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.ItemColumnComboBox.AutoFilter = true;
                this.ItemColumnComboBox.ValueMember = "ID";
                this.ItemColumnComboBox.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                ItemColumnComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.ItemColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.ItemColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (ItemColumnComboBox.SelectedValue == null)
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                ItemColumnComboBox.Focus();
                errorProvider1.SetError(this.ItemColumnComboBox, "Please Enter itemName name");

                return;
            }
            else
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (QtyTextBox.Text == "")
            {

                QtyTextBox.BackColor = Color.OrangeRed;

                QtyTextBox.Focus();
                errorProvider1.SetError(this.QtyTextBox, "Please Enter Qty");

                return;
            }
            else
            {
                QtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

            Operation.BeginOperation(this);


            try
            {
                var ChkStore = StoreCmd.ChekByItemID(int.Parse(ItemColumnComboBox.SelectedValue.ToString()));
                if (ChkStore.ID != 0)
                {
                    // Edit AvailableQty
                    ChkStore.ItemID = int.Parse(ItemColumnComboBox.SelectedValue.ToString());
                    ChkStore.AvailableQty += int.Parse(QtyTextBox.Text);
                    ChkStore.Description = DescriptiontextBox.Text;

                    StoreCmd.EditStore(ChkStore);

                    //================================================
                    WriteAt_StoreSells();
                    WriteAtStoreManagerTable();
                    //================================================
                    GetStore();
                    Operation.ShowToustOk("Item Updated ", this);
                }
            }
            catch (Exception)
            {
                // new 
                Store tb = new Store
                {
                    ItemID = int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                    AvailableQty = int.Parse(QtyTextBox.Text),
                    Description = DescriptiontextBox.Text
                };
                StoreCmd.AddNewStore(tb);
                Operation.ShowToustOk("Item Saved", this);
                //================================================
                GetStore();
                //================================================
                WriteAt_StoreSells();
                WriteAtStoreManagerTable();
                //================================================
            }


            ItemColumnComboBox.ResetText();
            QtyTextBox.Clear();
            DescriptiontextBox.Clear();
            ItemColumnComboBox.Focus();
            Operation.EndOperation(this);

        }

        private void FrmAddMainStore_Store_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillComboBoxItme);
            th.Start();
        }
        private void AvailableQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        void PopulateCmbSuppliers()
        {
            CmbSuppliers.Items.AddRange(
                (from s in SuppliersCmd.GetAllSuppliers() select s.SupplierName).Distinct().ToArray());
        }



        public int xSupplierId { get; set; }
        public int TotalPrice { get; set; }

        public Store StoreTb { get; set; }
        private void CmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        void WriteAt_StoreSells()
        {
            TotalPrice = 0;
            TotalPrice = int.Parse(txtUnitPrice.Text.ToString()) * int.Parse(QtyTextBox.Text.ToString());

            Store_Sell stb = new Store_Sell()
            {
                ItemID = int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                UnitPrice = int.Parse(txtUnitPrice.Text.ToString()),
                Price = TotalPrice,
                DateOfProcess = DateTime.Now,
                UserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
                SupplierID = xSupplierId,

            };
            StoreSalesCmd.AddNewSales(stb);
        }

        void WriteAtStoreManagerTable()
        {

            TotalPrice = 0;
            TotalPrice = int.Parse(txtUnitPrice.Text.ToString()) * int.Parse(QtyTextBox.Text.ToString());
            StoreManager tb = new StoreManager()
            {
                StoreID = StoreTb.ID,
                QtyInOrOut = int.Parse(QtyTextBox.Text.ToString()),
                DateOfProcess = DateTime.Now,
                Price = TotalPrice,
                ProcessType = "Pull In ",
                Description = "Pull In Qty (Sales )"
            };
            StoreManagerCmd.AddStoreManager(tb);
        }

        void GetStore()
        {

            StoreTb = StoreCmd.ChekByItemID(int.Parse(ItemColumnComboBox.SelectedValue.ToString()));


        }

        private void CmbSuppliers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (CmbSuppliers.Text != "")
                {
                    xSupplierId = (from i in SuppliersCmd.GetAllSuppliers() where i.SupplierName == CmbSuppliers.Text select i.ID).Single();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}