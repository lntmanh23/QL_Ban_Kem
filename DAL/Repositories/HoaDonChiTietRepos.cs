using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonChiTietRepos
    {
        AppDbContext _context = new AppDbContext();
        

        public HoaDonChiTietRepos()
        {
            _context = new AppDbContext();
        }
        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return _context.HoaDonChiTiets.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public List<HoaDonChiTiet> GetAllByHD(int IdHD)
        {
            return _context.HoaDonChiTiets.Where(p=>p.IdHoaDon == IdHD).ToList();
        }
        
        
        public HoaDonChiTiet GetById(int id)
        {
            return _context.HoaDonChiTiets.Find(id);
        }

        public bool CreateHDCT(int soluong, int maSP, int MaHD)
        {
            SanPham sp = _context.sanPhams.Find(maSP);
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
            {
                IdHoaDon = MaHD,
                IdSanPham = maSP,
                Gia = Convert.ToString(sp.GiaSanPham),
                SoLuongMua = soluong,
                ThanhTien = Convert.ToString(soluong * sp.GiaSanPham),
                NgayLapHoaDon = DateTime.Now,
                GhiChu = "",
                TrangThai = 1
            };
            try
            {
                _context.HoaDonChiTiets.Add(hoaDonChiTiet);               
                sp.SoLuong = sp.SoLuong - soluong;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSL(int soLuong, int idHDCT)   
        {
            try
            {
                var hdct = _context.HoaDonChiTiets.Find(idHDCT);
                hdct.SoLuongMua = soLuong + hdct.SoLuongMua;
                var sp = _context.sanPhams.Find(hdct.IdSanPham);
                sp.SoLuong = sp.SoLuong - soLuong;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false ;
            }
        }
        public bool DeleteHDCT(int idHDCT)
        {
            try
            {
                var hdct = _context.HoaDonChiTiets.Find(idHDCT);
                _context.HoaDonChiTiets.Remove(hdct);
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
