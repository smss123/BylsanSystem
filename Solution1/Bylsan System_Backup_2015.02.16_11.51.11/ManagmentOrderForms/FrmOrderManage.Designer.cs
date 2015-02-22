namespace Bylsan_System.ManagmentOrderForms
{
    partial class FrmOrderManage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVOrders = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVOrders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // DGVOrders
            // 
            this.DGVOrders.BackColor = System.Drawing.SystemColors.Control;
            this.DGVOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOrders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVOrders.Location = new System.Drawing.Point(3, 18);
            // 
            // DGVOrders
            // 
            this.DGVOrders.MasterTemplate.AutoGenerateColumns = false;
            this.DGVOrders.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "OrderName";
            gridViewTextBoxColumn2.HeaderText = "Order Name";
            gridViewTextBoxColumn2.Name = "OrderName";
            gridViewTextBoxColumn2.Width = 166;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "OrderDate";
            gridViewTextBoxColumn3.HeaderText = "Order Date";
            gridViewTextBoxColumn3.Name = "OrdDate";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "OrderType";
            gridViewTextBoxColumn4.HeaderText = "Order Type";
            gridViewTextBoxColumn4.Name = "OrderType";
            gridViewTextBoxColumn4.Width = 74;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "OrderVerify";
            gridViewTextBoxColumn5.HeaderText = "Order Verify";
            gridViewTextBoxColumn5.Name = "OrderVerify";
            gridViewTextBoxColumn5.Width = 76;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "OrderDeliveryDate";
            gridViewTextBoxColumn6.HeaderText = "Delivery Date";
            gridViewTextBoxColumn6.Name = "ColDevliverDate";
            gridViewTextBoxColumn6.Width = 76;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "DeliverdToBranch";
            gridViewTextBoxColumn7.HeaderText = "Deliverd To Branch";
            gridViewTextBoxColumn7.Name = "DeliverdToBranch";
            gridViewTextBoxColumn7.Width = 98;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "OrderStatus";
            gridViewTextBoxColumn8.HeaderText = "Order Status";
            gridViewTextBoxColumn8.Name = "OrderStatus";
            gridViewTextBoxColumn8.Width = 59;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Customer.CustomerName";
            gridViewTextBoxColumn9.HeaderText = "Customer";
            gridViewTextBoxColumn9.Name = "Customer";
            gridViewTextBoxColumn9.Width = 84;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Customer.PhoneNumber";
            gridViewTextBoxColumn10.HeaderText = "Customer PhoneNumber";
            gridViewTextBoxColumn10.Name = "PhoneNumber";
            gridViewTextBoxColumn10.Width = 62;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Comment";
            gridViewTextBoxColumn11.HeaderText = "Comment";
            gridViewTextBoxColumn11.Name = "Comment";
            gridViewTextBoxColumn11.Width = 155;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.MaxWidth = 45;
            gridViewCommandColumn1.MinWidth = 45;
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.HeaderText = "Print Bracode";
            gridViewCommandColumn2.Name = "printParcode";
            this.DGVOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.DGVOrders.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "ID";
            this.DGVOrders.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVOrders.Size = new System.Drawing.Size(1115, 345);
            this.DGVOrders.TabIndex = 2;
            this.DGVOrders.Text = "radGridView1";
            this.DGVOrders.ThemeName = "Office2010Black";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refreshbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1121, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.Refreshbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Refreshbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(82, 36);
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmOrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmOrderManage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Manage";
            this.ThemeName = "Office2010Black";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrderManage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Refreshbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGridView DGVOrders;
    }
}