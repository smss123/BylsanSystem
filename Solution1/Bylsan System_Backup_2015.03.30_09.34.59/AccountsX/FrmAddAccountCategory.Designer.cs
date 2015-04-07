namespace Bylsan_System.AccountsX
{
    partial class FrmAddAccountCategory
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label accountNameLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.CmbCategories = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new Telerik.WinControls.UI.RadButton();
            this.txtAccountBox = new System.Windows.Forms.TextBox();
            this.txtDescriptionBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            accountNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(73, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(83, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 0;
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new System.Drawing.Point(58, 71);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new System.Drawing.Size(80, 13);
            accountNameLabel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(68, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 13);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 13);
            label4.TabIndex = 0;
            label4.Text = "Account Category Name:";
            // 
            // CmbCategories
            // 
            this.CmbCategories.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // CmbCategories.NestedRadGridView
            // 
            this.CmbCategories.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbCategories.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbCategories.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbCategories.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbCategories.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbCategories.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbCategories.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbCategories.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbCategories.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbCategories.EditorControl.Name = "NestedRadGridView";
            this.CmbCategories.EditorControl.ReadOnly = true;
            this.CmbCategories.EditorControl.ShowGroupPanel = false;
            this.CmbCategories.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbCategories.EditorControl.TabIndex = 0;
            this.CmbCategories.Location = new System.Drawing.Point(148, 42);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.Size = new System.Drawing.Size(253, 20);
            this.CmbCategories.TabIndex = 4;
            this.CmbCategories.TabStop = false;
            this.CmbCategories.Text = "CmbCategories";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(253, 98);
            this.txtDescription.TabIndex = 3;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(148, 68);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(253, 20);
            this.txtAccountName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.txtAccountBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txtDescriptionBox);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::Bylsan_System.Properties.Resources.Add1;
            this.addBtn.Location = new System.Drawing.Point(11, 163);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 42);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "add";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.ThemeName = "Office2010Black";
            this.addBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtAccountBox
            // 
            this.txtAccountBox.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccountBox.Location = new System.Drawing.Point(143, 29);
            this.txtAccountBox.Name = "txtAccountBox";
            this.txtAccountBox.Size = new System.Drawing.Size(220, 20);
            this.txtAccountBox.TabIndex = 5;
            // 
            // txtDescriptionBox
            // 
            this.txtDescriptionBox.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescriptionBox.Location = new System.Drawing.Point(143, 67);
            this.txtDescriptionBox.Multiline = true;
            this.txtDescriptionBox.Name = "txtDescriptionBox";
            this.txtDescriptionBox.Size = new System.Drawing.Size(220, 83);
            this.txtDescriptionBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddAccountCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(414, 237);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 271);
            this.Name = "FrmAddAccountCategory";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(422, 271);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account Category";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmAddAccountCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbCategories;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescriptionBox;
        private System.Windows.Forms.TextBox txtAccountBox;
        private Telerik.WinControls.UI.RadButton addBtn;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}