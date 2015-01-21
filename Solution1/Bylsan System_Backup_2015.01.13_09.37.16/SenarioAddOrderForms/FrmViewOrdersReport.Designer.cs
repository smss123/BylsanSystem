namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmViewOrdersReport
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
            this.OrderIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.Accountstatementbtn = new Telerik.WinControls.UI.RadButton();
            this.DetailedReportBtn = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accountstatementbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedReportBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIDtextBox
            // 
            this.OrderIDtextBox.Location = new System.Drawing.Point(105, 28);
            this.OrderIDtextBox.Name = "OrderIDtextBox";
            this.OrderIDtextBox.Size = new System.Drawing.Size(185, 20);
            this.OrderIDtextBox.TabIndex = 0;
            this.OrderIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderIDtextBox_KeyDown);
            this.OrderIDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderIDtextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Order ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OrderIDtextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Information Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.customerNameTextBox);
            this.groupBox2.Controls.Add(this.Accountstatementbtn);
            this.groupBox2.Controls.Add(this.DetailedReportBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.phoneNumberTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Information Customer Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(352, 28);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.customerNameTextBox.TabIndex = 4;
            this.customerNameTextBox.TabStop = false;
            // 
            // Accountstatementbtn
            // 
            this.Accountstatementbtn.Location = new System.Drawing.Point(180, 90);
            this.Accountstatementbtn.Name = "Accountstatementbtn";
            this.Accountstatementbtn.Size = new System.Drawing.Size(110, 24);
            this.Accountstatementbtn.TabIndex = 3;
            this.Accountstatementbtn.Text = "Account statement";
            this.Accountstatementbtn.ThemeName = "VisualStudio2012Light";
            this.Accountstatementbtn.Click += new System.EventHandler(this.Accountstatementbtn_Click);
            // 
            // DetailedReportBtn
            // 
            this.DetailedReportBtn.Location = new System.Drawing.Point(12, 90);
            this.DetailedReportBtn.Name = "DetailedReportBtn";
            this.DetailedReportBtn.Size = new System.Drawing.Size(110, 24);
            this.DetailedReportBtn.TabIndex = 2;
            this.DetailedReportBtn.Text = "Detailed Report";
            this.DetailedReportBtn.ThemeName = "VisualStudio2012Light";
            this.DetailedReportBtn.Click += new System.EventHandler(this.DetailedReportBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Customer Phone:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(129, 28);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.phoneNumberTextBox.TabIndex = 0;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmViewOrdersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(554, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmViewOrdersReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewOrdersReport";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accountstatementbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedReportBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton DetailedReportBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private Telerik.WinControls.UI.RadButton Accountstatementbtn;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}