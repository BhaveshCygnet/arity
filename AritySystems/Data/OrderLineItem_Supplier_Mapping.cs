//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AritySystems.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLineItem_Supplier_Mapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderLineItem_Supplier_Mapping()
        {
            this.OrderLineItem_Supplier_Mapping1 = new HashSet<OrderLineItem_Supplier_Mapping>();
            this.Supplier_Assigned_OrderLineItem = new HashSet<Supplier_Assigned_OrderLineItem>();
        }
    
        public int OrderLineItemId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLineItem_Supplier_Mapping> OrderLineItem_Supplier_Mapping1 { get; set; }
        public virtual OrderLineItem_Supplier_Mapping OrderLineItem_Supplier_Mapping2 { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier_Assigned_OrderLineItem> Supplier_Assigned_OrderLineItem { get; set; }
    }
}