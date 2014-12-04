namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_StoreManager
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
            System.Windows.Forms.Label qtyInOrOutLabel;
            System.Windows.Forms.Label processTypeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.processTypeComboBox = new System.Windows.Forms.ComboBox();
            this.qtyInOrOutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            qtyInOrOutLabel = new System.Windows.Forms.Label();
            processTypeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyInOrOutLabel
            // 
            qtyInOrOutLabel.AutoSize = true;
            qtyInOrOutLabel.Location = new System.Drawing.Point(5, 63);
            qtyInOrOutLabel.Name = "qtyInOrOutLabel";
            qtyInOrOutLabel.Size = new System.Drawing.Size(79, 13);
            qtyInOrOutLabel.TabIndex = 2;
            qtyInOrOutLabel.Text = "Qty In Or Out:";
            // 
            // processTypeLabel
            // 
            processTypeLabel.AutoSize = true;
            processTypeLabel.Location = new System.Drawing.Point(10, 90);
            processTypeLabel.Name = "processTypeLabel";
            processTypeLabel.Size = new System.Drawing.Size(74, 13);
            processTypeLabel.TabIndex = 4;
            processTypeLabel.Text = "Process Type:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(46, 121);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(14, 142);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(processTypeLabel);
            this.groupBox1.Controls.Add(this.processTypeComboBox);
            this.groupBox1.Controls.Add(qtyInOrOutLabel);
            this.groupBox1.Controls.Add(this.qtyInOrOutTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StoreComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  Stor manger";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.Addbtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addbtn.Location = new System.Drawing.Point(13, 239);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 37);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addbtn.ThemeName = "VisualStudio2012Light";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(86, 142);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(246, 72);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.priceTextBox.Location = new System.Drawing.Point(84, 114);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(116, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // processTypeComboBox
            // 
            this.processTypeComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.processTypeComboBox.FormattingEnabled = true;
            this.processTypeComboBox.Location = new System.Drawing.Point(84, 87);
            this.processTypeComboBox.Name = "processTypeComboBox";
            this.processTypeComboBox.Size = new System.Drawing.Size(175, 21);
            this.processTypeComboBox.TabIndex = 3;
            // 
            // qtyInOrOutTextBox
            // 
            this.qtyInOrOutTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyInOrOutTextBox.Location = new System.Drawing.Point(84, 60);
            this.qtyInOrOutTextBox.Name = "qtyInOrOutTextBox";
            this.qtyInOrOutTextBox.Size = new System.Drawing.Size(116, 20);
            this.qtyInOrOutTextBox.TabIndex = 2;
            this.qtyInOrOutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyInOrOutTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stor:";
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
            this.StoreComboBox.Location = new System.Drawing.Point(84, 34);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(246, 20);
            this.StoreComboBox.TabIndex = 1;
            this.StoreComboBox.TabStop = false;
            this.StoreComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddMainStore_StoreManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox processTypeComboBox;
        private System.Windows.Forms.TextBox qtyInOrOutTextBox;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox StoreComboBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}