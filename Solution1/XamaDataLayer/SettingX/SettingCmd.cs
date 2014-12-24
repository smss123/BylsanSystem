using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.SettingX
{
    public class SettingCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static SystemSetting GetSettingByID(int id)
        {
            db = new DbDataContext();
            var lst = (from i in db.SystemSettings
                       orderby i.ID ascending
                       where i.ID == id
                       select i).Take(1).Single();
            return lst;
        }

        public static SystemSetting GetSettingBySerialNumber(string id)
        {
            db = new DbDataContext();
            var lst = (from i in db.SystemSettings
                       orderby i.ID ascending
                       where i.SerialNumber.ToString() == id
                       select i).Take(1).Single();
            return lst;
        }
        public static bool EditSettingValue(string StrVal, string ID)
        {
            var state = false;
            db = new DbDataContext();
            var lst = (from i in db.SystemSettings
                       orderby i.ID ascending
                       where i.SerialNumber.ToString() == ID
                       select i).Take(1).Single();

            lst.SettingValue = StrVal;
            db.SubmitChanges();

            return state;
        }
    }
}
