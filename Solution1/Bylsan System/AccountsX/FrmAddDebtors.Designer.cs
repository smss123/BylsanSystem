namespace Bylsan_System.AccountsX
{
    partial class FrmAddDebtors
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
            System.Windows.Forms.Label debtorNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addresssLabel;
            System.Windows.Forms.Label debtorDescriptionLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.debtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDebtorName = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.accountDailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            debtorNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addresssLabel = new System.Windows.Forms.Label();
            debtorDescriptionLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // debtorNameLabel
            // 
            debtorNameLabel.AutoSize = true;
            debtorNameLabel.Location = new System.Drawing.Point(40, 31);
            debtorNameLabel.Name = "debtorNameLabel";
            debtorNameLabel.Size = new System.Drawing.Size(78, 13);
            debtorNameLabel.TabIndex = 0;
            debtorNameLabel.Text = "Debtor Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(31, 57);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addresssLabel
            // 
            addresssLabel.AutoSize = true;
            addresssLabel.Location = new System.Drawing.Point(62, 87);
            addresssLabel.Name = "addresssLabel";
            addresssLabel.Size = new System.Drawing.Size(56, 13);
            addresssLabel.TabIndex = 6;
            addresssLabel.Text = "Addresss:";
            // 
            // debtorDescriptionLabel1
            // 
            debtorDescriptionLabel1.AutoSize = true;
            debtorDescriptionLabel1.Location = new System.Drawing.Point(10, 109);
            debtorDescriptionLabel1.Name = "debtorDescriptionLabel1";
            debtorDescriptionLabel1.Size = new System.Drawing.Size(108, 13);
            debtorDescriptionLabel1.TabIndex = 8;
            debtorDescriptionLabel1.Text = "Debtor Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(debtorDescriptionLabel1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(addresssLabel);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(debtorNameLabel);
            this.groupBox1.Controls.Add(this.txtDebtorName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(13, 168);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "DebtorDescription", true));
            this.txtDescription.Location = new System.Drawing.Point(124, 106);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 56);
            this.txtDescription.TabIndex = 9;
            // 
            // debtorBindingSource
            // 
            this.debtorBindingSource.DataSource = typeof(XamaDataLayer.Debtor);
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "Addresss", true));
            this.txtAddress.Location = new System.Drawing.Point(124, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "PhoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(124, 54);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtDebtorName
            // 
            this.txtDebtorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "DebtorName", true));
            this.txtDebtorName.Location = new System.Drawing.Point(124, 28);
            this.txtDebtorName.Name = "txtDebtorName";
            this.txtDebtorName.Size = new System.Drawing.Size(196, 20);
            this.txtDebtorName.TabIndex = 1;
            // 
            // accountDailyBindingSource
            // 
            this.accountDailyBindingSource.DataSource = typeof(XamaDataLayer.AccountDaily);
            // 
            // FrmAddDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 240);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddDebtors";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddDebtors";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmAddDebtors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource debtorBindingSource;
        private System.Windows.Forms.TextBox txtDebtorName;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.BindingSource accountDailyBindingSource;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}
