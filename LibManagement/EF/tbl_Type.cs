//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibManagement.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Type
    {
        public tbl_Type()
        {
            this.tbl_Books = new HashSet<tbl_Books>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
    
        public virtual ICollection<tbl_Books> tbl_Books { get; set; }
    }
}