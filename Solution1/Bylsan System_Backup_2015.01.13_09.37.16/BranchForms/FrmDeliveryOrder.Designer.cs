﻿namespace Bylsan_System.BranchForms
{
    partial class FrmDeliveryOrder
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.OkeyBtn = new System.Windows.Forms.Button();
            this.DGVDelivery = new Telerik.WinControls.UI.RadGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(917, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(917, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.OkeyBtn);
            this.radGroupBox1.Controls.Add(this.DGVDelivery);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Order Data";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 25);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(917, 494);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Order Data";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // OkeyBtn
            // 
            this.OkeyBtn.Location = new System.Drawing.Point(798, 452);
            this.OkeyBtn.Name = "OkeyBtn";
            this.OkeyBtn.Size = new System.Drawing.Size(114, 37);
            this.OkeyBtn.TabIndex = 1;
            this.OkeyBtn.Text = "Ok";
            this.OkeyBtn.UseVisualStyleBackColor = true;
            this.OkeyBtn.Click += new System.EventHandler(this.OkeyBtn_Click);
            // 
            // DGVDelivery
            // 
            this.DGVDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDelivery.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVDelivery.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVDelivery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVDelivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVDelivery.Location = new System.Drawing.Point(2, 18);
            // 
            // DGVDelivery
            // 
            this.DGVDelivery.MasterTemplate.AllowAddNewRow = false;
            this.DGVDelivery.MasterTemplate.AutoGenerateColumns = false;
            this.DGVDelivery.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 53;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "OrderName";
            gridViewTextBoxColumn1.HeaderText = "OrderName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "OrderName";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 132;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Customer.CustomerName";
            gridViewTextBoxColumn2.HeaderText = "Customer Name";
            gridViewTextBoxColumn2.Name = "CustomerName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 145;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "OrderType";
            gridViewTextBoxColumn3.HeaderText = "OrderType";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "OrderType";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 132;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "OrderVerify";
            gridViewTextBoxColumn4.HeaderText = "OrderVerify";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "OrderVerify";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 93;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "OrderDeliveryDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "OrderDeliveryDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "OrderDeliveryDate";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 123;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Branch.Branch_Name";
            gridViewTextBoxColumn5.HeaderText = "Branch Name";
            gridViewTextBoxColumn5.Name = "Branch_Name";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 114;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.HeaderText = "Check";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "CheckOreder";
            gridViewCheckBoxColumn1.Width = 61;
            gridViewCommandColumn1.DefaultText = "Show this Order";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "ShowOrder";
            gridViewCommandColumn1.Name = "ShowOrderCol";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 101;
            this.DGVDelivery.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn1,
            gridViewCommandColumn1});
            this.DGVDelivery.MasterTemplate.DataSource = this.orderBindingSource;
            sortDescriptor1.PropertyName = "ID";
            this.DGVDelivery.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.DGVDelivery.Name = "DGVDelivery";
            this.DGVDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVDelivery.Size = new System.Drawing.Size(913, 428);
            this.DGVDelivery.TabIndex = 0;
            this.DGVDelivery.Text = "radGridView1";
            this.DGVDelivery.ThemeName = "VisualStudio2012Light";
            this.DGVDelivery.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DGVDelivery_CommandCellClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(XamaDataLayer.Order);
            // 
            // FrmDeliveryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(917, 541);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDeliveryOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmDeliveryOrder";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmDeliveryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView DGVDelivery;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button OkeyBtn;
    }
}
