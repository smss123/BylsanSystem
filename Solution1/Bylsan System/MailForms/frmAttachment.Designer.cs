namespace Bylsan_System.MailForms
{
    partial class frmAttachment
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
            System.Windows.Forms.Label attachmentXLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.mailAttachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentXPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.mailAttachmentDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            attachmentXLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mailAttachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentXPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailAttachmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // attachmentXLabel
            // 
            attachmentXLabel.AutoSize = true;
            attachmentXLabel.Location = new System.Drawing.Point(321, 38);
            attachmentXLabel.Name = "attachmentXLabel";
            attachmentXLabel.Size = new System.Drawing.Size(67, 13);
            attachmentXLabel.TabIndex = 1;
            attachmentXLabel.Text = "Attachment:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(324, 170);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // mailAttachmentBindingSource
            // 
            this.mailAttachmentBindingSource.DataSource = typeof(XamaDataLayer.MailAttachment);
            // 
            // attachmentXPictureBox
            // 
            this.attachmentXPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mailAttachmentBindingSource, "AttachmentX", true));
            this.attachmentXPictureBox.Location = new System.Drawing.Point(394, 38);
            this.attachmentXPictureBox.Name = "attachmentXPictureBox";
            this.attachmentXPictureBox.Size = new System.Drawing.Size(147, 123);
            this.attachmentXPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attachmentXPictureBox.TabIndex = 2;
            this.attachmentXPictureBox.TabStop = false;
            this.attachmentXPictureBox.Click += new System.EventHandler(this.attachmentXPictureBox_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mailAttachmentBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(394, 167);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(147, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // mailAttachmentDataGridView
            // 
            this.mailAttachmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailAttachmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.AttachmentName,
            this.ColDescription});
            this.mailAttachmentDataGridView.Location = new System.Drawing.Point(12, 228);
            this.mailAttachmentDataGridView.Name = "mailAttachmentDataGridView";
            this.mailAttachmentDataGridView.Size = new System.Drawing.Size(534, 223);
            this.mailAttachmentDataGridView.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(466, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // AttachmentName
            // 
            this.AttachmentName.HeaderText = "Attachment Name";
            this.AttachmentName.Name = "AttachmentName";
            // 
            // ColDescription
            // 
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            // 
            // frmAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 463);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mailAttachmentDataGridView);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(attachmentXLabel);
            this.Controls.Add(this.attachmentXPictureBox);
            this.Name = "frmAttachment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attachment";
            this.Load += new System.EventHandler(this.frmAttachment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mailAttachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentXPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailAttachmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mailAttachmentBindingSource;
        private System.Windows.Forms.PictureBox attachmentXPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridView mailAttachmentDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
    }
}