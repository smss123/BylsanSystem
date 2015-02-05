namespace Bylsan_System.ProductForms
{
    partial class frmManageMiniummQty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMiniummQty));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.productMinimummQtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productMinimummQtyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.productMinimummQtyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productMinimummQtyRadGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyBindingNavigator)).BeginInit();
            this.productMinimummQtyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // productMinimummQtyBindingSource
            // 
            this.productMinimummQtyBindingSource.DataSource = typeof(XamaDataLayer.ProductMinimummQty);
            // 
            // productMinimummQtyBindingNavigator
            // 
            this.productMinimummQtyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productMinimummQtyBindingNavigator.BindingSource = this.productMinimummQtyBindingSource;
            this.productMinimummQtyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productMinimummQtyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productMinimummQtyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productMinimummQtyBindingNavigatorSaveItem});
            this.productMinimummQtyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productMinimummQtyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productMinimummQtyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productMinimummQtyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productMinimummQtyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productMinimummQtyBindingNavigator.Name = "productMinimummQtyBindingNavigator";
            this.productMinimummQtyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productMinimummQtyBindingNavigator.Size = new System.Drawing.Size(705, 25);
            this.productMinimummQtyBindingNavigator.TabIndex = 0;
            this.productMinimummQtyBindingNavigator.Text = "bindingNavigator1";
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
            // productMinimummQtyBindingNavigatorSaveItem
            // 
            this.productMinimummQtyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productMinimummQtyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productMinimummQtyBindingNavigatorSaveItem.Image")));
            this.productMinimummQtyBindingNavigatorSaveItem.Name = "productMinimummQtyBindingNavigatorSaveItem";
            this.productMinimummQtyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productMinimummQtyBindingNavigatorSaveItem.Text = "Save Data";
            this.productMinimummQtyBindingNavigatorSaveItem.Click += new System.EventHandler(this.productMinimummQtyBindingNavigatorSaveItem_Click);
            // 
            // productMinimummQtyRadGridView
            // 
            this.productMinimummQtyRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productMinimummQtyRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.productMinimummQtyRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.productMinimummQtyRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.productMinimummQtyRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productMinimummQtyRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productMinimummQtyRadGridView.Location = new System.Drawing.Point(12, 38);
            // 
            // productMinimummQtyRadGridView
            // 
            this.productMinimummQtyRadGridView.MasterTemplate.AutoGenerateColumns = false;
            this.productMinimummQtyRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 93;
            gridViewComboBoxColumn1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            gridViewComboBoxColumn1.DataType = typeof(System.Nullable<int>);
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "ProductID";
            gridViewComboBoxColumn1.HeaderText = "Product";
            gridViewComboBoxColumn1.Name = "ProductID";
            gridViewComboBoxColumn1.Width = 326;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "MinimumQty";
            gridViewTextBoxColumn1.HeaderText = "MinimumQty";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "MinimumQty";
            gridViewTextBoxColumn1.Width = 244;
            this.productMinimummQtyRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn1});
            this.productMinimummQtyRadGridView.MasterTemplate.DataSource = this.productMinimummQtyBindingSource;
            this.productMinimummQtyRadGridView.Name = "productMinimummQtyRadGridView";
            this.productMinimummQtyRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productMinimummQtyRadGridView.Size = new System.Drawing.Size(681, 452);
            this.productMinimummQtyRadGridView.TabIndex = 1;
            this.productMinimummQtyRadGridView.Text = "radGridView1";
            this.productMinimummQtyRadGridView.ThemeName = "Office2010Black";
            // 
            // frmManageMiniummQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 502);
            this.Controls.Add(this.productMinimummQtyRadGridView);
            this.Controls.Add(this.productMinimummQtyBindingNavigator);
            this.Name = "frmManageMiniummQty";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miniumm Qty";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmManageMiniummQty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyBindingNavigator)).EndInit();
            this.productMinimummQtyBindingNavigator.ResumeLayout(false);
            this.productMinimummQtyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMinimummQtyRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productMinimummQtyBindingSource;
        private System.Windows.Forms.BindingNavigator productMinimummQtyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productMinimummQtyBindingNavigatorSaveItem;
        private Telerik.WinControls.UI.RadGridView productMinimummQtyRadGridView;
    }
}