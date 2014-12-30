namespace Bylsan_System.AccountsX
{
    partial class FrmRepaydebt
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
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.Remaininglabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemainingtextBox = new System.Windows.Forms.TextBox();
            this.PaymenttextBox = new System.Windows.Forms.TextBox();
            this.TotalDebttextBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.Remaininglabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemainingtextBox);
            this.groupBox1.Controls.Add(this.PaymenttextBox);
            this.groupBox1.Controls.Add(this.TotalDebttextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(13, 130);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Remaininglabel
            // 
            this.Remaininglabel.AutoSize = true;
            this.Remaininglabel.Location = new System.Drawing.Point(27, 92);
            this.Remaininglabel.Name = "Remaininglabel";
            this.Remaininglabel.Size = new System.Drawing.Size(65, 13);
            this.Remaininglabel.TabIndex = 5;
            this.Remaininglabel.Text = "Remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Debt:";
            // 
            // RemainingtextBox
            // 
            this.RemainingtextBox.Location = new System.Drawing.Point(93, 88);
            this.RemainingtextBox.Name = "RemainingtextBox";
            this.RemainingtextBox.ReadOnly = true;
            this.RemainingtextBox.Size = new System.Drawing.Size(133, 20);
            this.RemainingtextBox.TabIndex = 2;
            this.RemainingtextBox.TabStop = false;
            // 
            // PaymenttextBox
            // 
            this.PaymenttextBox.Location = new System.Drawing.Point(93, 62);
            this.PaymenttextBox.Name = "PaymenttextBox";
            this.PaymenttextBox.Size = new System.Drawing.Size(133, 20);
            this.PaymenttextBox.TabIndex = 1;
            // 
            // TotalDebttextBox
            // 
            this.TotalDebttextBox.Location = new System.Drawing.Point(93, 36);
            this.TotalDebttextBox.Name = "TotalDebttextBox";
            this.TotalDebttextBox.ReadOnly = true;
            this.TotalDebttextBox.Size = new System.Drawing.Size(133, 20);
            this.TotalDebttextBox.TabIndex = 0;
            this.TotalDebttextBox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRepaydebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(294, 202);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(302, 235);
            this.Name = "FrmRepaydebt";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(302, 235);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRepaydebt";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RemainingtextBox;
        private System.Windows.Forms.TextBox PaymenttextBox;
        private System.Windows.Forms.TextBox TotalDebttextBox;
        private System.Windows.Forms.Label Remaininglabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}