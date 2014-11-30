using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer.Helper_Classes;

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

        public int IDImageAddress { get; set; }
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
            SizeLab.Text = "";
            UploadBtn.Visible = false; // UnUsed
            pictureBox1.Image = null;
           //================================
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
                    SizeLab.Text = item.imageX.Size.ToString () ;
                    IDImageAddress = item.ID;
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
                SizeLab.Text = imageList1.Images[i].Size.ToString();
                i++;
            }
            else
            {
                i = 0; 
                pictureBox1.Image = null;
                pictureBox1.Image = imageList1.Images[i];
                SizeLab.Text = imageList1.Images[i].Size.ToString () ;
            }
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
           return (Image)(new Bitmap(imgToResize, size));
        }

    
        private void SaveBtn_Click(object sender, EventArgs e)
        {     
                     
            int  w = int .Parse (WthBox.Text); int h = int .Parse (HghtBox.Text);    
            Image Img = pictureBox1.Image;
            Img = ResizeImage(Img , new Size(w, h));
            byteImg1 = PhotosConverter.ImageToByteArray(Img);

            OrderProduct tb = new OrderProduct() { 
            OrderID = TaregtOrder,
            Description = TxtDescription .Text ,
            Qty = int.Parse(DGVProducts.CurrentRow.Cells[2].Value.ToString()),
            ProductID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString()),
             ImageX = byteImg1 ,
            Status = "in producting ",
            };
            OrderProductsCmd.EditOrderProduct(tb, IDImageAddress);
            MessageBox.Show("Changes Was Saved ...");
            this.Hide();
        }


        #region "    ^^^ Brwose Photo    "

        OpenFileDialog Op = new OpenFileDialog();

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                pictureBox1.Image = Image.FromFile(Op.FileName);
               
                this.Cursor = Cursors.Default;

            }
        }
        byte[] byteImg1;
        private void ConvertCarsPhotoes()
        {

            if (Op.FileName != "")
            {

                this.Cursor = Cursors.WaitCursor;
                Image img = Image.FromFile(Op.FileName);
                byteImg1 = PhotosConverter.ImageToByteArray(img);
                this.Cursor = Cursors.Default;

            }
            else
            {
                byteImg1 = null;
            }

        }


        #endregion 

    }
}
