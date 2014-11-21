namespace Bylsan_System.BranchForms
{
    partial class FrmManageBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageBranch));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BranchGroupBox = new System.Windows.Forms.GroupBox();
            this.BranchGridView = new Telerik.WinControls.UI.RadGridView();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.toolStrip1.SuspendLayout();
            this.BranchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 22);
            this.AddBtn.Text = "Add Branch";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BranchGroupBox
            // 
            this.BranchGroupBox.Controls.Add(this.BranchGridView);
            this.BranchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BranchGroupBox.Location = new System.Drawing.Point(0, 25);
            this.BranchGroupBox.Name = "BranchGroupBox";
            this.BranchGroupBox.Size = new System.Drawing.Size(897, 491);
            this.BranchGroupBox.TabIndex = 2;
            this.BranchGroupBox.TabStop = false;
            this.BranchGroupBox.Text = "Branch Data";
            // 
            // BranchGridView
            // 
            this.BranchGridView.BackColor = System.Drawing.SystemColors.Control;
            this.BranchGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.BranchGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BranchGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BranchGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BranchGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BranchGridView.Location = new System.Drawing.Point(3, 16);
            // 
            // BranchGridView
            // 
            this.BranchGridView.MasterTemplate.AllowAddNewRow = false;
            this.BranchGridView.MasterTemplate.AllowColumnReorder = false;
            this.BranchGridView.MasterTemplate.AutoGenerateColumns = false;
            this.BranchGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "ID";
            gridViewDecimalColumn5.HeaderText = "ID";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "ID";
            gridViewDecimalColumn5.Width = 88;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Branch_Name";
            gridViewTextBoxColumn5.HeaderText = "Branch Name";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Branch_Name";
            gridViewTextBoxColumn5.Width = 206;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Branch_Description";
            gridViewTextBoxColumn6.HeaderText = "Description";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Branch_Description";
            gridViewTextBoxColumn6.Width = 211;
            gridViewDateTimeColumn3.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "CreatedDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "Created Date";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "CreatedDate";
            gridViewDateTimeColumn3.Width = 131;
            gridViewDecimalColumn6.DataType = typeof(string);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "Employee.Emp_Name";
            gridViewDecimalColumn6.HeaderText = "Manager Name";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "ManagerName";
            gridViewDecimalColumn6.Width = 165;
            gridViewCommandColumn5.EnableExpressionEditor = false;
            gridViewCommandColumn5.HeaderText = "Edit";
            gridViewCommandColumn5.Name = "EditCol";
            gridViewCommandColumn5.Width = 39;
            gridViewCommandColumn6.EnableExpressionEditor = false;
            gridViewCommandColumn6.HeaderText = "Delete";
            gridViewCommandColumn6.Name = "DeleteCol";
            gridViewCommandColumn6.Width = 36;
            this.BranchGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn6,
            gridViewCommandColumn5,
            gridViewCommandColumn6});
            this.BranchGridView.MasterTemplate.DataSource = this.branchBindingSource;
            this.BranchGridView.MasterTemplate.EnableFiltering = true;
            this.BranchGridView.Name = "BranchGridView";
            this.BranchGridView.ReadOnly = true;
            this.BranchGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BranchGridView.Size = new System.Drawing.Size(891, 472);
            this.BranchGridView.TabIndex = 0;
            this.BranchGridView.Text = "BranchGridView";
            this.BranchGridView.ThemeName = "Windows8";
            this.BranchGridView.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.BranchGridView_CommandCellClick);
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(XamaDataLayer.Branch);
            // 
            // FrmManageBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.BranchGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageBranch";
            this.Load += new System.EventHandler(this.FrmManageBranch_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BranchGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox BranchGroupBox;
        private Telerik.WinControls.UI.RadGridView BranchGridView;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.ToolStripButton AddBtn;
    }
}