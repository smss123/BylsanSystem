using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
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
            ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                ItemComboBox.AutoFilter = true;
                ItemComboBox.ValueMember = "ID";
                ItemComboBox.DisplayMember = "ItemName";
            });


            var q = ItemsCmd.GetAllItems();
            this.Invoke((MethodInvoker)delegate
            {
                ItemComboBox.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = ItemComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                ItemComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);





            StoreComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.AutoFilter = true;
                StoreComboBox.ValueMember = "ID";
                StoreComboBox.DisplayMember = "ItemID";
            });


            var q1 = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.DataSource = q1;
                var filter = new FilterDescriptor();
                filter.PropertyName = StoreComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                StoreComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedValue == null)
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                ItemComboBox.Focus();
                errorProvider1.SetError(ItemComboBox, "Please Enter Item ");

                return;
            }
            else
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
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


            if (StoreComboBox.SelectedValue == null)
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;


                StoreComboBox.Focus();
                errorProvider1.SetError(StoreComboBox, "Please Enter Store ");

                return;
            }
            else
            {
                StoreComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }







            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);


                Operation.ShowToustOk("StoreDrawal Saved", this);
                Operation.EndOperation(this);
            }
        }

        private void FrmEditMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            var th = new Thread(fillCombo);
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
