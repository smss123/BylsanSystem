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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.BranchgroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeManagerComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchDescription = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.BranchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
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
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Emp_Name";
            gridViewTextBoxColumn1.HeaderText = "Emp_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Emp_Name";
            gridViewTextBoxColumn1.Width = 125;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "HereDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "HereDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "HereDate";
            gridViewDateTimeColumn1.Width = 125;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Personalty_ID";
            gridViewTextBoxColumn2.HeaderText = "Personalty_ID";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Personalty_ID";
            gridViewTextBoxColumn2.Width = 124;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Nationalty";
            gridViewTextBoxColumn3.HeaderText = "Nationalty";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Nationalty";
            gridViewTextBoxColumn3.Width = 119;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "HomeAddress";
            gridViewTextBoxColumn4.HeaderText = "HomeAddress";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "HomeAddress";
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PhoneNumber";
            gridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "PhoneNumber";
            gridViewTextBoxColumn5.Width = 111;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "CreateDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "CreateDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "CreateDate";
            gridViewDateTimeColumn2.Width = 92;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Job";
            gridViewTextBoxColumn6.HeaderText = "Job";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Job";
            gridViewTextBoxColumn6.Width = 83;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn6});
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
            this.EmployeeManagerComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Branch Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
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
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.AddBtn.Location = new System.Drawing.Point(19, 194);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Save";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FrmEditBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(361, 284);
            this.Controls.Add(this.BranchgroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(369, 317);
            this.Name = "FrmEditBranch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(369, 317);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Branch";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEditBranch_Load);
            this.BranchgroupBox.ResumeLayout(false);
            this.BranchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}