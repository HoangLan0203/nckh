using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietHoaDonVanChuyen
{
    public int MaChiTiet { get; set; }

    public int MaHoaDon { get; set; }

    public decimal PhiDichVu { get; set; }

    public virtual HoaDonVanChuyen MaHoaDonNavigation { get; set; } = null!;
}
