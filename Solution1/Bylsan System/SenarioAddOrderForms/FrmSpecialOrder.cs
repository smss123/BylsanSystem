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
    
        OpenFileDialog Op = new OpenFileDialog();
        private void BrwoseBtn_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Tag = i;
            pic.Size = new Size(80, 80);
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            flowLayoutPanel1.Controls.Add(pic);
            i++;
            //======================================
            Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Op.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
                pic.Image = Image.FromFile(Op.FileName);
                ImageListProducuts.Images.Add(pic.Image );
            
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

        private void OkyBtn_Click(object sender, EventArgs e)
        {
            // Starting Save :



            //=====================================
            this.Hide();
        }


    }
}
