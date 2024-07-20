using BUS.Services;
using DAL.Models;
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
    public partial class Frm_KhuyenMai : Form
    {
        GiamGiaServices giamGiaServices;
        public Frm_KhuyenMai()
        {
            giamGiaServices = new GiamGiaServices();
            InitializeComponent();
        }
        public void LoadKhuyenMai()
        {
            dtgKhuyenMai.Rows.Clear();
            var khuyenmai = giamGiaServices.GetAllGiamGia();
            dtgKhuyenMai.ColumnCount = 7;
            dtgKhuyenMai.Columns[0].HeaderText = "Mã giảm giá";
            dtgKhuyenMai.Columns[1].HeaderText = "Tên giảm giá";
            dtgKhuyenMai.Columns[2].HeaderText = "Loại giảm giá";
            dtgKhuyenMai.Columns[3].HeaderText = "Ngày bắt đầu";
            dtgKhuyenMai.Columns[4].HeaderText = "Ngày kết thúc";
            dtgKhuyenMai.Columns[5].HeaderText = "Giá trị";
            dtgKhuyenMai.Columns[6].HeaderText = "Trạng thái";
            foreach (var km in khuyenmai)
            {
                dtgKhuyenMai.Rows.Add(km.Id, km.TenGiamGia, km.LoaiGiamGia, km.NgayBatDau, km.NgayKetThuc, km.GiaTri, km.TrangThai);
            }
        }

        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMai();
        }

        private void btn_ThemKM_Click(object sender, EventArgs e)
        {
            string tenkm = txt_TenKM.Text;
            string loaikm = cbb_LoaiKM.Text;
            DateTime batdau = dateNgayBatDauKM.Value;
            DateTime ketthuc = dateNgayKetThucKm.Value;
            string giatri = txt_GiaTriKM.Text;
            int trangthai = Convert.ToInt32(cbb_TrangThaiKM.Text);
            GiamGia giamGia = new GiamGia() { TenGiamGia = tenkm,LoaiGiamGia = loaikm,NgayBatDau = batdau,NgayKetThuc = ketthuc,GiaTri = giatri,TrangThai = trangthai};
            giamGiaServices.CreateGiamGia(giamGia);
            LoadKhuyenMai();
        }
    }
}
