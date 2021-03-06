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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderLineItems = new HashSet<OrderLineItem>();
        }
    
        public int Id { get; set; }
        public string Chinese_Name { get; set; }
        public string English_Name { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Dollar_Price { get; set; }
        public Nullable<decimal> RMB_Price { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; }
    }
}
