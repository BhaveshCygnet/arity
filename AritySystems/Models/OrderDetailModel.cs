using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AritySystems.Data;

namespace AritySystems.Models
{
    public class OrderDetailModel
    {
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public Decimal OrderTotal { get; set; }
        public IEnumerable<OrderLineItem> OrderLineItemsList { get; set; }
        public IEnumerable<SupplierOrderLineItemModel> SupplierOrderLineItemList { get; set; }
    }
}