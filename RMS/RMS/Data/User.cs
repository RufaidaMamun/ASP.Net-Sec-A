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
    
    public partial class User
    {
        public User()
        {
            this.Requests = new HashSet<Request>();
            this.Requests1 = new HashSet<Request>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TypeId { get; set; }
    
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Request> Requests1 { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
