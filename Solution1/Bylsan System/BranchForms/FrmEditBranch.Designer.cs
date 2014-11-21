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
            this.BranchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.BranchgroupBox.Location = new System.Drawing.Point(13, 15);
            this.BranchgroupBox.Name = "BranchgroupBox";
            this.BranchgroupBox.Size = new System.Drawing.Size(328, 253);
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
            // 
            // EmployeeManagerComboBox.NestedRadGridView
            // 
            this.EmployeeManagerComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeManagerComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmployeeManagerComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeManagerComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeManagerComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeManagerComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmployeeManagerComboBox.EditorControl.ReadOnly = true;
            this.EmployeeManagerComboBox.EditorControl.ShowGroupPanel = false;
            this.EmployeeManagerComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeManagerComboBox.EditorControl.TabIndex = 0;
            this.EmployeeManagerComboBox.Location = new System.Drawing.Point(117, 134);
            this.EmployeeManagerComboBox.Name = "EmployeeManagerComboBox";
            this.EmployeeManagerComboBox.Size = new System.Drawing.Size(195, 20);
            this.EmployeeManagerComboBox.TabIndex = 9;
            this.EmployeeManagerComboBox.TabStop = false;
            this.EmployeeManagerComboBox.ThemeName = "Windows8";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(19, 194);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 37);
            this.AddBtn.TabIndex = 7;
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
            this.txtBranchDescription.TabIndex = 5;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchName.Location = new System.Drawing.Point(117, 37);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(195, 20);
            this.txtBranchName.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(353, 291);
            this.Controls.Add(this.BranchgroupBox);
            this.Name = "FrmEditBranch";
            this.Text = "FrmEditBranch";
            this.BranchgroupBox.ResumeLayout(false);
            this.BranchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeManagerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}