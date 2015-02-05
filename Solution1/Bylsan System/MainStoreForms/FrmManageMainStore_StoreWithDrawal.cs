using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XamaDataLayer.Main_Store;

namespace Bylsan_System.MainStoreForms
{
    public partial class FrmManageMainStore_StoreWithDrawal : RadForm
    {
        public FrmManageMainStore_StoreWithDrawal()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        private Thread th;
        private void Loading()
        {
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Loading ...";
            });
            Operation.BeginOperation(this);
            var q = StoreDrawalCmd.GetAllStoreDrawals();
            this.Invoke((MethodInvoker)delegate
            {
                StoreWithDrawalGridView.DataSource = q;
            });
            toolStrip1.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Complete ..";
            });
            Operation.EndOperation(this);
            th.Abort();
        }
        private void FrmManageMainStore_StoreWithDrawal_Load(object sender, EventArgs e)
        {
            th = new Thread(Loading);
            th.Start();
        }

        private void StoreWithDrawalGridView_CommandCellClick(object sender, EventArgs e)
        {
        }
    }
}
