namespace Bylsan_System.AccountsX
{
    partial class FrmAccountTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountTree));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeAccounts = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.CollapseBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CollapseBtn);
            this.groupBox1.Controls.Add(this.ExpandBtn);
            this.groupBox1.Controls.Add(this.TreeAccounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TreeAccounts
            // 
            this.TreeAccounts.Location = new System.Drawing.Point(16, 19);
            this.TreeAccounts.Name = "TreeAccounts";
            this.TreeAccounts.Size = new System.Drawing.Size(408, 348);
            this.TreeAccounts.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            this.imageList1.Images.SetKeyName(2, "payment-card.png");
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.Location = new System.Drawing.Point(286, 373);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(138, 30);
            this.ExpandBtn.TabIndex = 1;
            this.ExpandBtn.Text = "Expaned All";
            this.ExpandBtn.UseVisualStyleBackColor = true;
            this.ExpandBtn.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Location = new System.Drawing.Point(29, 373);
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.Size = new System.Drawing.Size(113, 30);
            this.CollapseBtn.TabIndex = 2;
            this.CollapseBtn.Text = "Collapse All";
            this.CollapseBtn.UseVisualStyleBackColor = true;
            this.CollapseBtn.Click += new System.EventHandler(this.CollapseBtn_Click);
            // 
            // FrmAccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 445);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAccountTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccountTree";
            this.Load += new System.EventHandler(this.FrmAccountTree_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TreeAccounts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CollapseBtn;
        private System.Windows.Forms.Button ExpandBtn;
    }
}