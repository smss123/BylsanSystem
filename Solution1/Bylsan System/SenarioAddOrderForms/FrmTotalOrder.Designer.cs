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
            this.TotalOrderListView = new Telerik.WinControls.UI.RadListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalOrderListView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfomationGroupBox
            // 
            this.CustomerInfomationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfomationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfomationGroupBox.Name = "CustomerInfomationGroupBox";
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(479, 86);
            this.CustomerInfomationGroupBox.TabIndex = 7;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // TotalOrderListView
            // 
            this.TotalOrderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalOrderListView.Location = new System.Drawing.Point(0, 86);
            this.TotalOrderListView.Name = "TotalOrderListView";
            this.TotalOrderListView.Size = new System.Drawing.Size(479, 352);
            this.TotalOrderListView.TabIndex = 8;
            this.TotalOrderListView.Text = "radListView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 44);
            this.panel1.TabIndex = 9;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(338, 6);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(132, 33);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "radButton1";
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
            // FrmTotalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TotalOrderListView);
            this.Controls.Add(this.CustomerInfomationGroupBox);
            this.Name = "FrmTotalOrder";
            this.Text = "FrmTotalOrder";
            ((System.ComponentModel.ISupportInitialize)(this.TotalOrderListView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private Telerik.WinControls.UI.RadListView TotalOrderListView;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
    }
}