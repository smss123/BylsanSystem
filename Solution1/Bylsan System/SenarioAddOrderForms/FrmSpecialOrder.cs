using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;


namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmSpecialOrder : Form
    {
        public FrmSpecialOrder()
        {
            InitializeComponent();
        }

   

        #region "    ^^^ Brwose Photo    "
        int i = 0;

        PictureBox pic = new PictureBox();
         List <int> ImgIndx = new List<int> () ;

        OpenFileDialog Op = new OpenFileDialog();
        private void BrwoseBtn_Click(object sender, EventArgs e)
        {
            pic = new PictureBox();
            pic.Tag = i;
            
            pic.Size = new Size(80, 80);
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            flowLayoutPanel1.Controls.Add(pic);
          
            //======================================
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                pic.Image = Image.FromFile(Op.FileName);
                ImageListProducuts.Images.Add(pic.Image );
                ImgIndx.Add(i) ;
                this.Cursor = Cursors.Default;
                i++;
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

        private void OkyBtn_Click(object sender, EventArgs e)
        {
            // Starting Save :



            //=====================================
            this.Hide();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
           
               
                flowLayoutPanel1.Controls.RemoveAt(ImgIndx .Max ());

                ImageListProducuts.Images.RemoveAt(ImgIndx.Max());
                ImgIndx.RemoveAt(ImgIndx.Max());

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
         
        }


    }
}
