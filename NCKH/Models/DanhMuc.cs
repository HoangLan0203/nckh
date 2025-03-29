using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class DanhMuc
{
    public int MaSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
