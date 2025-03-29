using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class HoaDonNhapHang
{
    public int MaHoaDon { get; set; }

    public int MaDonNhap { get; set; }

    public int MaNcc { get; set; }

    public DateTime? NgayLap { get; set; }

    public decimal TongTien { get; set; }

    public int MaThanhToan { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; } = new List<ChiTietHoaDonNhapHang>();

    public virtual DonNhapHang MaDonNhapNavigation { get; set; } = null!;

    public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

    public virtual ThanhToan MaThanhToanNavigation { get; set; } = null!;
}
