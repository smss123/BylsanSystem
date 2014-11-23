namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmAddInformationCustomer
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpecialOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.NormalOrdercheckBox = new System.Windows.Forms.CheckBox();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            this.InformationgroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            customerNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(8, 67);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(87, 13);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Customer Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(8, 33);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpecialOrderCheckBox);
            this.groupBox1.Controls.Add(this.NormalOrdercheckBox);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.InformationgroupBox);
            this.groupBox1.Controls.Add(customerNameLabel);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            // 
            // SpecialOrderCheckBox
            // 
            this.SpecialOrderCheckBox.AutoSize = true;
            this.SpecialOrderCheckBox.Location = new System.Drawing.Point(176, 243);
            this.SpecialOrderCheckBox.Name = "SpecialOrderCheckBox";
            this.SpecialOrderCheckBox.Size = new System.Drawing.Size(90, 17);
            this.SpecialOrderCheckBox.TabIndex = 6;
            this.SpecialOrderCheckBox.Text = "Special Order";
            this.SpecialOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // NormalOrdercheckBox
            // 
            this.NormalOrdercheckBox.AutoSize = true;
            this.NormalOrdercheckBox.Location = new System.Drawing.Point(29, 243);
            this.NormalOrdercheckBox.Name = "NormalOrdercheckBox";
            this.NormalOrdercheckBox.Size = new System.Drawing.Size(90, 17);
            this.NormalOrdercheckBox.TabIndex = 5;
            this.NormalOrdercheckBox.Text = "Normal Order";
            this.NormalOrdercheckBox.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(360, 232);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(127, 37);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.ThemeName = "Windows8";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // InformationgroupBox
            // 
            this.InformationgroupBox.Location = new System.Drawing.Point(11, 97);
            this.InformationgroupBox.Name = "InformationgroupBox";
            this.InformationgroupBox.Size = new System.Drawing.Size(477, 129);
            this.InformationgroupBox.TabIndex = 4;
            this.InformationgroupBox.TabStop = false;
            this.InformationgroupBox.Text = "Information";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.customerNameTextBox.Location = new System.Drawing.Point(96, 64);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(94, 30);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(193, 20);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // FrmAddInformationCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(541, 298);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddInformationCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddInformationCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton NextBtn;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.GroupBox InformationgroupBox;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.CheckBox SpecialOrderCheckBox;
        private System.Windows.Forms.CheckBox NormalOrdercheckBox;
    }
}