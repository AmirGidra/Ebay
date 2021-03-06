//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SoldItem
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public bool Visible { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public string Condition { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ShopTransaction ShopTransaction { get; set; }
        public virtual ShopUser ShopUser { get; set; }
    }
}
