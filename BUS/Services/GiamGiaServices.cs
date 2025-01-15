using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class GiamGiaServices
    {
        GiamGiaRepos giamGiaRepos = new GiamGiaRepos();

        public GiamGiaServices()
        {
            giamGiaRepos = new GiamGiaRepos();
        }
        public List<GiamGia> GetAllGiamGia()
        {
            return giamGiaRepos.GetAllGiamGia();
        }
        public List<GiamGia> GetActiveGiamGia()
        {
            return giamGiaRepos.GetActiveGiamGia();
        }
        public string CreateGiamGia(GiamGia gg)
        {
            if (giamGiaRepos.CreateGiamGia(gg))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string UpdateKm(GiamGia gg,int id)
        {
            if (giamGiaRepos.UpdateKm(gg,id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
