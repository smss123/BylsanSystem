using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
                CustomerInformations.WaitingAttachment.Add(new OrderProuctAttachment() { Description = DescriptiontextBox.Text,
                  imageX = pic.Image,
                     });
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
