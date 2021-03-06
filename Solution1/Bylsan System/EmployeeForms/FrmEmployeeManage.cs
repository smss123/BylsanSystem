﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.EmployeeForms
{
    public partial class FrmEmployeeManage : RadForm
    {
        public FrmEmployeeManage()
        {
            InitializeComponent();
            EmployeeGridView.CommandCellClick += radGridView1_CommandCellClick;
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = EmployeeGridView.CurrentColumn.Index;
            if (col == 9)
            {
                var frm = new FrmEmployeeEdit();
                frm.TragetEmployee = (Employee)EmployeeGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadEmployee();
            }
            if (col == 10)
            {
                if (RadMessageBox.Show("Sure To Delete?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    EmployeesCmd.DeleteEmployee(((Employee)EmployeeGridView.CurrentRow.DataBoundItem).ID);
                    Operation.ShowToustOk("Deleted", this);
                    FrmEmployeeManage_Load(sender, e);
                    Operation.EndOperation(this);
                }
            }
        }

        private void FrmEmployeeManage_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadEmployee);
            th.Start();
        }

        private void LoadEmployee()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = EmployeesCmd.GetAllEmployees();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                EmployeeGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void EmployeeGridView_Click(object sender, EventArgs e)
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddEmployee();
            frm.ShowDialog();
        }
    }
}
