namespace Bylsan_System.SenarioAddOrderForms
{
    partial class frmReturnBill
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
            System.Windows.Forms.Label billNumberLabel;
            System.Windows.Forms.Label billTotalLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label billDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBill));
            this.billBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.billBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.billNumberTextBox = new System.Windows.Forms.TextBox();
            this.billTotalTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.billDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            billNumberLabel = new System.Windows.Forms.Label();
            billTotalLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            billDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingNavigator)).BeginInit();
            this.billBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billNumberLabel
            // 
            billNumberLabel.AutoSize = true;
            billNumberLabel.Location = new System.Drawing.Point(55, 15);
            billNumberLabel.Name = "billNumberLabel";
            billNumberLabel.Size = new System.Drawing.Size(63, 13);
            billNumberLabel.TabIndex = 1;
            billNumberLabel.Text = "Bill Number:";
            // 
            // billTotalLabel
            // 
            billTotalLabel.AutoSize = true;
            billTotalLabel.Location = new System.Drawing.Point(68, 41);
            billTotalLabel.Name = "billTotalLabel";
            billTotalLabel.Size = new System.Drawing.Size(50, 13);
            billTotalLabel.TabIndex = 3;
            billTotalLabel.Text = "Bill Total:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(31, 67);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(87, 13);
            customerNameLabel.TabIndex = 5;
            customerNameLabel.Text = "Customer Name:";
            // 
            // billDateLabel
            // 
            billDateLabel.AutoSize = true;
            billDateLabel.Location = new System.Drawing.Point(69, 94);
            billDateLabel.Name = "billDateLabel";
            billDateLabel.Size = new System.Drawing.Size(49, 13);
            billDateLabel.TabIndex = 7;
            billDateLabel.Text = "Bill Date:";
            // 
            // billBindingNavigator
            // 
            this.billBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.billBindingNavigator.BindingSource = this.billBindingSource;
            this.billBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.billBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.billBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtID,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.billBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billBindingNavigator.Name = "billBindingNavigator";
            this.billBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.billBindingNavigator.TabIndex = 0;
            this.billBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(XamaDataLayer.Bill);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // billBindingNavigatorSaveItem
            // 
            this.billBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.billBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("billBindingNavigatorSaveItem.Image")));
            this.billBindingNavigatorSaveItem.Name = "billBindingNavigatorSaveItem";
            this.billBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.billBindingNavigatorSaveItem.Text = "Save Data";
            this.billBindingNavigatorSaveItem.Click += new System.EventHandler(this.billBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel1.Text = "Enter Bill ID";
            // 
            // txtID
            // 
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton1.Text = "Go";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // billNumberTextBox
            // 
            this.billNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "BillNumber", true));
            this.billNumberTextBox.Location = new System.Drawing.Point(124, 12);
            this.billNumberTextBox.Name = "billNumberTextBox";
            this.billNumberTextBox.Size = new System.Drawing.Size(221, 20);
            this.billNumberTextBox.TabIndex = 2;
            // 
            // billTotalTextBox
            // 
            this.billTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "BillTotal", true));
            this.billTotalTextBox.Location = new System.Drawing.Point(124, 38);
            this.billTotalTextBox.Name = "billTotalTextBox";
            this.billTotalTextBox.Size = new System.Drawing.Size(221, 20);
            this.billTotalTextBox.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "Customer.CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(124, 64);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.customerNameTextBox.TabIndex = 6;
            // 
            // billDateDateTimePicker
            // 
            this.billDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billBindingSource, "BillDate", true));
            this.billDateDateTimePicker.Location = new System.Drawing.Point(124, 90);
            this.billDateDateTimePicker.Name = "billDateDateTimePicker";
            this.billDateDateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.billDateDateTimePicker.TabIndex = 8;
            // 
            // billItemsBindingSource
            // 
            this.billItemsBindingSource.DataMember = "BillItems";
            this.billItemsBindingSource.DataSource = this.billBindingSource;
            // 
            // billItemsDataGridView
            // 
            this.billItemsDataGridView.AllowUserToAddRows = false;
            this.billItemsDataGridView.AutoGenerateColumns = false;
            this.billItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductID,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Status});
            this.billItemsDataGridView.DataSource = this.billItemsBindingSource;
            this.billItemsDataGridView.Location = new System.Drawing.Point(12, 183);
            this.billItemsDataGridView.Name = "billItemsDataGridView";
            this.billItemsDataGridView.Size = new System.Drawing.Size(811, 197);
            this.billItemsDataGridView.TabIndex = 9;
            this.billItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.billItemsDataGridView_CellEndEdit);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XamaDataLayer.Product);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(billDateLabel);
            this.groupBox1.Controls.Add(this.billDateDateTimePicker);
            this.groupBox1.Controls.Add(customerNameLabel);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(billTotalLabel);
            this.groupBox1.Controls.Add(this.billTotalTextBox);
            this.groupBox1.Controls.Add(billNumberLabel);
            this.groupBox1.Controls.Add(this.billNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.iDTextBox.Location = new System.Drawing.Point(723, 49);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 30);
            this.iDTextBox.TabIndex = 11;
            this.iDTextBox.Text = "000000";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.DataSource = this.productBindingSource;
            this.ProductID.DisplayMember = "Product_Name";
            this.ProductID.HeaderText = "Product";
            this.ProductID.Name = "ProductID";
            this.ProductID.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Return Qty";
            this.Column1.Name = "Column1";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Items.AddRange(new object[] {
            "Done",
            "Return"});
            this.Status.Name = "Status";
            // 
            // frmReturnBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 400);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.billItemsDataGridView);
            this.Controls.Add(this.billBindingNavigator);
            this.Name = "frmReturnBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return bill";
            this.Load += new System.EventHandler(this.frmReturnBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billBindingNavigator)).EndInit();
            this.billBindingNavigator.ResumeLayout(false);
            this.billBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.BindingNavigator billBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton billBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox billNumberTextBox;
        private System.Windows.Forms.TextBox billTotalTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DateTimePicker billDateDateTimePicker;
        private System.Windows.Forms.BindingSource billItemsBindingSource;
        private System.Windows.Forms.DataGridView billItemsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtID;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
    }
}