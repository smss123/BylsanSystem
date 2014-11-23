namespace Bylsan_System.SenarioAddOrderForms
{
    partial class FrmAddOrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrderProduct));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new Telerik.WinControls.UI.RadButton();
            this.ListViewProductes = new Telerik.WinControls.UI.RadListView();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.CustomerInfomationGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTypeCheckLab = new System.Windows.Forms.Label();
            this.CustomerPhoneLab = new System.Windows.Forms.Label();
            this.CustomerNameLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CollapseBtn = new System.Windows.Forms.Button();
            this.ExpandAll = new System.Windows.Forms.Button();
            this.TreeCategories = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewProductes)).BeginInit();
            this.CustomerInfomationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 192);
            this.panel1.TabIndex = 3;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(871, 133);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(144, 46);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.ThemeName = "Windows8";
            // 
            // ListViewProductes
            // 
            this.ListViewProductes.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListViewProductes.Location = new System.Drawing.Point(170, 16);
            this.ListViewProductes.Name = "ListViewProductes";
            this.ListViewProductes.Size = new System.Drawing.Size(845, 293);
            this.ListViewProductes.TabIndex = 4;
            this.ListViewProductes.Text = "radListView1";
            // 
            // CustomerInfomationGroupBox
            // 
            this.CustomerInfomationGroupBox.Controls.Add(this.OrderTypeCheckLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.CustomerPhoneLab);
            this.CustomerInfomationGroupBox.Controls.Add(this.CustomerNameLab);
            this.CustomerInfomationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfomationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfomationGroupBox.Name = "CustomerInfomationGroupBox";
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(1018, 86);
            this.CustomerInfomationGroupBox.TabIndex = 6;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // OrderTypeCheckLab
            // 
            this.OrderTypeCheckLab.AutoSize = true;
            this.OrderTypeCheckLab.Location = new System.Drawing.Point(721, 50);
            this.OrderTypeCheckLab.Name = "OrderTypeCheckLab";
            this.OrderTypeCheckLab.Size = new System.Drawing.Size(35, 13);
            this.OrderTypeCheckLab.TabIndex = 2;
            this.OrderTypeCheckLab.Text = "label1";
            // 
            // CustomerPhoneLab
            // 
            this.CustomerPhoneLab.AutoSize = true;
            this.CustomerPhoneLab.Location = new System.Drawing.Point(58, 50);
            this.CustomerPhoneLab.Name = "CustomerPhoneLab";
            this.CustomerPhoneLab.Size = new System.Drawing.Size(35, 13);
            this.CustomerPhoneLab.TabIndex = 1;
            this.CustomerPhoneLab.Text = "label2";
            // 
            // CustomerNameLab
            // 
            this.CustomerNameLab.AutoSize = true;
            this.CustomerNameLab.Location = new System.Drawing.Point(58, 26);
            this.CustomerNameLab.Name = "CustomerNameLab";
            this.CustomerNameLab.Size = new System.Drawing.Size(35, 13);
            this.CustomerNameLab.TabIndex = 0;
            this.CustomerNameLab.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CollapseBtn);
            this.groupBox1.Controls.Add(this.ExpandAll);
            this.groupBox1.Controls.Add(this.TreeCategories);
            this.groupBox1.Controls.Add(this.ListViewProductes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Location = new System.Drawing.Point(89, 283);
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.Size = new System.Drawing.Size(75, 23);
            this.CollapseBtn.TabIndex = 6;
            this.CollapseBtn.Text = "Collapse All";
            this.CollapseBtn.UseVisualStyleBackColor = true;
            this.CollapseBtn.Click += new System.EventHandler(this.CollapesBtn_Click);
            // 
            // ExpandAll
            // 
            this.ExpandAll.Location = new System.Drawing.Point(12, 283);
            this.ExpandAll.Name = "ExpandAll";
            this.ExpandAll.Size = new System.Drawing.Size(75, 23);
            this.ExpandAll.TabIndex = 2;
            this.ExpandAll.Text = "Expand All";
            this.ExpandAll.UseVisualStyleBackColor = true;
            this.ExpandAll.Click += new System.EventHandler(this.ExpanedAll_Click);
            // 
            // TreeCategories
            // 
            this.TreeCategories.Location = new System.Drawing.Point(12, 19);
            this.TreeCategories.Name = "TreeCategories";
            this.TreeCategories.Size = new System.Drawing.Size(152, 260);
            this.TreeCategories.TabIndex = 5;
            this.TreeCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeCategories_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye.png");
            this.imageList1.Images.SetKeyName(1, "award_star_bronze_2.png");
            // 
            // FrmAddOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerInfomationGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmAddOrderProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAddOrderProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewProductes)).EndInit();
            this.CustomerInfomationGroupBox.ResumeLayout(false);
            this.CustomerInfomationGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton nextBtn;
        private Telerik.WinControls.UI.RadListView ListViewProductes;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TreeCategories;
        public System.Windows.Forms.Label CustomerPhoneLab;
        public System.Windows.Forms.Label CustomerNameLab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CollapseBtn;
        private System.Windows.Forms.Button ExpandAll;
        public System.Windows.Forms.Label OrderTypeCheckLab;
    }
}