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
    
    public partial class Payment
    {
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> PaymentDate { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> DollarAmount { get; set; }
        public Nullable<decimal> RMBAmount { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
