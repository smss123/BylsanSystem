namespace Bylsan_System.MainStoreForms
{
    partial class FrmManageMainStore_Supplier
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SupplierGridView = new Telerik.WinControls.UI.RadGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1.SuspendLayout();
            this.lblStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addbtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Addbtn
            // 
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(93, 37);
            this.Addbtn.Text = "Add item";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(106, 37);
            this.RefreshBtn.Text = "RefreshData";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // lblStatus
            // 
            this.lblStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.lblStatus.Location = new System.Drawing.Point(0, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(788, 22);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SupplierGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 446);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "---";
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.BackColor = System.Drawing.SystemColors.Control;
            this.SupplierGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SupplierGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SupplierGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SupplierGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SupplierGridView.Location = new System.Drawing.Point(3, 18);
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.MasterTemplate.AllowAddNewRow = false;
            this.SupplierGridView.MasterTemplate.AutoGenerateColumns = false;
            this.SupplierGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 59;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "SupplierName";
            gridViewTextBoxColumn1.HeaderText = "SupplierName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "SupplierName";
            gridViewTextBoxColumn1.Width = 143;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SupplierPhone";
            gridViewTextBoxColumn2.HeaderText = "SupplierPhone";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SupplierPhone";
            gridViewTextBoxColumn2.Width = 114;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Address";
            gridViewTextBoxColumn3.HeaderText = "Address";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Address";
            gridViewTextBoxColumn3.Width = 129;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.HeaderText = "Description";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Description";
            gridViewTextBoxColumn4.Width = 199;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 64;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Delte";
            gridViewCommandColumn2.Name = "DelteCol";
            gridViewCommandColumn2.Width = 60;
            this.SupplierGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.SupplierGridView.MasterTemplate.DataSource = this.supplierBindingSource;
            this.SupplierGridView.MasterTemplate.EnableFiltering = true;
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.ReadOnly = true;
            this.SupplierGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SupplierGridView.Size = new System.Drawing.Size(782, 425);
            this.SupplierGridView.TabIndex = 0;
            this.SupplierGridView.Text = "SupplierGridView";
            this.SupplierGridView.ThemeName = "Office2010Black";
            this.SupplierGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.SupplierGridView_CommandCellClick);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(XamaDataLayer.Supplier);
            // 
            // FrmManageMainStore_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageMainStore_Supplier";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageMainStore_Supplier";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmManageMainStore_Supplier_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lblStatus.ResumeLayout(false);
            this.lblStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView SupplierGridView;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton Addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}