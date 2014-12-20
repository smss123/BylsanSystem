namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_StoreWithDrawal
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
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label commentLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.CmbItems = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            itemNameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(7, 28);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(64, 13);
            itemNameLabel.TabIndex = 1;
            itemNameLabel.Text = "Item Name:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(41, 54);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(27, 13);
            qtyLabel.TabIndex = 2;
            qtyLabel.Text = "Qty:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 80);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(59, 13);
            commentLabel.TabIndex = 4;
            commentLabel.Text = "Comment:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(commentLabel);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.CmbItems);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addbtn.Location = new System.Drawing.Point(73, 154);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 37);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.ThemeName = "VisualStudio2012Light";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.commentTextBox.Location = new System.Drawing.Point(73, 77);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(232, 44);
            this.commentTextBox.TabIndex = 2;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyTextBox.Location = new System.Drawing.Point(73, 51);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(232, 20);
            this.qtyTextBox.TabIndex = 1;
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // CmbItems
            // 
            this.CmbItems.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // CmbItems.NestedRadGridView
            // 
            this.CmbItems.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbItems.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmbItems.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbItems.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbItems.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmbItems.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // CmbItems.NestedRadGridView
            // 
            this.CmbItems.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbItems.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbItems.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbItems.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.CmbItems.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 56;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ItemName";
            gridViewTextBoxColumn1.HeaderText = "ItemName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ItemName";
            gridViewTextBoxColumn1.Width = 56;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ItemType";
            gridViewTextBoxColumn2.HeaderText = "ItemType";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ItemType";
            gridViewTextBoxColumn2.Width = 56;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ItemDescription";
            gridViewTextBoxColumn3.HeaderText = "ItemDescription";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ItemDescription";
            gridViewTextBoxColumn3.Width = 54;
            this.CmbItems.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.CmbItems.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbItems.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbItems.EditorControl.Name = "NestedRadGridView";
            this.CmbItems.EditorControl.ReadOnly = true;
            this.CmbItems.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbItems.EditorControl.ShowGroupPanel = false;
            this.CmbItems.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbItems.EditorControl.TabIndex = 0;
            this.CmbItems.Location = new System.Drawing.Point(73, 25);
            this.CmbItems.Name = "CmbItems";
            this.CmbItems.Size = new System.Drawing.Size(232, 20);
            this.CmbItems.TabIndex = 0;
            this.CmbItems.TabStop = false;
            this.CmbItems.ThemeName = "VisualStudio2012Light";
            this.CmbItems.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_StoreWithDrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(421, 309);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddMainStore_StoreWithDrawal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMainStore_StoreWithDrawal";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmAddMainStore_StoreWithDrawal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbItems;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}