namespace Bylsan_System.AccountsX.Acc
{
    partial class frmAddAccount
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
            System.Windows.Forms.Label accountNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbCategories = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            accountNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new System.Drawing.Point(58, 71);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new System.Drawing.Size(84, 13);
            accountNameLabel.TabIndex = 0;
            accountNameLabel.Text = "Account Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(73, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(83, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 0;
            label1.Text = "Category  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbCategories);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(accountNameLabel);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Location = new System.Drawing.Point(5, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.CmbCategories.ThemeName = "Office2010Black";
            this.CmbCategories.SelectedIndexChanged += new System.EventHandler(this.CmbCategories_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(148, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(253, 98);
            this.txtDescription.TabIndex = 3;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(XamaDataLayer.Account);
            // 
            // txtAccountName
            // 
            this.txtAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "AccountName", true));
            this.txtAccountName.Location = new System.Drawing.Point(148, 68);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(253, 20);
            this.txtAccountName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "Office2010Black";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(481, 271);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddAccount";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.TextBox txtAccountName;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbCategories;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
