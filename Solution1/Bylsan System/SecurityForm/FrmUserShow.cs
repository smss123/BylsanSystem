using System;
using System.Threading;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmUserShow : Telerik.WinControls.UI.RadForm
    {
        public FrmUserShow()
        {
            InitializeComponent();
        }

        private void FrmUserShow_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillDataUser);
            th.Start();
        }

        private void FillDataUser()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = UserCmd.GetAllUsers();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                UserGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void UserGridView_CommandCellClick(object sender, EventArgs e)
        {
            FrmEditUserPermession frm = new FrmEditUserPermession();
            frm.TragetUser = (User)UserGridView.CurrentRow.DataBoundItem;
            frm.ShowDialog();
        }
    }
}
