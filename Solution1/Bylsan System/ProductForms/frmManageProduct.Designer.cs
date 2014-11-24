using System.Drawing;
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.ProductGridView = new Telerik.WinControls.UI.RadGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
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
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.Width = 171;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Product_Name";
            gridViewTextBoxColumn4.HeaderText = "Product_Name";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Product_Name";
            gridViewTextBoxColumn4.Width = 171;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Product_Description";
            gridViewTextBoxColumn5.HeaderText = "Product_Description";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Product_Description";
            gridViewTextBoxColumn5.Width = 171;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "CateogryID";
            gridViewDecimalColumn4.HeaderText = "CateogryID";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "CateogryID";
            gridViewDecimalColumn4.Width = 171;
            gridViewTextBoxColumn6.DataType = typeof(System.Drawing.Image);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Img";
            gridViewTextBoxColumn6.HeaderText = "Img";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Img";
            gridViewTextBoxColumn6.Width = 171;
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "Edit";
            gridViewCommandColumn3.Name = "EditCol";
            gridViewCommandColumn3.Width = 71;
            gridViewCommandColumn4.EnableExpressionEditor = false;
            gridViewCommandColumn4.HeaderText = "Delete";
            gridViewCommandColumn4.Name = "DeleteCol";
            gridViewCommandColumn4.Width = 73;
            this.ProductGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn6,
            gridViewCommandColumn3,
            gridViewCommandColumn4});
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.Text = "Manage Product";
            this.Load += new System.EventHandler(this.frmManageProduct_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}