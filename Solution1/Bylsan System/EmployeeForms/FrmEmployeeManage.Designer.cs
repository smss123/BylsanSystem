namespace Bylsan_System.EmployeeForms
{
    partial class FrmEmployeeManage
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.EmplyeegroupBox = new System.Windows.Forms.GroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.EmplyeegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EmplyeegroupBox
            // 
            this.EmplyeegroupBox.Controls.Add(this.radGridView1);
            this.EmplyeegroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmplyeegroupBox.Location = new System.Drawing.Point(0, 25);
            this.EmplyeegroupBox.Name = "EmplyeegroupBox";
            this.EmplyeegroupBox.Size = new System.Drawing.Size(1157, 540);
            this.EmplyeegroupBox.TabIndex = 2;
            this.EmplyeegroupBox.TabStop = false;
            this.EmplyeegroupBox.Text = "Emplyee Data";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(3, 16);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.Width = 72;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "Emp_Name";
            gridViewTextBoxColumn13.HeaderText = "Emp_Name";
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.Name = "Emp_Name";
            gridViewTextBoxColumn13.Width = 171;
            gridViewDateTimeColumn5.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn5.EnableExpressionEditor = false;
            gridViewDateTimeColumn5.FieldName = "HereDate";
            gridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn5.HeaderText = "HereDate";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.Name = "HereDate";
            gridViewDateTimeColumn5.Width = 105;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "Personalty_ID";
            gridViewTextBoxColumn14.HeaderText = "Personalty_ID";
            gridViewTextBoxColumn14.IsAutoGenerated = true;
            gridViewTextBoxColumn14.Name = "Personalty_ID";
            gridViewTextBoxColumn14.Width = 84;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "Nationalty";
            gridViewTextBoxColumn15.HeaderText = "Nationalty";
            gridViewTextBoxColumn15.IsAutoGenerated = true;
            gridViewTextBoxColumn15.Name = "Nationalty";
            gridViewTextBoxColumn15.Width = 82;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "HomeAddress";
            gridViewTextBoxColumn16.HeaderText = "HomeAddress";
            gridViewTextBoxColumn16.IsAutoGenerated = true;
            gridViewTextBoxColumn16.Name = "HomeAddress";
            gridViewTextBoxColumn16.Width = 139;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "PhoneNumber";
            gridViewTextBoxColumn17.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn17.IsAutoGenerated = true;
            gridViewTextBoxColumn17.Name = "PhoneNumber";
            gridViewTextBoxColumn17.Width = 109;
            gridViewDateTimeColumn6.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn6.EnableExpressionEditor = false;
            gridViewDateTimeColumn6.FieldName = "CreateDate";
            gridViewDateTimeColumn6.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn6.HeaderText = "CreateDate";
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.Name = "CreateDate";
            gridViewDateTimeColumn6.Width = 97;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "Job";
            gridViewTextBoxColumn18.HeaderText = "Job";
            gridViewTextBoxColumn18.IsAutoGenerated = true;
            gridViewTextBoxColumn18.Name = "Job";
            gridViewTextBoxColumn18.Width = 116;
            gridViewCommandColumn5.EnableExpressionEditor = false;
            gridViewCommandColumn5.HeaderText = "Edit";
            gridViewCommandColumn5.Name = "EditCol";
            gridViewCommandColumn5.Width = 79;
            gridViewCommandColumn6.EnableExpressionEditor = false;
            gridViewCommandColumn6.HeaderText = "Delete";
            gridViewCommandColumn6.Name = "DelteCol";
            gridViewCommandColumn6.Width = 86;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn13,
            gridViewDateTimeColumn5,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewDateTimeColumn6,
            gridViewTextBoxColumn18,
            gridViewCommandColumn5,
            gridViewCommandColumn6});
            this.radGridView1.MasterTemplate.DataSource = this.employeeBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1151, 521);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "EmployeeGridView";
            this.radGridView1.ThemeName = "Windows8";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(XamaDataLayer.Employee);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "_";
            // 
            // FrmEmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 587);
            this.Controls.Add(this.EmplyeegroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmployeeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployeeManage";
            this.Load += new System.EventHandler(this.FrmEmployeeManage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.EmplyeegroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox EmplyeegroupBox;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}