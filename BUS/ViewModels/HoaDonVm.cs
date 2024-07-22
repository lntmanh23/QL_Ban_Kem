using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class HoaDonVm
    {
        public int IdHd { get; set; }
        public int IdSp { get; set; }
        public string TenSp { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        
        public int? Thue { get; set; }
        public string ThanhTien { get; set; }
        public string? MoTa { get; set; }
    }
}
