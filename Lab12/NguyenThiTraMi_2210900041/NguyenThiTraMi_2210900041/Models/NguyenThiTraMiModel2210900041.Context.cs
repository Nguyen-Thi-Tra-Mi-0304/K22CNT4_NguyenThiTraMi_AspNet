﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenThiTraMi_2210900041.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NguyenThiTraMi_2210900041Entities : DbContext
    {
        public NguyenThiTraMi_2210900041Entities()
            : base("name=NguyenThiTraMi_2210900041Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NTTM_SACH> NTTM_SACH { get; set; }
        public virtual DbSet<NTTM_TACGIA> NTTM_TACGIA { get; set; }
    }
}