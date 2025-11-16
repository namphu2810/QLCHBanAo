using Microsoft.EntityFrameworkCore;

namespace QLCHBanAo.Models
{
    public class QlbaDbContext : DbContext
    {
        public QlbaDbContext(DbContextOptions<QlbaDbContext> options) : base(options) { }

        public DbSet<CuaHang> CuaHang { get; set; }
        public DbSet<ThuongHieu> ThuongHieu { get; set; }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<KichThuoc> KichThuoc { get; set; }
        public DbSet<ChatLieu> ChatLieu { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<BienThe> BienThe { get; set; }
        public DbSet<TonKhoSP> TonKhoSP { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<NguoiDungCuaHang> NguoiDungCuaHang { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuaHang>().ToTable("CuaHang");
            modelBuilder.Entity<ThuongHieu>().ToTable("ThuongHieu");
            modelBuilder.Entity<MauSac>().ToTable("MauSac");
            modelBuilder.Entity<KichThuoc>().ToTable("KichThuoc");
            modelBuilder.Entity<ChatLieu>().ToTable("ChatLieu");
            modelBuilder.Entity<SanPham>().ToTable("SanPham");
            modelBuilder.Entity<BienThe>().ToTable("BienThe");
            modelBuilder.Entity<TonKhoSP>().ToTable("TonKhoSP");
            modelBuilder.Entity<NguoiDung>().ToTable("NguoiDung");
            modelBuilder.Entity<NguoiDungCuaHang>().ToTable("NguoiDungCuaHang");
        }
    }
}
