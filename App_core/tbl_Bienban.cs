//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Bienban
    {
        public string PK_sMabienban { get; set; }
        public System.DateTime dNgaylap { get; set; }
        public string FK_sMaNV { get; set; }
        public string sNddanhgia { get; set; }
    
        public virtual tbl_Nhanvien tbl_Nhanvien { get; set; }
    }
}
