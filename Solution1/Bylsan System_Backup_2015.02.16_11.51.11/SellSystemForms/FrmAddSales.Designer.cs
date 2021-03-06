﻿namespace Bylsan_System.SellSystemForms
{
    partial class FrmAddSales
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshBTn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.txtqty = new Telerik.WinControls.UI.RadTextBox();
            this.txtProductName = new Telerik.WinControls.UI.RadTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVisaCard = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbPaymentTypes = new System.Windows.Forms.ComboBox();
            this.txtCustomerPhoneNumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtCustomerName = new Telerik.WinControls.UI.RadTextBox();
            this.txtCustomerPay = new System.Windows.Forms.NumericUpDown();
            this.Okeybtn = new Telerik.WinControls.UI.RadButton();
            this.BillCostBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBillNumber = new System.Windows.Forms.TextBox();
            this.DGVSellItems = new Telerik.WinControls.UI.RadGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Okeybtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshBTn,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1210, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshBTn
            // 
            this.RefreshBTn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.RefreshBTn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBTn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBTn.Name = "RefreshBTn";
            this.RefreshBTn.Size = new System.Drawing.Size(82, 36);
            this.RefreshBTn.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1210, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtqty);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtCustomerPhoneNumber);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.txtCustomerPay);
            this.groupBox2.Controls.Add(this.Okeybtn);
            this.groupBox2.Controls.Add(this.BillCostBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBarCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOrderID);
            this.groupBox2.Controls.Add(this.TxtBillNumber);
            this.groupBox2.Controls.Add(this.DGVSellItems);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1210, 611);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(448, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Go";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(216, 74);
            this.txtqty.Name = "txtqty";
            this.txtqty.NullText = "Enter Qty";
            this.txtqty.Size = new System.Drawing.Size(226, 31);
            this.txtqty.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(16, 74);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.NullText = "Enter \\Product Name";
            this.txtProductName.Size = new System.Drawing.Size(194, 31);
            this.txtProductName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVisaCard);
            this.groupBox3.Controls.Add(this.txtCash);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.CmbPaymentTypes);
            this.groupBox3.Location = new System.Drawing.Point(806, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 90);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Payment Type";
            // 
            // txtVisaCard
            // 
            this.txtVisaCard.Location = new System.Drawing.Point(232, 56);
            this.txtVisaCard.Name = "txtVisaCard";
            this.txtVisaCard.Size = new System.Drawing.Size(107, 20);
            this.txtVisaCard.TabIndex = 10;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(64, 60);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(95, 20);
            this.txtCash.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Visa Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cash";
            // 
            // CmbPaymentTypes
            // 
            this.CmbPaymentTypes.FormattingEnabled = true;
            this.CmbPaymentTypes.Location = new System.Drawing.Point(19, 21);
            this.CmbPaymentTypes.Name = "CmbPaymentTypes";
            this.CmbPaymentTypes.Size = new System.Drawing.Size(343, 21);
            this.CmbPaymentTypes.TabIndex = 6;
            this.CmbPaymentTypes.Text = "Cash Onley";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(938, 60);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.NullText = "Enter Phone Number Here";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(212, 27);
            this.txtCustomerPhoneNumber.TabIndex = 3;
            this.txtCustomerPhoneNumber.ThemeName = "Office2010Black";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(938, 93);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.NullText = "Enter Customer Name Here";
            this.txtCustomerName.Size = new System.Drawing.Size(212, 27);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.ThemeName = "Office2010Black";
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomerPay.DecimalPlaces = 2;
            this.txtCustomerPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPay.ForeColor = System.Drawing.Color.Lime;
            this.txtCustomerPay.Location = new System.Drawing.Point(985, 518);
            this.txtCustomerPay.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.Size = new System.Drawing.Size(208, 33);
            this.txtCustomerPay.TabIndex = 30;
            // 
            // Okeybtn
            // 
            this.Okeybtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.Okeybtn.Location = new System.Drawing.Point(1097, 558);
            this.Okeybtn.Name = "Okeybtn";
            this.Okeybtn.Size = new System.Drawing.Size(99, 35);
            this.Okeybtn.TabIndex = 70;
            this.Okeybtn.Text = " Save Bill";
            this.Okeybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Okeybtn.ThemeName = "Office2010Black";
            this.Okeybtn.Click += new System.EventHandler(this.Okeybtn_Click);
            // 
            // BillCostBox
            // 
            this.BillCostBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillCostBox.ForeColor = System.Drawing.Color.Red;
            this.BillCostBox.Location = new System.Drawing.Point(987, 478);
            this.BillCostBox.Name = "BillCostBox";
            this.BillCostBox.ReadOnly = true;
            this.BillCostBox.Size = new System.Drawing.Size(206, 30);
            this.BillCostBox.TabIndex = 20;
            this.BillCostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillCostBox.TextChanged += new System.EventHandler(this.BillCostBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(857, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Custmer Pay:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(842, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bar Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(899, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill Cost:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtBarCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(938, 128);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(212, 33);
            this.txtBarCode.TabIndex = 5;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(859, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill Number: ";
            // 
            // TxtBillNumber
            // 
            this.TxtBillNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBillNumber.Location = new System.Drawing.Point(987, 442);
            this.TxtBillNumber.Name = "TxtBillNumber";
            this.TxtBillNumber.ReadOnly = true;
            this.TxtBillNumber.Size = new System.Drawing.Size(206, 33);
            this.TxtBillNumber.TabIndex = 13;
            this.TxtBillNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBillNumber_KeyPress);
            // 
            // DGVSellItems
            // 
            this.DGVSellItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVSellItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVSellItems.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVSellItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVSellItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVSellItems.Location = new System.Drawing.Point(16, 111);
            // 
            // DGVSellItems
            // 
            this.DGVSellItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ID";
            gridViewTextBoxColumn6.HeaderText = "ID";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "ID";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ItemName";
            gridViewTextBoxColumn7.HeaderText = "Item Name";
            gridViewTextBoxColumn7.Name = "ItemName";
            gridViewTextBoxColumn7.Width = 177;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Description";
            gridViewTextBoxColumn8.HeaderText = "Description";
            gridViewTextBoxColumn8.Name = "Description";
            gridViewTextBoxColumn8.Width = 234;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "ItemPrice";
            gridViewTextBoxColumn9.HeaderText = "Item Price";
            gridViewTextBoxColumn9.Name = "ItemPrice";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 119;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.HeaderText = "Ouantity";
            gridViewTextBoxColumn10.Name = "Quantity";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 177;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Name = "colbtn";
            gridViewCommandColumn2.Width = 61;
            this.DGVSellItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn2});
            this.DGVSellItems.Name = "DGVSellItems";
            this.DGVSellItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVSellItems.Size = new System.Drawing.Size(784, 471);
            this.DGVSellItems.TabIndex = 50;
            this.DGVSellItems.Text = "DGVItems";
            this.DGVSellItems.ThemeName = "Office2010Black";
            this.DGVSellItems.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtOrderID.Location = new System.Drawing.Point(166, 19);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(59, 33);
            this.txtOrderID.TabIndex = 13;
            this.txtOrderID.Text = "0";
            this.txtOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBillNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(21, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Order Number:";
            // 
            // FrmAddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1210, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAddSales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmAddSales_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Okeybtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton Okeybtn;
        private Telerik.WinControls.UI.RadGridView DGVSellItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BillCostBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBillNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.ToolStripButton RefreshBTn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtCustomerPay;
        private Telerik.WinControls.UI.RadTextBox txtCustomerName;
        private Telerik.WinControls.UI.RadTextBox txtCustomerPhoneNumber;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVisaCard;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbPaymentTypes;
        private Telerik.WinControls.UI.RadTextBox txtqty;
        private Telerik.WinControls.UI.RadTextBox txtProductName;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderID;
    }
}
