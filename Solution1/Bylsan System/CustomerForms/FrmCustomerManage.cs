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
using XamaDataLayer;
using XamaDataLayer.BranchCmd;


namespace Bylsan_System.CustomerForms
{
    public partial class FrmCustomerManage : Form
    {
        public FrmCustomerManage()
        {
            InitializeComponent();
            CustomerGridView.CommandCellClick += CustomerGridView_CommandCellClick;
        }

        void CustomerGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = CustomerGridView.CurrentColumn.Index;
            if (col == 5)
            {
                FrmCustomerEdit frm = new FrmCustomerEdit();
                frm.TragetCustomer = (Customer)CustomerGridView.CurrentRow.DataBoundItem;
                frm.ShowDialog();
            }
        }

        private void FrmCustomerManage_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LoadCustomers);
            th.Start();
        }

        private void LoadCustomers()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading Customer";
            });
            Operation.BeginOperation(this);
            
            CustomerGridView.DataSource = CustomersCmd.GetAllCustmers();
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loaded ..";
            });
        }

        private void CustomerGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
