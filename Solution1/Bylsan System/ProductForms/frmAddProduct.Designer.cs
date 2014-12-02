namespace Bylsan_System.ProductForms
{
    partial class frmAddProduct
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
            System.Windows.Forms.Label product_DescriptionLabel;
            System.Windows.Forms.Label product_NameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.productpictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(2, 51);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(112, 13);
            product_DescriptionLabel.TabIndex = 4;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(30, 19);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(82, 13);
            product_NameLabel.TabIndex = 6;
            product_NameLabel.Text = "Product Name:";
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(this.label2);
            this.ProductgroupBox.Controls.Add(this.label1);
            this.ProductgroupBox.Controls.Add(this.CategoryComboBox);
            this.ProductgroupBox.Controls.Add(this.AddBtn);
            this.ProductgroupBox.Controls.Add(this.BrowseBtn);
            this.ProductgroupBox.Controls.Add(this.productpictureBox);
            this.ProductgroupBox.Controls.Add(product_DescriptionLabel);
            this.ProductgroupBox.Controls.Add(this.product_DescriptionTextBox);
            this.ProductgroupBox.Controls.Add(product_NameLabel);
            this.ProductgroupBox.Controls.Add(this.product_NameTextBox);
            this.ProductgroupBox.Location = new System.Drawing.Point(12, 7);
            this.ProductgroupBox.Name = "ProductgroupBox";
            this.ProductgroupBox.Size = new System.Drawing.Size(340, 335);
            this.ProductgroupBox.TabIndex = 0;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Add Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.CategoryComboBox.DataSource = this.productCategoryBindingSource;
            // 
            // CategoryComboBox.NestedRadGridView
            // 
            this.CategoryComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CategoryComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CategoryComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CategoryComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // CategoryComboBox.NestedRadGridView
            // 
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.Width = 88;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductCategoryName";
            gridViewTextBoxColumn3.HeaderText = "CategoryName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ProductCategoryName";
            gridViewTextBoxColumn3.Width = 190;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.HeaderText = "Description";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Description";
            gridViewTextBoxColumn4.Width = 241;
            this.CategoryComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.CategoryComboBox.EditorControl.MasterTemplate.DataSource = this.productCategoryBindingSource;
            this.CategoryComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CategoryComboBox.EditorControl.Name = "NestedRadGridView";
            this.CategoryComboBox.EditorControl.ReadOnly = true;
            this.CategoryComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryComboBox.EditorControl.ShowGroupPanel = false;
            this.CategoryComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CategoryComboBox.EditorControl.TabIndex = 0;
            this.CategoryComboBox.Location = new System.Drawing.Point(115, 128);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(204, 20);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.TabStop = false;
            this.CategoryComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(267, 159);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(45, 24);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.ThemeName = "VisualStudio2012Light";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(115, 46);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(204, 75);
            this.product_DescriptionTextBox.TabIndex = 2;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.Location = new System.Drawing.Point(114, 19);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(204, 20);
            this.product_NameTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(XamaDataLayer.ProductCategory);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(14, 278);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // productpictureBox
            // 
            this.productpictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.productpictureBox.Image = global::Bylsan_System.Properties.Resources.ImagePreview;
            this.productpictureBox.Location = new System.Drawing.Point(114, 156);
            this.productpictureBox.Name = "productpictureBox";
            this.productpictureBox.Size = new System.Drawing.Size(149, 99);
            this.productpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productpictureBox.TabIndex = 8;
            this.productpictureBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(364, 379);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProductgroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 412);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 412);
            this.Name = "frmAddProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(372, 386);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ProductgroupBox.ResumeLayout(false);
            this.ProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductgroupBox;
        private Telerik.WinControls.UI.RadButton BrowseBtn;
        private System.Windows.Forms.PictureBox productpictureBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CategoryComboBox;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}