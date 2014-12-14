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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label accountNameLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.CmbCategories = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            accountNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            label2.Location = new System.Drawing.Point(41, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 13);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 13);
            label4.TabIndex = 0;
            label4.Text = "Account Name:";
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
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(29, 127);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(125, 26);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(244, 20);
            this.txtAccount.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 83);
            this.textBox1.TabIndex = 3;
            // 
            // FrmAddAccountCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 220);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddAccountCategory";
            this.Text = "FrmAddAccountCategory";
            this.Load += new System.EventHandler(this.FrmAddAccountCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbCategories;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox txtAccount;
    }
}