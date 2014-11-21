namespace Bylsan_System.ProductForms
{
    partial class FrmEditProductCategory
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
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            productCategoryNameLabel = new System.Windows.Forms.Label();
            this.ProductCategorygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategorygroupBox
            // 
            this.ProductCategorygroupBox.Controls.Add(this.SaveBtn);
            this.ProductCategorygroupBox.Controls.Add(descriptionLabel);
            this.ProductCategorygroupBox.Controls.Add(this.descriptionTextBox);
            this.ProductCategorygroupBox.Controls.Add(productCategoryNameLabel);
            this.ProductCategorygroupBox.Controls.Add(this.productCategoryNameTextBox);
            this.ProductCategorygroupBox.Location = new System.Drawing.Point(7, 15);
            this.ProductCategorygroupBox.Name = "ProductCategorygroupBox";
            this.ProductCategorygroupBox.Size = new System.Drawing.Size(356, 207);
            this.ProductCategorygroupBox.TabIndex = 1;
            this.ProductCategorygroupBox.TabStop = false;
            this.ProductCategorygroupBox.Text = "Edit Category";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(14, 164);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 33);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 77);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(218, 61);
            this.descriptionTextBox.TabIndex = 2;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 245);
            this.Controls.Add(this.ProductCategorygroupBox);
            this.Name = "FrmEditProductCategory";
            this.Text = "FrmEditProductCategory";
            this.ProductCategorygroupBox.ResumeLayout(false);
            this.ProductCategorygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductCategorygroupBox;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox productCategoryNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}