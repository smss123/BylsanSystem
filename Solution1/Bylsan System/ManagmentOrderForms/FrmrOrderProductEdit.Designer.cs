namespace Bylsan_System.ManagmentOrderForms
{
    partial class FrmrOrderProductEdit
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
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label productIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ProductComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.UploadBtn = new Telerik.WinControls.UI.RadButton();
            this.BrawoseBtn = new Telerik.WinControls.UI.RadButton();
            this.RemoveBtn = new Telerik.WinControls.UI.RadButton();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            this.PreBtn = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            qtyLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrawoseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(44, 63);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(28, 13);
            qtyLabel.TabIndex = 2;
            qtyLabel.Text = "Qty:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(31, 89);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 13);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(9, 120);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(25, 35);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(50, 13);
            productIDLabel.TabIndex = 7;
            productIDLabel.Text = "Product:";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DataSource = this.productBindingSource;
            // 
            // ProductComboBox.NestedRadGridView
            // 
            this.ProductComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ProductComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ProductComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ProductComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ProductComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ProductComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ProductComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ProductComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn1.Width = 32;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product_Description";
            gridViewTextBoxColumn2.HeaderText = "Product_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Product_Description";
            gridViewTextBoxColumn2.Width = 32;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PublicName";
            gridViewTextBoxColumn3.HeaderText = "PublicName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PublicName";
            gridViewTextBoxColumn3.Width = 32;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProductPrice";
            gridViewDecimalColumn2.HeaderText = "ProductPrice";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProductPrice";
            gridViewDecimalColumn2.Width = 32;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ProductUnit";
            gridViewTextBoxColumn4.HeaderText = "ProductUnit";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ProductUnit";
            gridViewTextBoxColumn4.Width = 32;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ProductType";
            gridViewTextBoxColumn5.HeaderText = "ProductType";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ProductType";
            gridViewTextBoxColumn5.Width = 32;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ProductCategory.ProductCategoryName";
            gridViewTextBoxColumn6.HeaderText = "ProductCategory";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ProductCategory";
            gridViewTextBoxColumn6.Width = 34;
            this.ProductComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.ProductComboBox.EditorControl.MasterTemplate.DataSource = this.productBindingSource;
            this.ProductComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ProductComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ProductComboBox.EditorControl.Name = "NestedRadGridView";
            this.ProductComboBox.EditorControl.ReadOnly = true;
            this.ProductComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductComboBox.EditorControl.ShowGroupPanel = false;
            this.ProductComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ProductComboBox.EditorControl.TabIndex = 0;
            this.ProductComboBox.Location = new System.Drawing.Point(79, 34);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(255, 20);
            this.ProductComboBox.TabIndex = 0;
            this.ProductComboBox.TabStop = false;
            this.ProductComboBox.ThemeName = "Office2010Black";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(79, 60);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 3;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(79, 86);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(100, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(79, 113);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(243, 45);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ProductComboBox);
            this.radGroupBox1.Controls.Add(productIDLabel);
            this.radGroupBox1.Controls.Add(this.qtyTextBox);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(qtyLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(this.statusComboBox);
            this.radGroupBox1.Controls.Add(statusLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Information";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(367, 172);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Information";
            this.radGroupBox1.ThemeName = "Office2010Black";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.SaveBtn);
            this.radGroupBox2.Controls.Add(this.UploadBtn);
            this.radGroupBox2.Controls.Add(this.BrawoseBtn);
            this.radGroupBox2.Controls.Add(this.RemoveBtn);
            this.radGroupBox2.Controls.Add(this.NextBtn);
            this.radGroupBox2.Controls.Add(this.PreBtn);
            this.radGroupBox2.Controls.Add(this.pictureBox1);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "radGroupBox2";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 172);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(367, 242);
            this.radGroupBox2.TabIndex = 9;
            this.radGroupBox2.Text = "radGroupBox2";
            this.radGroupBox2.ThemeName = "Office2010Black";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(247, 194);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 33);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.ThemeName = "Office2010Black";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(194, 56);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(105, 24);
            this.UploadBtn.TabIndex = 5;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.ThemeName = "Office2010Black";
            // 
            // BrawoseBtn
            // 
            this.BrawoseBtn.Location = new System.Drawing.Point(195, 24);
            this.BrawoseBtn.Name = "BrawoseBtn";
            this.BrawoseBtn.Size = new System.Drawing.Size(44, 24);
            this.BrawoseBtn.TabIndex = 4;
            this.BrawoseBtn.Text = "..";
            this.BrawoseBtn.ThemeName = "Office2010Black";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(113, 160);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 24);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.ThemeName = "Office2010Black";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(63, 160);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(44, 24);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = ">>";
            this.NextBtn.ThemeName = "Office2010Black";
            // 
            // PreBtn
            // 
            this.PreBtn.Location = new System.Drawing.Point(10, 161);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(44, 24);
            this.PreBtn.TabIndex = 1;
            this.PreBtn.Text = "<<";
            this.PreBtn.ThemeName = "Office2010Black";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmrOrderProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(367, 414);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmrOrderProductEdit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmrOrderProductEdit";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmrOrderProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrawoseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox ProductComboBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadButton UploadBtn;
        private Telerik.WinControls.UI.RadButton BrawoseBtn;
        private Telerik.WinControls.UI.RadButton RemoveBtn;
        private Telerik.WinControls.UI.RadButton NextBtn;
        private Telerik.WinControls.UI.RadButton PreBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}