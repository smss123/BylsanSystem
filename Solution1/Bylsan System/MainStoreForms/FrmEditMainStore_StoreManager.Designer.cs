namespace Bylsan_System.MainStoreForms
{
    partial class FrmEditMainStore_StoreManager
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label processTypeLabel;
            System.Windows.Forms.Label qtyInOrOutLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StoreComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.processTypeComboBox = new System.Windows.Forms.ComboBox();
            this.qtyInOrOutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            processTypeLabel = new System.Windows.Forms.Label();
            qtyInOrOutLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(20, 128);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(50, 107);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Price:";
            // 
            // processTypeLabel
            // 
            processTypeLabel.AutoSize = true;
            processTypeLabel.Location = new System.Drawing.Point(13, 76);
            processTypeLabel.Name = "processTypeLabel";
            processTypeLabel.Size = new System.Drawing.Size(74, 13);
            processTypeLabel.TabIndex = 14;
            processTypeLabel.Text = "Process Type:";
            // 
            // qtyInOrOutLabel
            // 
            qtyInOrOutLabel.AutoSize = true;
            qtyInOrOutLabel.Location = new System.Drawing.Point(6, 49);
            qtyInOrOutLabel.Name = "qtyInOrOutLabel";
            qtyInOrOutLabel.Size = new System.Drawing.Size(80, 13);
            qtyInOrOutLabel.TabIndex = 12;
            qtyInOrOutLabel.Text = "Qty In Or Out:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StoreComboBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(processTypeLabel);
            this.groupBox1.Controls.Add(this.processTypeComboBox);
            this.groupBox1.Controls.Add(qtyInOrOutLabel);
            this.groupBox1.Controls.Add(this.qtyInOrOutTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.DataSource = this.storeBindingSource;
            this.StoreComboBox.DisplayMember = "ProductID";
            // 
            // StoreComboBox.NestedRadGridView
            // 
            this.StoreComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.StoreComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.StoreComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.StoreComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StoreComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StoreComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.StoreComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.StoreComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.StoreComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.StoreComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 28;
            gridViewTextBoxColumn1.DataType = typeof(System.Data.Linq.EntitySet<XamaDataLayer.StoreWithDrawal>);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "StoreWithDrawals";
            gridViewTextBoxColumn1.HeaderText = "StoreWithDrawals";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "StoreWithDrawals";
            gridViewTextBoxColumn1.Width = 28;
            gridViewDecimalColumn2.DataType = typeof(string);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Product.Product_Name";
            gridViewDecimalColumn2.HeaderText = "ProductID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductID";
            gridViewDecimalColumn2.Width = 28;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "AvailableQty";
            gridViewDecimalColumn3.HeaderText = "AvailableQty";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "AvailableQty";
            gridViewDecimalColumn3.Width = 28;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 28;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "ExpiredDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "ExpiredDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "ExpiredDate";
            gridViewDateTimeColumn1.Width = 28;
            gridViewTextBoxColumn3.DataType = typeof(System.Data.Linq.EntitySet<XamaDataLayer.StoreManager>);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "StoreManagers";
            gridViewTextBoxColumn3.HeaderText = "StoreManagers";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "StoreManagers";
            gridViewTextBoxColumn3.Width = 28;
            gridViewTextBoxColumn4.DataType = typeof(XamaDataLayer.Product);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Product";
            gridViewTextBoxColumn4.HeaderText = "Product";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Product";
            gridViewTextBoxColumn4.Width = 31;
            this.StoreComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.StoreComboBox.EditorControl.MasterTemplate.DataSource = this.storeBindingSource;
            this.StoreComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.StoreComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.StoreComboBox.EditorControl.Name = "NestedRadGridView";
            this.StoreComboBox.EditorControl.ReadOnly = true;
            this.StoreComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StoreComboBox.EditorControl.ShowGroupPanel = false;
            this.StoreComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.StoreComboBox.EditorControl.TabIndex = 0;
            this.StoreComboBox.Location = new System.Drawing.Point(95, 20);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(239, 20);
            this.StoreComboBox.TabIndex = 0;
            this.StoreComboBox.TabStop = false;
            this.StoreComboBox.ThemeName = "Office2010Black";
            this.StoreComboBox.ValueMember = "ID";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(95, 128);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(239, 72);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.priceTextBox.Location = new System.Drawing.Point(95, 100);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(239, 20);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // processTypeComboBox
            // 
            this.processTypeComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.processTypeComboBox.FormattingEnabled = true;
            this.processTypeComboBox.ItemHeight = 13;
            this.processTypeComboBox.Location = new System.Drawing.Point(95, 73);
            this.processTypeComboBox.Name = "processTypeComboBox";
            this.processTypeComboBox.Size = new System.Drawing.Size(239, 21);
            this.processTypeComboBox.TabIndex = 2;
            // 
            // qtyInOrOutTextBox
            // 
            this.qtyInOrOutTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyInOrOutTextBox.Location = new System.Drawing.Point(95, 46);
            this.qtyInOrOutTextBox.Name = "qtyInOrOutTextBox";
            this.qtyInOrOutTextBox.Size = new System.Drawing.Size(239, 20);
            this.qtyInOrOutTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stor:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(16, 217);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2010Black";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.SaveBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaveBtn_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(XamaDataLayer.Store);
            // 
            // FrmEditMainStore_StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(381, 295);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 329);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 329);
            this.Name = "FrmEditMainStore_StoreManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(389, 329);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Manager";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmEditMainStore_StoreManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox processTypeComboBox;
        private System.Windows.Forms.TextBox qtyInOrOutTextBox;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox StoreComboBox;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource storeBindingSource;
    }
}