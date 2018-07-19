using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AritySystems.Common
{
    public static class EnumHelpers
    {
        public enum Units { NOs, Ltr, Kg, gm }

        public enum OrderStatus
        {
            Draft = 1,
            Process = 2,
            Complete = 3,
            Caceled = 4
        }
    }

}