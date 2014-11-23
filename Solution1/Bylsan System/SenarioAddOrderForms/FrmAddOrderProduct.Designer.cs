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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new Telerik.WinControls.UI.RadButton();
            this.CategoryListView = new Telerik.WinControls.UI.RadListView();
            this.radListView2 = new Telerik.WinControls.UI.RadListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // CategoryListView
            // 
            this.CategoryListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CategoryListView.Location = new System.Drawing.Point(539, 25);
            this.CategoryListView.Name = "CategoryListView";
            this.CategoryListView.Size = new System.Drawing.Size(195, 379);
            this.CategoryListView.TabIndex = 4;
            this.CategoryListView.Text = "radListView1";
            // 
            // radListView2
            // 
            this.radListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView2.Location = new System.Drawing.Point(0, 25);
            this.radListView2.Name = "radListView2";
            this.radListView2.Size = new System.Drawing.Size(539, 379);
            this.radListView2.TabIndex = 5;
            this.radListView2.Text = "radListView2";
            // 
            // FrmAddOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.radListView2);
            this.Controls.Add(this.CategoryListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAddOrderProduct";
            this.Text = "FrmAddOrderProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton nextBtn;
        private Telerik.WinControls.UI.RadListView CategoryListView;
        private Telerik.WinControls.UI.RadListView radListView2;
    }
}