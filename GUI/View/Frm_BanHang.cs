using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class Frm_BanHang : Form
    {
        HoaDonSevices hoaDonSevices;

        HoaDonChiTietServices hoaDonChiTietServices;

        public Frm_BanHang()
        {
            hoaDonChiTietServices = new HoaDonChiTietServices();

            hoaDonSevices = new HoaDonSevices();
            InitializeComponent();

        }
        public void LoadView()
        {


            dtg_TaoHoaDon.ColumnCount = 8;
            dtg_TaoHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_TaoHoaDon.Columns[1].HeaderText = "Mã sản phẩm";
            dtg_TaoHoaDon.Columns[2].HeaderText = "Tên sản phẩm";
            dtg_TaoHoaDon.Columns[3].HeaderText = "Số lượng";
            dtg_TaoHoaDon.Columns[4].HeaderText = "Giá";
            dtg_TaoHoaDon.Columns[5].HeaderText = "Thuế";
            dtg_TaoHoaDon.Columns[6].HeaderText = "Thành tiền";
            dtg_TaoHoaDon.Columns[7].HeaderText = "Mô tả";
            
            var hd = hoaDonChiTietServices.GetHD_HDCT();
            foreach (var data in hd)
            {
                dtg_TaoHoaDon.Rows.Add(data.IdHd, data.IdSp, data.TenSp, data.SoLuong, data.Gia, data.Thue,data.ThanhTien, data.MoTa);
            }

        }
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            LoadView();
        }
    }
}
