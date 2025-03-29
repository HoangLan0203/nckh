using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class YcDonNhapHang
{
    public int MaDonNhap { get; set; }

    public int? MaNcc { get; set; }

    public DateTime? NgayNhap { get; set; }

    public decimal TongTien { get; set; }

    public string? TrangThai { get; set; }

    public virtual NhaCungCap? MaNccNavigation { get; set; }
}
