﻿namespace Bylsan_System.AccountsX
{
    partial class FrmManageDebtors
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DebeorGridView = new Telerik.WinControls.UI.RadGridView();
            this.debtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebeorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebeorGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DebeorGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DebeorGridView
            // 
            this.DebeorGridView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DebeorGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DebeorGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebeorGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DebeorGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebeorGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DebeorGridView.Location = new System.Drawing.Point(3, 18);
            // 
            // DebeorGridView
            // 
            this.DebeorGridView.MasterTemplate.AllowAddNewRow = false;
            this.DebeorGridView.MasterTemplate.AutoGenerateColumns = false;
            this.DebeorGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "DebtorName";
            gridViewTextBoxColumn1.HeaderText = "DebtorName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "DebtorName";
            gridViewTextBoxColumn1.Width = 161;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "DebtorDescription";
            gridViewTextBoxColumn2.HeaderText = "DebtorDescription";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "DebtorDescription";
            gridViewTextBoxColumn2.Width = 161;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Addresss";
            gridViewTextBoxColumn3.HeaderText = "Addresss";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Addresss";
            gridViewTextBoxColumn3.Width = 139;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "PhoneNumber";
            gridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "PhoneNumber";
            gridViewTextBoxColumn4.Width = 123;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "AccountID";
            gridViewDecimalColumn2.HeaderText = "AccountID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "AccountID";
            gridViewDecimalColumn2.Width = 84;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 55;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Show Account";
            gridViewCommandColumn2.Name = "ShowAccount";
            gridViewCommandColumn2.Width = 60;
            this.DebeorGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.DebeorGridView.MasterTemplate.DataSource = this.debtorBindingSource;
            this.DebeorGridView.MasterTemplate.EnableFiltering = true;
            this.DebeorGridView.Name = "DebeorGridView";
            this.DebeorGridView.ReadOnly = true;
            this.DebeorGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DebeorGridView.Size = new System.Drawing.Size(796, 451);
            this.DebeorGridView.TabIndex = 0;
            this.DebeorGridView.ThemeName = "VisualStudio2012Light";
            // 
            // debtorBindingSource
            // 
            this.debtorBindingSource.DataSource = typeof(XamaDataLayer.Debtor);
            // 
            // FrmManageDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageDebtors";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageDebtors";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebeorGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebeorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView DebeorGridView;
        private System.Windows.Forms.BindingSource debtorBindingSource;
    }
}