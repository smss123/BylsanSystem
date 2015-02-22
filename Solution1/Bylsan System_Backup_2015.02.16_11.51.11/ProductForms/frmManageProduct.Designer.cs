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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProduct));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintBarcode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProductManagmentBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.ProductGridView = new Telerik.WinControls.UI.RadGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator3,
            this.btnPrintBarcode,
            this.toolStripSeparator2,
            this.ProductManagmentBtn,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Bylsan_System.Properties.Resources.Add;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 37);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(82, 37);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBarcode.Image")));
            this.btnPrintBarcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintBarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(119, 37);
            this.btnPrintBarcode.Text = "Print Bar Code";
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // ProductManagmentBtn
            // 
            this.ProductManagmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductManagmentBtn.Image")));
            this.ProductManagmentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductManagmentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductManagmentBtn.Name = "ProductManagmentBtn";
            this.ProductManagmentBtn.Size = new System.Drawing.Size(151, 37);
            this.ProductManagmentBtn.Text = "Product Managment";
            this.ProductManagmentBtn.Click += new System.EventHandler(this.ProductManagmentBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "*";
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(this.ProductGridView);
            this.ProductgroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductgroupBox.Location = new System.Drawing.Point(0, 40);
            this.ProductgroupBox.Name = "ProductgroupBox";
            this.ProductgroupBox.Size = new System.Drawing.Size(1020, 543);
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
            this.ProductGridView.Location = new System.Drawing.Point(3, 18);
            // 
            // ProductGridView
            // 
            this.ProductGridView.MasterTemplate.AutoGenerateColumns = false;
            this.ProductGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductPrice";
            gridViewTextBoxColumn3.HeaderText = "Price";
            gridViewTextBoxColumn3.Name = "ColPrice";
            gridViewTextBoxColumn3.Width = 130;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "CateogryID";
            gridViewDecimalColumn2.HeaderText = "CateogryID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "CateogryID";
            gridViewDecimalColumn2.Width = 143;
            gridViewCommandColumn1.DefaultText = "Edit";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 46;
            gridViewCommandColumn2.DefaultText = "Delete";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Delete";
            gridViewCommandColumn2.Name = "DeleteCol";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 43;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "Img";
            gridViewImageColumn1.HeaderText = "column1";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gridViewImageColumn1.Name = "column1";
            gridViewImageColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewImageColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            gridViewImageColumn1.Width = 54;
            gridViewCommandColumn3.DefaultText = "Componant";
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.Name = "column2";
            gridViewCommandColumn3.UseDefaultText = true;
            gridViewCommandColumn3.Width = 73;
            this.ProductGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewImageColumn1,
            gridViewCommandColumn3});
            this.ProductGridView.MasterTemplate.DataSource = this.productBindingSource;
            this.ProductGridView.MasterTemplate.EnableFiltering = true;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductGridView.Size = new System.Drawing.Size(1014, 522);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.Text = "radGridView1";
            this.ProductGridView.ThemeName = "Office2010Black";
            this.ProductGridView.Click += new System.EventHandler(this.ProductGridView_Click);
            // 
            // frmManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 605);
            this.Controls.Add(this.ProductgroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmManageProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Product";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmManageProduct_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ProductgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox ProductgroupBox;
        private Telerik.WinControls.UI.RadGridView ProductGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripButton btnPrintBarcode;
        private System.Windows.Forms.ToolStripButton ProductManagmentBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}