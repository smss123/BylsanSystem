namespace Bylsan_System.MainStoreForms
{
    partial class FrmEditMainStore_StoreManager
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label processTypeLabel;
            System.Windows.Forms.Label qtyInOrOutLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.processTypeComboBox = new System.Windows.Forms.ComboBox();
            this.qtyInOrOutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.StoreComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            processTypeLabel = new System.Windows.Forms.Label();
            qtyInOrOutLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StoreComboBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(processTypeLabel);
            this.groupBox1.Controls.Add(this.processTypeComboBox);
            this.groupBox1.Controls.Add(qtyInOrOutLabel);
            this.groupBox1.Controls.Add(this.qtyInOrOutTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(20, 128);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(88, 128);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(246, 72);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(50, 107);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.priceTextBox.Location = new System.Drawing.Point(88, 100);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(116, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // processTypeLabel
            // 
            processTypeLabel.AutoSize = true;
            processTypeLabel.Location = new System.Drawing.Point(13, 76);
            processTypeLabel.Name = "processTypeLabel";
            processTypeLabel.Size = new System.Drawing.Size(75, 13);
            processTypeLabel.TabIndex = 14;
            processTypeLabel.Text = "Process Type:";
            // 
            // processTypeComboBox
            // 
            this.processTypeComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.processTypeComboBox.FormattingEnabled = true;
            this.processTypeComboBox.ItemHeight = 13;
            this.processTypeComboBox.Location = new System.Drawing.Point(88, 73);
            this.processTypeComboBox.Name = "processTypeComboBox";
            this.processTypeComboBox.Size = new System.Drawing.Size(175, 21);
            this.processTypeComboBox.TabIndex = 15;
            // 
            // qtyInOrOutLabel
            // 
            qtyInOrOutLabel.AutoSize = true;
            qtyInOrOutLabel.Location = new System.Drawing.Point(6, 49);
            qtyInOrOutLabel.Name = "qtyInOrOutLabel";
            qtyInOrOutLabel.Size = new System.Drawing.Size(78, 13);
            qtyInOrOutLabel.TabIndex = 12;
            qtyInOrOutLabel.Text = "Qty In Or Out:";
            // 
            // qtyInOrOutTextBox
            // 
            this.qtyInOrOutTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyInOrOutTextBox.Location = new System.Drawing.Point(88, 46);
            this.qtyInOrOutTextBox.Name = "qtyInOrOutTextBox";
            this.qtyInOrOutTextBox.Size = new System.Drawing.Size(116, 20);
            this.qtyInOrOutTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stor:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(256, 217);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 37);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.ThemeName = "Windows8";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.StoreComboBox.Location = new System.Drawing.Point(88, 20);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(246, 20);
            this.StoreComboBox.TabIndex = 0;
            this.StoreComboBox.TabStop = false;
            // 
            // FrmEditMainStore_StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditMainStore_StoreManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditMainStore_StoreManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox processTypeComboBox;
        private System.Windows.Forms.TextBox qtyInOrOutTextBox;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox StoreComboBox;
    }
}