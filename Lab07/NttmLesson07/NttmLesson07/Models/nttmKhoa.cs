//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NttmLesson07.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nttmKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nttmKhoa()
        {
            this.nttmSinhViens = new HashSet<nttmSinhVien>();
        }
    
        public string nttmMaKH { get; set; }
        public string nttmTenKH { get; set; }
        public Nullable<bool> nttmTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nttmSinhVien> nttmSinhViens { get; set; }
    }
}
