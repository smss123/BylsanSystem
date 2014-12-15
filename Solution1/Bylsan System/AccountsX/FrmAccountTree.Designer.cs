namespace Bylsan_System.AccountsX
{
    partial class FrmAccountTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountTree));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CollapseBtn = new System.Windows.Forms.Button();
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.TreeAccounts = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVAccountsDaily = new Telerik.WinControls.UI.RadGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily.MasterTemplate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CollapseBtn);
            this.groupBox1.Controls.Add(this.ExpandBtn);
            this.groupBox1.Controls.Add(this.TreeAccounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Location = new System.Drawing.Point(16, 243);
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.Size = new System.Drawing.Size(125, 30);
            this.CollapseBtn.TabIndex = 2;
            this.CollapseBtn.Text = "Collapse All";
            this.CollapseBtn.UseVisualStyleBackColor = true;
            this.CollapseBtn.Click += new System.EventHandler(this.CollapseBtn_Click);
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.Location = new System.Drawing.Point(191, 243);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(138, 30);
            this.ExpandBtn.TabIndex = 1;
            this.ExpandBtn.Text = "Expaned All";
            this.ExpandBtn.UseVisualStyleBackColor = true;
            this.ExpandBtn.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // TreeAccounts
            // 
            this.TreeAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeAccounts.FullRowSelect = true;
            this.TreeAccounts.Location = new System.Drawing.Point(16, 19);
            this.TreeAccounts.Name = "TreeAccounts";
            this.TreeAccounts.Size = new System.Drawing.Size(313, 218);
            this.TreeAccounts.TabIndex = 0;
            this.TreeAccounts.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeAccounts_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            this.imageList1.Images.SetKeyName(2, "payment-card.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVAccountsDaily);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // DGVAccountsDaily
            // 
            this.DGVAccountsDaily.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVAccountsDaily.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVAccountsDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAccountsDaily.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DGVAccountsDaily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVAccountsDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVAccountsDaily.Location = new System.Drawing.Point(3, 16);
            // 
            // DGVAccountsDaily
            // 
            this.DGVAccountsDaily.MasterTemplate.AutoGenerateColumns = false;
            this.DGVAccountsDaily.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 92;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TotalIn";
            gridViewDecimalColumn2.HeaderText = "TotalIn";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "TotalIn";
            gridViewDecimalColumn2.Width = 138;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "TotalOut";
            gridViewDecimalColumn3.HeaderText = "TotalOut";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "TotalOut";
            gridViewDecimalColumn3.Width = 138;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DateOfProcess";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "DateOfProcess";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DateOfProcess";
            gridViewDateTimeColumn1.Width = 138;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Description";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.Width = 134;
            this.DGVAccountsDaily.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1});
            this.DGVAccountsDaily.MasterTemplate.EnableFiltering = true;
            this.DGVAccountsDaily.Name = "DGVAccountsDaily";
            this.DGVAccountsDaily.ReadOnly = true;
            this.DGVAccountsDaily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVAccountsDaily.Size = new System.Drawing.Size(564, 385);
            this.DGVAccountsDaily.TabIndex = 1;
            this.DGVAccountsDaily.Text = "DGVAccountsDaily";
            this.DGVAccountsDaily.ThemeName = "VisualStudio2012Light";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.txtAccountName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(102, 79);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(227, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 53);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(102, 26);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(227, 20);
            this.txtAccountName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name :";
            // 
            // FrmAccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAccountTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccountTree";
            this.Load += new System.EventHandler(this.FrmAccountTree_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccountsDaily)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TreeAccounts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CollapseBtn;
        private System.Windows.Forms.Button ExpandBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadGridView DGVAccountsDaily;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}