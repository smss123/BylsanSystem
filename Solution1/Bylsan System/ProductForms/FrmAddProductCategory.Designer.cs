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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label productCategoryNameLabel;
            this.ProductCategorygroupBox = new System.Windows.Forms.GroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            productCategoryNameLabel = new System.Windows.Forms.Label();
            this.ProductCategorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(28, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // productCategoryNameLabel
            // 
            productCategoryNameLabel.AutoSize = true;
            productCategoryNameLabel.Location = new System.Drawing.Point(6, 31);
            productCategoryNameLabel.Name = "productCategoryNameLabel";
            productCategoryNameLabel.Size = new System.Drawing.Size(86, 13);
            productCategoryNameLabel.TabIndex = 4;
            productCategoryNameLabel.Text = "Category Name:";
            // 
            // ProductCategorygroupBox
            // 
            this.ProductCategorygroupBox.Controls.Add(this.AddBtn);
            this.ProductCategorygroupBox.Controls.Add(descriptionLabel);
            this.ProductCategorygroupBox.Controls.Add(this.descriptionTextBox);
            this.ProductCategorygroupBox.Controls.Add(productCategoryNameLabel);
            this.ProductCategorygroupBox.Controls.Add(this.productCategoryNameTextBox);
            this.ProductCategorygroupBox.Location = new System.Drawing.Point(12, 27);
            this.ProductCategorygroupBox.Name = "ProductCategorygroupBox";
            this.ProductCategorygroupBox.Size = new System.Drawing.Size(335, 210);
            this.ProductCategorygroupBox.TabIndex = 0;
            this.ProductCategorygroupBox.TabStop = false;
            this.ProductCategorygroupBox.Text = "Add Product Category";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 158);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(98, 54);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 90);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // productCategoryNameTextBox
            // 
            this.productCategoryNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.productCategoryNameTextBox.Location = new System.Drawing.Point(98, 28);
            this.productCategoryNameTextBox.Name = "productCategoryNameTextBox";
            this.productCategoryNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.productCategoryNameTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 258);
            this.Controls.Add(this.ProductCategorygroupBox);
            this.Name = "FrmAddProductCategory";
            this.Text = "FrmAddProductCategory";
            this.ProductCategorygroupBox.ResumeLayout(false);
            this.ProductCategorygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductCategorygroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox productCategoryNameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}