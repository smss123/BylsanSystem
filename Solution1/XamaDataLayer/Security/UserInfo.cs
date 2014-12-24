using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.Security
{
    public   class UserInfo
    {
        public static int CurrentUserID = 0;
        public static string CurrentUserName = string.Empty;
        public static string CurrentUserPassword = string.Empty;
        public static User CurrnetUser { get; set; }
    }
}
