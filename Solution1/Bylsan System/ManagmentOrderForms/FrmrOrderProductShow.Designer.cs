namespace Bylsan_System.ManagmentOrderForms
{
    partial class FrmrOrderProductShow
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
            System.Windows.Forms.Label orderDeliveryLabel;
            System.Windows.Forms.Label orderDeliveryDateLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label orderStatusLabel;
            System.Windows.Forms.Label orderVerifyLabel;
            System.Windows.Forms.Label totalAmountLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radMultiColumnComboBox2 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.orderDeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.orderVerifyTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            orderDeliveryLabel = new System.Windows.Forms.Label();
            orderDeliveryDateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            orderStatusLabel = new System.Windows.Forms.Label();
            orderVerifyLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1014, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(totalAmountLabel);
            this.radGroupBox1.Controls.Add(this.totalAmountTextBox);
            this.radGroupBox1.Controls.Add(orderVerifyLabel);
            this.radGroupBox1.Controls.Add(this.orderVerifyTextBox);
            this.radGroupBox1.Controls.Add(orderStatusLabel);
            this.radGroupBox1.Controls.Add(this.orderStatusComboBox);
            this.radGroupBox1.Controls.Add(commentLabel);
            this.radGroupBox1.Controls.Add(this.commentTextBox);
            this.radGroupBox1.Controls.Add(orderDeliveryDateLabel);
            this.radGroupBox1.Controls.Add(this.orderDeliveryDateDateTimePicker);
            this.radGroupBox1.Controls.Add(orderDeliveryLabel);
            this.radGroupBox1.Controls.Add(this.orderDeliveryTextBox);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.radMultiColumnComboBox2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.radMultiColumnComboBox1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1014, 237);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2010Black";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "radGroupBox2";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 237);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(1014, 187);
            this.radGroupBox2.TabIndex = 7;
            this.radGroupBox2.Text = "radGroupBox2";
            this.radGroupBox2.ThemeName = "Office2010Black";
            // 
            // radMultiColumnComboBox1
            // 
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(88, 42);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(274, 23);
            this.radMultiColumnComboBox1.TabIndex = 0;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.ThemeName = "Office2010Black";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // radMultiColumnComboBox2
            // 
            // 
            // radMultiColumnComboBox2.NestedRadGridView
            // 
            this.radMultiColumnComboBox2.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox2.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radMultiColumnComboBox2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox2.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // radMultiColumnComboBox2.NestedRadGridView
            // 
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox2.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox2.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox2.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox2.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox2.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox2.Location = new System.Drawing.Point(743, 89);
            this.radMultiColumnComboBox2.Name = "radMultiColumnComboBox2";
            this.radMultiColumnComboBox2.Size = new System.Drawing.Size(246, 20);
            this.radMultiColumnComboBox2.TabIndex = 2;
            this.radMultiColumnComboBox2.TabStop = false;
            this.radMultiColumnComboBox2.ThemeName = "Office2010Black";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DeliverdToBranch:";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(XamaDataLayer.Order);
            // 
            // orderDeliveryLabel
            // 
            orderDeliveryLabel.AutoSize = true;
            orderDeliveryLabel.Location = new System.Drawing.Point(654, 34);
            orderDeliveryLabel.Name = "orderDeliveryLabel";
            orderDeliveryLabel.Size = new System.Drawing.Size(83, 13);
            orderDeliveryLabel.TabIndex = 4;
            orderDeliveryLabel.Text = "Order Delivery:";
            // 
            // orderDeliveryTextBox
            // 
            this.orderDeliveryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDelivery", true));
            this.orderDeliveryTextBox.Location = new System.Drawing.Point(743, 31);
            this.orderDeliveryTextBox.Name = "orderDeliveryTextBox";
            this.orderDeliveryTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderDeliveryTextBox.TabIndex = 5;
            // 
            // orderDeliveryDateLabel
            // 
            orderDeliveryDateLabel.AutoSize = true;
            orderDeliveryDateLabel.Location = new System.Drawing.Point(627, 60);
            orderDeliveryDateLabel.Name = "orderDeliveryDateLabel";
            orderDeliveryDateLabel.Size = new System.Drawing.Size(110, 13);
            orderDeliveryDateLabel.TabIndex = 6;
            orderDeliveryDateLabel.Text = "Order Delivery Date:";
            orderDeliveryDateLabel.Click += new System.EventHandler(this.orderDeliveryDateLabel_Click);
            // 
            // orderDeliveryDateDateTimePicker
            // 
            this.orderDeliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDeliveryDate", true));
            this.orderDeliveryDateDateTimePicker.Location = new System.Drawing.Point(743, 57);
            this.orderDeliveryDateDateTimePicker.Name = "orderDeliveryDateDateTimePicker";
            this.orderDeliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDeliveryDateDateTimePicker.TabIndex = 7;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(678, 138);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(59, 13);
            commentLabel.TabIndex = 8;
            commentLabel.Text = "Comment:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(743, 118);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(246, 67);
            this.commentTextBox.TabIndex = 9;
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Location = new System.Drawing.Point(5, 84);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new System.Drawing.Size(75, 13);
            orderStatusLabel.TabIndex = 10;
            orderStatusLabel.Text = "Order Status:";
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderStatus", true));
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Location = new System.Drawing.Point(88, 78);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(136, 21);
            this.orderStatusComboBox.TabIndex = 11;
            // 
            // orderVerifyLabel
            // 
            orderVerifyLabel.AutoSize = true;
            orderVerifyLabel.Location = new System.Drawing.Point(10, 118);
            orderVerifyLabel.Name = "orderVerifyLabel";
            orderVerifyLabel.Size = new System.Drawing.Size(72, 13);
            orderVerifyLabel.TabIndex = 12;
            orderVerifyLabel.Text = "Order Verify:";
            // 
            // orderVerifyTextBox
            // 
            this.orderVerifyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderVerify", true));
            this.orderVerifyTextBox.Location = new System.Drawing.Point(88, 115);
            this.orderVerifyTextBox.Name = "orderVerifyTextBox";
            this.orderVerifyTextBox.Size = new System.Drawing.Size(259, 20);
            this.orderVerifyTextBox.TabIndex = 13;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(6, 150);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(79, 13);
            totalAmountLabel.TabIndex = 14;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "TotalAmount", true));
            this.totalAmountTextBox.Location = new System.Drawing.Point(91, 147);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 15;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(2, 18);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 72;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Product.Product_Name";
            gridViewTextBoxColumn1.HeaderText = "Product";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Product";
            gridViewTextBoxColumn1.Width = 210;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Qty";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Qty";
            gridViewDecimalColumn2.Width = 85;
            gridViewTextBoxColumn2.DataType = typeof(System.Nullable<double>);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Product.ProductPrice";
            gridViewTextBoxColumn2.HeaderText = "Price";
            gridViewTextBoxColumn2.Name = "ProductPrice";
            gridViewTextBoxColumn2.Width = 124;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 170;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Status";
            gridViewTextBoxColumn4.HeaderText = "Status";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Status";
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "Total";
            gridViewTextBoxColumn5.Name = "Total";
            gridViewTextBoxColumn5.Width = 121;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 117;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.orderProductBindingSource;
            sortDescriptor1.PropertyName = "column1";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1010, 167);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Office2010Black";
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataSource = typeof(XamaDataLayer.OrderProduct);
            // 
            // FrmrOrderProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 446);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmrOrderProductShow";
            this.Text = "FrmrOrderProductShow";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DateTimePicker orderDeliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox orderDeliveryTextBox;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox orderVerifyTextBox;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
    }
}