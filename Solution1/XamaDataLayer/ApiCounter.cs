using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamaDataLayer
{
    public class ApiCounter
    {
        public int GetNumber()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt16(buffer, 8) + int.Parse(DateTime.Now.Ticks.ToString());
        }
    }
}
