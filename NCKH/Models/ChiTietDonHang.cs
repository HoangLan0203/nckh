using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietDonHang
{
    public int Id { get; set; }

    public int? MaDonHang { get; set; }

    public int? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal GiaBan { get; set; }

    public virtual DonHang? MaDonHangNavigation { get; set; }

    public virtual ChiTietSanPham? MaSanPhamNavigation { get; set; }
}
