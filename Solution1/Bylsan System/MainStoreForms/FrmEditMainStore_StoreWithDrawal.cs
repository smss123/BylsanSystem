using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;
namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_StoreWithDrawal : RadForm
    {
        public FrmEditMainStore_StoreWithDrawal()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        public int XDrawalID { get; set; }
        public StoreWithDrawal TregatDrawal { get; set; }

        private void fillCombo()
        {
            #region "  fillItem "
            this.ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.ItemComboBox.AutoFilter = true;
                this.ItemComboBox.ValueMember = "ID";
                this.ItemComboBox.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                ItemComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.ItemComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.ItemComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
            #endregion

            //
            #region "  fillStore "

            this.StoreComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.StoreComboBox.AutoFilter = true;
                this.StoreComboBox.ValueMember = "ID";
                this.StoreComboBox.DisplayMember = "ItemID";
            });


            var q1 = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.DataSource = q1;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.StoreComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.StoreComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
            #endregion

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (ItemComboBox.SelectedValue == null)
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                ItemComboBox.Focus();
                errorProvider1.SetError(this.ItemComboBox, "Please Enter Item ");

                return;
            }
            else
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
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


            if (StoreComboBox.SelectedValue == null)
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                StoreComboBox.Focus();
                errorProvider1.SetError(this.StoreComboBox, "Please Enter Store ");

                return;
            }
            else
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();

            }





            #endregion

            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                StoreWithDrawal tb = new StoreWithDrawal()
                {
                    ID=XDrawalID,
                    ItemID = int.Parse(ItemComboBox.SelectedValue.ToString()),
                    StoreID = int.Parse(StoreComboBox.SelectedValue.ToString()),
                    Qty = int.Parse(qtyTextBox.Text),
                    Comment = commentTextBox.Text,


                };
         //       StoreDrawalCmd.ed(tb);

                Operation.ShowToustOk("StoreDrawal Saved", this);
                Operation.EndOperation(this);
            }

        }

        private void FrmEditMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(fillCombo);
            th.Start();
            XDrawalID = TregatDrawal.ID;
            ItemComboBox.Text = TregatDrawal.Item.ItemName;
            StoreComboBox.Text = TregatDrawal.Store.ProductID.ToString();
            qtyTextBox.Text = TregatDrawal.Qty.ToString();
            commentTextBox.Text = TregatDrawal.Comment;

        }

        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
