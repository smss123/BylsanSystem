namespace Bylsan_System.MainStoreForms
{
    partial class FrmManageMainStore_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageMainStore_Store));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStorePurchases = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPurchasesOrder = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StoreGridView = new Telerik.WinControls.UI.RadGridView();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransfer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addbtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2,
            this.btnStorePurchases,
            this.toolStripSeparator3,
            this.BtnPurchasesOrder,
            this.toolStripSeparator4,
            this.btnTransfer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Addbtn
            // 
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(93, 52);
            this.Addbtn.Text = "Add item";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(106, 52);
            this.RefreshBtn.Text = "RefreshData";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnStorePurchases
            // 
            this.btnStorePurchases.Image = ((System.Drawing.Image)(resources.GetObject("btnStorePurchases.Image")));
            this.btnStorePurchases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStorePurchases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStorePurchases.Name = "btnStorePurchases";
            this.btnStorePurchases.Size = new System.Drawing.Size(125, 52);
            this.btnStorePurchases.Text = "Store Purchases";
            this.btnStorePurchases.Click += new System.EventHandler(this.btnStorePurchases_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // BtnPurchasesOrder
            // 
            this.BtnPurchasesOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtnPurchasesOrder.Image")));
            this.BtnPurchasesOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPurchasesOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPurchasesOrder.Name = "BtnPurchasesOrder";
            this.BtnPurchasesOrder.Size = new System.Drawing.Size(129, 52);
            this.BtnPurchasesOrder.Text = "Purchases Order";
            this.BtnPurchasesOrder.Click += new System.EventHandler(this.BtnPurchasesOrder_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "_";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StoreGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 475);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Data";
            // 
            // StoreGridView
            // 
            this.StoreGridView.BackColor = System.Drawing.SystemColors.Control;
            this.StoreGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.StoreGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoreGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StoreGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StoreGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StoreGridView.Location = new System.Drawing.Point(3, 18);
            // 
            // StoreGridView
            // 
            this.StoreGridView.MasterTemplate.AllowAddNewRow = false;
            this.StoreGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ID";
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.Name = "ID";
            gridViewTextBoxColumn7.Width = 86;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Product.Product_Name";
            gridViewTextBoxColumn8.HeaderText = "Product";
            gridViewTextBoxColumn8.Name = "ItemID";
            gridViewTextBoxColumn8.Width = 196;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "AvailableQty";
            gridViewTextBoxColumn9.HeaderText = "AvailableQty";
            gridViewTextBoxColumn9.Name = "AvailableQty";
            gridViewTextBoxColumn9.Width = 155;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Description";
            gridViewTextBoxColumn10.HeaderText = "Description";
            gridViewTextBoxColumn10.Name = "Description";
            gridViewTextBoxColumn10.Width = 343;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.HeaderText = "Edit";
            gridViewTextBoxColumn11.Name = "EditCol";
            gridViewTextBoxColumn11.Width = 65;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.HeaderText = "Delete";
            gridViewTextBoxColumn12.Name = "DeleteCol";
            gridViewTextBoxColumn12.Width = 70;
            this.StoreGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.StoreGridView.Name = "StoreGridView";
            this.StoreGridView.ReadOnly = true;
            this.StoreGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StoreGridView.Size = new System.Drawing.Size(930, 454);
            this.StoreGridView.TabIndex = 0;
            this.StoreGridView.Text = "MainStorGridView";
            this.StoreGridView.ThemeName = "Office2010Black";
            this.StoreGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.StoreGridView_CommandCellClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(147, 52);
            this.btnTransfer.Text = "Transfer Product";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // FrmManageMainStore_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageMainStore_Store";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmManageMainStore_Store_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView StoreGridView;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton Addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnStorePurchases;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnPurchasesOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnTransfer;
    }
}