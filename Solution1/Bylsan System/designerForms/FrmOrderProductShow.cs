using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer.Helper_Classes;

using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using Telerik.WinControls.UI;

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

        private Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);
            if (Operation.Allproducts == null)
            {
                Operation.AllOrderProduct = OrderProductsCmd.GetAll();
            }
            var q = Operation.AllOrderProduct.Where(p => p.OrderID == SelectedOrder.ID).ToList();  //Operation.AllOrder.Where(p => p.ID == TagOrder.ID).Single().OrderProducts; //TagOrder.OrderProducts.ToList();
              
            this.Invoke((MethodInvoker)delegate
            {
                DGVProducts.DataSource = q;
            });
            Operation.EndOperation(this);
            Thr.Abort();
        }
        private void FrmOrderProductShow_Load(object sender, EventArgs e)
        {
            PhotoBox.Image = null;

            Thr = new Thread(PopulateGrd);
            Thr.Start();
            lblOrderDate.Text = SelectedOrder.OrderDate.Value.ToString("dd/MM/yyyy");
            lblOrderDelviryDate.Text = SelectedOrder.OrderDeliveryDate.ToString();
        }


        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Operation.BeginOperation(this);
            if (DGVProducts.Rows.Count != 0)
            {
                var  AttachThread = new Thread(LoadAttachments);
                AttachThread.Start();
            }
            Operation.EndOperation(this);
        }
        private List<Image> ListPictures = new List<Image >();

        private void LoadAttachments()
        {
            ListPictures.Clear();
            try
            {
                Operation.BeginOperation(this);

                var prdid = int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString());
                imageList1.Images.Clear();
                var lst = (from p in OrderProuctAttachmentCmd.GetOneAttachmentByOrderProductID(prdid)
                            select p).ToList();
                this.Invoke((MethodInvoker)delegate
                {

                    PhotoBox.Image = null;

                    OrderProduct ats = (OrderProduct)DGVProducts.CurrentRow.DataBoundItem;

                    Application.DoEvents();
                    foreach (var item in lst)
                    {
                        TxtDescription.Text = item.Description;
                        PhotoBox.Image = item.imageX;

                        imageList1.Images.Add(string.Format("Description=[{0}]\n\n Customer=[{1}]\n", item.Description,item.CustomerText),item.imageX);

                        IDImageAddress = item.ID;



                        ListPictures.Add(item.imageX);
                    }



                    var getcurrentProductInfo = (OrderProduct)DGVProducts.CurrentRow.DataBoundItem;


                    lblPoductName.Text = getcurrentProductInfo.Product.Product_Name;
                    lblPrice.Text = "[none]";
                });
            }
            catch (NullReferenceException ex)
            {
                Operation.EndOperation(this);
                MessageBox.Show(ex.Message.ToString(), "  Error");
                return;
            }
            Operation.EndOperation(this);
        }



        private int i = 0;
        private void NextPhotoBtn_Click(object sender, EventArgs e)
        {
            if (PhotoBox.Image != null)
            {
                if (ListPictures.Count != 0 && i < ListPictures .Count )
                {
                    PhotoBox.Image = null;
                    PhotoBox.Image = ListPictures[i];
                    TxtDescription.Text = imageList1.Images.Keys[i];
                    
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
            var tb = new OrderProduct() { OrderID = TaregtOrder,
                Description = TxtDescription.Text,
                Qty = int.Parse(DGVProducts.CurrentRow.Cells[3].Value.ToString()),
                ProductID = int.Parse(DGVProducts.CurrentRow.Cells[1].Value.ToString()),
            ImageX = PhotoBox .Image  ,
            Status = "in producting ",
            
            };
            OrderProductsCmd.EditOrderProductStatus(tb, int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString()));


            var Otb = new Order() { OrderStatus = "in producting "
            };
            OrdersCmd.EditOrderStatusOnly (Otb, TaregtOrder);


            MessageBox.Show("Changes Was Saved ...");

            var cellPlaceHolder = DGVProducts.TableElement.GetCellElement(DGVProducts .CurrentRow , DGVProducts.Columns[0]);
            cellPlaceHolder.DrawFill = true;
            cellPlaceHolder.BackColor = System.Drawing.Color.Pink;
        }




        private OpenFileDialog Op = new OpenFileDialog();

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
        private byte[] byteImg1;
        private void ConvertCarsPhotoes()
        {
            if (Op.FileName != string.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                var img = Image.FromFile(Op.FileName);
                byteImg1 = PhotosConverter.ImageToByteArray(img);
                this.Cursor = Cursors.Default;
            }
            else
            {
                byteImg1 = null;
            }
        }





        private SaveFileDialog SvDialog = new SaveFileDialog();
        private void SavePhotoBtn_Click(object sender, EventArgs e)
        {
            if (PhotoBox.Image != null)
            {
                SvDialog = new SaveFileDialog();
                SvDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                SvDialog.Title = "Save an Image File";
                SvDialog.ShowDialog();


                if (SvDialog.FileName != string.Empty && PhotoBox.Image != null)
                {
                    var fs =
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



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
    }
}
