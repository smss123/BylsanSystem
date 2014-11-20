namespace Bylsan_System.CustomerForms
{
    partial class FrmCustomerEdit
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            customerNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(customerNameLabel);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Customer";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(XamaDataLayer.Customer);
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(17, 30);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(87, 13);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(110, 27);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(17, 64);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(110, 64);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(201, 20);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(20, 118);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(123, 35);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            // 
            // FrmCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 207);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustomerEdit";
            this.Text = "FrmCustomerEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox customerNameTextBox;
    }
}