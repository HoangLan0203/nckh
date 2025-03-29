using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietGioHang
{
    public int Id { get; set; }

    public int? MaGioHang { get; set; }

    public int? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public virtual GioHang? MaGioHangNavigation { get; set; }

    public virtual ChiTietSanPham? MaSanPhamNavigation { get; set; }
}
