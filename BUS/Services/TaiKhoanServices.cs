using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanServices
    {
        TaiKhoanRepos taiKhoanRepos = new TaiKhoanRepos();
        private List<TaiKhoan> _list;
        public TaiKhoanServices()
        {
            _list = new List<TaiKhoan>();
            taiKhoanRepos = new TaiKhoanRepos();
        }
        
        public string Login(string tenTaiKhoan, string matKhau)
        {
            return taiKhoanRepos.CheckLogin(tenTaiKhoan, matKhau);
        }
        public List<TaiKhoan> SearchTaiKhoan(string tenTaiKhoan)
        {
            return _list.Where(p=>p.TenTaiKhoan.StartsWith(tenTaiKhoan)).ToList();
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return taiKhoanRepos.GetAllTaiKhoan();
        }
        public string CreateTaiKhoan(TaiKhoan tk)
        {
            if (taiKhoanRepos.CreateTaiKhoan(tk))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string UpdateTaiKhoan(TaiKhoan tk,int id)
        {
            if (taiKhoanRepos.UpdateTaiKhoan(id,tk))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
