using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class SanPhamGiamGiaVm
    {
        public int Id { get; set; }
        public int? IdLoaiSp { get; set; }
        public string TenSanPham { get; set; }
        public int GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public string AnhSanPham { get; set; }
        public long GiaGiam { get; set; }
        
        

    }
}
