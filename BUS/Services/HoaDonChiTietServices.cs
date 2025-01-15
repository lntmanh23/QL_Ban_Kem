using BUS.ViewModels;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BUS.Services
{
    public class HoaDonChiTietServices
    {
        HoaDonChiTietRepos hoaDonChiTietRepos = new HoaDonChiTietRepos();
        SanPhamServices sanPhamServices;
        HoaDonRepos hoaDonRepos = new HoaDonRepos();
        SanPhamRepos sanPhamRepos = new SanPhamRepos();
        LoaiSanPhamRepos loaiSanPhamRepos = new LoaiSanPhamRepos();
        TaiKhoanRepos taiKhoanRepos = new TaiKhoanRepos();
        AppDbContext _context;
       
        public HoaDonChiTietServices()
        {
            sanPhamServices = new SanPhamServices();
            sanPhamRepos = new SanPhamRepos();
            taiKhoanRepos = new TaiKhoanRepos();
            hoaDonRepos = new HoaDonRepos();
            hoaDonChiTietRepos = new HoaDonChiTietRepos();
            loaiSanPhamRepos = new LoaiSanPhamRepos();
            _context = new AppDbContext();
        }
        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return hoaDonChiTietRepos.GetAllHDCT();
        }
        public List<HoaDonChiTiet> GetAllHDByTrangThai()
        {
            return hoaDonChiTietRepos.GetAllHDCT().Where(c=>c.TrangThai != 1).ToList();
        }
        public List<HoaDonChiTiet> GetAllByHD(int IdHd)
        {
            return hoaDonChiTietRepos.GetAllByHD(IdHd);
        }
        public string Create(int soluong, int maSP, int MaHD)
        {
            if (hoaDonChiTietRepos.CreateHDCT(soluong, maSP, MaHD))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string UpdateCongDon(int idsp, int idhd,int soluong)
        {
            var allhdct = hoaDonChiTietRepos.GetAllByHD(idhd);
            var hdct =  allhdct.FirstOrDefault(p=>p.IdSanPham == idsp);
            if(hdct != null)
            {
                HoaDonChiTietRepos repo = new HoaDonChiTietRepos();
                repo.UpdateSL(soluong, hdct.Id);
                return "Thành công";
            }
            else
            {
                if (hoaDonChiTietRepos.CreateHDCT(soluong, idsp, idhd))
                {
                    return "Sửa thành công";
                }
                else
                {
                    return "Sửa thất bại";
                }
            }
        }
        public long TongTien(int idHD)
        {
            List<HoaDonChiTiet> hdct = hoaDonChiTietRepos.GetAllByHD(idHD);
            long sum = 0;
            foreach(var item in hdct)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                long giagiam = sanPhamServices.GetSanPhamGiamGia().Where(c => c.Id == item.IdSanPham).Select(c => c.GiaGiam).FirstOrDefault();
                sum += giagiam;
            }
            return sum; 
        }
        public List<HoaDonVm> GetHD_HDCT(int IdHD)
        {
            var hdct = hoaDonChiTietRepos.GetAllByHD(IdHD);
            var sp = sanPhamRepos.GetAllSanPham();
            var hd = hoaDonRepos.GetAllHoaDon();
            var hdVm = from a in hdct
                       join b in sp on a.IdSanPham equals b.Id
                       join c in hd on a.IdHoaDon equals c.Id
                       
                       select new HoaDonVm
                       {
                           Id = a.Id,
                           IdSp = b.Id,
                           IdHd = a.IdHoaDon,
                           TenSp = b.TenSanPham,
                           Gia = b.GiaSanPham,
                           
                           SoLuongMua = a.SoLuongMua,
                           ThanhTien = a.ThanhTien,
                           MoTa = ""
                       };
            return hdVm.ToList();
        }
    }
}
