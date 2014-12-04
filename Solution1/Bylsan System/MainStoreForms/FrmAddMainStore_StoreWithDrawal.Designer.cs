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
            System.Windows.Forms.Label storeIDLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.StoreComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.ItemComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            itemNameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).BeginInit();
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
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(20, 131);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(51, 13);
            storeIDLabel.TabIndex = 6;
            storeIDLabel.Text = "Store ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(this.StoreComboBox);
            this.groupBox1.Controls.Add(storeIDLabel);
            this.groupBox1.Controls.Add(commentLabel);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.ItemComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addbtn.Location = new System.Drawing.Point(12, 175);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 37);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.ThemeName = "VisualStudio2012Light";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // StoreComboBox
            // 
            // 
            // StoreComboBox.NestedRadGridView
            // 
            this.StoreComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.StoreComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.StoreComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StoreComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.StoreComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.StoreComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.StoreComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.StoreComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.StoreComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.StoreComboBox.EditorControl.Name = "NestedRadGridView";
            this.StoreComboBox.EditorControl.ReadOnly = true;
            this.StoreComboBox.EditorControl.ShowGroupPanel = false;
            this.StoreComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.StoreComboBox.EditorControl.TabIndex = 0;
            this.StoreComboBox.Location = new System.Drawing.Point(73, 128);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(232, 20);
            this.StoreComboBox.TabIndex = 3;
            this.StoreComboBox.TabStop = false;
            this.StoreComboBox.ThemeName = "VisualStudio2012Light";
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
            // ItemComboBox
            // 
            // 
            // ItemComboBox.NestedRadGridView
            // 
            this.ItemComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ItemComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ItemComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ItemComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ItemComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ItemComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ItemComboBox.EditorControl.Name = "NestedRadGridView";
            this.ItemComboBox.EditorControl.ReadOnly = true;
            this.ItemComboBox.EditorControl.ShowGroupPanel = false;
            this.ItemComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ItemComboBox.EditorControl.TabIndex = 0;
            this.ItemComboBox.Location = new System.Drawing.Point(73, 25);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(232, 20);
            this.ItemComboBox.TabIndex = 0;
            this.ItemComboBox.TabStop = false;
            this.ItemComboBox.ThemeName = "VisualStudio2012Light";
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
            this.ClientSize = new System.Drawing.Size(350, 255);
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
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemComboBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox StoreComboBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}