﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ProductForms
{
    public partial class FrmManageProductCategory : RadForm
    {
        public FrmManageProductCategory()
        {
            InitializeComponent();
            radGridView1.CommandCellClick += radGridView1_CommandCellClick;
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;

            if (col == 3)
            {
                var frm = new FrmEditProductCategory();
                frm.TragetCategory = (ProductCategory)radGridView1.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadCategory();
            }
        }

        private void FrmManageProductCategory_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadCategory);
            th.Start();
        }

        private void LoadCategory()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading ....";
            });
            Operation.BeginOperation(this);
            radGridView1.DataSource = CategoriesCmd.GetAllCategories();
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Complete ....";

            });
        }
    }
}
