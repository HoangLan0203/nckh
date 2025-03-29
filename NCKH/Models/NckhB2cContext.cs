using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NCKH.Models;

public partial class NckhB2cContext : DbContext
{
    public NckhB2cContext()
    {
    }

    public NckhB2cContext(DbContextOptions<NckhB2cContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChiTietDonNhap> ChiTietDonNhaps { get; set; }

    public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }

    public virtual DbSet<ChiTietHoaDonBanHang> ChiTietHoaDonBanHangs { get; set; }

    public virtual DbSet<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; }

    public virtual DbSet<ChiTietHoaDonVanChuyen> ChiTietHoaDonVanChuyens { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<ChiTietYcDonNhap> ChiTietYcDonNhaps { get; set; }

    public virtual DbSet<DanhGium> DanhGia { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<DonNhapHang> DonNhapHangs { get; set; }

    public virtual DbSet<DonViVanChuyen> DonViVanChuyens { get; set; }

    public virtual DbSet<GiamGium> GiamGia { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }

    public virtual DbSet<HoaDonNhapHang> HoaDonNhapHangs { get; set; }

    public virtual DbSet<HoaDonVanChuyen> HoaDonVanChuyens { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }

    public virtual DbSet<SanPhamSize> SanPhamSizes { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    public virtual DbSet<YcDonNhapHang> YcDonNhapHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-OCT2HQU\\SQLEXPRESS;Initial Catalog=NCKH_B2c;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__chi_tiet__3213E83F8214145B");

            entity.ToTable("chi_tiet_don_hang");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GiaBan)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("gia_ban");
            entity.Property(e => e.MaDonHang).HasColumnName("ma_don_hang");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaDonHang)
                .HasConstraintName("FK__chi_tiet___ma_do__07C12930");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__chi_tiet___ma_sa__08B54D69");
        });

        modelBuilder.Entity<ChiTietDonNhap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__chi_tiet__3213E83FA5019BD8");

            entity.ToTable("chi_tiet_don_nhap");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GiaNhap)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("gia_nhap");
            entity.Property(e => e.MaDonNhap).HasColumnName("ma_don_nhap");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");

            entity.HasOne(d => d.MaDonNhapNavigation).WithMany(p => p.ChiTietDonNhaps)
                .HasForeignKey(d => d.MaDonNhap)
                .HasConstraintName("FK__chi_tiet___ma_do__7A672E12");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietDonNhaps)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__chi_tiet___ma_sa__7B5B524B");
        });

        modelBuilder.Entity<ChiTietGioHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__chi_tiet__3213E83F145EAFFC");

            entity.ToTable("chi_tiet_gio_hang");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaGioHang).HasColumnName("ma_gio_hang");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");

            entity.HasOne(d => d.MaGioHangNavigation).WithMany(p => p.ChiTietGioHangs)
                .HasForeignKey(d => d.MaGioHang)
                .HasConstraintName("FK__chi_tiet___ma_gi__72C60C4A");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietGioHangs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__chi_tiet___ma_sa__73BA3083");
        });

        modelBuilder.Entity<ChiTietHoaDonBanHang>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__chi_tiet__CD8DB5146CA6D2E8");

            entity.ToTable("chi_tiet_hoa_don_ban_hang");

            entity.Property(e => e.MaChiTiet).HasColumnName("ma_chi_tiet");
            entity.Property(e => e.DonGia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("don_gia");
            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.ThanhTien)
                .HasComputedColumnSql("([so_luong]*[don_gia])", true)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("thanh_tien");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.ChiTietHoaDonBanHangs)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chi_tiet___ma_ho__123EB7A3");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietHoaDonBanHangs)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chi_tiet___ma_sa__1332DBDC");
        });

        modelBuilder.Entity<ChiTietHoaDonNhapHang>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__chi_tiet__CD8DB5149E1EE725");

            entity.ToTable("chi_tiet_hoa_don_nhap_hang");

            entity.Property(e => e.MaChiTiet).HasColumnName("ma_chi_tiet");
            entity.Property(e => e.DonGia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("don_gia");
            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.ThanhTien)
                .HasComputedColumnSql("([so_luong]*[don_gia])", true)
                .HasColumnType("decimal(29, 2)")
                .HasColumnName("thanh_tien");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.ChiTietHoaDonNhapHangs)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chi_tiet___ma_ho__1BC821DD");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietHoaDonNhapHangs)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chi_tiet___ma_sa__1CBC4616");
        });

        modelBuilder.Entity<ChiTietHoaDonVanChuyen>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__chi_tiet__CD8DB5148286FBB2");

            entity.ToTable("chi_tiet_hoa_don_van_chuyen");

            entity.Property(e => e.MaChiTiet).HasColumnName("ma_chi_tiet");
            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.PhiDichVu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("phi_dich_vu");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.ChiTietHoaDonVanChuyens)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__chi_tiet___ma_ho__2645B050");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPhamChiTiet).HasName("PK__chi_tiet__BBA2D7C95C1E5A87");

            entity.ToTable("chi_tiet_san_pham");

            entity.Property(e => e.MaSanPhamChiTiet)
                .ValueGeneratedNever()
                .HasColumnName("ma_san_pham_chi_tiet");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gioi_tinh");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hinh_anh");
            entity.Property(e => e.KhoiLuong)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("khoi_luong");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.MoTa)
                .HasColumnType("text")
                .HasColumnName("mo_ta");
            entity.Property(e => e.NgayCapNhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_cap_nhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.TenSanPham)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ten_san_pham");
            entity.Property(e => e.TongSoLuong)
                .HasDefaultValue(0)
                .HasColumnName("tong_so_luong");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__chi_tiet___ma_sa__571DF1D5");

            entity.HasMany(d => d.MaGiamGia).WithMany(p => p.MaSanPhams)
                .UsingEntity<Dictionary<string, object>>(
                    "SanPhamGiamGium",
                    r => r.HasOne<GiamGium>().WithMany()
                        .HasForeignKey("MaGiamGia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__san_pham___ma_gi__60A75C0F"),
                    l => l.HasOne<ChiTietSanPham>().WithMany()
                        .HasForeignKey("MaSanPham")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__san_pham___ma_sa__5FB337D6"),
                    j =>
                    {
                        j.HasKey("MaSanPham", "MaGiamGia").HasName("PK__san_pham__73F458E233C66FCE");
                        j.ToTable("san_pham_giam_gia");
                        j.IndexerProperty<int>("MaSanPham").HasColumnName("ma_san_pham");
                        j.IndexerProperty<int>("MaGiamGia").HasColumnName("ma_giam_gia");
                    });
        });

        modelBuilder.Entity<ChiTietYcDonNhap>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__chi_tiet__CD8DB514AC5D258E");

            entity.ToTable("chi_tiet_yc_don_nhap");

            entity.Property(e => e.MaChiTiet).HasColumnName("ma_chi_tiet");
            entity.Property(e => e.GiaNhap)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("gia_nhap");
            entity.Property(e => e.MaDonNhap).HasColumnName("ma_don_nhap");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");

            entity.HasOne(d => d.MaDonNhapNavigation).WithMany(p => p.ChiTietYcDonNhaps)
                .HasForeignKey(d => d.MaDonNhap)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__chi_tiet___ma_do__2DE6D218");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietYcDonNhaps)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__chi_tiet___ma_sa__2EDAF651");
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__danh_gia__3213E83F671BF2B7");

            entity.ToTable("danh_gia");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaNguoiDung).HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.NgayDanhGia)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_danh_gia");
            entity.Property(e => e.NoiDung)
                .HasColumnType("text")
                .HasColumnName("noi_dung");
            entity.Property(e => e.SoSao).HasColumnName("so_sao");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__danh_gia__ma_ngu__66603565");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__danh_gia__ma_san__656C112C");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__danh_muc__9D25990C882F0E37");

            entity.ToTable("danh_muc");

            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hinh_anh");
            entity.Property(e => e.MoTa)
                .HasColumnType("text")
                .HasColumnName("mo_ta");
            entity.Property(e => e.TenSanPham)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_san_pham");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__don_hang__0246C5EA07133991");

            entity.ToTable("don_hang");

            entity.Property(e => e.MaDonHang).HasColumnName("ma_don_hang");
            entity.Property(e => e.MaDvvc).HasColumnName("ma_dvvc");
            entity.Property(e => e.MaNguoiDung).HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.NgayDat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_dat");
            entity.Property(e => e.PhiVanChuyen)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("phi_van_chuyen");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("tong_tien");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ch? xác nh?n")
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaDvvcNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaDvvc)
                .HasConstraintName("FK__don_hang__ma_dvv__04E4BC85");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__don_hang__ma_ngu__03F0984C");
        });

        modelBuilder.Entity<DonNhapHang>(entity =>
        {
            entity.HasKey(e => e.MaDonNhap).HasName("PK__don_nhap__F08C58A5E15E252F");

            entity.ToTable("don_nhap_hang");

            entity.Property(e => e.MaDonNhap).HasColumnName("ma_don_nhap");
            entity.Property(e => e.MaNcc).HasColumnName("ma_ncc");
            entity.Property(e => e.NgayNhap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_nhap");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("tong_tien");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.DonNhapHangs)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__don_nhap___ma_nc__778AC167");
        });

        modelBuilder.Entity<DonViVanChuyen>(entity =>
        {
            entity.HasKey(e => e.MaDvvc).HasName("PK__don_vi_v__801B8936A41E5C70");

            entity.ToTable("don_vi_van_chuyen");

            entity.HasIndex(e => e.Email, "UQ__don_vi_v__AB6E6164A74A0A43").IsUnique();

            entity.Property(e => e.MaDvvc).HasColumnName("ma_dvvc");
            entity.Property(e => e.DiaChi)
                .HasColumnType("text")
                .HasColumnName("dia_chi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PhiVanChuyen)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("phi_van_chuyen");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TenDonVi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ten_don_vi");
        });

        modelBuilder.Entity<GiamGium>(entity =>
        {
            entity.HasKey(e => e.MaGiamGia).HasName("PK__giam_gia__ED1C1EEF029B26BF");

            entity.ToTable("giam_gia");

            entity.Property(e => e.MaGiamGia).HasColumnName("ma_giam_gia");
            entity.Property(e => e.NgayBatDau).HasColumnName("ngay_bat_dau");
            entity.Property(e => e.NgayKetThuc).HasColumnName("ngay_ket_thuc");
            entity.Property(e => e.TenGiamGia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_giam_gia");
            entity.Property(e => e.TyLeGiam)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ty_le_giam");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.MaGioHang).HasName("PK__gio_hang__6C00DDA3DA401C0B");

            entity.ToTable("gio_hang");

            entity.HasIndex(e => e.MaNguoiDung, "UQ__gio_hang__19C32CF6B6D6859A").IsUnique();

            entity.Property(e => e.MaGioHang).HasColumnName("ma_gio_hang");
            entity.Property(e => e.MaNguoiDung).HasColumnName("ma_nguoi_dung");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithOne(p => p.GioHang)
                .HasForeignKey<GioHang>(d => d.MaNguoiDung)
                .HasConstraintName("FK__gio_hang__ma_ngu__6FE99F9F");
        });

        modelBuilder.Entity<HoaDonBanHang>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__hoa_don___DBE2D9E3A13217BA");

            entity.ToTable("hoa_don_ban_hang");

            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaDonHang).HasColumnName("ma_don_hang");
            entity.Property(e => e.MaNguoiDung).HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MaThanhToan).HasColumnName("ma_thanh_toan");
            entity.Property(e => e.NgayLap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_lap");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tong_tien");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.HoaDonBanHangs)
                .HasForeignKey(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_b__ma_do__0D7A0286");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.HoaDonBanHangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_b__ma_ng__0E6E26BF");

            entity.HasOne(d => d.MaThanhToanNavigation).WithMany(p => p.HoaDonBanHangs)
                .HasForeignKey(d => d.MaThanhToan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_b__ma_th__0F624AF8");
        });

        modelBuilder.Entity<HoaDonNhapHang>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__hoa_don___DBE2D9E3C018BE14");

            entity.ToTable("hoa_don_nhap_hang");

            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaDonNhap).HasColumnName("ma_don_nhap");
            entity.Property(e => e.MaNcc).HasColumnName("ma_ncc");
            entity.Property(e => e.MaThanhToan).HasColumnName("ma_thanh_toan");
            entity.Property(e => e.NgayLap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_lap");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tong_tien");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaDonNhapNavigation).WithMany(p => p.HoaDonNhapHangs)
                .HasForeignKey(d => d.MaDonNhap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_n__ma_do__17036CC0");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.HoaDonNhapHangs)
                .HasForeignKey(d => d.MaNcc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_n__ma_nc__17F790F9");

            entity.HasOne(d => d.MaThanhToanNavigation).WithMany(p => p.HoaDonNhapHangs)
                .HasForeignKey(d => d.MaThanhToan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_n__ma_th__18EBB532");
        });

        modelBuilder.Entity<HoaDonVanChuyen>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__hoa_don___DBE2D9E31EEE9908");

            entity.ToTable("hoa_don_van_chuyen");

            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaDonHang).HasColumnName("ma_don_hang");
            entity.Property(e => e.MaDvvc).HasColumnName("ma_dvvc");
            entity.Property(e => e.MaThanhToan).HasColumnName("ma_thanh_toan");
            entity.Property(e => e.NgayLap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_lap");
            entity.Property(e => e.PhiVanChuyen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("phi_van_chuyen");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.HoaDonVanChuyens)
                .HasForeignKey(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_v__ma_do__2180FB33");

            entity.HasOne(d => d.MaDvvcNavigation).WithMany(p => p.HoaDonVanChuyens)
                .HasForeignKey(d => d.MaDvvc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_v__ma_dv__22751F6C");

            entity.HasOne(d => d.MaThanhToanNavigation).WithMany(p => p.HoaDonVanChuyens)
                .HasForeignKey(d => d.MaThanhToan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hoa_don_v__ma_th__236943A5");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaNguoiDung).HasName("PK__nguoi_du__19C32CF7F20DE7D7");

            entity.ToTable("nguoi_dung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__nguoi_du__363698B3597F6518").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__nguoi_du__AB6E616492F7E32C").IsUnique();

            entity.Property(e => e.MaNguoiDung).HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.DiaChi)
                .HasColumnType("text")
                .HasColumnName("dia_chi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HoTen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ho_ten");
            entity.Property(e => e.MaQuyen).HasColumnName("ma_quyen");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mat_khau");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_dang_nhap");

            entity.HasOne(d => d.MaQuyenNavigation).WithMany(p => p.NguoiDungs)
                .HasForeignKey(d => d.MaQuyen)
                .HasConstraintName("FK__nguoi_dun__ma_qu__4E88ABD4");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK__nha_cung__04FFEEB92BE930A1");

            entity.ToTable("nha_cung_cap");

            entity.HasIndex(e => e.Email, "UQ__nha_cung__AB6E6164B5AD76B6").IsUnique();

            entity.Property(e => e.MaNcc).HasColumnName("ma_ncc");
            entity.Property(e => e.DiaChi)
                .HasColumnType("text")
                .HasColumnName("dia_chi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ten_ncc");
        });

        modelBuilder.Entity<PhanQuyen>(entity =>
        {
            entity.HasKey(e => e.MaQuyen).HasName("PK__phan_quy__B9A4290F7A986A90");

            entity.ToTable("phan_quyen");

            entity.Property(e => e.MaQuyen).HasColumnName("ma_quyen");
            entity.Property(e => e.TenQuyen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ten_quyen");
        });

        modelBuilder.Entity<SanPhamSize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__san_pham__3213E83F54C6F904");

            entity.ToTable("san_pham_size");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaSanPham).HasColumnName("ma_san_pham");
            entity.Property(e => e.Size)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("size");
            entity.Property(e => e.SoLuong)
                .HasDefaultValue(0)
                .HasColumnName("so_luong");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.SanPhamSizes)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK__san_pham___ma_sa__5AEE82B9");
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaThanhToan).HasName("PK__thanh_to__F89DBB4FA3CC9F62");

            entity.ToTable("thanh_toan");

            entity.HasIndex(e => e.TenHinhThuc, "UQ__thanh_to__E8B029CF1AA1E5B2").IsUnique();

            entity.Property(e => e.MaThanhToan).HasColumnName("ma_thanh_toan");
            entity.Property(e => e.MoTa)
                .HasColumnType("text")
                .HasColumnName("mo_ta");
            entity.Property(e => e.TenHinhThuc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ten_hinh_thuc");
        });

        modelBuilder.Entity<YcDonNhapHang>(entity =>
        {
            entity.HasKey(e => e.MaDonNhap).HasName("PK__yc_don_n__F08C58A52EA30D45");

            entity.ToTable("yc_don_nhap_hang");

            entity.Property(e => e.MaDonNhap).HasColumnName("ma_don_nhap");
            entity.Property(e => e.MaNcc).HasColumnName("ma_ncc");
            entity.Property(e => e.NgayNhap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_nhap");
            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("tong_tien");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .HasDefaultValue("Ch? x? lý")
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.YcDonNhapHangs)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__yc_don_nh__ma_nc__2B0A656D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
