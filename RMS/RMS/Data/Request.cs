//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int Qty { get; set; }
        public int PreservedTime { get; set; }
        public int RequestedBy { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public int StatusId { get; set; }
        public System.DateTime RequestedOn { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
