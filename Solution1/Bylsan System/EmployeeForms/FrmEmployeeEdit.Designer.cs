namespace Bylsan_System.EmployeeForms
{
    partial class FrmEmployeeEdit
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
            System.Windows.Forms.Label nationaltyLabel;
            System.Windows.Forms.Label emp_NameLabel;
            System.Windows.Forms.Label hereDateLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label personalty_IDLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.nationaltyComboBox = new System.Windows.Forms.ComboBox();
            this.emp_NameTextBox = new System.Windows.Forms.TextBox();
            this.hereDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.personalty_IDTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            nationaltyLabel = new System.Windows.Forms.Label();
            emp_NameLabel = new System.Windows.Forms.Label();
            hereDateLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            personalty_IDLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // nationaltyLabel
            // 
            nationaltyLabel.AutoSize = true;
            nationaltyLabel.Location = new System.Drawing.Point(32, 92);
            nationaltyLabel.Name = "nationaltyLabel";
            nationaltyLabel.Size = new System.Drawing.Size(63, 13);
            nationaltyLabel.TabIndex = 17;
            nationaltyLabel.Text = "Nationalty:";
            // 
            // emp_NameLabel
            // 
            emp_NameLabel.AutoSize = true;
            emp_NameLabel.Location = new System.Drawing.Point(31, 35);
            emp_NameLabel.Name = "emp_NameLabel";
            emp_NameLabel.Size = new System.Drawing.Size(64, 13);
            emp_NameLabel.TabIndex = 2;
            emp_NameLabel.Text = "Emp Name:";
            // 
            // hereDateLabel
            // 
            hereDateLabel.AutoSize = true;
            hereDateLabel.Location = new System.Drawing.Point(30, 64);
            hereDateLabel.Name = "hereDateLabel";
            hereDateLabel.Size = new System.Drawing.Size(61, 13);
            hereDateLabel.TabIndex = 4;
            hereDateLabel.Text = "Here Date:";
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(15, 205);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(84, 13);
            homeAddressLabel.TabIndex = 6;
            homeAddressLabel.Text = "Home Address:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(67, 177);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(28, 13);
            jobLabel.TabIndex = 10;
            jobLabel.Text = "Job:";
            // 
            // personalty_IDLabel
            // 
            personalty_IDLabel.AutoSize = true;
            personalty_IDLabel.Location = new System.Drawing.Point(18, 149);
            personalty_IDLabel.Name = "personalty_IDLabel";
            personalty_IDLabel.Size = new System.Drawing.Size(77, 13);
            personalty_IDLabel.TabIndex = 14;
            personalty_IDLabel.Text = "Personalty ID:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 121);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::Bylsan_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(13, 247);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "VisualStudio2012Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // nationaltyComboBox
            // 
            this.nationaltyComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.nationaltyComboBox.FormattingEnabled = true;
            this.nationaltyComboBox.Location = new System.Drawing.Point(99, 89);
            this.nationaltyComboBox.Name = "nationaltyComboBox";
            this.nationaltyComboBox.Size = new System.Drawing.Size(255, 21);
            this.nationaltyComboBox.TabIndex = 2;
            // 
            // emp_NameTextBox
            // 
            this.emp_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.emp_NameTextBox.Location = new System.Drawing.Point(99, 32);
            this.emp_NameTextBox.Name = "emp_NameTextBox";
            this.emp_NameTextBox.Size = new System.Drawing.Size(255, 20);
            this.emp_NameTextBox.TabIndex = 0;
            // 
            // hereDateDateTimePicker
            // 
            this.hereDateDateTimePicker.Location = new System.Drawing.Point(99, 60);
            this.hereDateDateTimePicker.Name = "hereDateDateTimePicker";
            this.hereDateDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.hereDateDateTimePicker.TabIndex = 1;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.homeAddressTextBox.Location = new System.Drawing.Point(100, 202);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(254, 20);
            this.homeAddressTextBox.TabIndex = 6;
            // 
            // jobTextBox
            // 
            this.jobTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.jobTextBox.Location = new System.Drawing.Point(100, 174);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(254, 20);
            this.jobTextBox.TabIndex = 5;
            // 
            // personalty_IDTextBox
            // 
            this.personalty_IDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.personalty_IDTextBox.Location = new System.Drawing.Point(99, 146);
            this.personalty_IDTextBox.Name = "personalty_IDTextBox";
            this.personalty_IDTextBox.Size = new System.Drawing.Size(255, 20);
            this.personalty_IDTextBox.TabIndex = 4;
            this.personalty_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personalty_IDTextBox_KeyPress);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 118);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(255, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 350);
            this.Name = "FrmEmployeeEdit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Employee";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEmployeeEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.ComboBox nationaltyComboBox;
        private System.Windows.Forms.TextBox emp_NameTextBox;
        private System.Windows.Forms.DateTimePicker hereDateDateTimePicker;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox personalty_IDTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}