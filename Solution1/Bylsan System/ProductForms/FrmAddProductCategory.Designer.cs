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
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            productCategoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.ProductCategorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // productCategoryNameLabel
            // 
            productCategoryNameLabel.AutoSize = true;
            productCategoryNameLabel.Location = new System.Drawing.Point(12, 26);
            productCategoryNameLabel.Name = "productCategoryNameLabel";
            productCategoryNameLabel.Size = new System.Drawing.Size(86, 13);
            productCategoryNameLabel.TabIndex = 0;
            productCategoryNameLabel.Text = "Category Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(34, 64);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // ProductCategorygroupBox
            // 
            this.ProductCategorygroupBox.Controls.Add(this.AddBtn);
            this.ProductCategorygroupBox.Controls.Add(descriptionLabel);
            this.ProductCategorygroupBox.Controls.Add(this.descriptionTextBox);
            this.ProductCategorygroupBox.Controls.Add(productCategoryNameLabel);
            this.ProductCategorygroupBox.Controls.Add(this.productCategoryNameTextBox);
            this.ProductCategorygroupBox.Location = new System.Drawing.Point(14, 9);
            this.ProductCategorygroupBox.Name = "ProductCategorygroupBox";
            this.ProductCategorygroupBox.Size = new System.Drawing.Size(356, 193);
            this.ProductCategorygroupBox.TabIndex = 0;
            this.ProductCategorygroupBox.TabStop = false;
            this.ProductCategorygroupBox.Text = "Add Category";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(15, 144);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 33);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.ThemeName = "Windows8";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 61);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(218, 61);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // productCategoryNameTextBox
            // 
            this.productCategoryNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.productCategoryNameTextBox.Location = new System.Drawing.Point(105, 23);
            this.productCategoryNameTextBox.Name = "productCategoryNameTextBox";
            this.productCategoryNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.productCategoryNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(385, 215);
            this.Controls.Add(this.ProductCategorygroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 253);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 253);
            this.Name = "FrmAddProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Category";
            this.Load += new System.EventHandler(this.FrmAddProductCategory_Load);
            this.ProductCategorygroupBox.ResumeLayout(false);
            this.ProductCategorygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductCategorygroupBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox productCategoryNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}