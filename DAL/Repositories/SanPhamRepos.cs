using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepos
    {
        AppDbContext _context = new AppDbContext();

        public SanPhamRepos()
        {
            _context = new AppDbContext();
        }
        public List<SanPham> GetAllSanPham()
        {
            return _context.sanPhams.ToList(); // Lấy ra toàn bộ danh sách sản phẩm
        }
        
        public SanPham GetById(int id)
        {
            return _context.sanPhams.Find(id);
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.sanPhams.Add(sp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSanPham(SanPham sp,int id)
        {
            try
            {
                var update = _context.sanPhams.Find(id);
                update.TenSanPham = sp.TenSanPham;
                update.AnhSanPham = sp.AnhSanPham;
                update.SoLuong = sp.SoLuong;
                update.TrangThai = sp.TrangThai;
                update.GiaSanPham = sp.GiaSanPham;
                update.IdLoaiSp = sp.IdLoaiSp;
                update.giamGiaId = sp.giamGiaId;
                _context.sanPhams.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception )
            {

                return false;
            }
        }
    }
}
