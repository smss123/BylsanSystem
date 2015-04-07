namespace Bylsan_System.MailForms
{
    partial class FrmSendMail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TheMessageBox = new System.Windows.Forms.TextBox();
            this.SubjectLabl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.UsersAutoCompleteBox = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.SendBtn = new Telerik.WinControls.UI.RadButton();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAutoCompleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAttachment);
            this.groupBox1.Controls.Add(this.SendBtn);
            this.groupBox1.Controls.Add(this.TheMessageBox);
            this.groupBox1.Controls.Add(this.SubjectLabl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SubjectBox);
            this.groupBox1.Controls.Add(this.UsersAutoCompleteBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // TheMessageBox
            // 
            this.TheMessageBox.BackColor = System.Drawing.SystemColors.Info;
            this.TheMessageBox.Location = new System.Drawing.Point(69, 104);
            this.TheMessageBox.Multiline = true;
            this.TheMessageBox.Name = "TheMessageBox";
            this.TheMessageBox.Size = new System.Drawing.Size(398, 183);
            this.TheMessageBox.TabIndex = 6;
            // 
            // SubjectLabl
            // 
            this.SubjectLabl.AutoSize = true;
            this.SubjectLabl.Location = new System.Drawing.Point(7, 107);
            this.SubjectLabl.Name = "SubjectLabl";
            this.SubjectLabl.Size = new System.Drawing.Size(52, 13);
            this.SubjectLabl.TabIndex = 5;
            this.SubjectLabl.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // SubjectBox
            // 
            this.SubjectBox.BackColor = System.Drawing.SystemColors.Info;
            this.SubjectBox.Location = new System.Drawing.Point(69, 72);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(399, 20);
            this.SubjectBox.TabIndex = 3;
            // 
            // UsersAutoCompleteBox
            // 
            this.UsersAutoCompleteBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsersAutoCompleteBox.BackColor = System.Drawing.SystemColors.Info;
            this.UsersAutoCompleteBox.Location = new System.Drawing.Point(69, 30);
            this.UsersAutoCompleteBox.Name = "UsersAutoCompleteBox";
            this.UsersAutoCompleteBox.Size = new System.Drawing.Size(399, 26);
            this.UsersAutoCompleteBox.TabIndex = 2;
            this.UsersAutoCompleteBox.Text = "Select Users;";
            this.UsersAutoCompleteBox.ThemeName = "Office2010Black";
            this.UsersAutoCompleteBox.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.radAutoCompleteBox1_TextBlockFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SendBtn
            // 
            this.SendBtn.Image = global::Bylsan_System.Properties.Resources._1422157177_Forward;
            this.SendBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendBtn.Location = new System.Drawing.Point(69, 304);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(95, 30);
            this.SendBtn.TabIndex = 8;
            this.SendBtn.Text = "Send";
            this.SendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SendBtn.ThemeName = "Office2010Black";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // btnAttachment
            // 
            this.btnAttachment.Location = new System.Drawing.Point(450, 304);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(100, 30);
            this.btnAttachment.TabIndex = 9;
            this.btnAttachment.Text = "Add Attachment";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // FrmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(580, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSendMail";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmSendMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAutoCompleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label SubjectLabl;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadAutoCompleteBox UsersAutoCompleteBox;
        public System.Windows.Forms.TextBox TheMessageBox;
        public System.Windows.Forms.TextBox SubjectBox;
        private Telerik.WinControls.UI.RadButton SendBtn;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Button btnAttachment;
    }
}