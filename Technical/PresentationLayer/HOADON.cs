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
    
    public partial class HOADON
    {
        public HOADON()
        {
            this.CT_HOADON = new HashSet<CT_HOADON>();
        }
    
        public string MaHoaDon { get; set; }
        public string MaPhieu { get; set; }
        public System.DateTime NgayLap { get; set; }
        public string MaNguoiLap { get; set; }
        public decimal TongTien { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string MaKhachHang { get; set; }
    
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
