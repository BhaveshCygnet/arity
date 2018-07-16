using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AritySystems.Models
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> DollarPurchasePrice { get; set; }
        public Nullable<decimal> RMDPurchasePrice { get; set; }
        public Nullable<decimal> DollarSalesPrice { get; set; }
        public Nullable<decimal> RMBSalesPrice { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}