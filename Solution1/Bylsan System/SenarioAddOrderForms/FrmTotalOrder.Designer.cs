namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmTotalOrder
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
            this.CustomerInfomationGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLab = new System.Windows.Forms.Label();
            this.PhoneLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OkeyBtn = new Telerik.WinControls.UI.RadButton();
            this.ListViewProductes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerInfomationGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkeyBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfomationGroupBox
            // 
            this.CustomerInfomationGroupBox.Controls.Add(this.label3);
            this.CustomerInfomationGroupBox.Controls.Add(this.label2);
            this.CustomerInfomationGroupBox.Controls.Add(this.NameLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.PhoneLab);
            this.CustomerInfomationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfomationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfomationGroupBox.Name = "CustomerInfomationGroupBox";
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(479, 86);
            this.CustomerInfomationGroupBox.TabIndex = 7;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(127, 31);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(35, 13);
            this.NameLab.TabIndex = 1;
            this.NameLab.Text = "label3";
            // 
            // PhoneLab
            // 
            this.PhoneLab.AutoSize = true;
            this.PhoneLab.Location = new System.Drawing.Point(127, 53);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(35, 13);
            this.PhoneLab.TabIndex = 0;
            this.PhoneLab.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OkeyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 44);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // OkeyBtn
            // 
            this.OkeyBtn.Location = new System.Drawing.Point(338, 6);
            this.OkeyBtn.Name = "OkeyBtn";
            this.OkeyBtn.Size = new System.Drawing.Size(132, 33);
            this.OkeyBtn.TabIndex = 0;
            this.OkeyBtn.Text = "Ok";
            // 
            // ListViewProductes
            // 
            this.ListViewProductes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewProductes.FullRowSelect = true;
            this.ListViewProductes.GridLines = true;
            this.ListViewProductes.Location = new System.Drawing.Point(0, 86);
            this.ListViewProductes.Name = "ListViewProductes";
            this.ListViewProductes.Size = new System.Drawing.Size(479, 308);
            this.ListViewProductes.TabIndex = 10;
            this.ListViewProductes.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone";
            // 
            // FrmTotalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 438);
            this.Controls.Add(this.ListViewProductes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerInfomationGroupBox);
            this.Name = "FrmTotalOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTotalOrder";
            this.Load += new System.EventHandler(this.FrmTotalOrder_Load_1);
            this.CustomerInfomationGroupBox.ResumeLayout(false);
            this.CustomerInfomationGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkeyBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton OkeyBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView ListViewProductes;
        public System.Windows.Forms.Label NameLab;
        public System.Windows.Forms.Label PhoneLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}