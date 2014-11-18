namespace Bylsan_System.SecurityForm
{
    partial class FrmLogin
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
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EnterBtn = new Telerik.WinControls.UI.RadButton();
            this.ExitBtn = new Telerik.WinControls.UI.RadButton();
            this.GroupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupLogin
            // 
            this.GroupLogin.Controls.Add(this.ExitBtn);
            this.GroupLogin.Controls.Add(this.EnterBtn);
            this.GroupLogin.Controls.Add(this.label2);
            this.GroupLogin.Controls.Add(this.label1);
            this.GroupLogin.Controls.Add(this.PasswordTextBox);
            this.GroupLogin.Controls.Add(this.UserNameTextBox);
            this.GroupLogin.Location = new System.Drawing.Point(19, 18);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(312, 186);
            this.GroupLogin.TabIndex = 6;
            this.GroupLogin.TabStop = false;
            this.GroupLogin.Text = "Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(79, 92);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(210, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(79, 45);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(20, 135);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(122, 37);
            this.EnterBtn.TabIndex = 9;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(167, 135);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(122, 37);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.GroupLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 270);
            this.MinimumSize = new System.Drawing.Size(367, 270);
            this.Name = "FrmLogin";
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadButton ExitBtn;
        private Telerik.WinControls.UI.RadButton EnterBtn;
    }
}