namespace Bylsan_System.AccountsX
{
    partial class FrmAddDebt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.Remaininglabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.AmountofDebttextBox = new System.Windows.Forms.TextBox();
            this.TotalDebttextBox = new System.Windows.Forms.TextBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.DebetfromcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DebetfromcomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Remaininglabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TotaltextBox);
            this.groupBox1.Controls.Add(this.AmountofDebttextBox);
            this.groupBox1.Controls.Add(this.TotalDebttextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(64, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 40);
            this.txtDescription.TabIndex = 12;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(14, 221);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Remaininglabel
            // 
            this.Remaininglabel.AutoSize = true;
            this.Remaininglabel.Location = new System.Drawing.Point(53, 85);
            this.Remaininglabel.Name = "Remaininglabel";
            this.Remaininglabel.Size = new System.Drawing.Size(35, 13);
            this.Remaininglabel.TabIndex = 5;
            this.Remaininglabel.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount of Debt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Debt:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(94, 82);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(142, 20);
            this.TotaltextBox.TabIndex = 2;
            this.TotaltextBox.TabStop = false;
            // 
            // AmountofDebttextBox
            // 
            this.AmountofDebttextBox.Location = new System.Drawing.Point(94, 56);
            this.AmountofDebttextBox.Name = "AmountofDebttextBox";
            this.AmountofDebttextBox.Size = new System.Drawing.Size(142, 20);
            this.AmountofDebttextBox.TabIndex = 0;
            // 
            // TotalDebttextBox
            // 
            this.TotalDebttextBox.Location = new System.Drawing.Point(94, 30);
            this.TotalDebttextBox.Name = "TotalDebttextBox";
            this.TotalDebttextBox.ReadOnly = true;
            this.TotalDebttextBox.Size = new System.Drawing.Size(142, 20);
            this.TotalDebttextBox.TabIndex = 0;
            this.TotalDebttextBox.TabStop = false;
            // 
            // DebetfromcomboBox
            // 
            this.DebetfromcomboBox.FormattingEnabled = true;
            this.DebetfromcomboBox.Location = new System.Drawing.Point(96, 112);
            this.DebetfromcomboBox.Name = "DebetfromcomboBox";
            this.DebetfromcomboBox.Size = new System.Drawing.Size(144, 21);
            this.DebetfromcomboBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Debit from:";
            // 
            // FrmAddDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(326, 304);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddDebt";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddDebt";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmAddDebt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.Label Remaininglabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox AmountofDebttextBox;
        private System.Windows.Forms.TextBox TotalDebttextBox;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox DebetfromcomboBox;
        private System.Windows.Forms.Label label4;
    }
}