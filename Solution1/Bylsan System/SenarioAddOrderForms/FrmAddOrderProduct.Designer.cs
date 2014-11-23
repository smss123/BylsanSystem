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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new Telerik.WinControls.UI.RadButton();
            this.CategoryListView = new Telerik.WinControls.UI.RadListView();
            this.ProductListView = new Telerik.WinControls.UI.RadListView();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.CustomerInfomationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 55);
            this.panel1.TabIndex = 3;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(586, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(144, 46);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.ThemeName = "Windows8";
            // 
            // CategoryListView
            // 
            this.CategoryListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CategoryListView.Location = new System.Drawing.Point(556, 16);
            this.CategoryListView.Name = "CategoryListView";
            this.CategoryListView.Size = new System.Drawing.Size(175, 299);
            this.CategoryListView.TabIndex = 4;
            this.CategoryListView.Text = "radListView1";
            // 
            // ProductListView
            // 
            this.ProductListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductListView.Location = new System.Drawing.Point(3, 16);
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(553, 299);
            this.ProductListView.TabIndex = 5;
            this.ProductListView.Text = "radListView2";
            // 
            // CustomerInfomationGroupBox
            // 
            this.CustomerInfomationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfomationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfomationGroupBox.Name = "CustomerInfomationGroupBox";
            this.CustomerInfomationGroupBox.Size = new System.Drawing.Size(734, 86);
            this.CustomerInfomationGroupBox.TabIndex = 6;
            this.CustomerInfomationGroupBox.TabStop = false;
            this.CustomerInfomationGroupBox.Text = "Customer Infomation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductListView);
            this.groupBox1.Controls.Add(this.CategoryListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 318);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // FrmAddOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerInfomationGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmAddOrderProduct";
            this.Text = "FrmAddOrderProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton nextBtn;
        private Telerik.WinControls.UI.RadListView CategoryListView;
        private Telerik.WinControls.UI.RadListView ProductListView;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.GroupBox CustomerInfomationGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}