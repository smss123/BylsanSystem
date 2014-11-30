namespace Bylsan_System.MainStoreForms
{
    partial class FrmEditMainStore_Supplier
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label supplierPhoneLabel;
            System.Windows.Forms.Label supplierNameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.supplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            supplierPhoneLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(supplierPhoneLabel);
            this.groupBox1.Controls.Add(this.supplierPhoneTextBox);
            this.groupBox1.Controls.Add(supplierNameLabel);
            this.groupBox1.Controls.Add(this.supplierNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(237, 209);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 37);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.ThemeName = "Windows8";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(21, 108);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(86, 105);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(267, 80);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(35, 82);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(50, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.addressTextBox.Location = new System.Drawing.Point(86, 79);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(267, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // supplierPhoneLabel
            // 
            supplierPhoneLabel.AutoSize = true;
            supplierPhoneLabel.Location = new System.Drawing.Point(3, 56);
            supplierPhoneLabel.Name = "supplierPhoneLabel";
            supplierPhoneLabel.Size = new System.Drawing.Size(82, 13);
            supplierPhoneLabel.TabIndex = 2;
            supplierPhoneLabel.Text = "Supplier Phone:";
            // 
            // supplierPhoneTextBox
            // 
            this.supplierPhoneTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.supplierPhoneTextBox.Location = new System.Drawing.Point(86, 53);
            this.supplierPhoneTextBox.Name = "supplierPhoneTextBox";
            this.supplierPhoneTextBox.Size = new System.Drawing.Size(224, 20);
            this.supplierPhoneTextBox.TabIndex = 2;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(6, 30);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(79, 13);
            supplierNameLabel.TabIndex = 0;
            supplierNameLabel.Text = "Supplier Name:";
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.supplierNameTextBox.Location = new System.Drawing.Point(86, 27);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(267, 20);
            this.supplierNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditMainStore_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditMainStore_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditMainStore_Supplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox supplierPhoneTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}