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
    
    public partial class tbl_Books
    {
        public tbl_Books()
        {
            this.tbl_Borrow = new HashSet<tbl_Borrow>();
        }
    
        public int Id { get; set; }
        public string Bookname { get; set; }
        public string Writer { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual tbl_Type tbl_Type { get; set; }
        public virtual ICollection<tbl_Borrow> tbl_Borrow { get; set; }
    }
}