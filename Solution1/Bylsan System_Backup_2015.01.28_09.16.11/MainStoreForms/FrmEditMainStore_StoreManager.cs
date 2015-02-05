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
    public partial class FrmEditMainStore_StoreManager : RadForm
    {
        public FrmEditMainStore_StoreManager()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        public int XStoreManegerID { get; set; }
        public StoreManager TregatStorManeger { get; set; }
        private void FillComboBoxStor()
        {
            StoreComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.AutoFilter = true;
                StoreComboBox.ValueMember = "ID";
                StoreComboBox.DisplayMember = "ItemID";
            });


            var q = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = StoreComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                StoreComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
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


            if (qtyInOrOutTextBox.Text == string.Empty)
            {
                qtyInOrOutTextBox.BackColor = Color.OrangeRed;

                qtyInOrOutTextBox.Focus();
                errorProvider1.SetError(qtyInOrOutTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyInOrOutTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (priceTextBox.Text == string.Empty)
            {
                priceTextBox.BackColor = Color.OrangeRed;

                priceTextBox.Focus();
                errorProvider1.SetError(priceTextBox, "Please Enter price");

                return;
            }
            else
            {
                priceTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                var tb = new StoreManager()
                { ID = XStoreManegerID,
                    StoreID = int.Parse(StoreComboBox.SelectedValue.ToString()),
                    QtyInOrOut = int.Parse(qtyInOrOutTextBox.Text),
                    ProcessType = processTypeComboBox.Text,
                    Price = double.Parse(priceTextBox.Text),
                    Description = descriptionTextBox.Text, };
                StoreManagerCmd.EditStoreManager(tb);
                Operation.ShowToustOk("StoreManager Saved", this);
                Operation.EndOperation(this);
            }
        }

        private void FrmEditMainStore_StoreManager_Load(object sender, EventArgs e)
        {
            var th = new Thread(FillComboBoxStor);
            th.Start();

            XStoreManegerID = TregatStorManeger.ID;
            StoreComboBox.Text = TregatStorManeger.Store.ProductID.ToString();
            processTypeComboBox.Text = TregatStorManeger.ProcessType;
            priceTextBox.Text = TregatStorManeger.Price.ToString();
            descriptionTextBox.Text = TregatStorManeger.Description;
            qtyInOrOutTextBox.Text = TregatStorManeger.QtyInOrOut.ToString();
        }

        private void SaveBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;
            if (ch == 46 && priceTextBox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
