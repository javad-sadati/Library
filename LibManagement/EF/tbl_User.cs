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
    
    public partial class tbl_User
    {
        public tbl_User()
        {
            this.tbl_Borrow = new HashSet<tbl_Borrow>();
        }
    
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Tell { get; set; }
        public string Pic { get; set; }
    
        public virtual ICollection<tbl_Borrow> tbl_Borrow { get; set; }
    }
}