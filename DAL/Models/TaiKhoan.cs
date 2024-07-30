using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TaiKhoan
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(TaiKhoan))]
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int Quyen { get; set; }
        public string SDT { get; set; }
        public int GioiTinh { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDon>? HoaDons { get; set; }
    }
}
