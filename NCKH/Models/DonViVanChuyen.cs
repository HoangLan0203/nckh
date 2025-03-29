using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class DonViVanChuyen
{
    public int MaDvvc { get; set; }

    public string TenDonVi { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string Email { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public decimal PhiVanChuyen { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual ICollection<HoaDonVanChuyen> HoaDonVanChuyens { get; set; } = new List<HoaDonVanChuyen>();
}
