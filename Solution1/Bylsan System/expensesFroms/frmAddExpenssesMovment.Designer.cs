namespace Bylsan_System.expensesFroms
{
    partial class frmAddExpenssesMovment
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccountsComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(26, 31);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(51, 13);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AccountsComboBox);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AccountsComboBox
            // 
            // 
            // AccountsComboBox.NestedRadGridView
            // 
            this.AccountsComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.AccountsComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccountsComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AccountsComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccountsComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountsComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ID";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "AccountName";
            gridViewTextBoxColumn3.HeaderText = "AccountName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "AccountName";
            gridViewTextBoxColumn3.Width = 159;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.HeaderText = "Description";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Description";
            gridViewTextBoxColumn4.Width = 198;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "CategoryID";
            gridViewDecimalColumn4.HeaderText = "CategoryID";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "CategoryID";
            gridViewDecimalColumn4.Width = 169;
            this.AccountsComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn4});
            this.AccountsComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.AccountsComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.AccountsComboBox.EditorControl.Name = "NestedRadGridView";
            this.AccountsComboBox.EditorControl.ReadOnly = true;
            this.AccountsComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountsComboBox.EditorControl.ShowGroupPanel = false;
            this.AccountsComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.AccountsComboBox.EditorControl.TabIndex = 0;
            this.AccountsComboBox.Location = new System.Drawing.Point(83, 186);
            this.AccountsComboBox.Name = "AccountsComboBox";
            this.AccountsComboBox.Size = new System.Drawing.Size(231, 20);
            this.AccountsComboBox.TabIndex = 1;
            this.AccountsComboBox.TabStop = false;
            this.AccountsComboBox.ThemeName = "Office2010Black";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(11, 224);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2010Black";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(83, 63);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(231, 117);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.amountTextBox.Location = new System.Drawing.Point(83, 28);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(162, 20);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddExpenssesMovment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(369, 294);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 324);
            this.Name = "frmAddExpenssesMovment";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(377, 324);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddExpenssesMovment";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmAddExpenssesMovment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox AccountsComboBox;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}
