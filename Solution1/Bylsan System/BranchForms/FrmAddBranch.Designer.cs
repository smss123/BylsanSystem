namespace Bylsan_System.BranchForms
{
    partial class FrmAddBranch
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeManager = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchDescription = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmployeeManager);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBranchDescription);
            this.groupBox1.Controls.Add(this.txtBranchName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddBranch";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(13, 185);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manager:";
            // 
            // EmployeeManager
            // 
            this.EmployeeManager.BackColor = System.Drawing.SystemColors.Info;
            this.EmployeeManager.DataSource = this.bindingSource1;
            // 
            // EmployeeManager.NestedRadGridView
            // 
            this.EmployeeManager.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeManager.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeManager.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmployeeManager.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeManager.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeManager.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmployeeManager.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeManager.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeManager.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeManager.EditorControl.MasterTemplate.AutoGenerateColumns = false;
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
            gridViewTextBoxColumn1.Width = 151;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "HereDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "HereDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "HereDate";
            gridViewDateTimeColumn1.Width = 120;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Personalty_ID";
            gridViewTextBoxColumn2.HeaderText = "Personalty_ID";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Personalty_ID";
            gridViewTextBoxColumn2.Width = 153;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Nationalty";
            gridViewTextBoxColumn3.HeaderText = "Nationalty";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Nationalty";
            gridViewTextBoxColumn3.Width = 131;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "HomeAddress";
            gridViewTextBoxColumn4.HeaderText = "HomeAddress";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "HomeAddress";
            gridViewTextBoxColumn4.Width = 124;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PhoneNumber";
            gridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "PhoneNumber";
            gridViewTextBoxColumn5.Width = 104;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Job";
            gridViewTextBoxColumn6.HeaderText = "Job";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Job";
            gridViewTextBoxColumn6.Width = 108;
            this.EmployeeManager.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.EmployeeManager.EditorControl.MasterTemplate.DataSource = this.bindingSource1;
            this.EmployeeManager.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeManager.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeManager.EditorControl.Name = "NestedRadGridView";
            this.EmployeeManager.EditorControl.ReadOnly = true;
            this.EmployeeManager.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeManager.EditorControl.ShowGroupPanel = false;
            this.EmployeeManager.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeManager.EditorControl.TabIndex = 0;
            this.EmployeeManager.Location = new System.Drawing.Point(104, 128);
            this.EmployeeManager.Name = "EmployeeManager";
            this.EmployeeManager.NullText = "Enter Manager";
            this.EmployeeManager.Size = new System.Drawing.Size(195, 20);
            this.EmployeeManager.TabIndex = 2;
            this.EmployeeManager.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branch Name:";
            // 
            // txtBranchDescription
            // 
            this.txtBranchDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchDescription.Location = new System.Drawing.Point(104, 60);
            this.txtBranchDescription.Multiline = true;
            this.txtBranchDescription.Name = "txtBranchDescription";
            this.txtBranchDescription.Size = new System.Drawing.Size(195, 61);
            this.txtBranchDescription.TabIndex = 1;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchName.Location = new System.Drawing.Point(104, 31);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(195, 20);
            this.txtBranchName.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(XamaDataLayer.Employee);
            // 
            // FrmAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(349, 275);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(365, 313);
            this.MinimumSize = new System.Drawing.Size(365, 313);
            this.Name = "FrmAddBranch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.FrmAddBranch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadMultiColumnComboBox EmployeeManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBranchDescription;
        private System.Windows.Forms.TextBox txtBranchName;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}