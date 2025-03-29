using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietHoaDonNhapHang
{
    public int MaChiTiet { get; set; }

    public int MaHoaDon { get; set; }

    public int MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual HoaDonNhapHang MaHoaDonNavigation { get; set; } = null!;

    public virtual ChiTietSanPham MaSanPhamNavigation { get; set; } = null!;
}
