namespace Bylsan_System.MainStoreForms
{
    partial class FrmEditMainStore_Store
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
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label AvailableQtyLabel;
            System.Windows.Forms.Label itemNameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.AvailableQtyTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            DescriptionLabel = new System.Windows.Forms.Label();
            AvailableQtyLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(10, 94);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(69, 13);
            DescriptionLabel.TabIndex = 10;
            DescriptionLabel.Text = "Description:";
            // 
            // AvailableQtyLabel
            // 
            AvailableQtyLabel.AutoSize = true;
            AvailableQtyLabel.Location = new System.Drawing.Point(6, 64);
            AvailableQtyLabel.Name = "AvailableQtyLabel";
            AvailableQtyLabel.Size = new System.Drawing.Size(73, 13);
            AvailableQtyLabel.TabIndex = 6;
            AvailableQtyLabel.Text = "AvailableQty:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(15, 31);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(64, 13);
            itemNameLabel.TabIndex = 5;
            itemNameLabel.Text = "Item Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ItemColumnComboBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(DescriptionLabel);
            this.groupBox1.Controls.Add(AvailableQtyLabel);
            this.groupBox1.Controls.Add(this.AvailableQtyTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Main Store";
            // 
            // ItemColumnComboBox
            // 
            // 
            // ItemColumnComboBox.NestedRadGridView
            // 
            this.ItemColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ItemColumnComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ItemColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemColumnComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // ItemColumnComboBox.NestedRadGridView
            // 
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ItemColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ItemColumnComboBox.EditorControl.Name = "NestedRadGridView";
            this.ItemColumnComboBox.EditorControl.ReadOnly = true;
            this.ItemColumnComboBox.EditorControl.ShowGroupPanel = false;
            this.ItemColumnComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ItemColumnComboBox.EditorControl.TabIndex = 0;
            this.ItemColumnComboBox.Location = new System.Drawing.Point(81, 31);
            this.ItemColumnComboBox.Name = "ItemColumnComboBox";
            this.ItemColumnComboBox.Size = new System.Drawing.Size(274, 20);
            this.ItemColumnComboBox.TabIndex = 1;
            this.ItemColumnComboBox.TabStop = false;
            this.ItemColumnComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(81, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 75);
            this.textBox1.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(19, 186);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "VisualStudio2012Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AvailableQtyTextBox
            // 
            this.AvailableQtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AvailableQtyTextBox.Location = new System.Drawing.Point(81, 60);
            this.AvailableQtyTextBox.Name = "AvailableQtyTextBox";
            this.AvailableQtyTextBox.Size = new System.Drawing.Size(152, 20);
            this.AvailableQtyTextBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditMainStore_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 268);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditMainStore_Store";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditMainStore_Store";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEditMainStore_Store_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox AvailableQtyTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemColumnComboBox;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}