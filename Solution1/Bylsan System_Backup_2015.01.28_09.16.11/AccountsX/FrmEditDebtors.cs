using System;
using System.Collections.Generic;
using System.Drawing;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.AccountsX
{
    public partial class FrmEditDebtors : Telerik.WinControls.UI.RadForm
    {
        public FrmEditDebtors()
        {
            InitializeComponent();
        }
        public Debtor TargetDebitor { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (debtorNameTextBox.Text == string.Empty)
            {
                debtorNameTextBox.BackColor = Color.OrangeRed;

                debtorNameTextBox.Focus();
                errorProvider1.SetError(debtorNameTextBox, "Please Enter Debtor name");

                return;
            }
            else
            {
                debtorNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }




            Operation.BeginOperation(this);

            TargetDebitor.DebtorName = debtorNameTextBox.Text;
            TargetDebitor.PhoneNumber = phoneNumberTextBox.Text;
            TargetDebitor.Addresss = addresssTextBox.Text;
            TargetDebitor.DebtorDescription = debtorDescriptionTextBox1.Text;

            DebtorsCmd.EditDebtor(TargetDebitor, TargetDebitor.ID);

            Operation.EndOperation(this);

            Operation.ShowToustOk("Updated Successfull ....", this);


            this.Hide();
        }

        private void FrmEditDebtors_Load(object sender, EventArgs e)
        {
            debtorNameTextBox.Text = TargetDebitor.DebtorName;
            phoneNumberTextBox.Text = TargetDebitor.PhoneNumber;
            addresssTextBox.Text = TargetDebitor.Addresss;
            debtorDescriptionTextBox1.Text = TargetDebitor.DebtorDescription;
        }
    }
}
