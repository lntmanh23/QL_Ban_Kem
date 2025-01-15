using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LoaiSanPhamServices
    {
        LoaiSanPhamRepos LoaiSanPhamRepos = new LoaiSanPhamRepos();
        public LoaiSanPhamServices() 
        {
            LoaiSanPhamRepos = new LoaiSanPhamRepos();
        }
        public List<LoaiSanPham> GetLoaiSanPham()
        {
            return LoaiSanPhamRepos.GetAllLoaiSanPham();
        }
        public List<LoaiSanPham> GetLoaiSanPhamkd()
        {
            return LoaiSanPhamRepos.GetAllLoaiSanPham().Where(c=>c.TrangThai == 0).ToList();
        }
        public string CreateLoaiSP(LoaiSanPham lsp)
        {
            if (LoaiSanPhamRepos.CreateLoaiSP(lsp))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string UpdateLoaiSP(LoaiSanPham lsp,int id)
        {
            if (LoaiSanPhamRepos.UpdateLoaiSP(lsp,id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
