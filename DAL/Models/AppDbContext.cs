using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4J2MO29\\PH19847;Database=QuanLyBanKem;Trusted_Connection=True;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HoaDon>()
            .HasOne(h => h.TaiKhoan)
            .WithMany(t => t.HoaDons)
            .HasForeignKey(h => h.IdTaiKhoan);
        }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<GiamGia> giamGias { get; set; }
        public DbSet<LoaiSanPham> loaiSanPhams { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        
    }
}
