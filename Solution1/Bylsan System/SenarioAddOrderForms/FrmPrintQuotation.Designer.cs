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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintQuotation));
            this.quotationForTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressForTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.TreeCategories = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBtn = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            quotationForLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressForLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(addressForLabel);
            this.groupBox1.Controls.Add(this.addressForTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.quotationForTextBox);
            this.groupBox1.Controls.Add(quotationForLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 120);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewProducts);
            this.groupBox2.Controls.Add(this.TreeCategories);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 356);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // ListViewProducts
            // 
            this.ListViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListViewProducts.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListViewProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewProducts.ForeColor = System.Drawing.Color.Blue;
            this.ListViewProducts.FullRowSelect = true;
            this.ListViewProducts.GridLines = true;
            this.ListViewProducts.Location = new System.Drawing.Point(175, 18);
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(591, 335);
            this.ListViewProducts.TabIndex = 8;
            this.ListViewProducts.UseCompatibleStateImageBehavior = false;
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
            this.TreeCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeCategories_NodeMouseClick);
            this.TreeCategories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeCategories_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 89);
            this.panel1.TabIndex = 7;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Image = global::Bylsan_System.Properties.Resources.Print;
            this.PrintBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintBtn.Location = new System.Drawing.Point(634, 29);
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
            this.ClientSize = new System.Drawing.Size(769, 612);
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
            this.Text = "FrmPrintQuotation";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmPrintQuotation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton PrintBtn;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}