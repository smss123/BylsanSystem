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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.productpictureBox = new System.Windows.Forms.PictureBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(6, 61);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(104, 13);
            product_DescriptionLabel.TabIndex = 4;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(30, 21);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
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
            this.ProductgroupBox.Size = new System.Drawing.Size(332, 360);
            this.ProductgroupBox.TabIndex = 0;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 147);
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
            // 
            // 
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 88;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ProductCategoryName";
            gridViewTextBoxColumn1.HeaderText = "CategoryName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ProductCategoryName";
            gridViewTextBoxColumn1.Width = 190;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 241;
            this.CategoryComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.CategoryComboBox.EditorControl.MasterTemplate.DataSource = this.productCategoryBindingSource;
            this.CategoryComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CategoryComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CategoryComboBox.EditorControl.Name = "NestedRadGridView";
            this.CategoryComboBox.EditorControl.ReadOnly = true;
            this.CategoryComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryComboBox.EditorControl.ShowGroupPanel = false;
            this.CategoryComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CategoryComboBox.EditorControl.TabIndex = 0;
            this.CategoryComboBox.Location = new System.Drawing.Point(109, 144);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(203, 20);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.TabStop = false;
            this.CategoryComboBox.ThemeName = "Windows8";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(13, 307);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.ThemeName = "Windows8";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(262, 188);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(45, 24);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.ThemeName = "Windows8";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // productpictureBox
            // 
            this.productpictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.productpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("productpictureBox.Image")));
            this.productpictureBox.Location = new System.Drawing.Point(109, 185);
            this.productpictureBox.Name = "productpictureBox";
            this.productpictureBox.Size = new System.Drawing.Size(149, 99);
            this.productpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productpictureBox.TabIndex = 8;
            this.productpictureBox.TabStop = false;
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(111, 56);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(204, 75);
            this.product_DescriptionTextBox.TabIndex = 2;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.Location = new System.Drawing.Point(111, 19);
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
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.ProductgroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 417);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ProductgroupBox.ResumeLayout(false);
            this.ProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
    }
}