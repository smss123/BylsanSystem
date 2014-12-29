namespace Bylsan_System.BranchForms
{
    partial class FrmDeliveryOrderShowInfo
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OkyBtn = new Telerik.WinControls.UI.RadButton();
            this.PaymentRemainingtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remainingtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymenttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labCustomerPhone = new System.Windows.Forms.TextBox();
            this.labCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvproducts = new Telerik.WinControls.UI.RadGridView();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkyBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OkyBtn);
            this.groupBox2.Controls.Add(this.PaymentRemainingtextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.remainingtextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PaymenttextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TotaltextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labCustomerPhone);
            this.groupBox2.Controls.Add(this.labCustomerName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(431, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 392);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // OkyBtn
            // 
            this.OkyBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkyBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.OkyBtn.Location = new System.Drawing.Point(259, 349);
            this.OkyBtn.Name = "OkyBtn";
            this.OkyBtn.Size = new System.Drawing.Size(104, 36);
            this.OkyBtn.TabIndex = 14;
            this.OkyBtn.Text = "Oky";
            this.OkyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkyBtn.ThemeName = "VisualStudio2012Light";
            // 
            // PaymentRemainingtextBox
            // 
            this.PaymentRemainingtextBox.Location = new System.Drawing.Point(124, 167);
            this.PaymentRemainingtextBox.Name = "PaymentRemainingtextBox";
            this.PaymentRemainingtextBox.Size = new System.Drawing.Size(98, 20);
            this.PaymentRemainingtextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Payment Remaining:";
            // 
            // remainingtextBox
            // 
            this.remainingtextBox.Location = new System.Drawing.Point(124, 136);
            this.remainingtextBox.Name = "remainingtextBox";
            this.remainingtextBox.ReadOnly = true;
            this.remainingtextBox.Size = new System.Drawing.Size(98, 20);
            this.remainingtextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remaining:";
            // 
            // PaymenttextBox
            // 
            this.PaymenttextBox.Location = new System.Drawing.Point(124, 108);
            this.PaymenttextBox.Name = "PaymenttextBox";
            this.PaymenttextBox.ReadOnly = true;
            this.PaymenttextBox.Size = new System.Drawing.Size(98, 20);
            this.PaymenttextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(124, 82);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(98, 20);
            this.TotaltextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Order:";
            // 
            // labCustomerPhone
            // 
            this.labCustomerPhone.Location = new System.Drawing.Point(124, 56);
            this.labCustomerPhone.Name = "labCustomerPhone";
            this.labCustomerPhone.ReadOnly = true;
            this.labCustomerPhone.Size = new System.Drawing.Size(161, 20);
            this.labCustomerPhone.TabIndex = 5;
            // 
            // labCustomerName
            // 
            this.labCustomerName.Location = new System.Drawing.Point(124, 27);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.ReadOnly = true;
            this.labCustomerName.Size = new System.Drawing.Size(217, 20);
            this.labCustomerName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvproducts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // dgvproducts
            // 
            this.dgvproducts.BackColor = System.Drawing.SystemColors.Control;
            this.dgvproducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproducts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvproducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvproducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvproducts.Location = new System.Drawing.Point(3, 18);
            // 
            // dgvproducts
            // 
            this.dgvproducts.MasterTemplate.AllowAddNewRow = false;
            this.dgvproducts.MasterTemplate.AutoGenerateColumns = false;
            this.dgvproducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 86;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product.Product_Name";
            gridViewTextBoxColumn1.HeaderText = "ProductName";
            gridViewTextBoxColumn1.Name = "ProductName";
            gridViewTextBoxColumn1.Width = 182;
            gridViewTextBoxColumn2.DataType = typeof(System.Nullable<double>);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product.ProductPrice";
            gridViewTextBoxColumn2.HeaderText = "Price";
            gridViewTextBoxColumn2.Name = "ProductPrice";
            gridViewTextBoxColumn2.Width = 91;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Qty";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Qty";
            gridViewDecimalColumn2.Width = 62;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Status";
            gridViewTextBoxColumn3.HeaderText = "Status";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Status";
            gridViewTextBoxColumn3.Width = 74;
            this.dgvproducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3});
            this.dgvproducts.MasterTemplate.DataSource = this.orderProductBindingSource;
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvproducts.Size = new System.Drawing.Size(425, 371);
            this.dgvproducts.TabIndex = 0;
            this.dgvproducts.Text = "OrderGridView";
            this.dgvproducts.ThemeName = "VisualStudio2012Light";
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataSource = typeof(XamaDataLayer.OrderProduct);
            // 
            // FrmDeliveryOrderShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmDeliveryOrderShowInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeliveryOrderShowInfo";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmDeliveryOrderShowInfo_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OkyBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox remainingtextBox;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PaymenttextBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotaltextBox;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labCustomerPhone;
        private System.Windows.Forms.TextBox labCustomerName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView dgvproducts;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
        private Telerik.WinControls.UI.RadButton OkyBtn;
        private System.Windows.Forms.TextBox PaymentRemainingtextBox;
        public System.Windows.Forms.Label label6;
    }
}