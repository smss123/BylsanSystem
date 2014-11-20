namespace Bylsan_System.ProductForms
{
    partial class FrmAddProductCategory
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
            System.Windows.Forms.Label productCategoryNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.ProductCategorygroupBox = new System.Windows.Forms.GroupBox();
            this.productCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            productCategoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.ProductCategorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategorygroupBox
            // 
            this.ProductCategorygroupBox.Controls.Add(this.AddBtn);
            this.ProductCategorygroupBox.Controls.Add(descriptionLabel);
            this.ProductCategorygroupBox.Controls.Add(this.descriptionTextBox);
            this.ProductCategorygroupBox.Controls.Add(productCategoryNameLabel);
            this.ProductCategorygroupBox.Controls.Add(this.productCategoryNameTextBox);
            this.ProductCategorygroupBox.Location = new System.Drawing.Point(12, 15);
            this.ProductCategorygroupBox.Name = "ProductCategorygroupBox";
            this.ProductCategorygroupBox.Size = new System.Drawing.Size(356, 207);
            this.ProductCategorygroupBox.TabIndex = 0;
            this.ProductCategorygroupBox.TabStop = false;
            this.ProductCategorygroupBox.Text = "Add Category";
            // 
            // productCategoryNameLabel
            // 
            productCategoryNameLabel.AutoSize = true;
            productCategoryNameLabel.Location = new System.Drawing.Point(12, 42);
            productCategoryNameLabel.Name = "productCategoryNameLabel";
            productCategoryNameLabel.Size = new System.Drawing.Size(86, 13);
            productCategoryNameLabel.TabIndex = 0;
            productCategoryNameLabel.Text = "Category Name:";
            // 
            // productCategoryNameTextBox
            // 
            this.productCategoryNameTextBox.Location = new System.Drawing.Point(105, 39);
            this.productCategoryNameTextBox.Name = "productCategoryNameTextBox";
            this.productCategoryNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.productCategoryNameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(34, 80);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 77);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(218, 61);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(15, 169);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 33);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(XamaDataLayer.ProductCategory);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 243);
            this.Controls.Add(this.ProductCategorygroupBox);
            this.Name = "FrmAddProductCategory";
            this.Text = "FrmAddProductCategory";
            this.ProductCategorygroupBox.ResumeLayout(false);
            this.ProductCategorygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductCategorygroupBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.TextBox productCategoryNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}