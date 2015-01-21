namespace Bylsan_System.AccountsX
{
    partial class FrmShowDebtorAccount
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddDebtBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RepaydebBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DGVDebtors = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDebtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDebtors.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDebtBtn,
            this.toolStripSeparator1,
            this.RepaydebBtn,
            this.toolStripSeparator2,
            this.RefreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddDebtBtn
            // 
            this.AddDebtBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddDebtBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddDebtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDebtBtn.Name = "AddDebtBtn";
            this.AddDebtBtn.Size = new System.Drawing.Size(93, 36);
            this.AddDebtBtn.Text = "Add Debt";
            this.AddDebtBtn.Click += new System.EventHandler(this.AddDebtBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // RepaydebBtn
            // 
            this.RepaydebBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.RepaydebBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RepaydebBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RepaydebBtn.Name = "RepaydebBtn";
            this.RepaydebBtn.Size = new System.Drawing.Size(98, 36);
            this.RepaydebBtn.Text = "Repay deb";
            this.RepaydebBtn.Click += new System.EventHandler(this.RepaydebBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(79, 36);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DGVDebtors
            // 
            this.DGVDebtors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDebtors.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVDebtors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDebtors.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVDebtors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVDebtors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVDebtors.Location = new System.Drawing.Point(0, 39);
            // 
            // DGVDebtors
            // 
            this.DGVDebtors.MasterTemplate.AllowAddNewRow = false;
            this.DGVDebtors.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 168;
            gridViewTextBoxColumn2.FieldName = "AccountID";
            gridViewTextBoxColumn2.HeaderText = "AccountID";
            gridViewTextBoxColumn2.Name = "AccountIDCol";
            gridViewTextBoxColumn2.Width = 89;
            gridViewTextBoxColumn3.FieldName = "TotalIn";
            gridViewTextBoxColumn3.HeaderText = "TotalIn";
            gridViewTextBoxColumn3.Name = "TotalInCol";
            gridViewTextBoxColumn3.Width = 92;
            gridViewTextBoxColumn4.FieldName = "TotalOut";
            gridViewTextBoxColumn4.HeaderText = "TotalOut";
            gridViewTextBoxColumn4.Name = "TotalOutCol";
            gridViewTextBoxColumn4.Width = 92;
            gridViewTextBoxColumn5.FieldName = "DateOfProcess";
            gridViewTextBoxColumn5.HeaderText = "DateOfProcess";
            gridViewTextBoxColumn5.Name = "DateOfPrpcess";
            gridViewTextBoxColumn5.Width = 246;
            this.DGVDebtors.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.DGVDebtors.MasterTemplate.EnableFiltering = true;
            this.DGVDebtors.Name = "DGVDebtors";
            this.DGVDebtors.ReadOnly = true;
            this.DGVDebtors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVDebtors.Size = new System.Drawing.Size(703, 383);
            this.DGVDebtors.TabIndex = 2;
            this.DGVDebtors.Text = "radGridView1";
            this.DGVDebtors.ThemeName = "Office2010Black";
            // 
            // FrmShowDebtorAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 444);
            this.Controls.Add(this.DGVDebtors);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmShowDebtorAccount";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Debtor Account";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmShowDebtorAccount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDebtors.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDebtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddDebtBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RepaydebBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private Telerik.WinControls.UI.RadGridView DGVDebtors;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}