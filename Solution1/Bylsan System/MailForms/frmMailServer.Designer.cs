namespace Bylsan_System.MailForms
{
    partial class frmMailServer
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Column 1");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Column 2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailServer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FoldersGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.InBoxBtn = new Telerik.WinControls.UI.RadButton();
            this.DraftsBtn = new Telerik.WinControls.UI.RadButton();
            this.SentBtn = new Telerik.WinControls.UI.RadButton();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersGroupBox)).BeginInit();
            this.FoldersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InBoxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DraftsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.RefreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FoldersGroupBox
            // 
            this.FoldersGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.FoldersGroupBox.Controls.Add(this.SentBtn);
            this.FoldersGroupBox.Controls.Add(this.DraftsBtn);
            this.FoldersGroupBox.Controls.Add(this.InBoxBtn);
            this.FoldersGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FoldersGroupBox.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.FoldersGroupBox.HeaderText = "Folders";
            this.FoldersGroupBox.Location = new System.Drawing.Point(0, 25);
            this.FoldersGroupBox.Name = "FoldersGroupBox";
            this.FoldersGroupBox.Size = new System.Drawing.Size(136, 476);
            this.FoldersGroupBox.TabIndex = 3;
            this.FoldersGroupBox.Text = "Folders";
            this.FoldersGroupBox.ThemeName = "Windows8";
            // 
            // InBoxBtn
            // 
            this.InBoxBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InBoxBtn.Location = new System.Drawing.Point(2, 18);
            this.InBoxBtn.Name = "InBoxBtn";
            this.InBoxBtn.Size = new System.Drawing.Size(132, 38);
            this.InBoxBtn.TabIndex = 0;
            this.InBoxBtn.Text = "Inbox";
            this.InBoxBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InBoxBtn.ThemeName = "Windows8";
            // 
            // DraftsBtn
            // 
            this.DraftsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraftsBtn.Location = new System.Drawing.Point(2, 56);
            this.DraftsBtn.Name = "DraftsBtn";
            this.DraftsBtn.Size = new System.Drawing.Size(132, 38);
            this.DraftsBtn.TabIndex = 1;
            this.DraftsBtn.Text = "Drafts";
            this.DraftsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DraftsBtn.ThemeName = "Windows8";
            // 
            // SentBtn
            // 
            this.SentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SentBtn.Location = new System.Drawing.Point(2, 94);
            this.SentBtn.Name = "SentBtn";
            this.SentBtn.Size = new System.Drawing.Size(132, 38);
            this.SentBtn.TabIndex = 2;
            this.SentBtn.Text = "Sent";
            this.SentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SentBtn.ThemeName = "Windows8";
            // 
            // radListView1
            // 
            listViewDetailColumn1.HeaderText = "Column 0";
            listViewDetailColumn2.HeaderText = "Column 1";
            listViewDetailColumn3.HeaderText = "Column 2";
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.EnableFiltering = true;
            this.radListView1.EnableGrouping = true;
            this.radListView1.EnableKeyMap = true;
            this.radListView1.EnableLassoSelection = true;
            this.radListView1.EnableSorting = true;
            this.radListView1.Location = new System.Drawing.Point(136, 25);
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowGridLines = true;
            this.radListView1.ShowGroups = true;
            this.radListView1.Size = new System.Drawing.Size(622, 476);
            this.radListView1.TabIndex = 4;
            this.radListView1.Text = "radListView1";
            this.radListView1.ThemeName = "Windows8";
            // 
            // NewBtn
            // 
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(100, 22);
            this.NewBtn.Text = "New Message";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(66, 22);
            this.RefreshBtn.Text = "Refresh";
            // 
            // frmMailServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 523);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.FoldersGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMailServer";
            this.Text = "frmMailServer";
            this.Load += new System.EventHandler(this.frmMailServer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersGroupBox)).EndInit();
            this.FoldersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InBoxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DraftsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private Telerik.WinControls.UI.RadGroupBox FoldersGroupBox;
        private Telerik.WinControls.UI.RadButton SentBtn;
        private Telerik.WinControls.UI.RadButton DraftsBtn;
        private Telerik.WinControls.UI.RadButton InBoxBtn;
        private Telerik.WinControls.UI.RadListView radListView1;
    }
}