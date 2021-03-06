﻿using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer;
using Xprema.XExtention;

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
                var tragetProduct = Operation.Allproducts.ToList();
                var content = (GridViewMultiComboBoxColumn)radGridView1.Columns[1];
                content.DataSource = tragetProduct;
                db.CommandTimeout = 90000;
                q = db.Products.Where(p => p.ID == SelectedProduct.ID).Take(1).Single();
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
            GridViewComboBoxColumn col = (GridViewComboBoxColumn)radGridView1.Columns[3];
            col.DataSource = new string[] {
                "Number","Centimeter", "dozen", "feet", "gram","inch", "Kg","Liter",  "Meter", "Mm","Piece"                  
            };

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

        private void radGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            //try
            //{
            //    foreach (GridViewRowInfo item in radGridView1.Rows)
            //    {
            //        var p = (ProductContent)item.DataBoundItem;
            //        item.Cells[3].Value = p.Product.ProductUnit;
            //    }
            //}
            //catch (Exception ex)
            //{


            //}
        }

        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
           
           int p =e.Row.Cells[1].Value.ToString().ToInt();
           e.Row.Cells[3].Value = Operation.Allproducts.Where(x=>x.ID==p).SingleOrDefault().ProductUnit;
           //e.Row.Cells[0].Value = ApiCounter.GetNumber();
        }
    }
}
