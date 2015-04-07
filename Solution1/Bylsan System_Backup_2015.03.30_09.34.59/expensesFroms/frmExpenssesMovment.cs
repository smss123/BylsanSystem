using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.expensesFroms
{
    public partial class frmExpenssesMovment : Telerik.WinControls.UI.RadForm
    {
        public frmExpenssesMovment()
        {
            InitializeComponent();
        }

        public Expenss tragetExp { get; set; }
        private int ExpID { get; set; }
        private void FillData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();

            var q = ExpenssesMovmentCmd.GetAllExpenssesMovmentByExpID(ExpID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                ExpenssesMovmentGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }
        private void frmExpenssesMovment_Load(object sender, EventArgs e)
        {
            ExpID = tragetExp.ID;
            var th = new Thread(FillData);
            th.Start();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            var frm = new frmAddExpenssesMovment();

            frm.ExpenssId = ExpID;
            frm.TragetExpenss = tragetExp;
            frm.ShowDialog();
            Operation.EndOperation(this);
        }

        private void ExpenssesMovmentGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpenssesMovmentGridView.CurrentColumn.Index;
            if (col == 5)
            {
                Operation.BeginOperation(this);
                var frm = new frmEditExpenssesMovment();
                var tb = (ExpenssesMovment)ExpenssesMovmentGridView.CurrentRow.DataBoundItem;
                frm.TragetExpenssesMovment = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmExpenssesMovment_Load(sender, e);
        }
    }
}
