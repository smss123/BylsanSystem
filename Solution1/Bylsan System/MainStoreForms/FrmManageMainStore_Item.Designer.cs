namespace Bylsan_System.MainStoreForms
{
    partial class FrmManageMainStore_Item
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DGVItems = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1187, 40);
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "_";
            // 
            // DGVItems
            // 
            this.DGVItems.BackColor = System.Drawing.SystemColors.Control;
            this.DGVItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVItems.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVItems.Location = new System.Drawing.Point(3, 18);
            // 
            // DGVItems
            // 
            this.DGVItems.MasterTemplate.AllowAddNewRow = false;
            this.DGVItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 140;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ItemName";
            gridViewTextBoxColumn2.HeaderText = "Item Name";
            gridViewTextBoxColumn2.Name = "ItemName";
            gridViewTextBoxColumn2.Width = 228;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ItemType";
            gridViewTextBoxColumn3.HeaderText = "Item Type";
            gridViewTextBoxColumn3.Name = "ItemType";
            gridViewTextBoxColumn3.Width = 228;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ItemDescription";
            gridViewTextBoxColumn4.HeaderText = "Item Description";
            gridViewTextBoxColumn4.Name = "ItemDescription";
            gridViewTextBoxColumn4.Width = 480;
            gridViewCommandColumn1.DefaultText = "Edit";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.DefaultText = "Delete";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Delete";
            gridViewCommandColumn2.MaxWidth = 45;
            gridViewCommandColumn2.MinWidth = 45;
            gridViewCommandColumn2.Name = "DeleteCol";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 45;
            this.DGVItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.DGVItems.MasterTemplate.EnableFiltering = true;
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVItems.Size = new System.Drawing.Size(1181, 357);
            this.DGVItems.TabIndex = 2;
            this.DGVItems.Text = "ItemsGridView";
            this.DGVItems.ThemeName = "Office2010Black";
            this.DGVItems.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellClick);
            this.DGVItems.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            this.DGVItems.Click += new System.EventHandler(this.MasterTemplate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // FrmManageMainStore_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageMainStore_Item";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageMainStore_Item";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmManageMainStore_Item_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Addbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGridView DGVItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}