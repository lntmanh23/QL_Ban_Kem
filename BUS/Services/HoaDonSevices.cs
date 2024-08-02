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
        HoaDonRepos hoaDonRepos ;
        public HoaDonSevices()
        {        
            hoaDonRepos = new HoaDonRepos();
        }
        public List<HoaDon> GetAllHoaDon()
        {           
            return hoaDonRepos.GetAllHoaDon();        
        }
        public List<HoaDon> GetAllHdChuaThanhToan()
        {
            return hoaDonRepos.GetAllHoaDon().Where(p=>p.TrangThai == 1).ToList();
        }
        public string CreateHD(int idTk,int idGg)
        {
            
            HoaDon hd = new HoaDon()
            {
                IdTaiKhoan = idTk,
                NgayTao = DateTime.Now,
                GiaDuocGiam = "0",
                Thue = "0",
                TrangThai = 1,
                TongTienHD = "0",
                giamGiaId = idGg,
            };

            if (hoaDonRepos.CreateHD(hd))
            {
                return "Tạo thành công";
            }
            else return "Tạo thất bại";
        }

        public string DeleteHD(int id)
        {
            if (hoaDonRepos.DeleteHD(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
        public string UpdateHD(int id,int trangthai,long? tongTienHD)
        {
            if (hoaDonRepos.UpdateHD(id,trangthai,tongTienHD))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        
        
    }
}
