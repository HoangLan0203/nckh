using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ThanhToan
{
    public int MaThanhToan { get; set; }

    public string TenHinhThuc { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; } = new List<HoaDonBanHang>();

    public virtual ICollection<HoaDonNhapHang> HoaDonNhapHangs { get; set; } = new List<HoaDonNhapHang>();

    public virtual ICollection<HoaDonVanChuyen> HoaDonVanChuyens { get; set; } = new List<HoaDonVanChuyen>();
}
