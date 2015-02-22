namespace Bylsan_System.ProductForms
{
    partial class frmContentx
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn1 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.product_NameLabel = new System.Windows.Forms.Label();
            this.product_DescriptionLabel = new System.Windows.Forms.Label();
            this.publicNameLabel = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.publicNameTextBox = new System.Windows.Forms.TextBox();
            this.productContentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productContentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(XamaDataLayer.Product);
            // 
            // product_NameLabel
            // 
            this.product_NameLabel.AutoSize = true;
            this.product_NameLabel.Location = new System.Drawing.Point(34, 41);
            this.product_NameLabel.Name = "product_NameLabel";
            this.product_NameLabel.Size = new System.Drawing.Size(82, 13);
            this.product_NameLabel.TabIndex = 1;
            this.product_NameLabel.Text = "Product Name:";
            // 
            // product_DescriptionLabel
            // 
            this.product_DescriptionLabel.AutoSize = true;
            this.product_DescriptionLabel.Location = new System.Drawing.Point(10, 65);
            this.product_DescriptionLabel.Name = "product_DescriptionLabel";
            this.product_DescriptionLabel.Size = new System.Drawing.Size(112, 13);
            this.product_DescriptionLabel.TabIndex = 3;
            this.product_DescriptionLabel.Text = "Product Description:";
            // 
            // publicNameLabel
            // 
            this.publicNameLabel.AutoSize = true;
            this.publicNameLabel.Location = new System.Drawing.Point(42, 89);
            this.publicNameLabel.Name = "publicNameLabel";
            this.publicNameLabel.Size = new System.Drawing.Size(73, 13);
            this.publicNameLabel.TabIndex = 5;
            this.publicNameLabel.Text = "Public Name:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(122, 38);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.ReadOnly = true;
            this.product_NameTextBox.Size = new System.Drawing.Size(272, 20);
            this.product_NameTextBox.TabIndex = 2;
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.product_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Description", true));
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(122, 62);
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.ReadOnly = true;
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(272, 20);
            this.product_DescriptionTextBox.TabIndex = 4;
            // 
            // publicNameTextBox
            // 
            this.publicNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.publicNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PublicName", true));
            this.publicNameTextBox.Location = new System.Drawing.Point(122, 86);
            this.publicNameTextBox.Name = "publicNameTextBox";
            this.publicNameTextBox.ReadOnly = true;
            this.publicNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.publicNameTextBox.TabIndex = 6;
            // 
            // productContentsBindingSource
            // 
            this.productContentsBindingSource.DataMember = "ProductContents";
            this.productContentsBindingSource.DataSource = this.productBindingSource;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.publicNameLabel);
            this.radGroupBox1.Controls.Add(this.publicNameTextBox);
            this.radGroupBox1.Controls.Add(this.product_DescriptionLabel);
            this.radGroupBox1.Controls.Add(this.product_DescriptionTextBox);
            this.radGroupBox1.Controls.Add(this.product_NameLabel);
            this.radGroupBox1.Controls.Add(this.product_NameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Product Info";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(588, 145);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Product Info";
            this.radGroupBox1.ThemeName = "Office2010Black";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(423, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "Office2010Black";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.EnableCustomDrawing = true;
            this.radGridView1.EnableCustomFiltering = true;
            this.radGridView1.EnableCustomGrouping = true;
            this.radGridView1.EnableCustomSorting = true;
            this.radGridView1.EnableFastScrolling = true;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 145);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 64;
            gridViewMultiComboBoxColumn1.DataSource = this.productBindingSource1;
            gridViewMultiComboBoxColumn1.DataType = typeof(System.Nullable<int>);
            gridViewMultiComboBoxColumn1.DisplayMember = "Product_Name";
            gridViewMultiComboBoxColumn1.EnableExpressionEditor = false;
            gridViewMultiComboBoxColumn1.FieldName = "ContentsProductID";
            gridViewMultiComboBoxColumn1.HeaderText = "Item";
            gridViewMultiComboBoxColumn1.Name = "column1";
            gridViewMultiComboBoxColumn1.ValueMember = "ID";
            gridViewMultiComboBoxColumn1.Width = 292;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<long>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Qty";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Qty";
            gridViewDecimalColumn2.Width = 94;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unitOfProduct";
            gridViewTextBoxColumn1.HeaderText = "unitOfProduct";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "unitOfProduct";
            gridViewTextBoxColumn1.Width = 116;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewMultiComboBoxColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.productContentsBindingSource;
            this.radGridView1.MasterTemplate.EnableCustomFiltering = true;
            this.radGridView1.MasterTemplate.EnableCustomGrouping = true;
            this.radGridView1.MasterTemplate.EnableCustomSorting = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnablePaging = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(583, 375);
            this.radGridView1.TabIndex = 10;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2010Black";
            this.radGridView1.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEditorInitialized);
            // 
            // frmContentx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 577);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frmContentx";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componant";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productContentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox publicNameTextBox;
        private System.Windows.Forms.BindingSource productContentsBindingSource;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Label product_NameLabel;
        private System.Windows.Forms.Label product_DescriptionLabel;
        private System.Windows.Forms.Label publicNameLabel;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}