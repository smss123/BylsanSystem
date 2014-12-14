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
            System.Windows.Forms.Label debtorDescriptionLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addresssLabel;
            System.Windows.Forms.Label debtorDescriptionLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.debtorDescriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.debtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addresssTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.debtorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.debtorNameTextBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.accountDailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            debtorNameLabel = new System.Windows.Forms.Label();
            debtorDescriptionLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addresssLabel = new System.Windows.Forms.Label();
            debtorDescriptionLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
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
            // debtorDescriptionLabel
            // 
            debtorDescriptionLabel.AutoSize = true;
            debtorDescriptionLabel.Location = new System.Drawing.Point(10, 71);
            debtorDescriptionLabel.Name = "debtorDescriptionLabel";
            debtorDescriptionLabel.Size = new System.Drawing.Size(108, 13);
            debtorDescriptionLabel.TabIndex = 2;
            debtorDescriptionLabel.Text = "Debtor Description:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(31, 108);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addresssLabel
            // 
            addresssLabel.AutoSize = true;
            addresssLabel.Location = new System.Drawing.Point(62, 143);
            addresssLabel.Name = "addresssLabel";
            addresssLabel.Size = new System.Drawing.Size(56, 13);
            addresssLabel.TabIndex = 6;
            addresssLabel.Text = "Addresss:";
            // 
            // debtorDescriptionLabel1
            // 
            debtorDescriptionLabel1.AutoSize = true;
            debtorDescriptionLabel1.Location = new System.Drawing.Point(10, 169);
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
            this.groupBox1.Controls.Add(this.debtorDescriptionTextBox1);
            this.groupBox1.Controls.Add(addresssLabel);
            this.groupBox1.Controls.Add(this.addresssTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(debtorDescriptionLabel);
            this.groupBox1.Controls.Add(this.debtorDescriptionTextBox);
            this.groupBox1.Controls.Add(debtorNameLabel);
            this.groupBox1.Controls.Add(this.debtorNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // debtorDescriptionTextBox1
            // 
            this.debtorDescriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "DebtorDescription", true));
            this.debtorDescriptionTextBox1.Location = new System.Drawing.Point(124, 166);
            this.debtorDescriptionTextBox1.Multiline = true;
            this.debtorDescriptionTextBox1.Name = "debtorDescriptionTextBox1";
            this.debtorDescriptionTextBox1.Size = new System.Drawing.Size(196, 56);
            this.debtorDescriptionTextBox1.TabIndex = 9;
            // 
            // debtorBindingSource
            // 
            this.debtorBindingSource.DataSource = typeof(XamaDataLayer.Debtor);
            // 
            // addresssTextBox
            // 
            this.addresssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "Addresss", true));
            this.addresssTextBox.Location = new System.Drawing.Point(124, 140);
            this.addresssTextBox.Name = "addresssTextBox";
            this.addresssTextBox.Size = new System.Drawing.Size(196, 20);
            this.addresssTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(124, 105);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(196, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // debtorDescriptionTextBox
            // 
            this.debtorDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "DebtorDescription", true));
            this.debtorDescriptionTextBox.Location = new System.Drawing.Point(124, 68);
            this.debtorDescriptionTextBox.Name = "debtorDescriptionTextBox";
            this.debtorDescriptionTextBox.Size = new System.Drawing.Size(196, 20);
            this.debtorDescriptionTextBox.TabIndex = 3;
            // 
            // debtorNameTextBox
            // 
            this.debtorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorBindingSource, "DebtorName", true));
            this.debtorNameTextBox.Location = new System.Drawing.Point(124, 28);
            this.debtorNameTextBox.Name = "debtorNameTextBox";
            this.debtorNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.debtorNameTextBox.TabIndex = 1;
            // 
            // accountDailyBindingSource
            // 
            this.accountDailyBindingSource.DataSource = typeof(XamaDataLayer.AccountDaily);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(13, 242);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            // 
            // FrmAddDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 314);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddDebtors";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddDebtors";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox debtorDescriptionTextBox;
        private System.Windows.Forms.BindingSource debtorBindingSource;
        private System.Windows.Forms.TextBox debtorNameTextBox;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.BindingSource accountDailyBindingSource;
        private System.Windows.Forms.TextBox debtorDescriptionTextBox1;
        private System.Windows.Forms.TextBox addresssTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}
