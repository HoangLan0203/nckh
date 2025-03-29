using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class DanhGium
{
    public int Id { get; set; }

    public int? MaSanPham { get; set; }

    public int? MaNguoiDung { get; set; }

    public int? SoSao { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayDanhGia { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }

    public virtual ChiTietSanPham? MaSanPhamNavigation { get; set; }
}
