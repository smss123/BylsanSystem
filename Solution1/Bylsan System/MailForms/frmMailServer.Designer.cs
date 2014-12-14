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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailServer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FoldersGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.SentBtn = new Telerik.WinControls.UI.RadButton();
            this.DraftsBtn = new Telerik.WinControls.UI.RadButton();
            this.InBoxBtn = new Telerik.WinControls.UI.RadButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.GroupDisplayMessage = new System.Windows.Forms.GroupBox();
            this.labMessageDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.labSubject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersGroupBox)).BeginInit();
            this.FoldersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DraftsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InBoxBtn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.GroupDisplayMessage.SuspendLayout();
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
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
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
            this.FoldersGroupBox.Size = new System.Drawing.Size(136, 390);
            this.FoldersGroupBox.TabIndex = 3;
            this.FoldersGroupBox.Text = "Folders";
            this.FoldersGroupBox.ThemeName = "Windows8";
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
            this.SentBtn.Click += new System.EventHandler(this.SentBtn_Click);
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
            this.DraftsBtn.Click += new System.EventHandler(this.DraftsBtn_Click);
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
            this.InBoxBtn.Click += new System.EventHandler(this.InBoxBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBtn,
            this.MoveBtn,
            this.ClearBtn,
            this.toolStripMenuItem1,
            this.DeleteBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 98);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(158, 22);
            this.OpenBtn.Text = "Open";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // MoveBtn
            // 
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(158, 22);
            this.MoveBtn.Text = "Move To Drafts";
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(158, 22);
            this.ClearBtn.Text = "Clear Selection";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(158, 22);
            this.DeleteBtn.Text = "Delete Selection";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MessagesListView
            // 
            this.MessagesListView.ContextMenuStrip = this.contextMenuStrip1;
            this.MessagesListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.FullRowSelect = true;
            this.MessagesListView.GridLines = true;
            this.MessagesListView.Location = new System.Drawing.Point(136, 25);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(622, 390);
            this.MessagesListView.TabIndex = 4;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.MouseHover += new System.EventHandler(this.MessagesListView_MouseHover);
            // 
            // GroupDisplayMessage
            // 
            this.GroupDisplayMessage.BackColor = System.Drawing.Color.Silver;
            this.GroupDisplayMessage.Controls.Add(this.ReplayBtn);
            this.GroupDisplayMessage.Controls.Add(this.labMessageDate);
            this.GroupDisplayMessage.Controls.Add(this.label4);
            this.GroupDisplayMessage.Controls.Add(this.label2);
            this.GroupDisplayMessage.Controls.Add(this.CloseBtn);
            this.GroupDisplayMessage.Controls.Add(this.labSubject);
            this.GroupDisplayMessage.Controls.Add(this.label3);
            this.GroupDisplayMessage.Controls.Add(this.labUserName);
            this.GroupDisplayMessage.Controls.Add(this.label1);
            this.GroupDisplayMessage.Controls.Add(this.richTextBox1);
            this.GroupDisplayMessage.Location = new System.Drawing.Point(173, 43);
            this.GroupDisplayMessage.Name = "GroupDisplayMessage";
            this.GroupDisplayMessage.Size = new System.Drawing.Size(526, 348);
            this.GroupDisplayMessage.TabIndex = 7;
            this.GroupDisplayMessage.TabStop = false;
            this.GroupDisplayMessage.Text = "Selected Message";
            // 
            // labMessageDate
            // 
            this.labMessageDate.AutoSize = true;
            this.labMessageDate.ForeColor = System.Drawing.Color.White;
            this.labMessageDate.Location = new System.Drawing.Point(88, 324);
            this.labMessageDate.Name = "labMessageDate";
            this.labMessageDate.Size = new System.Drawing.Size(27, 13);
            this.labMessageDate.TabIndex = 8;
            this.labMessageDate.Text = ".....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "At Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "The Message ";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Location = new System.Drawing.Point(433, 319);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click_1);
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.ForeColor = System.Drawing.Color.White;
            this.labSubject.Location = new System.Drawing.Point(110, 47);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(27, 13);
            this.labSubject.TabIndex = 4;
            this.labSubject.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject :";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.ForeColor = System.Drawing.Color.White;
            this.labUserName.Location = new System.Drawing.Point(110, 25);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(27, 13);
            this.labUserName.TabIndex = 2;
            this.labUserName.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User      :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(502, 219);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplayBtn.Location = new System.Drawing.Point(352, 319);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplayBtn.TabIndex = 9;
            this.ReplayBtn.Text = "Replay";
            this.ReplayBtn.UseVisualStyleBackColor = true;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // frmMailServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 437);
            this.Controls.Add(this.GroupDisplayMessage);
            this.Controls.Add(this.MessagesListView);
            this.Controls.Add(this.FoldersGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMailServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMailServer";
            this.Load += new System.EventHandler(this.frmMailServer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersGroupBox)).EndInit();
            this.FoldersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SentBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DraftsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InBoxBtn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.GroupDisplayMessage.ResumeLayout(false);
            this.GroupDisplayMessage.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenBtn;
        private System.Windows.Forms.ToolStripMenuItem MoveBtn;
        private System.Windows.Forms.ToolStripMenuItem ClearBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteBtn;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.GroupBox GroupDisplayMessage;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMessageDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReplayBtn;
    }
}