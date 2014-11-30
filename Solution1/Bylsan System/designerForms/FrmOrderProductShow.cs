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
                    this.Cursor = Cursors.WaitCursor;
                    AttachThread = new Thread(LoadAttachments);
                    AttachThread.Start();

                    this.Cursor = Cursors.Default;
                }
           
        }

        void LoadAttachments()
        {
           
            imageList1.Images.Clear();
            this.Invoke((MethodInvoker)delegate
            {
                
                var lst = (from p in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString())) select p).ToList ();
                foreach (var item in lst )
                {
                    TxtDescription.Text = item.Description;
                    pictureBox1.Image = item.imageX;
                    imageList1.Images.Add(item.imageX);
                }
               
            });
          
            AttachThread.Abort();
            

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int i = 0;
        private void NextPhotoBtn_Click(object sender, EventArgs e)
        {
           
            if (i != imageList1.Images.Count ) 
            {
               
                pictureBox1.Image = null;
                pictureBox1.Image = imageList1.Images[i];
                i++;
            }
            else
            {
                i = 0; 
                pictureBox1.Image = null;
                pictureBox1.Image = imageList1.Images[i];
            }
        }
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

          
            if (saveFileDialog1.FileName != "")
            {
              
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

    }
}
