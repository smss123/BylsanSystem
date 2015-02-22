namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_Item
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
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label itemTypeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemTypecomboBox = new System.Windows.Forms.ComboBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            itemNameLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            itemTypeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(32, 35);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(64, 13);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new System.Drawing.Point(2, 63);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(94, 13);
            itemDescriptionLabel.TabIndex = 2;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemTypeLabel
            // 
            itemTypeLabel.AutoSize = true;
            itemTypeLabel.Location = new System.Drawing.Point(38, 142);
            itemTypeLabel.Name = "itemTypeLabel";
            itemTypeLabel.Size = new System.Drawing.Size(58, 13);
            itemTypeLabel.TabIndex = 4;
            itemTypeLabel.Text = "Item Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ItemTypecomboBox);
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(itemTypeLabel);
            this.groupBox1.Controls.Add(itemDescriptionLabel);
            this.groupBox1.Controls.Add(this.itemDescriptionTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // ItemTypecomboBox
            // 
            this.ItemTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypecomboBox.FormattingEnabled = true;
            this.ItemTypecomboBox.Items.AddRange(new object[] {
            "item product",
            "item row material",
            "All"});
            this.ItemTypecomboBox.Location = new System.Drawing.Point(97, 139);
            this.ItemTypecomboBox.Name = "ItemTypecomboBox";
            this.ItemTypecomboBox.Size = new System.Drawing.Size(234, 21);
            this.ItemTypecomboBox.TabIndex = 3;
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addbtn.Location = new System.Drawing.Point(10, 187);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 37);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.ThemeName = "Office2010Black";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(97, 60);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(234, 69);
            this.itemDescriptionTextBox.TabIndex = 2;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemNameTextBox.Location = new System.Drawing.Point(97, 32);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 266);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 300);
            this.Name = "FrmAddMainStore_Item";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(387, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMainStore_Item";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmAddMainStore_Item_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox ItemTypecomboBox;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}