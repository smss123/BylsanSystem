﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
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

            this.StoreComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.StoreComboBox.AutoFilter = true;
                this.StoreComboBox.ValueMember = "ID";
                this.StoreComboBox.DisplayMember = "ItemID";
            });


            var q = StoreCmd.GetAllStores();
            this.Invoke((MethodInvoker)delegate
            {
                StoreComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.StoreComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.StoreComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

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


            if (qtyInOrOutTextBox.Text == "")
            {

                qtyInOrOutTextBox.BackColor = Color.OrangeRed;

                qtyInOrOutTextBox.Focus();
                errorProvider1.SetError(this.qtyInOrOutTextBox, "Please Enter Qty ");

                return;
            }
            else
            {
                qtyInOrOutTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }


            if (priceTextBox.Text == "")
            {

                priceTextBox.BackColor = Color.OrangeRed;

                priceTextBox.Focus();
                errorProvider1.SetError(this.priceTextBox, "Please Enter price");

                return;
            }
            else
            {
                priceTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {

                Operation.BeginOperation(this);
                StoreManager tb = new StoreManager()
                {
                    ID = XStoreManegerID,
                    StoreID = int.Parse(StoreComboBox.SelectedValue.ToString()),        
                    QtyInOrOut = int.Parse(qtyInOrOutTextBox.Text),
                    ProcessType = processTypeComboBox.Text,
                    Price = double.Parse(priceTextBox.Text),
                    Description = descriptionTextBox.Text,
                };
                StoreManagerCmd.EditStoreManager(tb);
                Operation.ShowToustOk("StoreManager Saved", this);
                Operation.EndOperation(this);


            }

        }

        private void FrmEditMainStore_StoreManager_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillComboBoxStor);
            th.Start();

            XStoreManegerID = TregatStorManeger.ID;
            StoreComboBox.Text = TregatStorManeger.Store.ItemID.ToString();
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
            char ch = e.KeyChar;
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
