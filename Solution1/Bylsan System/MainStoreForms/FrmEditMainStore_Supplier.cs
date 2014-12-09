﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmEditMainStore_Supplier : RadForm
    {
        public FrmEditMainStore_Supplier()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        public int SupplierID { get; set; }
        public Supplier TreagetSupplier { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "


            if (supplierNameTextBox.Text == "")
            {

                supplierNameTextBox.BackColor = Color.OrangeRed;

                supplierNameTextBox.Focus();
                errorProvider1.SetError(this.supplierNameTextBox, "Please Enter Name");

                return;
            }
            else
            {
                supplierNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                Supplier tb = new Supplier
                ()
                 {
                     ID = SupplierID,
                     Address = addressTextBox.Text,
                     Description = descriptionTextBox.Text,
                     SupplierName = supplierNameTextBox.Text,
                     SupplierPhone = supplierPhoneTextBox.Text

                 };
                SuppliersCmd.EditSupplier(tb);
                {
                    Operation.ShowToustOk("Supplier has been Saved ..", this);
                }
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }

                Operation.EndOperation(this);
            }
        }
        private void FrmEditMainStore_Supplier_Load(object sender, EventArgs e)
        {
            SupplierID = TreagetSupplier.ID;
            supplierNameTextBox.Text = TreagetSupplier.SupplierName;
            supplierPhoneTextBox.Text = TreagetSupplier.SupplierPhone;
            addressTextBox.Text = TreagetSupplier.Address;
            descriptionTextBox.Text = TreagetSupplier.Description;
        }
    }
}
