﻿namespace Bylsan_System.AccountsX
{
    partial class FrmPrivatewithdrawals
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.CmbToAccount = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.CmbFromAccount = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvailableAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radButton1);
            this.groupBox1.Controls.Add(this.CmbToAccount);
            this.groupBox1.Controls.Add(this.CmbFromAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAvailableAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Private withdrawals";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::Bylsan_System.Properties.Resources.Save;
            this.radButton1.Location = new System.Drawing.Point(16, 217);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 37);
            this.radButton1.TabIndex = 17;
            this.radButton1.Text = "Save";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.ThemeName = "Office2010Black";
            this.radButton1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CmbToAccount
            // 
            this.CmbToAccount.DisplayMember = "AccountName";
            // 
            // CmbToAccount.NestedRadGridView
            // 
            this.CmbToAccount.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbToAccount.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbToAccount.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbToAccount.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbToAccount.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmbToAccount.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbToAccount.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 64;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "AccountName";
            gridViewTextBoxColumn1.HeaderText = "AccountName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "AccountName";
            gridViewTextBoxColumn1.Width = 74;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 76;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "AccountCategory.AccountCategoryName";
            gridViewTextBoxColumn3.HeaderText = "Category";
            gridViewTextBoxColumn3.Name = "Category";
            gridViewTextBoxColumn3.Width = 72;
            this.CmbToAccount.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.CmbToAccount.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbToAccount.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbToAccount.EditorControl.Name = "NestedRadGridView";
            this.CmbToAccount.EditorControl.ReadOnly = true;
            this.CmbToAccount.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbToAccount.EditorControl.ShowGroupPanel = false;
            this.CmbToAccount.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbToAccount.EditorControl.TabIndex = 0;
            this.CmbToAccount.Location = new System.Drawing.Point(84, 99);
            this.CmbToAccount.Name = "CmbToAccount";
            this.CmbToAccount.Size = new System.Drawing.Size(312, 20);
            this.CmbToAccount.TabIndex = 16;
            this.CmbToAccount.TabStop = false;
            this.CmbToAccount.ThemeName = "Office2010Black";
            // 
            // CmbFromAccount
            // 
            this.CmbFromAccount.DisplayMember = "AccountName";
            // 
            // CmbFromAccount.NestedRadGridView
            // 
            this.CmbFromAccount.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbFromAccount.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbFromAccount.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbFromAccount.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbFromAccount.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmbFromAccount.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn2.Width = 57;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "AccountName";
            gridViewTextBoxColumn4.HeaderText = "AccountName";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "AccountName";
            gridViewTextBoxColumn4.Width = 78;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Description";
            gridViewTextBoxColumn5.HeaderText = "Description";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Description";
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "AccountCategory.AccountCategoryName";
            gridViewTextBoxColumn6.HeaderText = "Category";
            gridViewTextBoxColumn6.Name = "Category";
            gridViewTextBoxColumn6.Width = 64;
            this.CmbFromAccount.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.CmbFromAccount.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor1.PropertyName = "ID";
            this.CmbFromAccount.EditorControl.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.CmbFromAccount.EditorControl.Name = "NestedRadGridView";
            this.CmbFromAccount.EditorControl.ReadOnly = true;
            this.CmbFromAccount.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbFromAccount.EditorControl.ShowGroupPanel = false;
            this.CmbFromAccount.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbFromAccount.EditorControl.TabIndex = 0;
            this.CmbFromAccount.Location = new System.Drawing.Point(84, 73);
            this.CmbFromAccount.Name = "CmbFromAccount";
            this.CmbFromAccount.Size = new System.Drawing.Size(312, 20);
            this.CmbFromAccount.TabIndex = 15;
            this.CmbFromAccount.TabStop = false;
            this.CmbFromAccount.ThemeName = "Office2010Black";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "The Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(92, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(85, 23);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "From:";
            // 
            // lblAvailableAmount
            // 
            this.lblAvailableAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvailableAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableAmount.Location = new System.Drawing.Point(314, 36);
            this.lblAvailableAmount.Name = "lblAvailableAmount";
            this.lblAvailableAmount.Size = new System.Drawing.Size(82, 23);
            this.lblAvailableAmount.TabIndex = 4;
            this.lblAvailableAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Amount:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(84, 137);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 70);
            this.txtDescription.TabIndex = 2;
            // 
            // FrmPrivatewithdrawals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrivatewithdrawals";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Private withdrawals";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmPrivatewithdrawals_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvailableAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbToAccount;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbFromAccount;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}