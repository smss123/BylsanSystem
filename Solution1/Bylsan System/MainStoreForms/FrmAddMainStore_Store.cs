using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
            ItemColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                ItemColumnComboBox.AutoFilter = true;
                ItemColumnComboBox.ValueMember = "ID";
                ItemColumnComboBox.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                ItemColumnComboBox.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = ItemColumnComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                ItemColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (ItemColumnComboBox.SelectedValue == null)
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                ItemColumnComboBox.Focus();
                errorProvider1.SetError(ItemColumnComboBox, "Please Enter itemName name");

                return;
            }
            else
            {
                ItemColumnComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (QtyTextBox.Text == string.Empty)
            {
                QtyTextBox.BackColor = Color.OrangeRed;

                QtyTextBox.Focus();
                errorProvider1.SetError(QtyTextBox, "Please Enter Qty");

                return;
            }
            else
            {
                QtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            Operation.BeginOperation(this);


            try
            {
                var ChkStore = StoreCmd.ChekByItemID(int.Parse(ItemColumnComboBox.SelectedValue.ToString()));
                if (ChkStore.ID != 0)
                {
                    ChkStore.ProductID = int.Parse(ItemColumnComboBox.SelectedValue.ToString());
                    ChkStore.AvailableQty += int.Parse(QtyTextBox.Text);
                    ChkStore.Description = DescriptiontextBox.Text;

                    StoreCmd.EditStore(ChkStore);



                    TargetStoreID = ChkStore.ID;
                    WriteAt_StoreSells();
                    WriteAtStoreManagerTable();


                    Operation.ShowToustOk("Item Updated ", this);
                }
            }
            catch (Exception)
            {
                var tb = new Store
                { ProductID = int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                    AvailableQty = int.Parse(QtyTextBox.Text),
                    Description = DescriptiontextBox.Text
                };
                StoreCmd.AddNewStore(tb);
                Operation.ShowToustOk("Item Saved", this);

                GetStore();

                WriteAt_StoreSells();
                WriteAtStoreManagerTable();
            }

            txtUnitPrice.Text = string.Empty;
            ItemColumnComboBox.ResetText();
            QtyTextBox.Clear();
            DescriptiontextBox.Clear();
            ItemColumnComboBox.Focus();
            Operation.EndOperation(this);
        }

        private void FrmAddMainStore_Store_Load(object sender, EventArgs e)
        {
            PopulateCmbSuppliers();

            var th = new Thread(FillComboBoxItme);
            th.Start();
        }
        private void AvailableQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void PopulateCmbSuppliers()
        {
            CmbSuppliers.Items.Clear();
            CmbSuppliers.Items.AddRange(
                (from s in SuppliersCmd.GetAllSuppliers()
                  select s.SupplierName).Distinct().ToArray());
        }



        public int xSupplierId { get; set; }
        public int TotalPrice { get; set; }

        public Store StoreTb { get; set; }

        public int TargetStoreID { get; set; }
        private void CmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void WriteAt_StoreSells()
        {
            TotalPrice = 0;
            TotalPrice = int.Parse(txtUnitPrice.Text.ToString()) * int.Parse(QtyTextBox.Text.ToString());

            var stb = new Store_Sell()
            { ItemID = int.Parse(ItemColumnComboBox.SelectedValue.ToString()),
                UnitPrice = int.Parse(txtUnitPrice.Text.ToString()),
                Price = TotalPrice,
                DateOfProcess = DateTime.Now,
                UserID = XamaDataLayer.Security.UserInfo.CurrentUserID,
                SupplierID = xSupplierId, };
            StoreSalesCmd.AddNewSales(stb);
        }

        private void WriteAtStoreManagerTable()
        {
            TotalPrice = 0;
            TotalPrice = int.Parse(txtUnitPrice.Text.ToString()) * int.Parse(QtyTextBox.Text.ToString());
            var tb = new StoreManager()
            { StoreID = TargetStoreID ,
                QtyInOrOut = int.Parse(QtyTextBox.Text.ToString()),
                DateOfProcess = DateTime.Now,
                Price = TotalPrice,
                ProcessType = "Pull In ",
                Description = "Pull In Qty (Sales )"
            };
            StoreManagerCmd.AddStoreManager(tb);
        }

        private void GetStore()
        {
            TargetStoreID = 0;
            StoreTb = StoreCmd.ChekByItemID(int.Parse(ItemColumnComboBox.SelectedValue.ToString()));
            TargetStoreID = StoreTb.ID;
        }

        private void CmbSuppliers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (CmbSuppliers.Text != string.Empty)
                {
                    xSupplierId = 0;
                    xSupplierId = (from i in SuppliersCmd.GetAllSuppliers()
                                    where i.SupplierName == CmbSuppliers.Text
                                    select i.ID).Single();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
