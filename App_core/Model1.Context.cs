﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.App_core
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyNhanSu_KTPMEntities1 : DbContext
    {
        public QuanLyNhanSu_KTPMEntities1()
            : base("name=QuanLyNhanSu_KTPMEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Bienban> tbl_Bienban { get; set; }
        public virtual DbSet<tbl_Nhanvien> tbl_Nhanvien { get; set; }
    }
}
