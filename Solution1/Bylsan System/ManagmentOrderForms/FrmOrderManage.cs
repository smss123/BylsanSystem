using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class FrmOrderManage : RadForm
    {
        public FrmOrderManage()
        {
            InitializeComponent();
            DGVOrders.CommandCellClick += DGVOrders_CommandCellClick;
        }

        void DGVOrders_CommandCellClick(object sender, EventArgs e)
        {
            if (DGVOrders.CurrentCell.ColumnInfo.Index==11)
            {
                Order o = (Order)DGVOrders.CurrentRow.DataBoundItem;
                FrmrOrderProductShow frm  = new FrmrOrderProductShow();
                frm.TragetOrder = o;
                frm.ShowDialog();
            }
        }

        private void FrmOrderManage_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            DGVOrders.DataSource = OrdersCmd.GetAllOrders();
            Operation.EndOperation(this);
        }
    }
}
