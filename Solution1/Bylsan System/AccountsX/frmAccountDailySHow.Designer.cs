namespace Bylsan_System.AccountsX
{
    partial class frmAccountDailySHow
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVAccountsDaily = new Telerik.WinControls.UI.RadGridView();
            this.accountDailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ADDbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADDbtn,
            this.toolStripSeparator1,
            this.RefreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVAccountsDaily);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Daily Data";
            // 
            // DGVAccountsDaily
            // 
            this.DGVAccountsDaily.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVAccountsDaily.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVAccountsDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAccountsDaily.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVAccountsDaily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVAccountsDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVAccountsDaily.Location = new System.Drawing.Point(3, 18);
            // 
            // DGVAccountsDaily
            // 
            this.DGVAccountsDaily.MasterTemplate.AutoGenerateColumns = false;
            this.DGVAccountsDaily.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "ID";
            gridViewDecimalColumn9.HeaderText = "ID";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "ID";
            gridViewDecimalColumn9.Width = 112;
            gridViewDecimalColumn10.DataType = typeof(string);
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "Account.AccountName";
            gridViewDecimalColumn10.HeaderText = "AccountName";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.Name = "AccountName";
            gridViewDecimalColumn10.Width = 112;
            gridViewDecimalColumn11.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "TotalIn";
            gridViewDecimalColumn11.HeaderText = "TotalIn";
            gridViewDecimalColumn11.IsAutoGenerated = true;
            gridViewDecimalColumn11.Name = "TotalIn";
            gridViewDecimalColumn11.Width = 112;
            gridViewDecimalColumn12.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "TotalOut";
            gridViewDecimalColumn12.HeaderText = "TotalOut";
            gridViewDecimalColumn12.IsAutoGenerated = true;
            gridViewDecimalColumn12.Name = "TotalOut";
            gridViewDecimalColumn12.Width = 112;
            gridViewDateTimeColumn3.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "DateOfProcess";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "DateOfProcess";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "DateOfProcess";
            gridViewDateTimeColumn3.Width = 112;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Description";
            gridViewTextBoxColumn5.HeaderText = "Description";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Description";
            gridViewTextBoxColumn5.Width = 112;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "CommandArg";
            gridViewTextBoxColumn6.HeaderText = "CommandArg";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "CommandArg";
            gridViewTextBoxColumn6.Width = 112;
            this.DGVAccountsDaily.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn9,
            gridViewDecimalColumn10,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.DGVAccountsDaily.MasterTemplate.DataSource = this.accountDailyBindingSource;
            this.DGVAccountsDaily.MasterTemplate.EnableFiltering = true;
            this.DGVAccountsDaily.Name = "DGVAccountsDaily";
            this.DGVAccountsDaily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVAccountsDaily.Size = new System.Drawing.Size(797, 451);
            this.DGVAccountsDaily.TabIndex = 0;
            this.DGVAccountsDaily.Text = "DGVAccountsDaily";
            this.DGVAccountsDaily.ThemeName = "VisualStudio2012Light";
            // 
            // accountDailyBindingSource
            // 
            this.accountDailyBindingSource.DataSource = typeof(XamaDataLayer.AccountDaily);
            // 
            // ADDbtn
            // 
            this.ADDbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.ADDbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ADDbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(65, 36);
            this.ADDbtn.Text = "Add";
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // frmAccountDailySHow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAccountDailySHow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountDailySHow";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.frmAccountDailySHow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView DGVAccountsDaily;
        private System.Windows.Forms.BindingSource accountDailyBindingSource;
        private System.Windows.Forms.ToolStripButton ADDbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
    }
}
