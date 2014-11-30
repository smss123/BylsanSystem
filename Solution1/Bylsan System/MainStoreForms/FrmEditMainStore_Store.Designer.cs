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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.AvailableQtyTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ItemColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            DescriptionLabel = new System.Windows.Forms.Label();
            AvailableQtyLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemColumnComboBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(DescriptionLabel);
            this.groupBox1.Controls.Add(AvailableQtyLabel);
            this.groupBox1.Controls.Add(this.AvailableQtyTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Main Store";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(98, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 75);
            this.textBox1.TabIndex = 8;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(205, 184);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(127, 37);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Add";
            this.Addbtn.ThemeName = "Windows8";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(32, 88);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(64, 13);
            DescriptionLabel.TabIndex = 10;
            DescriptionLabel.Text = "Description:";
            // 
            // AvailableQtyLabel
            // 
            AvailableQtyLabel.AutoSize = true;
            AvailableQtyLabel.Location = new System.Drawing.Point(22, 58);
            AvailableQtyLabel.Name = "AvailableQtyLabel";
            AvailableQtyLabel.Size = new System.Drawing.Size(72, 13);
            AvailableQtyLabel.TabIndex = 6;
            AvailableQtyLabel.Text = "AvailableQty:";
            // 
            // AvailableQtyTextBox
            // 
            this.AvailableQtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AvailableQtyTextBox.Location = new System.Drawing.Point(98, 54);
            this.AvailableQtyTextBox.Name = "AvailableQtyTextBox";
            this.AvailableQtyTextBox.Size = new System.Drawing.Size(234, 20);
            this.AvailableQtyTextBox.TabIndex = 7;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(33, 25);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(63, 13);
            itemNameLabel.TabIndex = 5;
            itemNameLabel.Text = "Item Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // 
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
            this.ItemColumnComboBox.Location = new System.Drawing.Point(98, 25);
            this.ItemColumnComboBox.Name = "ItemColumnComboBox";
            this.ItemColumnComboBox.Size = new System.Drawing.Size(234, 20);
            this.ItemColumnComboBox.TabIndex = 11;
            this.ItemColumnComboBox.TabStop = false;
            // 
            // FrmEditMainStore_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditMainStore_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditMainStore_Store";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemColumnComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.TextBox AvailableQtyTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemColumnComboBox;
    }
}