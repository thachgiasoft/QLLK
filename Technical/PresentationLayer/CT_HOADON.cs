//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_HOADON
    {
        public string MaHoaDon { get; set; }
        public string MaLinhKien { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual LINHKIEN LINHKIEN { get; set; }
    }
}
