using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using XamaDataLayer;
using XamaDataLayer.Accountant;

namespace Bylsan_System.expensesFroms
{
    public partial class FrmexpensesShow : Telerik.WinControls.UI.RadForm
    {
        public FrmexpensesShow()
        {
            InitializeComponent();
        }
      
        private void FillData()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
          {

              toolStrip1.Text = "Loading .. ";

          });
            Operation.BeginOperation(this);

            Application.DoEvents();

            var q = ExpenssesCmd.GetAllExpensses();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                
                expensesGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void FrmexpensesShow_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillData);
            th.Start();
          
        }

        private void expensesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = expensesGridView.CurrentColumn.Index;
             if (col == 3)
             {
                 Operation.BeginOperation(this);
                 FrmEditExpensses frm = new FrmEditExpensses();
                 Expenss tb = (Expenss)expensesGridView.CurrentRow.DataBoundItem;
                 frm.TragetExpenss = tb;
                 frm.ShowDialog();
                 Operation.EndOperation(this);
             }

             if (col == 4)
             {


                 Operation.BeginOperation(this);
                 frmExpenssesMovment frm = new frmExpenssesMovment();
                 Expenss tb = (Expenss)expensesGridView.CurrentRow.DataBoundItem;
                 frm.tragetExp = tb;
                 frm.ShowDialog();
                 Operation.EndOperation(this);

             }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            FrmAddExpensses frm = new FrmAddExpensses();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmexpensesShow_Load(sender, e);
        }
    }
}