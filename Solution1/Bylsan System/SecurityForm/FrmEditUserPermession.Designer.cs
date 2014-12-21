namespace Bylsan_System.SecurityForm
{
    partial class FrmEditUserPermession
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordsLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbBranches = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.passwordsTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            userNameLabel = new System.Windows.Forms.Label();
            passwordsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(20, 36);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(65, 13);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // passwordsLabel
            // 
            passwordsLabel.AutoSize = true;
            passwordsLabel.Location = new System.Drawing.Point(21, 72);
            passwordsLabel.Name = "passwordsLabel";
            passwordsLabel.Size = new System.Drawing.Size(64, 13);
            passwordsLabel.TabIndex = 2;
            passwordsLabel.Text = "Passwords:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(367, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 5;
            label1.Text = "Branch:";
            label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.CmbBranches);
            this.groupBox1.Controls.Add(passwordsLabel);
            this.groupBox1.Controls.Add(this.passwordsTextBox);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CmbBranches
            // 
            // 
            // CmbBranches.NestedRadGridView
            // 
            this.CmbBranches.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbBranches.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbBranches.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbBranches.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbBranches.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbBranches.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbBranches.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbBranches.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbBranches.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbBranches.EditorControl.Name = "NestedRadGridView";
            this.CmbBranches.EditorControl.ReadOnly = true;
            this.CmbBranches.EditorControl.ShowGroupPanel = false;
            this.CmbBranches.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbBranches.EditorControl.TabIndex = 0;
            this.CmbBranches.Location = new System.Drawing.Point(434, 29);
            this.CmbBranches.Name = "CmbBranches";
            this.CmbBranches.Size = new System.Drawing.Size(194, 20);
            this.CmbBranches.TabIndex = 4;
            this.CmbBranches.TabStop = false;
            this.CmbBranches.ThemeName = "VisualStudio2012Light";
            this.CmbBranches.Visible = false;
            // 
            // passwordsTextBox
            // 
            this.passwordsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Passwords", true));
            this.passwordsTextBox.Location = new System.Drawing.Point(91, 69);
            this.passwordsTextBox.Name = "passwordsTextBox";
            this.passwordsTextBox.ReadOnly = true;
            this.passwordsTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordsTextBox.TabIndex = 3;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(XamaDataLayer.User);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(91, 33);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveBtn);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 367);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Permession";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.Location = new System.Drawing.Point(3, 282);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(149, 40);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "VisualStudio2012Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.Blue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(637, 261);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 75.56384F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 148.294F;
            this.Column2.HeaderText = "Permession";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 76.14214F;
            this.Column4.HeaderText = "Value";
            this.Column4.Name = "Column4";
            // 
            // FrmEditUserPermession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditUserPermession";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmUserPermessionEdit";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEditUserPermession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbBranches;
        private System.Windows.Forms.TextBox passwordsTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}
