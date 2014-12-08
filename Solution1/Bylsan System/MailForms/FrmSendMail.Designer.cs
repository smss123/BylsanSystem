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
            this.SendBtn = new Telerik.WinControls.UI.RadButton();
            this.TheMessageBox = new System.Windows.Forms.TextBox();
            this.SubjectLabl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.UsersAutoCompleteBox = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAutoCompleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SendBtn);
            this.groupBox1.Controls.Add(this.TheMessageBox);
            this.groupBox1.Controls.Add(this.SubjectLabl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SubjectBox);
            this.groupBox1.Controls.Add(this.UsersAutoCompleteBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(49, 293);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(105, 31);
            this.SendBtn.TabIndex = 7;
            this.SendBtn.Text = "Send";
            this.SendBtn.ThemeName = "Windows8";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // TheMessageBox
            // 
            this.TheMessageBox.BackColor = System.Drawing.SystemColors.Info;
            this.TheMessageBox.Location = new System.Drawing.Point(56, 104);
            this.TheMessageBox.Multiline = true;
            this.TheMessageBox.Name = "TheMessageBox";
            this.TheMessageBox.Size = new System.Drawing.Size(411, 183);
            this.TheMessageBox.TabIndex = 6;
            // 
            // SubjectLabl
            // 
            this.SubjectLabl.AutoSize = true;
            this.SubjectLabl.Location = new System.Drawing.Point(7, 107);
            this.SubjectLabl.Name = "SubjectLabl";
            this.SubjectLabl.Size = new System.Drawing.Size(49, 13);
            this.SubjectLabl.TabIndex = 5;
            this.SubjectLabl.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // SubjectBox
            // 
            this.SubjectBox.BackColor = System.Drawing.SystemColors.Info;
            this.SubjectBox.Location = new System.Drawing.Point(54, 72);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(414, 20);
            this.SubjectBox.TabIndex = 3;
            // 
            // UsersAutoCompleteBox
            // 
            this.UsersAutoCompleteBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsersAutoCompleteBox.BackColor = System.Drawing.SystemColors.Info;
            this.UsersAutoCompleteBox.Location = new System.Drawing.Point(49, 30);
            this.UsersAutoCompleteBox.Name = "UsersAutoCompleteBox";
            this.UsersAutoCompleteBox.Size = new System.Drawing.Size(419, 26);
            this.UsersAutoCompleteBox.TabIndex = 2;
            this.UsersAutoCompleteBox.Text = "Select Users;";
            this.UsersAutoCompleteBox.ThemeName = "Windows8";
            this.UsersAutoCompleteBox.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.radAutoCompleteBox1_TextBlockFormatting);
            this.UsersAutoCompleteBox.TabIndexChanged += new System.EventHandler(this.radAutoCompleteBox1_TabIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // FrmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(580, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSendMail";
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.FrmSendMail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAutoCompleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadButton SendBtn;
        private System.Windows.Forms.TextBox TheMessageBox;
        private System.Windows.Forms.Label SubjectLabl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjectBox;
        private Telerik.WinControls.UI.RadAutoCompleteBox UsersAutoCompleteBox;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}