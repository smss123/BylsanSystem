﻿namespace Bylsan_System.MainStoreForms
{
    partial class FrmAddMainStore_Item
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
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label itemTypeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemTypeTextBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            itemNameLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            itemTypeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(itemTypeLabel);
            this.groupBox1.Controls.Add(this.itemTypeTextBox);
            this.groupBox1.Controls.Add(itemDescriptionLabel);
            this.groupBox1.Controls.Add(this.itemDescriptionTextBox);
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(32, 35);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(63, 13);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemNameTextBox.Location = new System.Drawing.Point(97, 32);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new System.Drawing.Point(6, 70);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(89, 13);
            itemDescriptionLabel.TabIndex = 2;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(97, 67);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(234, 69);
            this.itemDescriptionTextBox.TabIndex = 3;
            // 
            // itemTypeLabel
            // 
            itemTypeLabel.AutoSize = true;
            itemTypeLabel.Location = new System.Drawing.Point(35, 151);
            itemTypeLabel.Name = "itemTypeLabel";
            itemTypeLabel.Size = new System.Drawing.Size(60, 13);
            itemTypeLabel.TabIndex = 4;
            itemTypeLabel.Text = "Item Type:";
            // 
            // itemTypeTextBox
            // 
            this.itemTypeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.itemTypeTextBox.Location = new System.Drawing.Point(97, 145);
            this.itemTypeTextBox.Name = "itemTypeTextBox";
            this.itemTypeTextBox.Size = new System.Drawing.Size(234, 20);
            this.itemTypeTextBox.TabIndex = 5;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(204, 194);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(127, 37);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Add";
            this.Addbtn.ThemeName = "Windows8";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMainStore_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddMainStore_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMainStore_Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemTypeTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private Telerik.WinControls.UI.RadButton Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}