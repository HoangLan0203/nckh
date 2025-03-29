using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class ChiTietSanPham
{
    public int MaSanPhamChiTiet { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? HinhAnh { get; set; }

    public int? TongSoLuong { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public decimal? KhoiLuong { get; set; }

    public string? GioiTinh { get; set; }

    public int? MaSanPham { get; set; }

    public double Rate { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<ChiTietDonNhap> ChiTietDonNhaps { get; set; } = new List<ChiTietDonNhap>();

    public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; } = new List<ChiTietGioHang>();

    public virtual ICollection<ChiTietHoaDonBanHang> ChiTietHoaDonBanHangs { get; set; } = new List<ChiTietHoaDonBanHang>();

    public virtual ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; } = new List<ChiTietHoaDonNhapHang>();

    public virtual ICollection<ChiTietYcDonNhap> ChiTietYcDonNhaps { get; set; } = new List<ChiTietYcDonNhap>();

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual DanhMuc? MaSanPhamNavigation { get; set; }

    public virtual ICollection<SanPhamSize> SanPhamSizes { get; set; } = new List<SanPhamSize>();

    public virtual ICollection<GiamGium> MaGiamGia { get; set; } = new List<GiamGium>();
}
