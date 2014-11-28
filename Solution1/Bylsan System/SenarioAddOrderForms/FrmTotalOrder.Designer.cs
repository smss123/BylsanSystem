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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.CustomerInfomationGroupBox = new System.Windows.Forms.GroupBox();
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
            this.OrdersCountLab = new System.Windows.Forms.Label();
            this.OkeyBtn = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.CustomerInfomationGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkeyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfomationGroupBox
            // 
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
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(524, 133);
            this.CustomerInfomationGroupBox.TabIndex = 7;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // txtBranches
            // 
            this.txtBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranches.FormattingEnabled = true;
            this.txtBranches.Location = new System.Drawing.Point(108, 86);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.Size = new System.Drawing.Size(121, 21);
            this.txtBranches.TabIndex = 10;
            this.txtBranches.SelectedIndexChanged += new System.EventHandler(this.txtBranches_SelectedIndexChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(299, 111);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(213, 20);
            this.txtPayment.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment:";
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Location = new System.Drawing.Point(299, 83);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.Size = new System.Drawing.Size(213, 20);
            this.TotalPriceBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Cost:";
            // 
            // receiptdateTimePicker
            // 
            this.receiptdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.receiptdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiptdateTimePicker.Location = new System.Drawing.Point(299, 25);
            this.receiptdateTimePicker.Name = "receiptdateTimePicker";
            this.receiptdateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.receiptdateTimePicker.TabIndex = 5;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(299, 54);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(213, 20);
            this.AddresstextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delivery Branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivery Address:";
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
            this.PhoneLab.Location = new System.Drawing.Point(127, 54);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(35, 13);
            this.PhoneLab.TabIndex = 0;
            this.PhoneLab.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delivery Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrdersCountLab);
            this.panel1.Controls.Add(this.OkeyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 44);
            this.panel1.TabIndex = 9;
            // 
            // OrdersCountLab
            // 
            this.OrdersCountLab.AutoSize = true;
            this.OrdersCountLab.Location = new System.Drawing.Point(23, 15);
            this.OrdersCountLab.Name = "OrdersCountLab";
            this.OrdersCountLab.Size = new System.Drawing.Size(75, 13);
            this.OrdersCountLab.TabIndex = 1;
            this.OrdersCountLab.Text = "Orders Count ";
            // 
            // OkeyBtn
            // 
            this.OkeyBtn.Location = new System.Drawing.Point(384, 6);
            this.OkeyBtn.Name = "OkeyBtn";
            this.OkeyBtn.Size = new System.Drawing.Size(132, 33);
            this.OkeyBtn.TabIndex = 0;
            this.OkeyBtn.Text = "Ok";
            this.OkeyBtn.Click += new System.EventHandler(this.OkeyBtn_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 139);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.FieldName = "Product.Product_Name";
            gridViewTextBoxColumn6.HeaderText = "Name";
            gridViewTextBoxColumn6.Name = "ColName";
            gridViewTextBoxColumn6.Width = 126;
            gridViewTextBoxColumn7.Expression = "";
            gridViewTextBoxColumn7.FieldName = "Qty";
            gridViewTextBoxColumn7.HeaderText = "Qty";
            gridViewTextBoxColumn7.Name = "ColQty";
            gridViewTextBoxColumn7.Width = 126;
            gridViewTextBoxColumn8.FieldName = "Product.ProductPrice";
            gridViewTextBoxColumn8.HeaderText = "Product Price";
            gridViewTextBoxColumn8.Name = "ColProductPrice";
            gridViewTextBoxColumn8.Width = 126;
            gridViewTextBoxColumn9.EnableExpressionEditor = true;
            gridViewTextBoxColumn9.Expression = "ColProductPrice * ColQty";
            gridViewTextBoxColumn9.HeaderText = "Price";
            gridViewTextBoxColumn9.Name = "ColPrice";
            gridViewTextBoxColumn9.Width = 128;
            gridViewTextBoxColumn10.FieldName = "ProductID";
            gridViewTextBoxColumn10.HeaderText = "ProductID";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "ColID";
            gridViewTextBoxColumn10.Width = 45;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(524, 253);
            this.radGridView1.TabIndex = 14;
            this.radGridView1.Text = "radGridView1";
            // 
            // FrmTotalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 438);
            this.Controls.Add(this.radGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton OkeyBtn;
        private System.Windows.Forms.Label OrdersCountLab;
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
    }
}