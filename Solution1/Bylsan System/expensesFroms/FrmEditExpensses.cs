using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.expensesFroms
{
    public partial class FrmEditExpensses : Telerik.WinControls.UI.RadForm
    {
        public FrmEditExpensses()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        public  int ExpenssID{get;set;}
        public Expenss TragetExpenss { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "
            if (expenssesNameTextBox.Text == "")
            {

                expenssesNameTextBox.BackColor = Color.OrangeRed;

                expenssesNameTextBox.Focus();
                errorProvider1.SetError(this.expenssesNameTextBox, "Please Enter Expensses Name");

                return;
            }
            else
            {
                expenssesNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            #endregion

             Operation.BeginOperation(this);
            Expenss extb = new Expenss() {ID=ExpenssID, ExpenssesName = expenssesNameTextBox.Text, Description = descriptionTextBox.Text };
            if (RadMessageBox.Show(this, "Do you Want To Save", "Save Changes", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                ExpenssesCmd.EditExpenss(extb);
            
            }

            Operation.EndOperation(this);



       
        }

        private void FrmEditExpensses_Load(object sender, EventArgs e)
        {
            ExpenssID = TragetExpenss.ID;
            expenssesNameTextBox.Text = TragetExpenss.ExpenssesName;
            descriptionTextBox.Text = TragetExpenss.Description;
        }
    }
}
