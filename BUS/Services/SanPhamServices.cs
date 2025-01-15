using BUS.ViewModels;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamServices
    {
        SanPhamRepos sanPhamRepos = new SanPhamRepos();
        GiamGiaServices giamGiaServices = new GiamGiaServices();
        
        public SanPhamServices()
        {
            sanPhamRepos = new SanPhamRepos();
        }
        public List<SanPhamGiamGiaVm> GetSanPhamGiamGia()
        {
            var sanpham = sanPhamRepos.GetAllSanPham();
            var giamgia = giamGiaServices.GetAllGiamGia();
            
            var sanPhamGiamGia =
                from sp in sanpham
                join gg in giamgia on sp.giamGiaId equals gg.Id
                
                select new SanPhamGiamGiaVm
                {
                    Id = sp.Id,
                    IdLoaiSp = sp.IdLoaiSp,
                    TenSanPham = sp.TenSanPham,
                    GiaSanPham = sp.GiaSanPham,
                    SoLuong = sp.SoLuong,
                    TrangThai = sp.TrangThai,
                    AnhSanPham = sp.AnhSanPham,
                    GiaGiam = Convert.ToInt64(sp.GiaSanPham - sp.GiaSanPham * Convert.ToInt64(gg.GiaTri) / 100),
                  
                    
                };
            return sanPhamGiamGia.ToList();
        }
        
        public List<SanPham> GetAllSanPham()
        {
            return sanPhamRepos.GetAllSanPham();
        }
        public List<SanPham> GetSpByTrangThai()
        {
            return sanPhamRepos.GetAllSanPham().Where(c=>c.TrangThai == 0).ToList();
        }
        public string CreateSanPham(SanPham sp)
        {
            if (sanPhamRepos.CreateSP(sp))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string UpdateSanPham(SanPham sp,int id)
        {
            if (sanPhamRepos.UpdateSanPham(sp,id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }

    }
}
