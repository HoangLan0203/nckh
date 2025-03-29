using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class DonHang
{
    public int MaDonHang { get; set; }

    public int? MaNguoiDung { get; set; }

    public DateTime? NgayDat { get; set; }

    public decimal? TongTien { get; set; }

    public decimal? PhiVanChuyen { get; set; }

    public string? TrangThai { get; set; }

    public int? MaDvvc { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; } = new List<HoaDonBanHang>();

    public virtual ICollection<HoaDonVanChuyen> HoaDonVanChuyens { get; set; } = new List<HoaDonVanChuyen>();

    public virtual DonViVanChuyen? MaDvvcNavigation { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
