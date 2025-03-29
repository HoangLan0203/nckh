using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class NhaCungCap
{
    public int MaNcc { get; set; }

    public string TenNcc { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; } = new List<DonNhapHang>();

    public virtual ICollection<HoaDonNhapHang> HoaDonNhapHangs { get; set; } = new List<HoaDonNhapHang>();

    public virtual ICollection<YcDonNhapHang> YcDonNhapHangs { get; set; } = new List<YcDonNhapHang>();
}
