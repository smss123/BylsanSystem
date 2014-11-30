namespace Bylsan_System.designerForms
{
    partial class FrmOrderShow
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVOrders = new Telerik.WinControls.UI.RadGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVOrders);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // DGVOrders
            // 
            this.DGVOrders.BackColor = System.Drawing.SystemColors.Control;
            this.DGVOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVOrders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVOrders.Location = new System.Drawing.Point(3, 16);
            // 
            // DGVOrders
            // 
            this.DGVOrders.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.Width = 72;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "OrderName";
            gridViewTextBoxColumn2.HeaderText = "Order Name";
            gridViewTextBoxColumn2.Name = "OrderName";
            gridViewTextBoxColumn2.Width = 271;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Enter";
            gridViewCommandColumn1.Name = "EnterColm";
            gridViewCommandColumn1.Width = 109;
            gridViewTextBoxColumn3.FieldName = "OrderDate";
            gridViewTextBoxColumn3.HeaderText = "Order Date";
            gridViewTextBoxColumn3.Name = "OrdDate";
            gridViewTextBoxColumn3.Width = 182;
            this.DGVOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewTextBoxColumn3});
            this.DGVOrders.MasterTemplate.EnableFiltering = true;
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVOrders.Size = new System.Drawing.Size(652, 471);
            this.DGVOrders.TabIndex = 1;
            this.DGVOrders.Text = "radGridView1";
            this.DGVOrders.ThemeName = "Windows8";
            this.DGVOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGVOrders_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmOrderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 515);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderShow";
            this.Text = "FrmOrderShow";
            this.Load += new System.EventHandler(this.FrmOrderShow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView DGVOrders;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}