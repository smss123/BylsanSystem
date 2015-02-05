namespace Bylsan_System.CustomerForms
{
    partial class frmManagePoint
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
            System.Windows.Forms.Label settingNameLabel;
            System.Windows.Forms.Label settingValueLabel;
            System.Windows.Forms.Label label2;
            this.settingNameLabel1 = new System.Windows.Forms.Label();
            this.settingValueTextBox = new System.Windows.Forms.TextBox();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.LBLid = new System.Windows.Forms.Label();
            settingNameLabel = new System.Windows.Forms.Label();
            settingValueLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // settingNameLabel
            // 
            settingNameLabel.AutoSize = true;
            settingNameLabel.Location = new System.Drawing.Point(3, 45);
            settingNameLabel.Name = "settingNameLabel";
            settingNameLabel.Size = new System.Drawing.Size(79, 13);
            settingNameLabel.TabIndex = 1;
            settingNameLabel.Text = "Setting Name:";
            // 
            // settingValueLabel
            // 
            settingValueLabel.AutoSize = true;
            settingValueLabel.Location = new System.Drawing.Point(3, 74);
            settingValueLabel.Name = "settingValueLabel";
            settingValueLabel.Size = new System.Drawing.Size(79, 13);
            settingValueLabel.TabIndex = 3;
            settingValueLabel.Text = "Setting Value:";
            // 
            // settingNameLabel1
            // 
            this.settingNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingNameLabel1.Location = new System.Drawing.Point(88, 45);
            this.settingNameLabel1.Name = "settingNameLabel1";
            this.settingNameLabel1.Size = new System.Drawing.Size(191, 23);
            this.settingNameLabel1.TabIndex = 2;
            this.settingNameLabel1.Text = "label1";
            // 
            // settingValueTextBox
            // 
            this.settingValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingValueTextBox.Location = new System.Drawing.Point(88, 72);
            this.settingValueTextBox.Name = "settingValueTextBox";
            this.settingValueTextBox.Size = new System.Drawing.Size(191, 20);
            this.settingValueTextBox.TabIndex = 4;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(220, 121);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(127, 37);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next";
            this.NextBtn.ThemeName = "Office2010Black";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(settingNameLabel);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.LBLid);
            this.groupBox1.Controls.Add(this.settingNameLabel1);
            this.groupBox1.Controls.Add(settingValueLabel);
            this.groupBox1.Controls.Add(this.settingValueTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // LBLid
            // 
            this.LBLid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLid.Location = new System.Drawing.Point(88, 18);
            this.LBLid.Name = "LBLid";
            this.LBLid.Size = new System.Drawing.Size(191, 23);
            this.LBLid.TabIndex = 2;
            this.LBLid.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 13);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // frmManagePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 189);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManagePoint";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Point";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmManagePoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label settingNameLabel1;
        private System.Windows.Forms.TextBox settingValueTextBox;
        private Telerik.WinControls.UI.RadButton NextBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Label LBLid;
    }
}