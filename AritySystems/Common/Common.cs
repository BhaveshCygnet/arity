using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AritySystems.Common
{
    public class Common
    {
        /// <summary>
        /// Define User Types as per system
        /// </summary>
        public enum ArityUserType
        {
            Admin = 1,
            Sales = 2,
            Purchase = 3,
            Supplier = 4,
            Exporter = 5,
            Customer = 6
        }

        public enum OrderStatus
        {
            draft =1,
            pending = 2
        }
    }
}