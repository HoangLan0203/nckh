using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietYcDonNhap
{
    public int MaChiTiet { get; set; }

    public int? MaDonNhap { get; set; }

    public int? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal GiaNhap { get; set; }

    public virtual DonNhapHang? MaDonNhapNavigation { get; set; }

    public virtual ChiTietSanPham? MaSanPhamNavigation { get; set; }
}
