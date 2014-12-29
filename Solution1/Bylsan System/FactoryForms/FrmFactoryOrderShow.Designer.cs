namespace Bylsan_System.FactoryForms
{
    partial class FrmFactoryOrderShow
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DGVOrders = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ID";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.Name = "ID";
            gridViewTextBoxColumn4.Width = 79;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "OrderName";
            gridViewTextBoxColumn5.HeaderText = "Order Name";
            gridViewTextBoxColumn5.Name = "OrderName";
            gridViewTextBoxColumn5.Width = 299;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "OrderDate";
            gridViewTextBoxColumn6.HeaderText = "Order Date";
            gridViewTextBoxColumn6.Name = "OrdDate";
            gridViewTextBoxColumn6.Width = 201;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Enter";
            gridViewCommandColumn2.Name = "EnterBtn";
            gridViewCommandColumn2.Width = 48;
            this.DGVOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn2});
            this.DGVOrders.MasterTemplate.EnableFiltering = true;
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVOrders.Size = new System.Drawing.Size(643, 436);
            this.DGVOrders.TabIndex = 1;
            this.DGVOrders.Text = "DGVOrders";
            this.DGVOrders.ThemeName = "VisualStudio2012Light";
            this.DGVOrders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            this.DGVOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGVOrders_MouseDoubleClick_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refreshbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Image = global::Bylsan_System.Properties.Resources.Refrech;
            this.Refreshbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Refreshbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(79, 36);
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVOrders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 457);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // FrmFactoryOrderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmFactoryOrderShow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactoryOrderShow";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmFactoryOrderShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGridView DGVOrders;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Refreshbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
