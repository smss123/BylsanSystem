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
using Xprema.XExtention;
using Telerik.WinControls.UI;
using Telerik.WinControls;
namespace Bylsan_System.designerForms
{
    public partial class FrmOrderProductShow : RadForm
    {
        public FrmOrderProductShow()
        {
            InitializeComponent();
        }

        public int IDImageAddress { get; set; }
        public int TaregtOrder { get; set; }
        public Order SelectedOrder { get; set; }

        Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            var q = SelectedOrder.OrderProducts.ToList();//OrderProductsCmd.GetAllByOrderID(TaregtOrder);//.Where(p=>p.Status.Contains("To Deliver"));
            this.Invoke((MethodInvoker)delegate 
            {
                DGVProducts.DataSource = q; 
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
            lblOrderDate.Text = SelectedOrder.OrderDate.ToString();
            lblOrderDelviryDate.Text = SelectedOrder.OrderDeliveryDate. ToString();
        }

       
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Operation.BeginOperation(this);
            if (DGVProducts.Rows.Count != 0)
            {

               Thread  AttachThread = new Thread(LoadAttachments);
                AttachThread.Start();
            }
            Operation.EndOperation(this);

           
           
        }
        List<Image> ListPictures = new List<Image >();

        void LoadAttachments()
        {
            //SelectedProductPhotoBox.Image =null;
            //lblPoductName.Text = "";
            ////lblPrice.Text = "";
            ListPictures.Clear();
            try
            {
                Operation.BeginOperation(this);

                int prdid = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString());
                imageList1.Images.Clear();
                var lst = (from p in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(prdid) select p).ToList();
                this.Invoke((MethodInvoker)delegate
                {

                    PhotoBox.Image = null;

                    //============================================

                    Application.DoEvents();
                    foreach (var item in lst)
                    {

                        TxtDescription.Text = item.Description;
                        PhotoBox.Image = item.imageX;

                        imageList1.Images.Add(item.imageX);

                        IDImageAddress = item.ID;

                        //================================

                        ListPictures.Add(item.imageX);
                    }
                    //==============================================
                    //-- Display Selected Product Information : 

                    var getcurrentProductInfo = (OrderProduct)DGVProducts.CurrentRow.DataBoundItem;//ProductsCmd.GetProductByID(prdid);

                   // SelectedProductPhotoBox.Image = (Image)getcurrentProductInfo.Product.Img;
                    lblPoductName.Text = getcurrentProductInfo.Product.Product_Name;
                    lblPrice.Text = "[none]";
                    

                    //=============================================
                });

                //AttachThread.Abort();

            }
            catch (NullReferenceException ex)
            {
                Operation.EndOperation(this);
                MessageBox.Show(ex.Message.ToString(), "  Error");
                return;
            }
            Operation.EndOperation(this);
        }

   

        int i = 0;
        private void NextPhotoBtn_Click(object sender, EventArgs e)
        {

            if (PhotoBox.Image != null)
            {
        
                if (ListPictures.Count != 0 && i < ListPictures .Count )
                {
                    PhotoBox.Image = null;
                    PhotoBox.Image = ListPictures[i];
                    i++;
                }
                else
                {
                    i = 0;
                    PhotoBox.Image = null;
                    PhotoBox.Image = ListPictures[i];
                }
               
                
            }
        }

 

    
        private void SaveBtn_Click(object sender, EventArgs e)
        {     
                     
          
            OrderProduct tb = new OrderProduct() {
                OrderID = TaregtOrder,
                Description = TxtDescription.Text,//
                Qty = int.Parse(DGVProducts.CurrentRow.Cells[2].Value.ToString()),
                ProductID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString()),
            ImageX = PhotoBox .Image  ,
            Status = "in producting "
            };
            OrderProductsCmd.EditOrderProductStatus(tb, int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString()));


            Order Otb = new Order() {
                OrderStatus = "in producting "
            };
            OrdersCmd.EditOrderStatusOnly (Otb, TaregtOrder);


            MessageBox.Show("Changes Was Saved ...");

           var cellPlaceHolder = DGVProducts.TableElement.GetCellElement(DGVProducts .CurrentRow , DGVProducts.Columns[0]);
           cellPlaceHolder.DrawFill = true;
                 cellPlaceHolder.BackColor = System.Drawing.Color.Pink;
//cellPlaceHolder.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local);
//cellPlaceHolder.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
        
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
            if (PhotoBox.Image != null)
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

        private void DGVProducts_Click(object sender, EventArgs e)
        {

        }

        //int  w = int .Parse (WthBox.Text); int h = int .Parse (HghtBox.Text);    
        //Image Img = pictureBox1.Image;
        //Img = ResizeImage(Img , new Size(w, h));
        //byteImg1 = PhotosConverter.ImageToByteArray(Img);
        #endregion

    }
}
