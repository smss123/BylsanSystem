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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.CustomerInfomationGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDiscountBox = new System.Windows.Forms.TextBox();
            this.OrderTypeLab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBranches = new System.Windows.Forms.ComboBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.PhoneLab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkeyBtn = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.PrintButton = new Telerik.WinControls.UI.RadButton();
            this.ReceiptVoucherButton = new Telerik.WinControls.UI.RadButton();
            this.CustomerInfomationGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkeyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptVoucherButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfomationGroupBox
            // 
            this.CustomerInfomationGroupBox.Controls.Add(this.txtDiscountBox);
            this.CustomerInfomationGroupBox.Controls.Add(this.OrderTypeLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.label8);
            this.CustomerInfomationGroupBox.Controls.Add(this.txtBranches);
            this.CustomerInfomationGroupBox.Controls.Add(this.txtPayment);
            this.CustomerInfomationGroupBox.Controls.Add(this.label1);
            this.CustomerInfomationGroupBox.Controls.Add(this.TotalPriceBox);
            this.CustomerInfomationGroupBox.Controls.Add(this.label6);
            this.CustomerInfomationGroupBox.Controls.Add(this.receiptdateTimePicker);
            this.CustomerInfomationGroupBox.Controls.Add(this.AddresstextBox);
            this.CustomerInfomationGroupBox.Controls.Add(this.label7);
            this.CustomerInfomationGroupBox.Controls.Add(this.label3);
            this.CustomerInfomationGroupBox.Controls.Add(this.label2);
            this.CustomerInfomationGroupBox.Controls.Add(this.label4);
            this.CustomerInfomationGroupBox.Controls.Add(this.NameLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.PhoneLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.label5);
            this.CustomerInfomationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfomationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfomationGroupBox.Name = "CustomerInfomationGroupBox";
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(632, 167);
            this.CustomerInfomationGroupBox.TabIndex = 7;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // txtDiscountBox
            // 
            this.txtDiscountBox.Location = new System.Drawing.Point(148, 121);
            this.txtDiscountBox.Name = "txtDiscountBox";
            this.txtDiscountBox.Size = new System.Drawing.Size(64, 20);
            this.txtDiscountBox.TabIndex = 11;
            this.txtDiscountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountBox_KeyPress);
            // 
            // OrderTypeLab
            // 
            this.OrderTypeLab.AutoSize = true;
            this.OrderTypeLab.Location = new System.Drawing.Point(180, 16);
            this.OrderTypeLab.Name = "OrderTypeLab";
            this.OrderTypeLab.Size = new System.Drawing.Size(19, 13);
            this.OrderTypeLab.TabIndex = 1;
            this.OrderTypeLab.Text = "....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Discount on the amount:";
            // 
            // txtBranches
            // 
            this.txtBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranches.FormattingEnabled = true;
            this.txtBranches.Location = new System.Drawing.Point(98, 86);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.Size = new System.Drawing.Size(121, 21);
            this.txtBranches.TabIndex = 10;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(398, 114);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(213, 20);
            this.txtPayment.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment:";
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Location = new System.Drawing.Point(398, 86);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.ReadOnly = true;
            this.TotalPriceBox.Size = new System.Drawing.Size(213, 20);
            this.TotalPriceBox.TabIndex = 9;
            this.TotalPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Cost:";
            // 
            // receiptdateTimePicker
            // 
            this.receiptdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.receiptdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiptdateTimePicker.Location = new System.Drawing.Point(398, 28);
            this.receiptdateTimePicker.Name = "receiptdateTimePicker";
            this.receiptdateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.receiptdateTimePicker.TabIndex = 5;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(398, 57);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(213, 20);
            this.AddresstextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delivery Branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivery Address:";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(127, 31);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(27, 13);
            this.NameLab.TabIndex = 1;
            this.NameLab.Text = "-----";
            // 
            // PhoneLab
            // 
            this.PhoneLab.AutoSize = true;
            this.PhoneLab.Location = new System.Drawing.Point(127, 54);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(23, 13);
            this.PhoneLab.TabIndex = 0;
            this.PhoneLab.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delivery Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReceiptVoucherButton);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.OkeyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 46);
            this.panel1.TabIndex = 9;
            // 
            // OkeyBtn
            // 
            this.OkeyBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.OkeyBtn.Location = new System.Drawing.Point(517, 4);
            this.OkeyBtn.Name = "OkeyBtn";
            this.OkeyBtn.Size = new System.Drawing.Size(109, 38);
            this.OkeyBtn.TabIndex = 0;
            this.OkeyBtn.Text = "Ok";
            this.OkeyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkeyBtn.ThemeName = "VisualStudio2012Light";
            this.OkeyBtn.Click += new System.EventHandler(this.OkeyBtn_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 173);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Product.Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.Name = "ColName";
            gridViewTextBoxColumn1.Width = 152;
            gridViewTextBoxColumn2.Expression = "";
            gridViewTextBoxColumn2.FieldName = "Qty";
            gridViewTextBoxColumn2.HeaderText = "Qty";
            gridViewTextBoxColumn2.Name = "ColQty";
            gridViewTextBoxColumn2.Width = 152;
            gridViewTextBoxColumn3.FieldName = "Product.ProductPrice";
            gridViewTextBoxColumn3.HeaderText = "Product Price";
            gridViewTextBoxColumn3.Name = "ColProductPrice";
            gridViewTextBoxColumn3.Width = 152;
            gridViewTextBoxColumn4.EnableExpressionEditor = true;
            gridViewTextBoxColumn4.Expression = "ColProductPrice * ColQty";
            gridViewTextBoxColumn4.HeaderText = "Price";
            gridViewTextBoxColumn4.Name = "ColPrice";
            gridViewTextBoxColumn4.Width = 157;
            gridViewTextBoxColumn5.FieldName = "ProductID";
            gridViewTextBoxColumn5.HeaderText = "ProductID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ColID";
            gridViewTextBoxColumn5.Width = 45;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(629, 245);
            this.radGridView1.TabIndex = 14;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "VisualStudio2012Light";
            // 
            // PrintButton
            // 
            this.PrintButton.Enabled = false;
            this.PrintButton.Image = global::Bylsan_System.Properties.Resources.Print;
            this.PrintButton.Location = new System.Drawing.Point(3, 4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(118, 38);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print bill";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButton.ThemeName = "VisualStudio2012Light";
            this.PrintButton.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ReceiptVoucherButton
            // 
            this.ReceiptVoucherButton.Enabled = false;
            this.ReceiptVoucherButton.Image = global::Bylsan_System.Properties.Resources.Print;
            this.ReceiptVoucherButton.Location = new System.Drawing.Point(148, 4);
            this.ReceiptVoucherButton.Name = "ReceiptVoucherButton";
            this.ReceiptVoucherButton.Size = new System.Drawing.Size(164, 38);
            this.ReceiptVoucherButton.TabIndex = 2;
            this.ReceiptVoucherButton.Text = "print  Receipt Voucher";
            this.ReceiptVoucherButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReceiptVoucherButton.ThemeName = "VisualStudio2012Light";
            // 
            // FrmTotalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 470);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerInfomationGroupBox);
            this.MaximumSize = new System.Drawing.Size(640, 503);
            this.MinimumSize = new System.Drawing.Size(640, 503);
            this.Name = "FrmTotalOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(640, 503);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTotalOrder";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmTotalOrder_Load_1);
            this.CustomerInfomationGroupBox.ResumeLayout(false);
            this.CustomerInfomationGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OkeyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptVoucherButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton OkeyBtn;
        public System.Windows.Forms.Label NameLab;
        public System.Windows.Forms.Label PhoneLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker receiptdateTimePicker;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtBranches;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label OrderTypeLab;
        private System.Windows.Forms.TextBox txtDiscountBox;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton ReceiptVoucherButton;
        private Telerik.WinControls.UI.RadButton PrintButton;
    }
}