using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonSevices
    {
        HoaDonRepos hoaDonRepos = new HoaDonRepos();
        HoaDonChiTietRepos HoaDonChiTietRepos = new HoaDonChiTietRepos();
        TaiKhoanRepos taiKhoanRepos = new TaiKhoanRepos();
        AppDbContext _context;

        public HoaDonSevices()
        {
            taiKhoanRepos = new TaiKhoanRepos();
            hoaDonRepos = new HoaDonRepos();
            HoaDonChiTietRepos = new HoaDonChiTietRepos();
            _context = new AppDbContext();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            //var hd = (from hoaDon in _context.HoaDons
            //          join HDCT in _context.HoaDonChiTiets on hoaDon.Id equals HDCT.IdHoaDon
            //          join taiKhoan in _context.TaiKhoans on hoaDon.IdTaiKhoan equals taiKhoan.Id

            //          select new 
            //          {
            //              Id = hoaDon.Id,
            //              TenTaiKhoan = taiKhoan.TenTaiKhoan,
            //              NgayTao = hoaDon.NgayTao,
            //              GiaDuocGiam = hoaDon.GiaDuocGiam,
            //              TrangThai = hoaDon.TrangThai,
            //              Thue = hoaDon.Thue,
            //              ThanhTien = HDCT.ThanhTien,
            //              GhiChu = HDCT.GhiChu,

            //          }).ToList();
           
            return hoaDonRepos.GetAllHoaDon();
            //return hoaDonRepos.GetAllHoaDon();
        }
        public string CreateHD(HoaDon hoaDon)
        {
            if (hoaDonRepos.CreateHD(hoaDon))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string DeleteHD(int id)
        {
            if (hoaDonRepos.DeleteHD(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
        public string UpdateHD(HoaDon hoaDon,int id)
        {
            if (hoaDonRepos.UpdateHD(hoaDon,id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        
    }
}
