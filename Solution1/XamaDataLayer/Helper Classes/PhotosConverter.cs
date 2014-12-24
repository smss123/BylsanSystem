using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;

namespace XamaDataLayer.Helper_Classes
{
    public  class PhotosConverter
    {
        public static  byte[] ConvertImageToByteArray(System.Drawing.Image
        imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ret;
        }


        public  static byte[] ImageToByteArray(Image img)
        {
            var ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private byte[] ReadFile(string sPath)
        {
            var data = (byte[])null;

            var fInfo = new FileInfo(sPath);
            var numBytes = fInfo.Length;

            var fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            var br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);
            return data;
        }
    }
}
