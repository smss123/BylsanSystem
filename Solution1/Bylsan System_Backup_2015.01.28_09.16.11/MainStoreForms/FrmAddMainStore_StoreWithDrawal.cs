using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_StoreWithDrawal : RadForm
    {
        public FrmAddMainStore_StoreWithDrawal()
        {
            InitializeComponent();
        }
        private void fillCombo()
        {
            CmbItems.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                CmbItems.AutoFilter = true;
                CmbItems.ValueMember = "ID";
                CmbItems.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                CmbItems.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = CmbItems.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                CmbItems.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (CmbItems.SelectedValue == null)
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                CmbItems.Focus();
                errorProvider1.SetError(CmbItems, "Please Enter Item ");

                return;
            }
            else
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }
            if (qtyTextBox.Text == string.Empty)
            {
                qtyTextBox.BackColor = Color.OrangeRed;

                qtyTextBox.Focus();
                errorProvider1.SetError(qtyTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }











            if (int.Parse(qtyTextBox.Text.ToString()) > xAvailableQty)
            {
                Operation.ShowToustOk("Qty Not vvailable ... Sorry", this);
                Broom();
                return;
            }

            Operation.BeginOperation(this);
            var tb = new StoreWithDrawal()
            { ItemID = XItemID ,
                StoreID =  xStoreTb .ID ,
                DateOfProcess = DateTime.Now,
                Qty = int.Parse(qtyTextBox.Text),
                Comment = commentTextBox.Text + "-- Roll Out Qty   ",
                UserID = XamaDataLayer.Security.UserInfo.CurrentUserID };
            StoreDrawalCmd.AddDrawal(tb);

            RollOutQty();
            WriteAtStoreManagerTable();

            Operation.ShowToustOk("Store Drawal Saved", this);

            Broom();

            Operation.EndOperation(this);
        }

        private void FrmAddMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            var th = new Thread(fillCombo);
            th.Start();
        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        public int XItemID { get; set; }
        public Store  xStoreTb { get; set; }
        public int   xAvailableQty { get; set; }
        public int ItmUnitPrice  { get; set; }
        public int TotalPrice { get; set; }
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbItems .Text != null)
            {
                XItemID = 0;
                XItemID = int .Parse (CmbItems.SelectedValue.ToString());

                xStoreTb = StoreCmd.GetAvailableQtyByItemID (XItemID);
                xAvailableQty = int .Parse (xStoreTb.AvailableQty.ToString ());


                var tb = StoreSalesCmd.GetAllSTore_SellByItemID(XItemID);
                ItmUnitPrice = 0;
                ItmUnitPrice = int .Parse (tb.UnitPrice .ToString ());
            }
        }

        private void RollOutQty()
        {
            xStoreTb.ProductID = XItemID;
            xStoreTb.AvailableQty -= int.Parse(qtyTextBox.Text);
            xStoreTb.Description = "Roll Out ";
            StoreCmd.EditStore(xStoreTb);
        }

        private void WriteAtStoreManagerTable()
        {
            TotalPrice = 0 ;
            TotalPrice = int .Parse (qtyTextBox .Text .ToString ()) * ItmUnitPrice ;
            var tb = new StoreManager () { StoreID = xStoreTb .ID ,
             QtyInOrOut = int .Parse (qtyTextBox .Text .ToString ()),
             DateOfProcess = DateTime .Now ,
             Price =  TotalPrice ,
             ProcessType = "Roll Out ",
             Description = "Roll Out Qty ( Drawal Process )" };
            StoreManagerCmd.AddStoreManager(tb);
        }
        private void Broom()
        {
            CmbItems.ResetText();
            qtyTextBox.Clear();
            commentTextBox.Clear();
            CmbItems.Focus();
        }
    }
}
