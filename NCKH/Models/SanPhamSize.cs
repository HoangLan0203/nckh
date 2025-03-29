using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class SanPhamSize
{
    public int Id { get; set; }

    public int? MaSanPham { get; set; }

    public string Size { get; set; } = null!;

    public int? SoLuong { get; set; }

    public virtual ChiTietSanPham? MaSanPhamNavigation { get; set; }
}
