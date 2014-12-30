namespace Bylsan_System.AccountsX
{
    partial class FrmEditDebtors
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
            System.Windows.Forms.Label debtorDescriptionLabel1;
            System.Windows.Forms.Label addresssLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label debtorNameLabel;
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.debtorDescriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.addresssTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.debtorNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            debtorDescriptionLabel1 = new System.Windows.Forms.Label();
            addresssLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            debtorNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // debtorDescriptionLabel1
            // 
            debtorDescriptionLabel1.AutoSize = true;
            debtorDescriptionLabel1.Location = new System.Drawing.Point(10, 108);
            debtorDescriptionLabel1.Name = "debtorDescriptionLabel1";
            debtorDescriptionLabel1.Size = new System.Drawing.Size(108, 13);
            debtorDescriptionLabel1.TabIndex = 8;
            debtorDescriptionLabel1.Text = "Debtor Description:";
            // 
            // addresssLabel
            // 
            addresssLabel.AutoSize = true;
            addresssLabel.Location = new System.Drawing.Point(62, 79);
            addresssLabel.Name = "addresssLabel";
            addresssLabel.Size = new System.Drawing.Size(56, 13);
            addresssLabel.TabIndex = 6;
            addresssLabel.Text = "Addresss:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(31, 49);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // debtorNameLabel
            // 
            debtorNameLabel.AutoSize = true;
            debtorNameLabel.Location = new System.Drawing.Point(40, 21);
            debtorNameLabel.Name = "debtorNameLabel";
            debtorNameLabel.Size = new System.Drawing.Size(78, 13);
            debtorNameLabel.TabIndex = 0;
            debtorNameLabel.Text = "Debtor Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(debtorDescriptionLabel1);
            this.groupBox1.Controls.Add(this.debtorDescriptionTextBox1);
            this.groupBox1.Controls.Add(addresssLabel);
            this.groupBox1.Controls.Add(this.addresssTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(debtorNameLabel);
            this.groupBox1.Controls.Add(this.debtorNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(13, 169);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "VisualStudio2012Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // debtorDescriptionTextBox1
            // 
            this.debtorDescriptionTextBox1.Location = new System.Drawing.Point(124, 105);
            this.debtorDescriptionTextBox1.Multiline = true;
            this.debtorDescriptionTextBox1.Name = "debtorDescriptionTextBox1";
            this.debtorDescriptionTextBox1.Size = new System.Drawing.Size(221, 56);
            this.debtorDescriptionTextBox1.TabIndex = 9;
            // 
            // addresssTextBox
            // 
            this.addresssTextBox.Location = new System.Drawing.Point(124, 76);
            this.addresssTextBox.Name = "addresssTextBox";
            this.addresssTextBox.Size = new System.Drawing.Size(221, 20);
            this.addresssTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(124, 46);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(221, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // debtorNameTextBox
            // 
            this.debtorNameTextBox.Location = new System.Drawing.Point(124, 18);
            this.debtorNameTextBox.Name = "debtorNameTextBox";
            this.debtorNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.debtorNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(404, 238);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(412, 271);
            this.MinimumSize = new System.Drawing.Size(412, 271);
            this.Name = "FrmEditDebtors";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(412, 271);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditDebtors";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEditDebtors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox debtorDescriptionTextBox1;
        private System.Windows.Forms.TextBox addresssTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox debtorNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
