using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TaiKhoanRepos
    {
        AppDbContext _context = new AppDbContext();

        public TaiKhoanRepos()
        {
            _context = new AppDbContext();
        }
        public string CheckLogin(string tenTaiKhoan,string matKhau)
        {
            try
            {
                var check = _context.TaiKhoans.FirstOrDefault(p => p.TenTaiKhoan == tenTaiKhoan && p.MatKhau == matKhau);
                if (check != null)
                {
                    return check.Id.ToString();
                }else return "0";
            }
            catch (Exception e)
            {

                return "1";
            }
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return _context.TaiKhoans.ToList(); // Lấy ra toàn bộ danh sách sản phẩm

        }
        public TaiKhoan GetById(int id)
        {
            return _context.TaiKhoans.Find(id);
        }
        public bool CreateTaiKhoan(TaiKhoan tk)
        {
            try
            {
                _context.TaiKhoans.Add(tk);
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
