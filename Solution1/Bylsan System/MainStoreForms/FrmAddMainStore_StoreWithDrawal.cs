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
    public partial class FrmAddMainStore_StoreWithDrawal : RadForm
    {
        public FrmAddMainStore_StoreWithDrawal()
        {
            InitializeComponent();
        }
        private void fillCombo()
        {
            #region "  fillItem "
            this.CmbItems.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CmbItems.AutoFilter = true;
                this.CmbItems.ValueMember = "ID";
                this.CmbItems.DisplayMember = "ItemName";
            });

          
            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                CmbItems.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.CmbItems.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.CmbItems.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
            #endregion

            //
            #region "  fillStore "

            this.CmbStores.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CmbStores.AutoFilter = true;
                this.CmbStores.ValueMember = "ID";
                this.CmbStores.DisplayMember = "ItemID";
            });


            var q1 = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                CmbStores.DataSource = q1;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.CmbStores.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.CmbStores.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
            #endregion

        }

       
        private void Addbtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (CmbItems.SelectedValue == null)
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                CmbItems.Focus();
                errorProvider1.SetError(this.CmbItems, "Please Enter Item ");

                return;
            }
            else
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();

            }
            if (qtyTextBox.Text == "")
            {

                qtyTextBox.BackColor = Color.OrangeRed;

                qtyTextBox.Focus();
                errorProvider1.SetError(this.qtyTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }


            if (CmbStores.SelectedValue == null)
            {
                CmbStores.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                CmbStores.Focus();
                errorProvider1.SetError(this.CmbStores, "Please Enter Store ");

                return;
            }
            else
            {
                CmbStores.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();

            }


 


            #endregion

            //=====================================================
            if (int.Parse(qtyTextBox.Text.ToString()) > xAvailableQty)
            {
                Operation.ShowToustOk("Qty Not vvailable ... Sorry", this);
                Broom();
                return;
            }

            Operation.BeginOperation(this);
            StoreWithDrawal tb = new StoreWithDrawal()
            {
                ItemID = XItemID ,
                StoreID =  xStoreTb .ID ,
                DateOfProcess=DateTime.Now,
                Qty=int.Parse(qtyTextBox.Text),
                Comment=commentTextBox.Text + "-- Roll Out Qty   ",
                UserID = XamaDataLayer.Security.UserInfo.CurrentUserID 

            };
            StoreDrawalCmd.AddDrawal(tb);
            //==========================
            RollOutQty();
            WriteAtStoreManagerTable();
            //==========================
            Operation.ShowToustOk("Store Drawal Saved", this);

            Broom();
       
            Operation.EndOperation(this);

        }

        private void FrmAddMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(fillCombo);
            th.Start();
        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #region "  ^^^ Load Store Informations    "
        public int XItemID { get; set; }
        public Store  xStoreTb { get; set; }
        public int   xAvailableQty { get; set; }
        public int ItmUnitPrice  { get; set; }
        public int TotalPrice { get; set; }
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbItems .Text != null){
                XItemID = 0;
                XItemID = int .Parse (CmbItems.SelectedValue.ToString());

                xStoreTb = StoreCmd.GetAvailableQtyByItemID (XItemID);
                xAvailableQty = int .Parse (xStoreTb.AvailableQty.ToString ());
                //===============================================================
                // Get Item Price From  {  Store Sell Table }
                Store_Sell tb = StoreSalesCmd.GetAllSTore_SellByItemID(XItemID);
                ItmUnitPrice = 0;
                ItmUnitPrice = int .Parse (tb.UnitPrice .ToString ());
            }
        }

        void RollOutQty()
        {
            xStoreTb.ItemID = XItemID;
            xStoreTb.AvailableQty -= int.Parse(qtyTextBox.Text);
            xStoreTb.Description = "Roll Out ";
            StoreCmd.EditStore(xStoreTb);
        }

        void WriteAtStoreManagerTable()
        {
            TotalPrice = 0 ;
            TotalPrice = int .Parse (qtyTextBox .Text .ToString ()) * ItmUnitPrice ;
            StoreManager tb = new StoreManager () {
             StoreID = xStoreTb .ID ,
             QtyInOrOut = int .Parse (qtyTextBox .Text .ToString ()),
             DateOfProcess = DateTime .Now ,
             Price =  TotalPrice ,
             ProcessType = "Roll Out ",
             Description = "Roll Out Qty ( Drawal Process )" 
            };
            StoreManagerCmd.AddStoreManager(tb);
        }
        void Broom()
        {
          
            CmbItems.ResetText();
            CmbStores.ResetText();
            qtyTextBox.Clear();
            commentTextBox.Clear();
            CmbItems.Focus();

        }
        #endregion 

    }
}
