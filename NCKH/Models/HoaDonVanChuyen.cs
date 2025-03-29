using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class HoaDonVanChuyen
{
    public int MaHoaDon { get; set; }

    public int MaDonHang { get; set; }

    public int MaDvvc { get; set; }

    public DateTime? NgayLap { get; set; }

    public decimal PhiVanChuyen { get; set; }

    public int MaThanhToan { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDonVanChuyen> ChiTietHoaDonVanChuyens { get; set; } = new List<ChiTietHoaDonVanChuyen>();

    public virtual DonHang MaDonHangNavigation { get; set; } = null!;

    public virtual DonViVanChuyen MaDvvcNavigation { get; set; } = null!;

    public virtual ThanhToan MaThanhToanNavigation { get; set; } = null!;
}
