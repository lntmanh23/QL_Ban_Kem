﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(TaiKhoan))]
        public int? IdTaiKhoan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? GiaDuocGiam { get; set; }
        public int? TrangThai { get; set; }
        public string? Thue { get; set; }
        [ForeignKey(nameof(GiamGia))]
        public int? giamGiaId { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual GiamGia giamGia { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }

    }
}
