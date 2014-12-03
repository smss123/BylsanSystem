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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StoreGridView = new Telerik.WinControls.UI.RadGridView();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StoreGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 505);
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
            gridViewTextBoxColumn8.FieldName = "ItemID";
            gridViewTextBoxColumn8.HeaderText = "ItemID";
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
            gridViewTextBoxColumn10.Width = 344;
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
            this.StoreGridView.Size = new System.Drawing.Size(930, 484);
            this.StoreGridView.TabIndex = 0;
            this.StoreGridView.Text = "MainStorGridView";
            this.StoreGridView.ThemeName = "VisualStudio2012Light";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "_";
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
            this.Text = "FrmManageMainStore_Store";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmManageMainStore_Store_Load);
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
    }
}