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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListItems = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBillNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BillCostBox = new System.Windows.Forms.TextBox();
            this.Okeybtn = new Telerik.WinControls.UI.RadButton();
            this.DGVSellItems = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Okeybtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSellItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "product Show";
            // 
            // ListItems
            // 
            this.ListItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListItems.FullRowSelect = true;
            this.ListItems.GridLines = true;
            this.ListItems.Location = new System.Drawing.Point(3, 18);
            this.ListItems.Name = "ListItems";
            this.ListItems.Size = new System.Drawing.Size(723, 275);
            this.ListItems.TabIndex = 0;
            this.ListItems.UseCompatibleStateImageBehavior = false;
            this.ListItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            this.ListItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItems_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBarCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtBillNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BillCostBox);
            this.groupBox2.Controls.Add(this.Okeybtn);
            this.groupBox2.Controls.Add(this.DGVSellItems);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill Number ";
            // 
            // TxtBillNumber
            // 
            this.TxtBillNumber.Location = new System.Drawing.Point(635, 43);
            this.TxtBillNumber.Name = "TxtBillNumber";
            this.TxtBillNumber.Size = new System.Drawing.Size(82, 20);
            this.TxtBillNumber.TabIndex = 4;
            this.TxtBillNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBillNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill Cost";
            // 
            // BillCostBox
            // 
            this.BillCostBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillCostBox.ForeColor = System.Drawing.Color.Red;
            this.BillCostBox.Location = new System.Drawing.Point(635, 209);
            this.BillCostBox.Name = "BillCostBox";
            this.BillCostBox.ReadOnly = true;
            this.BillCostBox.Size = new System.Drawing.Size(82, 22);
            this.BillCostBox.TabIndex = 2;
            this.BillCostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Okeybtn
            // 
            this.Okeybtn.Location = new System.Drawing.Point(635, 235);
            this.Okeybtn.Name = "Okeybtn";
            this.Okeybtn.Size = new System.Drawing.Size(87, 38);
            this.Okeybtn.TabIndex = 1;
            this.Okeybtn.Text = "Ok Save Bill";
            this.Okeybtn.ThemeName = "VisualStudio2012Light";
            this.Okeybtn.Click += new System.EventHandler(this.Okeybtn_Click);
            // 
            // DGVSellItems
            // 
            this.DGVSellItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVSellItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVSellItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGVSellItems.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVSellItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVSellItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVSellItems.Location = new System.Drawing.Point(3, 18);
            // 
            // DGVSellItems
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ItemName";
            gridViewTextBoxColumn2.HeaderText = "Item Name";
            gridViewTextBoxColumn2.Name = "ItemName";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ItemPrice";
            gridViewTextBoxColumn4.HeaderText = "Item Price";
            gridViewTextBoxColumn4.Name = "ItemPrice";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Ouantity";
            gridViewTextBoxColumn5.Name = "Quantity";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 100;
            this.DGVSellItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.DGVSellItems.Name = "DGVSellItems";
            this.DGVSellItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVSellItems.Size = new System.Drawing.Size(626, 258);
            this.DGVSellItems.TabIndex = 0;
            this.DGVSellItems.Text = "DGVItems";
            this.DGVSellItems.ThemeName = "VisualStudio2012Light";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bar Code";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(635, 118);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(82, 20);
            this.txtBarCode.TabIndex = 6;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            // 
            // FrmAddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(729, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAddSales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddSales";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmAddSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton Okeybtn;
        private Telerik.WinControls.UI.RadGridView DGVSellItems;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ListView ListItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BillCostBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBillNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
    }
}
