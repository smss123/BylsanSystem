namespace Bylsan_System.ProductForms
{
    partial class frmEditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.productpictureBox = new System.Windows.Forms.PictureBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(3, 78);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(104, 13);
            product_DescriptionLabel.TabIndex = 16;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(27, 38);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 17;
            product_NameLabel.Text = "Product Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMultiColumnComboBox1);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.BrowseBtn);
            this.groupBox1.Controls.Add(this.productpictureBox);
            this.groupBox1.Controls.Add(product_DescriptionLabel);
            this.groupBox1.Controls.Add(this.product_DescriptionTextBox);
            this.groupBox1.Controls.Add(product_NameLabel);
            this.groupBox1.Controls.Add(this.product_NameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Prodct";
            // 
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(106, 164);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(206, 20);
            this.radMultiColumnComboBox1.TabIndex = 21;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.ThemeName = "Windows8";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 309);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Save";
            this.AddBtn.ThemeName = "Windows8";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(260, 205);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(45, 24);
            this.BrowseBtn.TabIndex = 14;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.ThemeName = "Windows8";
            // 
            // productpictureBox
            // 
            this.productpictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.productpictureBox.Location = new System.Drawing.Point(106, 202);
            this.productpictureBox.Name = "productpictureBox";
            this.productpictureBox.Size = new System.Drawing.Size(149, 99);
            this.productpictureBox.TabIndex = 18;
            this.productpictureBox.TabStop = false;
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(108, 73);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(213, 75);
            this.product_DescriptionTextBox.TabIndex = 13;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.Location = new System.Drawing.Point(108, 36);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(213, 20);
            this.product_NameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Category:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadButton BrowseBtn;
        private System.Windows.Forms.PictureBox productpictureBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;

    }
}