namespace Bylsan_System.MainStoreForms
{
    partial class frmMainToBranchTranfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.NumericUpDown();
            this.ProductCmb = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.BranchCmb = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.btnOky = new Telerik.WinControls.UI.RadButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Qty);
            this.groupBox1.Controls.Add(this.ProductCmb);
            this.groupBox1.Controls.Add(this.BranchCmb);
            this.groupBox1.Location = new System.Drawing.Point(17, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(112, 77);
            this.Qty.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(272, 20);
            this.Qty.TabIndex = 2;
            // 
            // ProductCmb
            // 
            this.ProductCmb.DataSource = this.productBindingSource;
            this.ProductCmb.DisplayMember = "Product_Name";
            this.ProductCmb.DropDownMaxSize = new System.Drawing.Size(600, 0);
            this.ProductCmb.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            // 
            // ProductCmb.NestedRadGridView
            // 
            this.ProductCmb.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ProductCmb.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductCmb.EditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductCmb.EditorControl.EnableCustomFiltering = true;
            this.ProductCmb.EditorControl.EnableCustomGrouping = true;
            this.ProductCmb.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ProductCmb.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductCmb.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductCmb.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // ProductCmb.NestedRadGridView
            // 
            this.ProductCmb.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ProductCmb.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ProductCmb.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ProductCmb.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.ProductCmb.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ProductCmb.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 82;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product_Name";
            gridViewTextBoxColumn1.Width = 82;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PublicName";
            gridViewTextBoxColumn2.HeaderText = "PublicName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "PublicName";
            gridViewTextBoxColumn2.Width = 82;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProductPrice";
            gridViewDecimalColumn2.HeaderText = "ProductPrice";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductPrice";
            gridViewDecimalColumn2.Width = 82;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductUnit";
            gridViewTextBoxColumn3.HeaderText = "ProductUnit";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ProductUnit";
            gridViewTextBoxColumn3.Width = 82;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ProductType";
            gridViewTextBoxColumn4.HeaderText = "ProductType";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ProductType";
            gridViewTextBoxColumn4.Width = 75;
            this.ProductCmb.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.ProductCmb.EditorControl.MasterTemplate.DataSource = this.productBindingSource;
            this.ProductCmb.EditorControl.MasterTemplate.EnableCustomFiltering = true;
            this.ProductCmb.EditorControl.MasterTemplate.EnableCustomGrouping = true;
            this.ProductCmb.EditorControl.MasterTemplate.EnableFiltering = true;
            this.ProductCmb.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ProductCmb.EditorControl.Name = "NestedRadGridView";
            this.ProductCmb.EditorControl.ReadOnly = true;
            this.ProductCmb.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductCmb.EditorControl.ShowGroupPanel = false;
            this.ProductCmb.EditorControl.Size = new System.Drawing.Size(0, 106);
            this.ProductCmb.EditorControl.TabIndex = 0;
            this.ProductCmb.Location = new System.Drawing.Point(112, 25);
            this.ProductCmb.Name = "ProductCmb";
            this.ProductCmb.Size = new System.Drawing.Size(272, 20);
            this.ProductCmb.TabIndex = 1;
            this.ProductCmb.TabStop = false;
            this.ProductCmb.ThemeName = "Office2010Black";
            this.ProductCmb.ValueMember = "ID";
            this.ProductCmb.SelectedIndexChanged += new System.EventHandler(this.ProductCmb_SelectedIndexChanged);
            // 
            // BranchCmb
            // 
            this.BranchCmb.DataSource = this.branchBindingSource;
            this.BranchCmb.DisplayMember = "Branch_Name";
            this.BranchCmb.DropDownMaxSize = new System.Drawing.Size(600, 0);
            // 
            // BranchCmb.NestedRadGridView
            // 
            this.BranchCmb.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.BranchCmb.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.BranchCmb.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.BranchCmb.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BranchCmb.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BranchCmb.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // BranchCmb.NestedRadGridView
            // 
            this.BranchCmb.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.BranchCmb.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.BranchCmb.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.BranchCmb.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.BranchCmb.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.BranchCmb.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.Width = 56;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Branch_Name";
            gridViewTextBoxColumn5.HeaderText = "Branch_Name";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Branch_Name";
            gridViewTextBoxColumn5.Width = 56;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Branch_Description";
            gridViewTextBoxColumn6.HeaderText = "Branch_Description";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Branch_Description";
            gridViewTextBoxColumn6.Width = 56;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "CreatedDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "CreatedDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CreatedDate";
            gridViewDateTimeColumn1.Width = 55;
            this.BranchCmb.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn1});
            this.BranchCmb.EditorControl.MasterTemplate.DataSource = this.branchBindingSource;
            this.BranchCmb.EditorControl.MasterTemplate.EnableGrouping = false;
            this.BranchCmb.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.BranchCmb.EditorControl.Name = "NestedRadGridView";
            this.BranchCmb.EditorControl.ReadOnly = true;
            this.BranchCmb.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BranchCmb.EditorControl.ShowGroupPanel = false;
            this.BranchCmb.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.BranchCmb.EditorControl.TabIndex = 0;
            this.BranchCmb.Location = new System.Drawing.Point(112, 51);
            this.BranchCmb.Name = "BranchCmb";
            this.BranchCmb.Size = new System.Drawing.Size(272, 20);
            this.BranchCmb.TabIndex = 0;
            this.BranchCmb.TabStop = false;
            this.BranchCmb.ThemeName = "Office2010Black";
            this.BranchCmb.ValueMember = "ID";
            // 
            // btnOky
            // 
            this.btnOky.Location = new System.Drawing.Point(330, 380);
            this.btnOky.Name = "btnOky";
            this.btnOky.Size = new System.Drawing.Size(110, 24);
            this.btnOky.TabIndex = 1;
            this.btnOky.Text = "oky";
            this.btnOky.ThemeName = "Office2010Black";
            this.btnOky.Click += new System.EventHandler(this.btnOky_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(XamaDataLayer.Branch);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qty";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Location = new System.Drawing.Point(108, 35);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(79, 20);
            this.txtProduct.TabIndex = 3;
            this.txtProduct.Text = "Product Name";
            this.txtProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(108, 64);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(79, 20);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "Qty";
            this.txtQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainToBranchTranfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOky);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainToBranchTranfer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Product";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmMainToBranchTranfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox BranchCmb;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ProductCmb;
        private System.Windows.Forms.NumericUpDown Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnOky;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtProduct;
        private System.Windows.Forms.Label label4;
    }
}