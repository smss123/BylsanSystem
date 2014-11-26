namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmPrintQuotation
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
            System.Windows.Forms.Label quotationForLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressForLabel;
            this.quotationForTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressForTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TreeCategories = new System.Windows.Forms.TreeView();
            this.ListViewProductes = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBtn = new Telerik.WinControls.UI.RadButton();
            quotationForLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressForLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // quotationForLabel
            // 
            quotationForLabel.AutoSize = true;
            quotationForLabel.Location = new System.Drawing.Point(66, 27);
            quotationForLabel.Name = "quotationForLabel";
            quotationForLabel.Size = new System.Drawing.Size(27, 13);
            quotationForLabel.TabIndex = 1;
            quotationForLabel.Text = "For:";
            // 
            // quotationForTextBox
            // 
            this.quotationForTextBox.Location = new System.Drawing.Point(99, 24);
            this.quotationForTextBox.Name = "quotationForTextBox";
            this.quotationForTextBox.Size = new System.Drawing.Size(316, 20);
            this.quotationForTextBox.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(644, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(addressForLabel);
            this.groupBox1.Controls.Add(this.addressForTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.quotationForTextBox);
            this.groupBox1.Controls.Add(quotationForLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quotation Information ";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 53);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 50);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(181, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // addressForLabel
            // 
            addressForLabel.AutoSize = true;
            addressForLabel.Location = new System.Drawing.Point(24, 79);
            addressForLabel.Name = "addressForLabel";
            addressForLabel.Size = new System.Drawing.Size(69, 13);
            addressForLabel.TabIndex = 4;
            addressForLabel.Text = "Address For:";
            // 
            // addressForTextBox
            // 
            this.addressForTextBox.Location = new System.Drawing.Point(99, 76);
            this.addressForTextBox.Name = "addressForTextBox";
            this.addressForTextBox.Size = new System.Drawing.Size(300, 20);
            this.addressForTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewProductes);
            this.groupBox2.Controls.Add(this.TreeCategories);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 356);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // TreeCategories
            // 
            this.TreeCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeCategories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeCategories.LineColor = System.Drawing.Color.Blue;
            this.TreeCategories.Location = new System.Drawing.Point(3, 16);
            this.TreeCategories.Name = "TreeCategories";
            this.TreeCategories.Size = new System.Drawing.Size(166, 337);
            this.TreeCategories.TabIndex = 7;
            // 
            // ListViewProductes
            // 
            this.ListViewProductes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewProductes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListViewProductes.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListViewProductes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewProductes.ForeColor = System.Drawing.Color.Blue;
            this.ListViewProductes.FullRowSelect = true;
            this.ListViewProductes.GridLines = true;
            this.ListViewProductes.Location = new System.Drawing.Point(184, 16);
            this.ListViewProductes.Name = "ListViewProductes";
            this.ListViewProductes.Size = new System.Drawing.Size(457, 337);
            this.ListViewProductes.TabIndex = 8;
            this.ListViewProductes.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 89);
            this.panel1.TabIndex = 7;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(488, 27);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(144, 46);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.ThemeName = "Windows8";
            // 
            // FrmPrintQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrintQuotation";
            this.Text = "FrmPrintQuotation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quotationForTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressForTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView TreeCategories;
        private System.Windows.Forms.ListView ListViewProductes;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton PrintBtn;
    }
}