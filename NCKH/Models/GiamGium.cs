using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class GiamGium
{
    public int MaGiamGia { get; set; }

    public string? TenGiamGia { get; set; }

    public decimal TyLeGiam { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public virtual ICollection<ChiTietSanPham> MaSanPhams { get; set; } = new List<ChiTietSanPham>();
}
