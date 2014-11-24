namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmOrderDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            this.AdresstextBox = new System.Windows.Forms.TextBox();
            this.receiptdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receiptdateTimePicker);
            this.groupBox1.Controls.Add(this.AdresstextBox);
            this.groupBox1.Controls.Add(this.NextBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date and Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of receipt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(195, 98);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(119, 41);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "Next";
            // 
            // AdresstextBox
            // 
            this.AdresstextBox.Location = new System.Drawing.Point(95, 65);
            this.AdresstextBox.Name = "AdresstextBox";
            this.AdresstextBox.Size = new System.Drawing.Size(219, 20);
            this.AdresstextBox.TabIndex = 2;
            // 
            // receiptdateTimePicker
            // 
            this.receiptdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.receiptdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiptdateTimePicker.Location = new System.Drawing.Point(95, 39);
            this.receiptdateTimePicker.Name = "receiptdateTimePicker";
            this.receiptdateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.receiptdateTimePicker.TabIndex = 1;
            // 
            // FrmOrderDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderDate";
            this.Text = "FrmOrderDate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton NextBtn;
        private System.Windows.Forms.DateTimePicker receiptdateTimePicker;
        private System.Windows.Forms.TextBox AdresstextBox;
    }
}