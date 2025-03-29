using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class HoaDonBanHang
{
    public int MaHoaDon { get; set; }

    public int MaDonHang { get; set; }

    public int MaNguoiDung { get; set; }

    public DateTime? NgayLap { get; set; }

    public decimal TongTien { get; set; }

    public int MaThanhToan { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDonBanHang> ChiTietHoaDonBanHangs { get; set; } = new List<ChiTietHoaDonBanHang>();

    public virtual DonHang MaDonHangNavigation { get; set; } = null!;

    public virtual NguoiDung MaNguoiDungNavigation { get; set; } = null!;

    public virtual ThanhToan MaThanhToanNavigation { get; set; } = null!;
}
