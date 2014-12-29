using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XamaDataLayer.Helper_Classes
{
  public  class XpremaTrack
    {
     static Thread  th = null;
        public static void WriteTrack()
        {
           th = new Thread(SaveTrack);
           th.Start();
        }

        private static void SaveTrack()
        {
            while (true)
            {
                string str = string.Format("\n-------------------------------------------------------\n{0}\n-------------------{1}--------------------------------", Environment.StackTrace, DateTime.Now.ToString());
                File.AppendAllText("TrackFile.xprema", str);
                Thread.Sleep(50000);
            }
        }
    }
}
