//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NttmLesson09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NttmKetQua
    {
        public string NttmKQ { get; set; }
        public string NttmMaSV { get; set; }
        public string NttmMaMH { get; set; }
        public Nullable<decimal> NttmDiem { get; set; }
    
        public virtual NttmMonHoc NttmMonHoc { get; set; }
        public virtual NttmSinhVien NttmSinhVien { get; set; }
    }
}