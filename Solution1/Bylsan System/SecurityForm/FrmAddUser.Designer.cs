namespace Bylsan_System.SecurityForm
{
    partial class FrmAddUser
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
            System.Windows.Forms.Label passwordsLabel;
            System.Windows.Forms.Label branch_IDLabel;
            System.Windows.Forms.Label userNameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BranshComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordsTextBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            passwordsLabel = new System.Windows.Forms.Label();
            branch_IDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(24, 81);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(64, 13);
            passwordsLabel.TabIndex = 2;
            passwordsLabel.Text = "Passwords:";
            // 
            // branch_IDLabel
            // 
            branch_IDLabel.AutoSize = true;
            branch_IDLabel.Location = new System.Drawing.Point(28, 120);
            branch_IDLabel.Name = "branch_IDLabel";
            branch_IDLabel.Size = new System.Drawing.Size(60, 13);
            branch_IDLabel.TabIndex = 4;
            branch_IDLabel.Text = "Branch ID:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(23, 42);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(65, 13);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "User Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.BranshComboBox);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(branch_IDLabel);
            this.groupBox1.Controls.Add(passwordsLabel);
            this.groupBox1.Controls.Add(this.passwordsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // BranshComboBox
            // 
            this.BranshComboBox.DataSource = this.branchBindingSource;
            // 
            // BranshComboBox.NestedRadGridView
            // 
            this.BranshComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.BranshComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.BranshComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.BranshComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BranshComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BranshComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.BranshComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.BranshComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.BranshComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.BranshComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.BranshComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 23;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Branch_Name";
            gridViewTextBoxColumn1.HeaderText = "Branch_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Branch_Name";
            gridViewTextBoxColumn1.Width = 49;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Branch_Description";
            gridViewTextBoxColumn2.HeaderText = "Branch_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Branch_Description";
            gridViewTextBoxColumn2.Width = 43;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "CreatedDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "CreatedDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CreatedDate";
            gridViewDateTimeColumn1.Width = 64;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Manager_ID";
            gridViewDecimalColumn2.HeaderText = "Manager_ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Manager_ID";
            gridViewDecimalColumn2.Width = 44;
            this.BranshComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn2});
            this.BranshComboBox.EditorControl.MasterTemplate.DataSource = this.branchBindingSource;
            this.BranshComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.BranshComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.BranshComboBox.EditorControl.Name = "NestedRadGridView";
            this.BranshComboBox.EditorControl.ReadOnly = true;
            this.BranshComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BranshComboBox.EditorControl.ShowGroupPanel = false;
            this.BranshComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.BranshComboBox.EditorControl.TabIndex = 0;
            this.BranshComboBox.Location = new System.Drawing.Point(92, 120);
            this.BranshComboBox.Name = "BranshComboBox";
            this.BranshComboBox.Size = new System.Drawing.Size(209, 20);
            this.BranshComboBox.TabIndex = 8;
            this.BranshComboBox.TabStop = false;
            this.BranshComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(92, 39);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.userNameTextBox.TabIndex = 7;
            // 
            // passwordsTextBox
            // 
            this.passwordsTextBox.Location = new System.Drawing.Point(92, 78);
            this.passwordsTextBox.Name = "passwordsTextBox";
            this.passwordsTextBox.PasswordChar = '*';
            this.passwordsTextBox.Size = new System.Drawing.Size(209, 20);
            this.passwordsTextBox.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(6, 163);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(XamaDataLayer.Branch);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 234);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranshComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordsTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox BranshComboBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
