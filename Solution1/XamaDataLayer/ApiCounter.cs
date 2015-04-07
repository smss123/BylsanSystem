using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamaDataLayer
{
    public class ApiCounter
    {

        public static DbDataContext db = new DbDataContext();
        public static int GetNumber()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            decimal retVal;
            retVal = (long)BitConverter.ToInt16(buffer, 4);// +int.Parse(DateTime.Now.Millisecond.ToString());   
            return int.Parse(Math.Abs(int.Parse((retVal).ToString())).ToString());
        }
    }
}
