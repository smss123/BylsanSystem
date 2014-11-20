﻿namespace Bylsan_System.EmployeeForms
{
    partial class FrmAddEmployee
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
            System.Windows.Forms.Label emp_NameLabel;
            System.Windows.Forms.Label hereDateLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label personalty_IDLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label nationaltyLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emp_NameTextBox = new System.Windows.Forms.TextBox();
            this.hereDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.personalty_IDTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationaltyComboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            emp_NameLabel = new System.Windows.Forms.Label();
            hereDateLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            personalty_IDLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            nationaltyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(nationaltyLabel);
            this.groupBox1.Controls.Add(this.nationaltyComboBox);
            this.groupBox1.Controls.Add(emp_NameLabel);
            this.groupBox1.Controls.Add(this.emp_NameTextBox);
            this.groupBox1.Controls.Add(hereDateLabel);
            this.groupBox1.Controls.Add(this.hereDateDateTimePicker);
            this.groupBox1.Controls.Add(homeAddressLabel);
            this.groupBox1.Controls.Add(this.homeAddressTextBox);
            this.groupBox1.Controls.Add(jobLabel);
            this.groupBox1.Controls.Add(this.jobTextBox);
            this.groupBox1.Controls.Add(personalty_IDLabel);
            this.groupBox1.Controls.Add(this.personalty_IDTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // emp_NameLabel
            // 
            emp_NameLabel.AutoSize = true;
            emp_NameLabel.Location = new System.Drawing.Point(31, 35);
            emp_NameLabel.Name = "emp_NameLabel";
            emp_NameLabel.Size = new System.Drawing.Size(61, 13);
            emp_NameLabel.TabIndex = 2;
            emp_NameLabel.Text = "Emp Name:";
            // 
            // emp_NameTextBox
            // 
            this.emp_NameTextBox.Location = new System.Drawing.Point(99, 32);
            this.emp_NameTextBox.Name = "emp_NameTextBox";
            this.emp_NameTextBox.Size = new System.Drawing.Size(255, 20);
            this.emp_NameTextBox.TabIndex = 0;
            // 
            // hereDateLabel
            // 
            hereDateLabel.AutoSize = true;
            hereDateLabel.Location = new System.Drawing.Point(31, 62);
            hereDateLabel.Name = "hereDateLabel";
            hereDateLabel.Size = new System.Drawing.Size(60, 13);
            hereDateLabel.TabIndex = 4;
            hereDateLabel.Text = "Here Date:";
            // 
            // hereDateDateTimePicker
            // 
            this.hereDateDateTimePicker.Location = new System.Drawing.Point(99, 58);
            this.hereDateDateTimePicker.Name = "hereDateDateTimePicker";
            this.hereDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hereDateDateTimePicker.TabIndex = 1;
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(20, 228);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(80, 13);
            homeAddressLabel.TabIndex = 6;
            homeAddressLabel.Text = "Home Address:";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(100, 225);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(254, 20);
            this.homeAddressTextBox.TabIndex = 6;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(68, 196);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(28, 13);
            jobLabel.TabIndex = 10;
            jobLabel.Text = "Job:";
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(100, 190);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(200, 20);
            this.jobTextBox.TabIndex = 5;
            // 
            // personalty_IDLabel
            // 
            personalty_IDLabel.AutoSize = true;
            personalty_IDLabel.Location = new System.Drawing.Point(23, 161);
            personalty_IDLabel.Name = "personalty_IDLabel";
            personalty_IDLabel.Size = new System.Drawing.Size(76, 13);
            personalty_IDLabel.TabIndex = 14;
            personalty_IDLabel.Text = "Personalty ID:";
            // 
            // personalty_IDTextBox
            // 
            this.personalty_IDTextBox.Location = new System.Drawing.Point(99, 158);
            this.personalty_IDTextBox.Name = "personalty_IDTextBox";
            this.personalty_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.personalty_IDTextBox.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(17, 126);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 123);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(XamaDataLayer.Employee);
            // 
            // nationaltyLabel
            // 
            nationaltyLabel.AutoSize = true;
            nationaltyLabel.Location = new System.Drawing.Point(32, 95);
            nationaltyLabel.Name = "nationaltyLabel";
            nationaltyLabel.Size = new System.Drawing.Size(60, 13);
            nationaltyLabel.TabIndex = 17;
            nationaltyLabel.Text = "Nationalty:";
            // 
            // nationaltyComboBox
            // 
            this.nationaltyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Nationalty", true));
            this.nationaltyComboBox.FormattingEnabled = true;
            this.nationaltyComboBox.Location = new System.Drawing.Point(99, 92);
            this.nationaltyComboBox.Name = "nationaltyComboBox";
            this.nationaltyComboBox.Size = new System.Drawing.Size(121, 21);
            this.nationaltyComboBox.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(33, 289);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 36);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddEmployee";
            this.Text = "FrmAddEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emp_NameTextBox;
        private System.Windows.Forms.DateTimePicker hereDateDateTimePicker;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox personalty_IDTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox nationaltyComboBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}