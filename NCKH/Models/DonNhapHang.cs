using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class DonNhapHang
{
    public int MaDonNhap { get; set; }

    public int? MaNcc { get; set; }

    public DateTime? NgayNhap { get; set; }

    public decimal? TongTien { get; set; }

    public virtual ICollection<ChiTietDonNhap> ChiTietDonNhaps { get; set; } = new List<ChiTietDonNhap>();

    public virtual ICollection<ChiTietYcDonNhap> ChiTietYcDonNhaps { get; set; } = new List<ChiTietYcDonNhap>();

    public virtual ICollection<HoaDonNhapHang> HoaDonNhapHangs { get; set; } = new List<HoaDonNhapHang>();

    public virtual NhaCungCap? MaNccNavigation { get; set; }
}
