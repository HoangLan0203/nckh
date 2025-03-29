using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class GioHang
{
    public int MaGioHang { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; } = new List<ChiTietGioHang>();

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
