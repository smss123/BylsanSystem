namespace Bylsan_System.BranchForms
{
    partial class FrmEditBranch
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.BranchgroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeManagerComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchDescription = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BranchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchgroupBox
            // 
            this.BranchgroupBox.Controls.Add(this.label3);
            this.BranchgroupBox.Controls.Add(this.EmployeeManagerComboBox);
            this.BranchgroupBox.Controls.Add(this.AddBtn);
            this.BranchgroupBox.Controls.Add(this.label2);
            this.BranchgroupBox.Controls.Add(this.label1);
            this.BranchgroupBox.Controls.Add(this.txtBranchDescription);
            this.BranchgroupBox.Controls.Add(this.txtBranchName);
            this.BranchgroupBox.Location = new System.Drawing.Point(12, 13);
            this.BranchgroupBox.Name = "BranchgroupBox";
            this.BranchgroupBox.Size = new System.Drawing.Size(328, 247);
            this.BranchgroupBox.TabIndex = 0;
            this.BranchgroupBox.TabStop = false;
            this.BranchgroupBox.Text = "Edit Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Manager:";
            // 
            // EmployeeManagerComboBox
            // 
            this.EmployeeManagerComboBox.DataSource = this.employeeBindingSource;
            // 
            // EmployeeManagerComboBox.NestedRadGridView
            // 
            this.EmployeeManagerComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeManagerComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeManagerComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmployeeManagerComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeManagerComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeManagerComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Emp_Name";
            gridViewTextBoxColumn7.HeaderText = "Emp_Name";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Emp_Name";
            gridViewTextBoxColumn7.Width = 125;
            gridViewDateTimeColumn3.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "HereDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "HereDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "HereDate";
            gridViewDateTimeColumn3.Width = 125;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Personalty_ID";
            gridViewTextBoxColumn8.HeaderText = "Personalty_ID";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Personalty_ID";
            gridViewTextBoxColumn8.Width = 124;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Nationalty";
            gridViewTextBoxColumn9.HeaderText = "Nationalty";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Nationalty";
            gridViewTextBoxColumn9.Width = 119;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "HomeAddress";
            gridViewTextBoxColumn10.HeaderText = "HomeAddress";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "HomeAddress";
            gridViewTextBoxColumn10.Width = 120;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "PhoneNumber";
            gridViewTextBoxColumn11.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "PhoneNumber";
            gridViewTextBoxColumn11.Width = 111;
            gridViewDateTimeColumn4.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "CreateDate";
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn4.HeaderText = "CreateDate";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.Name = "CreateDate";
            gridViewDateTimeColumn4.Width = 92;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "Job";
            gridViewTextBoxColumn12.HeaderText = "Job";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "Job";
            gridViewTextBoxColumn12.Width = 83;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn7,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn12});
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.DataSource = this.employeeBindingSource;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeManagerComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmployeeManagerComboBox.EditorControl.ReadOnly = true;
            this.EmployeeManagerComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeManagerComboBox.EditorControl.ShowGroupPanel = false;
            this.EmployeeManagerComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeManagerComboBox.EditorControl.TabIndex = 0;
            this.EmployeeManagerComboBox.Location = new System.Drawing.Point(117, 134);
            this.EmployeeManagerComboBox.Name = "EmployeeManagerComboBox";
            this.EmployeeManagerComboBox.Size = new System.Drawing.Size(195, 20);
            this.EmployeeManagerComboBox.TabIndex = 2;
            this.EmployeeManagerComboBox.TabStop = false;
            this.EmployeeManagerComboBox.ThemeName = "Windows8";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 194);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Save";
            this.AddBtn.ThemeName = "Windows8";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Branch Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Branch Name:";
            // 
            // txtBranchDescription
            // 
            this.txtBranchDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchDescription.Location = new System.Drawing.Point(117, 66);
            this.txtBranchDescription.Multiline = true;
            this.txtBranchDescription.Name = "txtBranchDescription";
            this.txtBranchDescription.Size = new System.Drawing.Size(195, 61);
            this.txtBranchDescription.TabIndex = 1;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchName.Location = new System.Drawing.Point(117, 37);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(195, 20);
            this.txtBranchName.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(XamaDataLayer.Employee);
            // 
            // FrmEditBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(353, 279);
            this.Controls.Add(this.BranchgroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(369, 317);
            this.Name = "FrmEditBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Branch";
            this.Load += new System.EventHandler(this.FrmEditBranch_Load);
            this.BranchgroupBox.ResumeLayout(false);
            this.BranchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BranchgroupBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmployeeManagerComboBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBranchDescription;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}