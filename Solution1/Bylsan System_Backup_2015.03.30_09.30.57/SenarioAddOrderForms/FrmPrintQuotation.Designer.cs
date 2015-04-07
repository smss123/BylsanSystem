namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmPrintQuotation
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
            System.Windows.Forms.Label quotationForLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressForLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintQuotation));
            this.quotationForTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressForTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ckBracode = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreeCategories = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Publicnamelab = new System.Windows.Forms.Label();
            this.ProductDescriotionLab = new System.Windows.Forms.Label();
            this.ProductNameLab = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.PrintBtn = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            quotationForLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressForLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // quotationForLabel
            // 
            quotationForLabel.AutoSize = true;
            quotationForLabel.Location = new System.Drawing.Point(66, 27);
            quotationForLabel.Name = "quotationForLabel";
            quotationForLabel.Size = new System.Drawing.Size(27, 13);
            quotationForLabel.TabIndex = 1;
            quotationForLabel.Text = "For:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 53);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addressForLabel
            // 
            addressForLabel.AutoSize = true;
            addressForLabel.Location = new System.Drawing.Point(24, 79);
            addressForLabel.Name = "addressForLabel";
            addressForLabel.Size = new System.Drawing.Size(71, 13);
            addressForLabel.TabIndex = 4;
            addressForLabel.Text = "Address For:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(448, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 1;
            label1.Text = "Description :";
            // 
            // quotationForTextBox
            // 
            this.quotationForTextBox.Location = new System.Drawing.Point(99, 24);
            this.quotationForTextBox.Name = "quotationForTextBox";
            this.quotationForTextBox.Size = new System.Drawing.Size(316, 20);
            this.quotationForTextBox.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1098, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(addressForLabel);
            this.groupBox1.Controls.Add(this.addressForTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.quotationForTextBox);
            this.groupBox1.Controls.Add(quotationForLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quotation Information ";
            // 
            // addressForTextBox
            // 
            this.addressForTextBox.Location = new System.Drawing.Point(99, 76);
            this.addressForTextBox.Name = "addressForTextBox";
            this.addressForTextBox.Size = new System.Drawing.Size(300, 20);
            this.addressForTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(99, 50);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(181, 20);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(528, 24);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(316, 72);
            this.txtDescription.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.TreeCategories);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 356);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.ckBracode);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(176, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 64);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ckBracode
            // 
            this.ckBracode.AutoSize = true;
            this.ckBracode.Location = new System.Drawing.Point(8, 24);
            this.ckBracode.Name = "ckBracode";
            this.ckBracode.Size = new System.Drawing.Size(72, 17);
            this.ckBracode.TabIndex = 1;
            this.ckBracode.TabStop = true;
            this.ckBracode.Text = "Bar Code";
            this.ckBracode.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.QtyX,
            this.dataGridViewTextBoxColumn3,
            this.amountX,
            this.ColDescription});
            this.dataGridView2.Location = new System.Drawing.Point(624, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(464, 336);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // QtyX
            // 
            this.QtyX.HeaderText = "Qty";
            this.QtyX.Name = "QtyX";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // amountX
            // 
            this.amountX.HeaderText = "Amount";
            this.amountX.Name = "amountX";
            // 
            // ColDescription
            // 
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.ProductName,
            this.ProductPrice});
            this.dataGridView1.Location = new System.Drawing.Point(176, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 264);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDProduct
            // 
            this.IDProduct.DataPropertyName = "ID";
            this.IDProduct.HeaderText = "Product ID";
            this.IDProduct.Name = "IDProduct";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Product_Name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // TreeCategories
            // 
            this.TreeCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeCategories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeCategories.LineColor = System.Drawing.Color.Blue;
            this.TreeCategories.Location = new System.Drawing.Point(3, 18);
            this.TreeCategories.Name = "TreeCategories";
            this.TreeCategories.Size = new System.Drawing.Size(166, 335);
            this.TreeCategories.TabIndex = 7;
            this.TreeCategories.Visible = false;
            this.TreeCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeCategories_NodeMouseClick);
            this.TreeCategories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeCategories_NodeMouseDoubleClick);
            this.TreeCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeCategories_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Publicnamelab);
            this.panel1.Controls.Add(this.ProductDescriotionLab);
            this.panel1.Controls.Add(this.ProductNameLab);
            this.panel1.Controls.Add(this.PhotoBox);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 89);
            this.panel1.TabIndex = 7;
            // 
            // Publicnamelab
            // 
            this.Publicnamelab.AutoSize = true;
            this.Publicnamelab.Location = new System.Drawing.Point(248, 56);
            this.Publicnamelab.Name = "Publicnamelab";
            this.Publicnamelab.Size = new System.Drawing.Size(11, 13);
            this.Publicnamelab.TabIndex = 8;
            this.Publicnamelab.Text = "-";
            // 
            // ProductDescriotionLab
            // 
            this.ProductDescriotionLab.AutoSize = true;
            this.ProductDescriotionLab.Location = new System.Drawing.Point(248, 40);
            this.ProductDescriotionLab.Name = "ProductDescriotionLab";
            this.ProductDescriotionLab.Size = new System.Drawing.Size(11, 13);
            this.ProductDescriotionLab.TabIndex = 7;
            this.ProductDescriotionLab.Text = "-";
            // 
            // ProductNameLab
            // 
            this.ProductNameLab.AutoSize = true;
            this.ProductNameLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLab.ForeColor = System.Drawing.Color.Red;
            this.ProductNameLab.Location = new System.Drawing.Point(248, 16);
            this.ProductNameLab.Name = "ProductNameLab";
            this.ProductNameLab.Size = new System.Drawing.Size(14, 19);
            this.ProductNameLab.TabIndex = 6;
            this.ProductNameLab.Text = "-";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoBox.Location = new System.Drawing.Point(96, 16);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(137, 56);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 5;
            this.PhotoBox.TabStop = false;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Image = global::Bylsan_System.Properties.Resources.Print;
            this.PrintBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintBtn.Location = new System.Drawing.Point(968, 24);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(123, 46);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintBtn.ThemeName = "VisualStudio2012Light";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye.png");
            this.imageList1.Images.SetKeyName(1, "award_star_bronze_2.png");
            this.imageList1.Images.SetKeyName(2, "yen coins.ico");
            // 
            // FrmPrintQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1098, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrintQuotation";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintQuotation";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FrmPrintQuotation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quotationForTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressForTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView TreeCategories;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton PrintBtn;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton ckBracode;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label Publicnamelab;
        private System.Windows.Forms.Label ProductDescriotionLab;
        private System.Windows.Forms.Label ProductNameLab;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
    }
}