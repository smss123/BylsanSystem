﻿namespace Bylsan_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UserDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EmployeeDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddEmloyeebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.managementEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BranchDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addBranchBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addProductCategoryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ManagementBranchBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MangeProductCategoryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.managementProductBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addCustomerbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserDropDownButton,
            this.toolStripSeparator1,
            this.EmployeeDropDownButton,
            this.BranchDropDownButton,
            this.ProductDropDownButton,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UserDropDownButton
            // 
            this.UserDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.manToolStripMenuItem});
            this.UserDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("UserDropDownButton.Image")));
            this.UserDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserDropDownButton.Name = "UserDropDownButton";
            this.UserDropDownButton.Size = new System.Drawing.Size(64, 22);
            this.UserDropDownButton.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // manToolStripMenuItem
            // 
            this.manToolStripMenuItem.Name = "manToolStripMenuItem";
            this.manToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manToolStripMenuItem.Text = " User Management";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EmployeeDropDownButton
            // 
            this.EmployeeDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmloyeebtn,
            this.managementEmployeeToolStripMenuItem});
            this.EmployeeDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeDropDownButton.Image")));
            this.EmployeeDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmployeeDropDownButton.Name = "EmployeeDropDownButton";
            this.EmployeeDropDownButton.Size = new System.Drawing.Size(88, 22);
            this.EmployeeDropDownButton.Text = "Employee";
            // 
            // AddEmloyeebtn
            // 
            this.AddEmloyeebtn.Name = "AddEmloyeebtn";
            this.AddEmloyeebtn.Size = new System.Drawing.Size(203, 22);
            this.AddEmloyeebtn.Text = "Add Employee";
            this.AddEmloyeebtn.Click += new System.EventHandler(this.AddEmloyeebtn_Click);
            // 
            // managementEmployeeToolStripMenuItem
            // 
            this.managementEmployeeToolStripMenuItem.Name = "managementEmployeeToolStripMenuItem";
            this.managementEmployeeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.managementEmployeeToolStripMenuItem.Text = " Employee Management";
            this.managementEmployeeToolStripMenuItem.Click += new System.EventHandler(this.managementEmployeeToolStripMenuItem_Click);
            // 
            // BranchDropDownButton
            // 
            this.BranchDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBranchBtn,
            this.ManagementBranchBtn});
            this.BranchDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("BranchDropDownButton.Image")));
            this.BranchDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BranchDropDownButton.Name = "BranchDropDownButton";
            this.BranchDropDownButton.Size = new System.Drawing.Size(73, 22);
            this.BranchDropDownButton.Text = "Branch";
            // 
            // addBranchBtn
            // 
            this.addBranchBtn.Name = "addBranchBtn";
            this.addBranchBtn.Size = new System.Drawing.Size(188, 22);
            this.addBranchBtn.Text = "Add Branch";
            this.addBranchBtn.Click += new System.EventHandler(this.addBranchBtn_Click);
            // 
            // ProductDropDownButton
            // 
            this.ProductDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductCategoryBtn,
            this.MangeProductCategoryBtn,
            this.toolStripSeparator2,
            this.addProductBtn,
            this.managementProductBtn});
            this.ProductDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductDropDownButton.Image")));
            this.ProductDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductDropDownButton.Name = "ProductDropDownButton";
            this.ProductDropDownButton.Size = new System.Drawing.Size(78, 22);
            this.ProductDropDownButton.Text = "Product";
            // 
            // addProductCategoryBtn
            // 
            this.addProductCategoryBtn.Name = "addProductCategoryBtn";
            this.addProductCategoryBtn.Size = new System.Drawing.Size(244, 22);
            this.addProductCategoryBtn.Text = "Add Product Category";
            this.addProductCategoryBtn.Click += new System.EventHandler(this.addProductCategoryBtn_Click);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerbtn,
            this.customerManagementBtn});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(93, 22);
            this.toolStripDropDownButton5.Text = "Customers";
            // 
            // toolStripDropDownButton6
            // 
            this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
            this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
            this.toolStripDropDownButton6.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton6.Text = "toolStripDropDownButton6";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(936, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ManagementBranchBtn
            // 
            this.ManagementBranchBtn.Name = "ManagementBranchBtn";
            this.ManagementBranchBtn.Size = new System.Drawing.Size(188, 22);
            this.ManagementBranchBtn.Text = " Branch Management";
            this.ManagementBranchBtn.Click += new System.EventHandler(this.ManagementBranchBtn_Click);
            // 
            // MangeProductCategoryBtn
            // 
            this.MangeProductCategoryBtn.Name = "MangeProductCategoryBtn";
            this.MangeProductCategoryBtn.Size = new System.Drawing.Size(244, 22);
            this.MangeProductCategoryBtn.Text = " Product Category Management";
            this.MangeProductCategoryBtn.Click += new System.EventHandler(this.MangeProductCategoryBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(244, 22);
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // managementProductBtn
            // 
            this.managementProductBtn.Name = "managementProductBtn";
            this.managementProductBtn.Size = new System.Drawing.Size(244, 22);
            this.managementProductBtn.Text = "Product Management ";
            this.managementProductBtn.Click += new System.EventHandler(this.managementProductBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // addCustomerbtn
            // 
            this.addCustomerbtn.Name = "addCustomerbtn";
            this.addCustomerbtn.Size = new System.Drawing.Size(200, 22);
            this.addCustomerbtn.Text = "Add Customer";
            this.addCustomerbtn.Click += new System.EventHandler(this.addCustomerbtn_Click);
            // 
            // customerManagementBtn
            // 
            this.customerManagementBtn.Name = "customerManagementBtn";
            this.customerManagementBtn.Size = new System.Drawing.Size(200, 22);
            this.customerManagementBtn.Text = "Customer Management";
            this.customerManagementBtn.Click += new System.EventHandler(this.customerManagementBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton UserDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton EmployeeDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AddEmloyeebtn;
        private System.Windows.Forms.ToolStripMenuItem managementEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton BranchDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addBranchBtn;
        private System.Windows.Forms.ToolStripDropDownButton ProductDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addProductCategoryBtn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ManagementBranchBtn;
        private System.Windows.Forms.ToolStripMenuItem MangeProductCategoryBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addProductBtn;
        private System.Windows.Forms.ToolStripMenuItem managementProductBtn;
        private System.Windows.Forms.ToolStripMenuItem addCustomerbtn;
        private System.Windows.Forms.ToolStripMenuItem customerManagementBtn;

    }
}