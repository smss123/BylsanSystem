using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer.Main_Store;
namespace Bylsan_System.MainStoreForms
{
    public partial class FrmAddMainStore_Supplier : RadForm
    {
        public FrmAddMainStore_Supplier()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
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
            Operation.BeginOperation(this);
           if( SuppliersCmd.AddNewSupplier(new XamaDataLayer.Supplier() { 
             Address = addressTextBox.Text,
              Description= descriptionTextBox.Text,
               SupplierName= supplierNameTextBox.Text,
                SupplierPhone = supplierPhoneTextBox.Text

           }))
           {
               Operation.ShowToustOk("Supplier has been Saved ..", this);
           }
           Operation.EndOperation(this);
        }

        private void FrmAddMainStore_Supplier_Load(object sender, EventArgs e)
        {

        }
        }
    }

