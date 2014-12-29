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
           string str =  "\n-------------------------------------------------------\n"+Environment.StackTrace+"\n-------------------"+DateTime.Now.ToString()+"--------------------------------";
           File.AppendAllText("TrackFile.xprema",str);
        }
    }
}
