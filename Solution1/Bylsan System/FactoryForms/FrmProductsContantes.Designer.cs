namespace Bylsan_System.FactoryForms
{
    partial class FrmProductsContantes
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbItems = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.Cmbproducts = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.CmbUnits = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radButton1);
            this.groupBox1.Controls.Add(this.CmbItems);
            this.groupBox1.Controls.Add(this.Cmbproducts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelx);
            this.groupBox1.Controls.Add(this.CmbUnits);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Contents";
            // 
            // CmbItems
            // 
            // 
            // CmbItems.NestedRadGridView
            // 
            this.CmbItems.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbItems.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbItems.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbItems.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbItems.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmbItems.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // CmbItems.NestedRadGridView
            // 
            this.CmbItems.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbItems.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbItems.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbItems.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.CmbItems.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.Width = 41;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ItemName";
            gridViewTextBoxColumn7.HeaderText = "ItemName";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "ItemName";
            gridViewTextBoxColumn7.Width = 73;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ItemType";
            gridViewTextBoxColumn8.HeaderText = "ItemType";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "ItemType";
            gridViewTextBoxColumn8.Width = 59;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "ItemDescription";
            gridViewTextBoxColumn9.HeaderText = "ItemDescription";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "ItemDescription";
            gridViewTextBoxColumn9.Width = 89;
            this.CmbItems.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.CmbItems.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbItems.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbItems.EditorControl.Name = "NestedRadGridView";
            this.CmbItems.EditorControl.ReadOnly = true;
            this.CmbItems.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbItems.EditorControl.ShowGroupPanel = false;
            this.CmbItems.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbItems.EditorControl.TabIndex = 0;
            this.CmbItems.Location = new System.Drawing.Point(102, 61);
            this.CmbItems.Name = "CmbItems";
            this.CmbItems.Size = new System.Drawing.Size(210, 20);
            this.CmbItems.TabIndex = 9;
            this.CmbItems.TabStop = false;
            this.CmbItems.ThemeName = "VisualStudio2012Light";
            // 
            // Cmbproducts
            // 
            this.Cmbproducts.DisplayMember = "Product_Name";
            // 
            // Cmbproducts.NestedRadGridView
            // 
            this.Cmbproducts.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.Cmbproducts.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cmbproducts.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Cmbproducts.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cmbproducts.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cmbproducts.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // Cmbproducts.NestedRadGridView
            // 
            this.Cmbproducts.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.Cmbproducts.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.Cmbproducts.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.Cmbproducts.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.Cmbproducts.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product_Name";
            gridViewTextBoxColumn1.Width = 74;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product_Description";
            gridViewTextBoxColumn2.HeaderText = "Product_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Product_Description";
            gridViewTextBoxColumn2.Width = 86;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductCategory.ProductCategoryName";
            gridViewTextBoxColumn3.HeaderText = "Category";
            gridViewTextBoxColumn3.Name = "ProductCategoryName";
            gridViewTextBoxColumn3.Width = 61;
            this.Cmbproducts.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.Cmbproducts.EditorControl.MasterTemplate.EnableGrouping = false;
            this.Cmbproducts.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.Cmbproducts.EditorControl.Name = "NestedRadGridView";
            this.Cmbproducts.EditorControl.ReadOnly = true;
            this.Cmbproducts.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmbproducts.EditorControl.ShowGroupPanel = false;
            this.Cmbproducts.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.Cmbproducts.EditorControl.TabIndex = 0;
            this.Cmbproducts.Location = new System.Drawing.Point(103, 34);
            this.Cmbproducts.Name = "Cmbproducts";
            this.Cmbproducts.Size = new System.Drawing.Size(210, 20);
            this.Cmbproducts.TabIndex = 8;
            this.Cmbproducts.TabStop = false;
            this.Cmbproducts.ThemeName = "VisualStudio2012Light";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit Of Produc:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(46, 90);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(54, 13);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "Quantity:";
            // 
            // CmbUnits
            // 
            this.CmbUnits.FormattingEnabled = true;
            this.CmbUnits.Location = new System.Drawing.Point(102, 116);
            this.CmbUnits.Name = "CmbUnits";
            this.CmbUnits.Size = new System.Drawing.Size(121, 21);
            this.CmbUnits.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(102, 90);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "item row material:";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::Bylsan_System.Properties.Resources.Save;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(7, 179);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(109, 37);
            this.radButton1.TabIndex = 11;
            this.radButton1.Text = "Save";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.ThemeName = "VisualStudio2012Light";
            this.radButton1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductsContantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(365, 257);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 290);
            this.Name = "FrmProductsContantes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductsContantes";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmProductsContantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.ComboBox CmbUnits;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbItems;
        private Telerik.WinControls.UI.RadMultiColumnComboBox Cmbproducts;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}