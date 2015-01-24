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
            System.Windows.Forms.Label productPriceLabel;
            System.Windows.Forms.Label publicNameLabel;
            System.Windows.Forms.Label productUnitLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.productUnitTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.productpictureBox = new System.Windows.Forms.PictureBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            publicNameLabel = new System.Windows.Forms.Label();
            productUnitLabel = new System.Windows.Forms.Label();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(-3, 49);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(112, 13);
            product_DescriptionLabel.TabIndex = 4;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(27, 22);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(82, 13);
            product_NameLabel.TabIndex = 6;
            product_NameLabel.Text = "Product Name:";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new System.Drawing.Point(32, 131);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(77, 13);
            productPriceLabel.TabIndex = 11;
            productPriceLabel.Text = "Product Price:";
            // 
            // publicNameLabel
            // 
            publicNameLabel.AutoSize = true;
            publicNameLabel.Location = new System.Drawing.Point(36, 155);
            publicNameLabel.Name = "publicNameLabel";
            publicNameLabel.Size = new System.Drawing.Size(73, 13);
            publicNameLabel.TabIndex = 12;
            publicNameLabel.Text = "Public Name:";
            // 
            // productUnitLabel
            // 
            productUnitLabel.AutoSize = true;
            productUnitLabel.Location = new System.Drawing.Point(34, 179);
            productUnitLabel.Name = "productUnitLabel";
            productUnitLabel.Size = new System.Drawing.Size(75, 13);
            productUnitLabel.TabIndex = 14;
            productUnitLabel.Text = "Product Unit:";
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(productUnitLabel);
            this.ProductgroupBox.Controls.Add(this.productUnitTextBox);
            this.ProductgroupBox.Controls.Add(publicNameLabel);
            this.ProductgroupBox.Controls.Add(this.publicNameTextBox);
            this.ProductgroupBox.Controls.Add(productPriceLabel);
            this.ProductgroupBox.Controls.Add(this.productPriceTextBox);
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
            this.ProductgroupBox.Size = new System.Drawing.Size(344, 462);
            this.ProductgroupBox.TabIndex = 0;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Add Data";
            // 
            // productUnitTextBox
            // 
            this.productUnitTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.productUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductUnit", true));
            this.productUnitTextBox.Location = new System.Drawing.Point(115, 176);
            this.productUnitTextBox.Name = "productUnitTextBox";
            this.productUnitTextBox.Size = new System.Drawing.Size(203, 20);
            this.productUnitTextBox.TabIndex = 5;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // publicNameTextBox
            // 
            this.publicNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.publicNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PublicName", true));
            this.publicNameTextBox.Location = new System.Drawing.Point(115, 152);
            this.publicNameTextBox.Name = "publicNameTextBox";
            this.publicNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.publicNameTextBox.TabIndex = 4;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.productPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductPrice", true));
            this.productPriceTextBox.Location = new System.Drawing.Point(115, 128);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(203, 20);
            this.productPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.CategoryComboBox.Location = new System.Drawing.Point(115, 200);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(203, 20);
            this.CategoryComboBox.TabIndex = 6;
            this.CategoryComboBox.TabStop = false;
            this.CategoryComboBox.ThemeName = "Office2010Black";
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(XamaDataLayer.ProductCategory);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(12, 414);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2010Black";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(265, 296);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(45, 24);
            this.BrowseBtn.TabIndex = 7;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.ThemeName = "Office2010Black";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // productpictureBox
            // 
            this.productpictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.productpictureBox.Image = global::Bylsan_System.Properties.Resources.ImagePreview;
            this.productpictureBox.Location = new System.Drawing.Point(112, 292);
            this.productpictureBox.Name = "productpictureBox";
            this.productpictureBox.Size = new System.Drawing.Size(149, 99);
            this.productpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productpictureBox.TabIndex = 8;
            this.productpictureBox.TabStop = false;
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(115, 46);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(203, 75);
            this.product_DescriptionTextBox.TabIndex = 2;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.Location = new System.Drawing.Point(115, 19);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(203, 20);
            this.product_NameTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProductgroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 412);
            this.Name = "frmAddProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ProductgroupBox.ResumeLayout(false);
            this.ProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox productUnitTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox publicNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}