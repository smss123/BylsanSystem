namespace Bylsan_System.ProductForms
{
    partial class frmManageProduct
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.ProductGridView = new Telerik.WinControls.UI.RadGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(this.ProductGridView);
            this.ProductgroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductgroupBox.Location = new System.Drawing.Point(0, 25);
            this.ProductgroupBox.Name = "ProductgroupBox";
            this.ProductgroupBox.Size = new System.Drawing.Size(1020, 558);
            this.ProductgroupBox.TabIndex = 2;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Product Data";
            // 
            // ProductGridView
            // 
            this.ProductGridView.BackColor = System.Drawing.SystemColors.Control;
            this.ProductGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProductGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductGridView.Location = new System.Drawing.Point(3, 16);
            // 
            // ProductGridView
            // 
            this.ProductGridView.MasterTemplate.AutoGenerateColumns = false;
            this.ProductGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 171;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product_Name";
            gridViewTextBoxColumn1.Width = 171;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product_Description";
            gridViewTextBoxColumn2.HeaderText = "Product_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Product_Description";
            gridViewTextBoxColumn2.Width = 171;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "CateogryID";
            gridViewDecimalColumn2.HeaderText = "CateogryID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "CateogryID";
            gridViewDecimalColumn2.Width = 171;
            gridViewTextBoxColumn3.DataType = typeof(System.Data.Linq.Binary);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Img";
            gridViewTextBoxColumn3.HeaderText = "Img";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Img";
            gridViewTextBoxColumn3.Width = 171;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 71;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Delete";
            gridViewCommandColumn2.Name = "DeleteCol";
            gridViewCommandColumn2.Width = 73;
            this.ProductGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.ProductGridView.MasterTemplate.DataSource = this.productBindingSource;
            this.ProductGridView.MasterTemplate.EnableFiltering = true;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductGridView.Size = new System.Drawing.Size(1014, 539);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.Text = "radGridView1";
            this.ProductGridView.ThemeName = "Windows8";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // frmManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 605);
            this.Controls.Add(this.ProductgroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmManageProduct";
            this.Text = "frmManageProduct";
            this.ProductgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox ProductgroupBox;
        private Telerik.WinControls.UI.RadGridView ProductGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}