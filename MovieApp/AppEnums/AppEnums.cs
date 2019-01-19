using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.AppEnums
{
    public static class AppEnums
    {
        public enum MembershipTypes
        {
            Unknown = 0,
            PayAsUGo = 1,
            Monthly = 2,
            Quaterly = 3,
            Annual = 4
        }
    }
}