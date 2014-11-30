namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_Supplier
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
            System.Windows.Forms.Label supplierNameLabel;
            System.Windows.Forms.Label supplierPhoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            supplierNameLabel = new System.Windows.Forms.Label();
            supplierPhoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(supplierPhoneLabel);
            this.groupBox1.Controls.Add(this.supplierPhoneTextBox);
            this.groupBox1.Controls.Add(supplierNameLabel);
            this.groupBox1.Controls.Add(this.supplierNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
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
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(237, 209);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(127, 37);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.ThemeName = "Windows8";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddMainStore_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMainStore_Supplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox supplierPhoneTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}