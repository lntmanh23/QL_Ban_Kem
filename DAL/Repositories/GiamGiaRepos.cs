using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiamGiaRepos
    {
        AppDbContext _context = new AppDbContext();

        public GiamGiaRepos()
        {
            _context = new AppDbContext();
        }
        public List<GiamGia> GetAllGiamGia()
        {
            return _context.giamGias.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public List<GiamGia> GetActiveGiamGia()
        {
            return _context.giamGias.Where(p=>p.NgayBatDau <= DateTime.Now && p.NgayKetThuc >= DateTime.Now &&
            p.TrangThai == 0).ToList(); // Lấy ra toàn bộ danh sách sản phẩm
        }

        public GiamGia GetById(int id)
        {
            return _context.giamGias.Find(id);
        }
        public bool CreateGiamGia(GiamGia gg)
        {
            try
            {
                
                _context.giamGias.Add(gg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateKm(GiamGia gg, int id)
        {
            try
            {
                var update = _context.giamGias.Find(id);
                update.TenGiamGia = gg.TenGiamGia;
                update.LoaiGiamGia = gg.LoaiGiamGia;
                update.GiaTri = gg.GiaTri;
                update.NgayBatDau = gg.NgayBatDau;
                update.NgayKetThuc = gg.NgayKetThuc;
                update.TrangThai = gg.TrangThai;
                _context.giamGias.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
