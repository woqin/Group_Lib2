//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Group_Lib2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class return_record
    {
        public int id { get; set; }
        public Nullable<int> readerid { get; set; }
        public Nullable<int> bookid { get; set; }
        public Nullable<System.DateTime> returndate { get; set; }
    
        public virtual book book { get; set; }
        public virtual reader reader { get; set; }
    }
}