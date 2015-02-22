namespace Bylsan_System.SellSystemForms
{
    partial class FrmEditSellIStore
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
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label itemIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.ItemComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            qtyLabel = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(21, 59);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(28, 13);
            qtyLabel.TabIndex = 11;
            qtyLabel.Text = "Qty:";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(17, 27);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(32, 13);
            itemIDLabel.TabIndex = 10;
            itemIDLabel.Text = "Item:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(itemIDLabel);
            this.groupBox1.Controls.Add(this.ItemComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(6, 106);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2010Black";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyTextBox.Location = new System.Drawing.Point(51, 59);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 2;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DataSource = this.productBindingSource;
            this.ItemComboBox.DisplayMember = "Product_Name";
            // 
            // ItemComboBox.NestedRadGridView
            // 
            this.ItemComboBox.EditorControl.AutoSizeRows = true;
            this.ItemComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ItemComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ItemComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ItemComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ItemComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.ItemComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 25;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product_Name";
            gridViewTextBoxColumn1.Width = 54;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PublicName";
            gridViewTextBoxColumn2.HeaderText = "PublicName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "PublicName";
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProductPrice";
            gridViewDecimalColumn2.HeaderText = "ProductPrice";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductPrice";
            gridViewDecimalColumn2.Width = 25;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductUnit";
            gridViewTextBoxColumn3.HeaderText = "ProductUnit";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ProductUnit";
            gridViewTextBoxColumn3.Width = 25;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ProductType";
            gridViewTextBoxColumn4.HeaderText = "ProductType";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ProductType";
            gridViewTextBoxColumn4.Width = 25;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "LoadingCost";
            gridViewDecimalColumn3.HeaderText = "LoadingCost";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LoadingCost";
            gridViewDecimalColumn3.Width = 22;
            this.ItemComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn3});
            this.ItemComboBox.EditorControl.MasterTemplate.DataSource = this.productBindingSource;
            this.ItemComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ItemComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ItemComboBox.EditorControl.Name = "NestedRadGridView";
            this.ItemComboBox.EditorControl.ReadOnly = true;
            this.ItemComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemComboBox.EditorControl.ShowGroupPanel = false;
            this.ItemComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ItemComboBox.EditorControl.TabIndex = 0;
            this.ItemComboBox.Location = new System.Drawing.Point(51, 29);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(221, 20);
            this.ItemComboBox.TabIndex = 1;
            this.ItemComboBox.TabStop = false;
            this.ItemComboBox.ThemeName = "Office2010Black";
            this.ItemComboBox.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // FrmEditSellIStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(332, 175);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 209);
            this.Name = "FrmEditSellIStore";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(340, 209);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditSellIStore";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmEditSellIStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemComboBox;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox qtyTextBox;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}
