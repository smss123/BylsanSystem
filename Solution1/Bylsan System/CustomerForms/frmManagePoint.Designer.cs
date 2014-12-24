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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label settingNameLabel;
            System.Windows.Forms.Label settingValueLabel;
            this.systemSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingNameLabel1 = new System.Windows.Forms.Label();
            this.settingValueTextBox = new System.Windows.Forms.TextBox();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            settingNameLabel = new System.Windows.Forms.Label();
            settingValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // settingNameLabel
            // 
            settingNameLabel.AutoSize = true;
            settingNameLabel.Location = new System.Drawing.Point(66, 74);
            settingNameLabel.Name = "settingNameLabel";
            settingNameLabel.Size = new System.Drawing.Size(79, 13);
            settingNameLabel.TabIndex = 1;
            settingNameLabel.Text = "Setting Name:";
            // 
            // settingValueLabel
            // 
            settingValueLabel.AutoSize = true;
            settingValueLabel.Location = new System.Drawing.Point(70, 103);
            settingValueLabel.Name = "settingValueLabel";
            settingValueLabel.Size = new System.Drawing.Size(79, 13);
            settingValueLabel.TabIndex = 3;
            settingValueLabel.Text = "Setting Value:";
            // 
            // systemSettingBindingSource
            // 
            this.systemSettingBindingSource.DataSource = typeof(XamaDataLayer.SystemSetting);
            // 
            // settingNameLabel1
            // 
            this.settingNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemSettingBindingSource, "SettingName", true));
            this.settingNameLabel1.Location = new System.Drawing.Point(147, 74);
            this.settingNameLabel1.Name = "settingNameLabel1";
            this.settingNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.settingNameLabel1.TabIndex = 2;
            this.settingNameLabel1.Text = "label1";
            // 
            // settingValueTextBox
            // 
            this.settingValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemSettingBindingSource, "SettingValue", true));
            this.settingValueTextBox.Location = new System.Drawing.Point(150, 100);
            this.settingValueTextBox.Name = "settingValueTextBox";
            this.settingValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.settingValueTextBox.TabIndex = 4;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(235, 143);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(127, 37);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next";
            this.NextBtn.ThemeName = "Windows8";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // frmManagePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 189);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(settingValueLabel);
            this.Controls.Add(this.settingValueTextBox);
            this.Controls.Add(settingNameLabel);
            this.Controls.Add(this.settingNameLabel1);
            this.Name = "frmManagePoint";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePoint";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.frmManagePoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource systemSettingBindingSource;
        private System.Windows.Forms.Label settingNameLabel1;
        private System.Windows.Forms.TextBox settingValueTextBox;
        private Telerik.WinControls.UI.RadButton NextBtn;
    }
}