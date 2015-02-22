namespace Bylsan_System.BranchForms
{
    partial class frmTransferItems
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
            System.Windows.Forms.Label branchIDLabel;
            System.Windows.Forms.Label branchIDLabel1;
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label qtyLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.frombranch = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.toBranch = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemSelectedcombo = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItemQty = new Telerik.WinControls.UI.RadLabel();
            this.lblItemName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            branchIDLabel = new System.Windows.Forms.Label();
            branchIDLabel1 = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frombranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frombranch.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frombranch.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch.EditorControl.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo.EditorControl.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // branchIDLabel
            // 
            branchIDLabel.AutoSize = true;
            branchIDLabel.Location = new System.Drawing.Point(14, 21);
            branchIDLabel.Name = "branchIDLabel";
            branchIDLabel.Size = new System.Drawing.Size(76, 13);
            branchIDLabel.TabIndex = 1;
            branchIDLabel.Text = "from branch :";
            // 
            // branchIDLabel1
            // 
            branchIDLabel1.AutoSize = true;
            branchIDLabel1.Location = new System.Drawing.Point(30, 56);
            branchIDLabel1.Name = "branchIDLabel1";
            branchIDLabel1.Size = new System.Drawing.Size(64, 13);
            branchIDLabel1.TabIndex = 3;
            branchIDLabel1.Text = "To branch :";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(54, 85);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(35, 13);
            itemIDLabel.TabIndex = 5;
            itemIDLabel.Text = "Item :";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(42, 251);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(72, 13);
            qtyLabel.TabIndex = 7;
            qtyLabel.Text = "Transfer Qty:";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyTextBox.Location = new System.Drawing.Point(115, 251);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(261, 20);
            this.qtyTextBox.TabIndex = 8;
            // 
            // frombranch
            // 
            this.frombranch.BackColor = System.Drawing.SystemColors.Info;
            this.frombranch.DisplayMember = "Branch_Name";
            // 
            // frombranch.NestedRadGridView
            // 
            this.frombranch.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.frombranch.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.frombranch.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frombranch.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.frombranch.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.frombranch.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.frombranch.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.frombranch.EditorControl.MasterTemplate.EnableGrouping = false;
            this.frombranch.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.frombranch.EditorControl.Name = "NestedRadGridView";
            this.frombranch.EditorControl.ReadOnly = true;
            this.frombranch.EditorControl.ShowGroupPanel = false;
            this.frombranch.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.frombranch.EditorControl.TabIndex = 0;
            this.frombranch.Location = new System.Drawing.Point(94, 21);
            this.frombranch.Name = "frombranch";
            this.frombranch.Size = new System.Drawing.Size(368, 20);
            this.frombranch.TabIndex = 9;
            this.frombranch.TabStop = false;
            this.frombranch.ThemeName = "Office2010Black";
            this.frombranch.ValueMember = "ID";
            // 
            // toBranch
            // 
            this.toBranch.BackColor = System.Drawing.SystemColors.Info;
            this.toBranch.DisplayMember = "Branch_Name";
            // 
            // toBranch.NestedRadGridView
            // 
            this.toBranch.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.toBranch.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.toBranch.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.toBranch.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toBranch.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toBranch.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.toBranch.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.toBranch.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.toBranch.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.toBranch.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.toBranch.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.toBranch.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 56;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Branch_Name";
            gridViewTextBoxColumn1.HeaderText = "Branch_Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Branch_Name";
            gridViewTextBoxColumn1.Width = 56;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Branch_Description";
            gridViewTextBoxColumn2.HeaderText = "Branch_Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Branch_Description";
            gridViewTextBoxColumn2.Width = 56;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "CreatedDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "CreatedDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CreatedDate";
            gridViewDateTimeColumn1.Width = 55;
            this.toBranch.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1});
            this.toBranch.EditorControl.MasterTemplate.EnableFiltering = true;
            this.toBranch.EditorControl.MasterTemplate.EnableGrouping = false;
            this.toBranch.EditorControl.MasterTemplate.EnablePaging = true;
            this.toBranch.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.toBranch.EditorControl.Name = "NestedRadGridView";
            this.toBranch.EditorControl.ReadOnly = true;
            this.toBranch.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toBranch.EditorControl.ShowGroupPanel = false;
            this.toBranch.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.toBranch.EditorControl.TabIndex = 0;
            this.toBranch.Location = new System.Drawing.Point(94, 53);
            this.toBranch.Name = "toBranch";
            this.toBranch.Size = new System.Drawing.Size(368, 20);
            this.toBranch.TabIndex = 10;
            this.toBranch.TabStop = false;
            this.toBranch.ThemeName = "Office2010Black";
            this.toBranch.ValueMember = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemSelectedcombo);
            this.groupBox1.Controls.Add(this.toBranch);
            this.groupBox1.Controls.Add(this.frombranch);
            this.groupBox1.Controls.Add(itemIDLabel);
            this.groupBox1.Controls.Add(branchIDLabel1);
            this.groupBox1.Controls.Add(branchIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // itemSelectedcombo
            // 
            this.itemSelectedcombo.DisplayMember = "Product_Name";
            // 
            // itemSelectedcombo.NestedRadGridView
            // 
            this.itemSelectedcombo.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.itemSelectedcombo.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemSelectedcombo.EditorControl.EnableCustomFiltering = true;
            this.itemSelectedcombo.EditorControl.EnableCustomGrouping = true;
            this.itemSelectedcombo.EditorControl.EnableCustomSorting = true;
            this.itemSelectedcombo.EditorControl.EnableFastScrolling = true;
            this.itemSelectedcombo.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.itemSelectedcombo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemSelectedcombo.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemSelectedcombo.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.itemSelectedcombo.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AutoExpandGroups = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.itemSelectedcombo.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.Width = 37;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Product_Name";
            gridViewTextBoxColumn3.HeaderText = "Product_Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Product_Name";
            gridViewTextBoxColumn3.Width = 37;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Product_Description";
            gridViewTextBoxColumn4.HeaderText = "Product_Description";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Product_Description";
            gridViewTextBoxColumn4.Width = 37;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PublicName";
            gridViewTextBoxColumn5.HeaderText = "PublicName";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "PublicName";
            gridViewTextBoxColumn5.Width = 37;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ProductPrice";
            gridViewDecimalColumn3.HeaderText = "ProductPrice";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ProductPrice";
            gridViewDecimalColumn3.Width = 37;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ProductUnit";
            gridViewTextBoxColumn6.HeaderText = "ProductUnit";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ProductUnit";
            gridViewTextBoxColumn6.Width = 40;
            this.itemSelectedcombo.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn6});
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnableCustomFiltering = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnableCustomGrouping = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnableCustomSorting = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnableFiltering = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnableGrouping = false;
            this.itemSelectedcombo.EditorControl.MasterTemplate.EnablePaging = true;
            this.itemSelectedcombo.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.itemSelectedcombo.EditorControl.Name = "NestedRadGridView";
            this.itemSelectedcombo.EditorControl.ReadOnly = true;
            this.itemSelectedcombo.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemSelectedcombo.EditorControl.ShowGroupPanel = false;
            this.itemSelectedcombo.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.itemSelectedcombo.EditorControl.TabIndex = 0;
            this.itemSelectedcombo.Location = new System.Drawing.Point(94, 85);
            this.itemSelectedcombo.Name = "itemSelectedcombo";
            this.itemSelectedcombo.Size = new System.Drawing.Size(368, 20);
            this.itemSelectedcombo.TabIndex = 11;
            this.itemSelectedcombo.TabStop = false;
            this.itemSelectedcombo.ThemeName = "Office2010Black";
            this.itemSelectedcombo.ValueMember = "ID";
            this.itemSelectedcombo.DropDownClosed += new Telerik.WinControls.UI.RadPopupClosedEventHandler(this.itemSelectedcombo_DropDownClosed);
            this.itemSelectedcombo.SelectedIndexChanged += new System.EventHandler(this.itemSelectedcombo_SelectedIndexChanged);
            this.itemSelectedcombo.TextChanged += new System.EventHandler(this.itemSelectedcombo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblItemQty);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Controls.Add(this.radLabel3);
            this.groupBox2.Controls.Add(this.radLabel1);
            this.groupBox2.Location = new System.Drawing.Point(35, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 89);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // lblItemQty
            // 
            this.lblItemQty.Location = new System.Drawing.Point(84, 50);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(20, 18);
            this.lblItemQty.TabIndex = 0;
            this.lblItemQty.Text = "---";
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(91, 26);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(20, 18);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "---";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(28, 50);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(50, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Item Qty";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(23, 26);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Item Name";
            // 
            // btnOk
            // 
            this.btnOk.Image = global::Bylsan_System.Properties.Resources.Save;
            this.btnOk.Location = new System.Drawing.Point(14, 299);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 38);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Oky";
            this.btnOk.ThemeName = "Office2010Black";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmTransferItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 349);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Name = "frmTransferItems";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Product";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmTransferItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frombranch.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frombranch.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frombranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBranch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectedcombo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtyTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox frombranch;
        private Telerik.WinControls.UI.RadMultiColumnComboBox toBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadLabel lblItemQty;
        private Telerik.WinControls.UI.RadLabel lblItemName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnOk;
        private Telerik.WinControls.UI.RadMultiColumnComboBox itemSelectedcombo;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}