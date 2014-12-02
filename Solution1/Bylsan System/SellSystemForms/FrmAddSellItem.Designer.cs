﻿namespace Bylsan_System.SellSystemForms
{
    partial class FrmAddSellItem
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
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label itemPriceLabel;
            System.Windows.Forms.Label label1;
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.BrowseBtn = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            itemNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            itemPriceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(19, 32);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(64, 13);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(14, 58);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Location = new System.Drawing.Point(24, 126);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new System.Drawing.Size(59, 13);
            itemPriceLabel.TabIndex = 4;
            itemPriceLabel.Text = "Item Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 154);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 9;
            label1.Text = "Item Icon:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.BrowseBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(itemPriceLabel);
            this.groupBox1.Controls.Add(this.itemPriceTextBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = global::Bylsan_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(17, 225);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 37);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "VisualStudio2012Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(173, 154);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(51, 24);
            this.BrowseBtn.TabIndex = 4;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.ThemeName = "VisualStudio2012Light";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(89, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 54);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemPriceTextBox.Location = new System.Drawing.Point(89, 123);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.itemPriceTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 55);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(217, 60);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemNameTextBox.Location = new System.Drawing.Point(89, 29);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // FrmAddSellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(360, 311);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddSellItem";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddSellItem";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton BrowseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}
