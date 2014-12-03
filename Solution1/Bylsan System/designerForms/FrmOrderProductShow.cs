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
          
            PhotoBox.Image = null;
           //================================
            Thr = new Thread(PopulateGrd);
            Thr.Start();
        }

        Thread AttachThread;
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Operation.BeginOperation(this);
                if (DGVProducts.Rows.Count != 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    AttachThread = new Thread(LoadAttachments);
                    AttachThread.Start();

                    this.Cursor = Cursors.Default;
                }
                Operation.EndOperation (this);
        }

        void LoadAttachments()
        {
           
            imageList1.Images.Clear();
            this.Invoke((MethodInvoker)delegate
            {
              
                PhotoBox.Image = null;
               
                //============================================
                var lst = (from p in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString())) select p).ToList ();
                foreach (var item in lst )
                {
                    TxtDescription.Text = item.Description;
                    PhotoBox.Image = item.imageX;
                    imageList1.Images.Add(item.imageX);
                   
                    IDImageAddress = item.ID;
                    MessageBox.Show(DGVProducts.CurrentRow.Cells[0].Value.ToString());
                }
               
            });
          
            AttachThread.Abort();
            

        }

   

        int i = 0;
        private void NextPhotoBtn_Click(object sender, EventArgs e)
        {
           
            if (i != imageList1.Images.Count ) 
            {
               
                PhotoBox.Image = null;
                PhotoBox.Image = imageList1.Images[i];
                SizeLab.Text = imageList1.Images[i].Size.ToString();
                i++;
            }
            else
            {
                i = 0; 
                PhotoBox.Image = null;
                PhotoBox.Image = imageList1.Images[i];
                SizeLab.Text = imageList1.Images[i].Size.ToString () ;
            }
        }

 

    
        private void SaveBtn_Click(object sender, EventArgs e)
        {     
                     
          
            OrderProduct tb = new OrderProduct() { 
            OrderID = TaregtOrder,
            Description = TxtDescription .Text ,
            Qty = int.Parse(DGVProducts.CurrentRow.Cells[2].Value.ToString()),
            ProductID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString()),
             ImageX = byteImg1 ,
            Status = "in producting ",
            };
            OrderProductsCmd.EditOrderProduct(tb, int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString()));
            Order Otb = new Order() {
                OrderStatus = "in producting "
            };
            OrdersCmd.EditOrder(Otb, TaregtOrder);
            MessageBox.Show("Changes Was Saved ...");
            this.Hide();
        }


        #region "   Upload  Photo    "

        OpenFileDialog Op = new OpenFileDialog();

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                PhotoBox.Image = Image.FromFile(Op.FileName);
               
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

        #region "      Save Photo At Computer         "
        SaveFileDialog SvDialog = new SaveFileDialog();
        private void SavePhotoBtn_Click(object sender, EventArgs e)
        {
            SvDialog = new SaveFileDialog();
            SvDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            SvDialog.Title = "Save an Image File";
            SvDialog.ShowDialog();


            if (SvDialog.FileName != "" && PhotoBox.Image != null)
            {

                System.IO.FileStream fs =
                   (System.IO.FileStream)SvDialog.OpenFile();

                switch (SvDialog.FilterIndex)
                {
                    case 1:
                        PhotoBox.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        PhotoBox.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        PhotoBox.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
        #endregion
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region " UnUsed  "

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //int  w = int .Parse (WthBox.Text); int h = int .Parse (HghtBox.Text);    
        //Image Img = pictureBox1.Image;
        //Img = ResizeImage(Img , new Size(w, h));
        //byteImg1 = PhotosConverter.ImageToByteArray(Img);
        #endregion

    }
}
