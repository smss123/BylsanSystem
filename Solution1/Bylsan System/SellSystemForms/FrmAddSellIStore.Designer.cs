namespace Bylsan_System.SellSystemForms
{
    partial class FrmAddSellIStore
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
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label qtyLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.ItemComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            itemIDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(6, 28);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(32, 13);
            itemIDLabel.TabIndex = 0;
            itemIDLabel.Text = "Item:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(11, 60);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(27, 13);
            qtyLabel.TabIndex = 2;
            qtyLabel.Text = "Qty:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ItemComboBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(itemIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(15, 98);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2010Black";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.ItemComboBox.Location = new System.Drawing.Point(40, 28);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(233, 20);
            this.ItemComboBox.TabIndex = 1;
            this.ItemComboBox.TabStop = false;
            this.ItemComboBox.ThemeName = "Office2010Black";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.qtyTextBox.Location = new System.Drawing.Point(40, 57);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 2;
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddSellIStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(344, 174);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 204);
            this.Name = "FrmAddSellIStore";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(352, 204);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddSellIStore";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmAddSellIStore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemComboBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}
