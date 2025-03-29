using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietHoaDonBanHang
{
    public int MaChiTiet { get; set; }

    public int MaHoaDon { get; set; }

    public int MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual HoaDonBanHang MaHoaDonNavigation { get; set; } = null!;

    public virtual ChiTietSanPham MaSanPhamNavigation { get; set; } = null!;
}
