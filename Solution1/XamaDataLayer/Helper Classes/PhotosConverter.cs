﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace XamaDataLayer.Helper_Classes
{
    public static class PhotosConverter
    {
        public byte[] ConvertImageToByteArray(System.Drawing.Image
          imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
        {

            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

        //=========================================================
        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);
            return data;
        }

        //==========================
        // To Save Photo at  form

        //Image img = Image.FromFile( Op.FileName  );
        //    byte[] byteImg = ImageToByteArray( img );
        //    Rw.Photo =  byteImg;
    }
}
