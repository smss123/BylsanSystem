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
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(this.AddBtn);
            this.ProductgroupBox.Controls.Add(this.BrowseBtn);
            this.ProductgroupBox.Controls.Add(this.pictureBox1);
            this.ProductgroupBox.Controls.Add(product_DescriptionLabel);
            this.ProductgroupBox.Controls.Add(this.product_DescriptionTextBox);
            this.ProductgroupBox.Controls.Add(product_NameLabel);
            this.ProductgroupBox.Controls.Add(this.product_NameTextBox);
            this.ProductgroupBox.Location = new System.Drawing.Point(12, 25);
            this.ProductgroupBox.Name = "ProductgroupBox";
            this.ProductgroupBox.Size = new System.Drawing.Size(332, 332);
            this.ProductgroupBox.TabIndex = 0;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Add Product";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(4, 84);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(104, 13);
            product_DescriptionLabel.TabIndex = 4;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(109, 79);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(204, 75);
            this.product_DescriptionTextBox.TabIndex = 2;
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(28, 44);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 6;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.Location = new System.Drawing.Point(109, 42);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(204, 20);
            this.product_NameTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(109, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 99);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(7, 197);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(99, 24);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(10, 281);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 376);
            this.Controls.Add(this.ProductgroupBox);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProduct";
            this.ProductgroupBox.ResumeLayout(false);
            this.ProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductgroupBox;
        private Telerik.WinControls.UI.RadButton BrowseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}