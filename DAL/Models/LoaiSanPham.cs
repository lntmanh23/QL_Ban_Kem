using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiSanPham { get; set; }
        public int TrangThai {  get; set; }
        [ForeignKey(nameof(SanPham))]
        public int? SanPhamId { get; set; }
        public List<SanPham>  SanPhams { get; set; }
    }
}
