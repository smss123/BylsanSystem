namespace Bylsan_System.EmployeeForms
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
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.nationaltyComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_NameTextBox = new System.Windows.Forms.TextBox();
            this.hereDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.personalty_IDTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            emp_NameLabel = new System.Windows.Forms.Label();
            hereDateLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            personalty_IDLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            nationaltyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_NameLabel
            // 
            emp_NameLabel.AutoSize = true;
            emp_NameLabel.Location = new System.Drawing.Point(31, 31);
            emp_NameLabel.Name = "emp_NameLabel";
            emp_NameLabel.Size = new System.Drawing.Size(64, 13);
            emp_NameLabel.TabIndex = 2;
            emp_NameLabel.Text = "Emp Name:";
            // 
            // hereDateLabel
            // 
            hereDateLabel.AutoSize = true;
            hereDateLabel.Location = new System.Drawing.Point(31, 59);
            hereDateLabel.Name = "hereDateLabel";
            hereDateLabel.Size = new System.Drawing.Size(61, 13);
            hereDateLabel.TabIndex = 4;
            hereDateLabel.Text = "Here Date:";
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(14, 196);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(84, 13);
            homeAddressLabel.TabIndex = 6;
            homeAddressLabel.Text = "Home Address:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(68, 171);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(28, 13);
            jobLabel.TabIndex = 10;
            jobLabel.Text = "Job:";
            // 
            // personalty_IDLabel
            // 
            personalty_IDLabel.AutoSize = true;
            personalty_IDLabel.Location = new System.Drawing.Point(16, 140);
            personalty_IDLabel.Name = "personalty_IDLabel";
            personalty_IDLabel.Size = new System.Drawing.Size(77, 13);
            personalty_IDLabel.TabIndex = 14;
            personalty_IDLabel.Text = "Personalty ID:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(10, 113);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // nationaltyLabel
            // 
            nationaltyLabel.AutoSize = true;
            nationaltyLabel.Location = new System.Drawing.Point(32, 85);
            nationaltyLabel.Name = "nationaltyLabel";
            nationaltyLabel.Size = new System.Drawing.Size(63, 13);
            nationaltyLabel.TabIndex = 17;
            nationaltyLabel.Text = "Nationalty:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.groupBox1.Size = new System.Drawing.Size(370, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(11, 241);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // nationaltyComboBox
            // 
            this.nationaltyComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.nationaltyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Nationalty", true));
            this.nationaltyComboBox.FormattingEnabled = true;
            this.nationaltyComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.nationaltyComboBox.Location = new System.Drawing.Point(99, 82);
            this.nationaltyComboBox.Name = "nationaltyComboBox";
            this.nationaltyComboBox.Size = new System.Drawing.Size(255, 21);
            this.nationaltyComboBox.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(XamaDataLayer.Employee);
            // 
            // emp_NameTextBox
            // 
            this.emp_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.emp_NameTextBox.Location = new System.Drawing.Point(99, 28);
            this.emp_NameTextBox.Name = "emp_NameTextBox";
            this.emp_NameTextBox.Size = new System.Drawing.Size(255, 20);
            this.emp_NameTextBox.TabIndex = 0;
            // 
            // hereDateDateTimePicker
            // 
            this.hereDateDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.hereDateDateTimePicker.Location = new System.Drawing.Point(99, 55);
            this.hereDateDateTimePicker.Name = "hereDateDateTimePicker";
            this.hereDateDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.hereDateDateTimePicker.TabIndex = 1;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.homeAddressTextBox.Location = new System.Drawing.Point(100, 193);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(254, 20);
            this.homeAddressTextBox.TabIndex = 6;
            // 
            // jobTextBox
            // 
            this.jobTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.jobTextBox.Location = new System.Drawing.Point(100, 165);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(254, 20);
            this.jobTextBox.TabIndex = 5;
            // 
            // personalty_IDTextBox
            // 
            this.personalty_IDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.personalty_IDTextBox.Location = new System.Drawing.Point(99, 137);
            this.personalty_IDTextBox.Name = "personalty_IDTextBox";
            this.personalty_IDTextBox.Size = new System.Drawing.Size(255, 20);
            this.personalty_IDTextBox.TabIndex = 4;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 110);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(255, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(402, 323);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 356);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 356);
            this.Name = "FrmAddEmployee";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(410, 356);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.ThemeName = "VisualStudio2012Light";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
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
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}