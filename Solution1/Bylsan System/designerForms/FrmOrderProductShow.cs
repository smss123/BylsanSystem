using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
namespace Bylsan_System.designerForms
{
    public partial class FrmOrderProductShow : Form
    {
        public FrmOrderProductShow()
        {
            InitializeComponent();
        }

        public int TaregtOrder { get; set; }

        Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate 
            {
                DGVProducts.DataSource = OrderProductsCmd.GetAllByOrderID(TaregtOrder);
       
            });
            Operation.EndOperation(this);
            this.Thr.Abort();
        }
        private void FrmOrderProductShow_Load(object sender, EventArgs e)
        {
            Thr = new Thread(PopulateGrd);
            Thr.Start();
        }

        Thread AttachThread;
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
                if (DGVProducts.Rows.Count != 0)
                {
                    AttachThread = new Thread(LoadAttachments);
                    AttachThread.Start();
                }
           
        }

        void LoadAttachments()
        {
            this.Invoke((MethodInvoker)delegate
            {
                var lst = (from p in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString())) select p).ToList ();
                foreach (var item in lst )
                {
                    TxtDescription.Text = item.Description;
                    pictureBox1.Image = item.imageX;
                }
            });

            AttachThread.Abort();
        }

    }
}
