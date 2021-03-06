﻿using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer;

namespace Bylsan_System.ProductForms
{
    public partial class frmContentx : RadForm
    {
        public frmContentx()
        {
            InitializeComponent();
        }

        private DbDataContext db = new DbDataContext();

        private void ProductManagmentFunction(bool loader)
        {
            var q = new object();
            if (loader)
            {
                var tragetProduct = Operation.Allproducts.Where(p => p.ProductType == "All" || p.ProductType == "Row material").ToList();
                var content = (GridViewMultiComboBoxColumn)radGridView1.Columns[1];
                content.DataSource = tragetProduct;

                q =  db.Products.Where(p => p.ID == SelectedProduct.ID).Take(1).Single();
                productBindingSource.DataSource = q;
            }
            else
            {
                this.Validate();
                productBindingSource.EndEdit();

                Operation.BeginOperation(this);
                db.SubmitChanges();
                Operation.EndOperation(this);
                Operation.ShowToustOk("Saved", this);
            }
        }
        public Product SelectedProduct { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            ProductManagmentFunction(true);


            Operation.EndOperation(this);
        }

        private void radGridView1_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            try
            {
                var editor = (RadMultiColumnComboBoxElement)radGridView1.ActiveEditor;
                editor.DropDownWidth = 500;
                editor.DropDownHeight = 250;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductManagmentFunction(false);
        }
    }
}
