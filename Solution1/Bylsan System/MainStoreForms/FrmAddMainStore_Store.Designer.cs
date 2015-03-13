namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_Store
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
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label QtyLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbSuppliers = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            DescriptionLabel = new System.Windows.Forms.Label();
            QtyLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(26, 88);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description:";
            // 
            // QtyLabel
            // 
            QtyLabel.AutoSize = true;
            QtyLabel.Location = new System.Drawing.Point(37, 57);
            QtyLabel.Name = "QtyLabel";
            QtyLabel.Size = new System.Drawing.Size(52, 13);
            QtyLabel.TabIndex = 2;
            QtyLabel.Text = "Add Qty:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(27, 25);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(64, 13);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 169);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 6;
            label1.Text = "Unit Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 201);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 8;
            label2.Text = "Supplier:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ItemColumnComboBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.CmbSuppliers);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.DescriptiontextBox);
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(DescriptionLabel);
            this.groupBox1.Controls.Add(QtyLabel);
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Main Store";
            // 
            // ItemColumnComboBox
            // 
            this.ItemColumnComboBox.DataSource = this.productBindingSource;
            // 
            // ItemColumnComboBox.NestedRadGridView
            // 
            this.ItemColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ItemColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemColumnComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ItemColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ItemColumnComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product_Name";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product_Description";
            gridViewTextBoxColumn2.HeaderText = "Product_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Product_Description";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PublicName";
            gridViewTextBoxColumn3.HeaderText = "PublicName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PublicName";
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProductPrice";
            gridViewDecimalColumn2.HeaderText = "ProductPrice";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductPrice";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ProductUnit";
            gridViewTextBoxColumn4.HeaderText = "ProductUnit";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ProductUnit";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ProductType";
            gridViewTextBoxColumn5.HeaderText = "ProductType";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ProductType";
            this.ItemColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.ItemColumnComboBox.EditorControl.MasterTemplate.DataSource = this.productBindingSource;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ItemColumnComboBox.EditorControl.Name = "NestedRadGridView";
            this.ItemColumnComboBox.EditorControl.ReadOnly = true;
            this.ItemColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemColumnComboBox.EditorControl.ShowGroupPanel = false;
            this.ItemColumnComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ItemColumnComboBox.EditorControl.TabIndex = 0;
            this.ItemColumnComboBox.Location = new System.Drawing.Point(95, 26);
            this.ItemColumnComboBox.Name = "ItemColumnComboBox";
            this.ItemColumnComboBox.Size = new System.Drawing.Size(236, 20);
            this.ItemColumnComboBox.TabIndex = 9;
            this.ItemColumnComboBox.TabStop = false;
            this.ItemColumnComboBox.ThemeName = "Office2010Black";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // CmbSuppliers
            // 
            this.CmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSuppliers.FormattingEnabled = true;
            this.CmbSuppliers.Location = new System.Drawing.Point(97, 198);
            this.CmbSuppliers.Name = "CmbSuppliers";
            this.CmbSuppliers.Size = new System.Drawing.Size(230, 21);
            this.CmbSuppliers.TabIndex = 7;
            this.CmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.CmbSuppliers_SelectedIndexChanged_1);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(97, 166);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptiontextBox.Location = new System.Drawing.Point(97, 84);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(234, 75);
            this.DescriptiontextBox.TabIndex = 3;
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addbtn.Location = new System.Drawing.Point(8, 238);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 37);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.ThemeName = "Office2010Black";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.QtyTextBox.Location = new System.Drawing.Point(97, 54);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(162, 20);
            this.QtyTextBox.TabIndex = 2;
            this.QtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AvailableQtyTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 362);
            this.Name = "FrmAddMainStore_Store";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(387, 362);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add To Store";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmAddMainStore_Store_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox CmbSuppliers;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemColumnComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}