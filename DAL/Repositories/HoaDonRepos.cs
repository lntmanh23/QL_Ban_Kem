using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepos
    {
        AppDbContext _context = new AppDbContext();

        public HoaDonRepos()
        {
            _context = new AppDbContext();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return _context.HoaDons.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public HoaDon GetById(int id)
        {
            return _context.HoaDons.Find(id);
        }
        
        public bool CreateHD(HoaDon hd)
        {
            try
            {               
                _context.HoaDons.Add(hd);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }
        public bool DeleteHD(int id)
        {
            try
            {
                var delete = _context.HoaDons.Find(id);
                _context.HoaDons.Remove(delete);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteHD_HDCT(int id) // Xóa kèm cả những HDCT của nó nếu không sẽ không thể xóa được
        {
            try
            {
                var allhdct = _context.HoaDonChiTiets.Where(p => p.IdHoaDon == id);
                _context.HoaDonChiTiets.RemoveRange(allhdct); // Xóa cả mục 1 lô 1 lốc
                _context.SaveChanges();// Xong mới đi xóa hóa đơn 
                var hd = _context.HoaDons.Find(id);
                _context.HoaDons.Remove(hd);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateHD(int id, int trangthai)
        {
            try
            {
                var hd = _context.HoaDons.Find(id);
                hd.TrangThai = trangthai;
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
