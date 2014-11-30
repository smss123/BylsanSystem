namespace Bylsan_System.designerForms
{
    partial class FrmOrderProductShow
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DGVProducts = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.NextPhotoBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labCustomerPhone = new System.Windows.Forms.Label();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SizeLab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WthBox = new System.Windows.Forms.TextBox();
            this.HghtBox = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OrderProduct";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(178, 366);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(110, 36);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DGVProducts
            // 
            this.DGVProducts.BackColor = System.Drawing.SystemColors.Control;
            this.DGVProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVProducts.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVProducts.Location = new System.Drawing.Point(3, 16);
            // 
            // DGVProducts
            // 
            this.DGVProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ID";
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.Name = "ID";
            gridViewTextBoxColumn7.Width = 43;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ProductID";
            gridViewTextBoxColumn8.HeaderText = "Product Name";
            gridViewTextBoxColumn8.Name = "Product_Name";
            gridViewTextBoxColumn8.Width = 215;
            gridViewTextBoxColumn9.FieldName = "Qty";
            gridViewTextBoxColumn9.HeaderText = "Quantity";
            gridViewTextBoxColumn9.Name = "Quantity";
            gridViewTextBoxColumn9.Width = 115;
            this.DGVProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.DGVProducts.MasterTemplate.EnableFiltering = true;
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVProducts.Size = new System.Drawing.Size(392, 504);
            this.DGVProducts.TabIndex = 0;
            this.DGVProducts.Text = "OrdeProductGridView";
            this.DGVProducts.ThemeName = "Windows8";
            this.DGVProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGVProducts_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(17, 36);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(262, 51);
            this.TxtDescription.TabIndex = 2;
            // 
            // NextPhotoBtn
            // 
            this.NextPhotoBtn.Location = new System.Drawing.Point(162, 291);
            this.NextPhotoBtn.Name = "NextPhotoBtn";
            this.NextPhotoBtn.Size = new System.Drawing.Size(126, 23);
            this.NextPhotoBtn.TabIndex = 4;
            this.NextPhotoBtn.Text = "Next Photo >>";
            this.NextPhotoBtn.UseVisualStyleBackColor = true;
            this.NextPhotoBtn.Click += new System.EventHandler(this.NextPhotoBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Attachments:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labCustomerPhone);
            this.groupBox2.Controls.Add(this.labCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(416, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name :";
            // 
            // labCustomerPhone
            // 
            this.labCustomerPhone.AutoSize = true;
            this.labCustomerPhone.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomerPhone.Location = new System.Drawing.Point(146, 57);
            this.labCustomerPhone.Name = "labCustomerPhone";
            this.labCustomerPhone.Size = new System.Drawing.Size(112, 13);
            this.labCustomerPhone.TabIndex = 1;
            this.labCustomerPhone.Text = "labCustomerPhone:";
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomerName.Location = new System.Drawing.Point(149, 30);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(109, 13);
            this.labCustomerName.TabIndex = 0;
            this.labCustomerName.Text = "labCustomerName:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HghtBox);
            this.groupBox3.Controls.Add(this.WthBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NextPhotoBtn);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.UploadBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtDescription);
            this.groupBox3.Controls.Add(this.CloseBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SizeLab);
            this.groupBox3.Controls.Add(this.SaveBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(413, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 419);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Designing Zoon";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(17, 291);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(130, 23);
            this.UploadBtn.TabIndex = 8;
            this.UploadBtn.Text = "Upload New Image";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(209, 337);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(84, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Image Size :";
            // 
            // SizeLab
            // 
            this.SizeLab.AutoSize = true;
            this.SizeLab.Location = new System.Drawing.Point(236, 255);
            this.SizeLab.Name = "SizeLab";
            this.SizeLab.Size = new System.Drawing.Size(43, 13);
            this.SizeLab.TabIndex = 10;
            this.SizeLab.Text = "SizeLab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "New Size    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            // 
            // WthBox
            // 
            this.WthBox.Location = new System.Drawing.Point(94, 339);
            this.WthBox.Name = "WthBox";
            this.WthBox.Size = new System.Drawing.Size(43, 20);
            this.WthBox.TabIndex = 13;
            // 
            // HghtBox
            // 
            this.HghtBox.Location = new System.Drawing.Point(162, 339);
            this.HghtBox.Name = "HghtBox";
            this.HghtBox.Size = new System.Drawing.Size(43, 20);
            this.HghtBox.TabIndex = 14;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmOrderProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderProductShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderProductShow";
            this.Load += new System.EventHandler(this.FrmOrderProductShow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView DGVProducts;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label labCustomerPhone;
        public System.Windows.Forms.Label labCustomerName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button NextPhotoBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SizeLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HghtBox;
        private System.Windows.Forms.TextBox WthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList2;
    }
}