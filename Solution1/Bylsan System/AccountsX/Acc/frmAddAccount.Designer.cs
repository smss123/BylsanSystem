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
            this.CategoryMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            accountNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
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
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Category :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryMultiColumnComboBox1);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(accountNameLabel);
            this.groupBox1.Controls.Add(this.accountNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CategoryMultiColumnComboBox1
            // 
            // 
            // CategoryMultiColumnComboBox1.NestedRadGridView
            // 
            this.CategoryMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CategoryMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CategoryMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.CategoryMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.CategoryMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.CategoryMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CategoryMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.CategoryMultiColumnComboBox1.Location = new System.Drawing.Point(148, 42);
            this.CategoryMultiColumnComboBox1.Name = "CategoryMultiColumnComboBox1";
            this.CategoryMultiColumnComboBox1.Size = new System.Drawing.Size(253, 20);
            this.CategoryMultiColumnComboBox1.TabIndex = 4;
            this.CategoryMultiColumnComboBox1.TabStop = false;
            this.CategoryMultiColumnComboBox1.Text = "radMultiColumnComboBox1";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(148, 94);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(253, 98);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "AccountName", true));
            this.accountNameTextBox.Location = new System.Drawing.Point(148, 68);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.accountNameTextBox.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(XamaDataLayer.Account);
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(459, 272);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddAccount";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmAddAccount";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CategoryMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
