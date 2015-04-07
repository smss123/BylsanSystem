using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using XamaDataLayer;
using XamaDataLayer.Accountant;
using Xprema.XExtention;

namespace Bylsan_System.expensesFroms
{
    public partial class frmAddExpenssesMovment : Telerik.WinControls.UI.RadForm
    {
        public frmAddExpenssesMovment()
        {
            InitializeComponent();
        }
        public int ExpenssId { get; set; }
        public Expenss TragetExpenss { get; set; }
        private void FillAccount()
        {
            AccountsComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                AccountsComboBox.AutoFilter = true;
                AccountsComboBox.ValueMember = "ID";
                AccountsComboBox.DisplayMember = "AccountName";
            });


            var q = AccountsCmd.GetAllAccounts();
            this.Invoke((MethodInvoker)delegate
            {
                AccountsComboBox.DataSource = q;
                var filter = new FilterDescriptor();
                filter.PropertyName = AccountsComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                AccountsComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);




            });
            Operation.EndOperation(this);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == string.Empty)
            {
                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(amountTextBox, "Please Enter Amount ");

                return;
            }
            else
            {
                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();
            }

            Operation.BeginOperation(this);
            var tb = new ExpenssesMovment
            { ExpenssesID = ExpenssId,
                Amount = double.Parse(amountTextBox.Text),
                DateOfProcess = DateTime.Now,
                Description = descriptionTextBox.Text, };

            if (  ExpenssesMovmentCmd.AddExpenssesMovment(tb))
            {
                if ( AccountDailyCmd.AddAccountDaily(new AccountDaily()
                {
                  AccountID = AccountsComboBox.SelectedValue.ToString().ToInt(),
                DateOfProcess = DateTime.Now,
                Description = "عبارة عن مبلغ مسحوب لصالح المصروفات ",
                 TotalOut = amountTextBox.Text.Todouble(),
                  TotalIn = 0f,
                   CommandArg = string.Empty,
                    }))
                {
                    Operation.ShowToustOk("Expenss Has Been Saved", this);
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        amountTextBox.Focus();
                        Operation.EndOperation(this);
                    }
                }
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;
            if (ch == 46 && amountTextBox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frmAddExpenssesMovment_Load(object sender, EventArgs e)
        {
            var th = new Thread(FillAccount);
            th.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
