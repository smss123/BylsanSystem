using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.Helper_Classes;


namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmSpecialOrder : RadForm
    {
        public FrmSpecialOrder()
        {
            InitializeComponent();
        }


        public Product TragetOrderproduct { get; set; }
        private List<OrderProuctAttachment> AttachList = new List<OrderProuctAttachment>();
        private int i = 0;

        private PictureBox pic = new PictureBox();
        private List <int> ImgIndx = new List<int> () ;

        private OpenFileDialog Op = new OpenFileDialog();
        private void BrwoseBtn_Click(object sender, EventArgs e)
        {
            pic = new PictureBox();
            pic.Tag = i;

            pic.Size = new Size(80, 80);
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            flowLayoutPanel1.Controls.Add(pic);


            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                pic.Image = Image.FromFile(Op.FileName);
                ImageListProducuts.Images.Add(pic.Image );
                ImgIndx.Add(i) ;



                var attach = new OrderProuctAttachment()
                {
                    Description = 
                    string.Format("Description:\n {0}  \n\n\n Customer Text : {1}", DescriptiontextBox.Text, txtCustomerText.Text),
                    imageX = pic.Image,
                };
                AttachList.Add(attach);
                this.Cursor = Cursors.Default;
                i++;
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




        private void OkyBtn_Click(object sender, EventArgs e)
        {
            OrderProduct or = new OrderProduct()
            {
                ProductID = TragetOrderproduct.ID,
                Product = TragetOrderproduct,
                Description ="",
                Qty = 1,
                Status = "Ordered"
            };
            foreach (var item in AttachList)
            {
                OrderProuctAttachment op = new OrderProuctAttachment()
                {
                     Description= item.Description,
                      imageX= item.imageX,
                       OrderProductID= item.OrderProductID
                };
                or.OrderProuctAttachments.Add(op);
            }
            
            CustomerInformations.WaitingOrder.OrderProducts.Add(or);
            this.Hide();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var xIndex = ImgIndx.Max();
            flowLayoutPanel1.Controls.RemoveAt(ImgIndx .Max ());
            CustomerInformations.WaitingAttachment.RemoveAt(xIndex );
            ImageListProducuts.Images.RemoveAt(ImgIndx.Max());
            ImgIndx.RemoveAt(ImgIndx.Max());
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void FrmSpecialOrder_Load(object sender, EventArgs e)
        {
        }
    }
}
