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
                string tt = km.TrangThai == 0 ? "Đang diễn ra" : "Kết thúc";
                dtgKhuyenMai.Rows.Add(km.Id, km.TenGiamGia, km.LoaiGiamGia, km.NgayBatDau, km.NgayKetThuc, km.GiaTri, tt);
            }
        }
        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMai();
        }
        private void btn_ThemKM_Click(object sender, EventArgs e)
        {
            var tenkmcheck = giamGiaServices.GetAllGiamGia().Select(c => c.TenGiamGia).ToList();
            if (txt_TenKM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khuyến mại", "Thông báo");
            }
            else if (tenkmcheck.Contains(txt_TenKM.Text))
            {
                MessageBox.Show("Khuyến mại này đã tồn tại !!!", "Thông báo");
            }
            else if (cbb_LoaiKM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại khuyến mại", "Thông báo");
            }
            else if (cbb_TrangThaiKM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái khuyến mại", "Thông báo");
            }
            else if (dateNgayKetThucKm.Value < DateTime.Now || dateNgayBatDauKM.Value > dateNgayKetThucKm.Value)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ngày chạy chương trình khuyến mại", "Thông báo");
            }
            else
            {
                string tenkm = txt_TenKM.Text;
                string loaikm = cbb_LoaiKM.Text;
                int giatri = Convert.ToInt32(txt_giatri.Text);
                DateTime batdau = dateNgayBatDauKM.Value;
                DateTime ketthuc = dateNgayKetThucKm.Value;
                int trangthai = cbb_TrangThaiKM.SelectedIndex;
                GiamGia giamGia = new GiamGia() { TenGiamGia = tenkm, LoaiGiamGia = loaikm, GiaTri = Convert.ToString(giatri), NgayBatDau = batdau, NgayKetThuc = ketthuc, TrangThai = trangthai };
                MessageBox.Show(giamGiaServices.CreateGiamGia(giamGia), "Thông báo");
                LoadKhuyenMai();
                Clear();
            }
        }
        public void Clear()
        {
            txt_MaKM.Text = "";
            txt_giatri.Text = "";
            txt_TenKM.Text = "";
            cbb_LoaiKM.SelectedIndex = -1;
            cbb_TrangThaiKM.SelectedIndex = -1;
        }
        private void dtgKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgKhuyenMai.Rows[e.RowIndex];
            txt_MaKM.Text = row.Cells[0].Value.ToString();
            txt_TenKM.Text = row.Cells[1].Value.ToString();
            cbb_LoaiKM.Text = row.Cells[2].Value.ToString();
            if (row.Cells[5].Value == null)
            {
                txt_giatri.Text = "0";
            }
            else
            {
                txt_giatri.Text = row.Cells[5].Value.ToString();
            }
            dateNgayBatDauKM.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            dateNgayKetThucKm.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            cbb_TrangThaiKM.Text = row.Cells[6].Value.ToString();
        }

        private void btn_CapNhatKm_Click(object sender, EventArgs e)
        {
            if (txt_MaKM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chương trình cần cập nhật", "Thông báo");
            }
            var tenkmcheck = giamGiaServices.GetAllGiamGia().Select(c => c.TenGiamGia).ToList();
            if (txt_TenKM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khuyến mại", "Thông báo");
            }
            
            else if (cbb_LoaiKM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại khuyến mại", "Thông báo");
            }
            else if (cbb_TrangThaiKM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái khuyến mại", "Thông báo");
            }
            
            else
            {
                string tenkm = txt_TenKM.Text;
                string loaikm = cbb_LoaiKM.Text;
                int giatri = Convert.ToInt32(txt_giatri.Text);
                DateTime batdau = dateNgayBatDauKM.Value;
                DateTime ketthuc = dateNgayKetThucKm.Value;
                int trangthai = cbb_TrangThaiKM.SelectedIndex;
                GiamGia giamGia = new GiamGia() { TenGiamGia = tenkm, LoaiGiamGia = loaikm, GiaTri = Convert.ToString(giatri), NgayBatDau = batdau, NgayKetThuc = ketthuc, TrangThai = trangthai };
                MessageBox.Show(giamGiaServices.UpdateKm(giamGia, Convert.ToInt32(txt_MaKM.Text)), "Thông báo");
                LoadKhuyenMai();
                Clear();
            }
        }

        private void txt_TenKMTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadKhuyenMai() ;
        }
        public void LoadKhuyenMai(string tenkm)
        {
            dtgKhuyenMai.Rows.Clear();
            var khuyenmai = giamGiaServices.GetAllGiamGia().Where(c=>c.TenGiamGia.StartsWith(tenkm)).ToList();
            if(khuyenmai.Any())
            {
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
                    string tt = km.TrangThai == 0 ? "Đang diễn ra" : "Kết thúc";
                    dtgKhuyenMai.Rows.Add(km.Id, km.TenGiamGia, km.LoaiGiamGia, km.NgayBatDau, km.NgayKetThuc, km.GiaTri, tt);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy","Thông báo");
            }
            
        }
        private void btn_TimKM_Click(object sender, EventArgs e)
        {
            LoadKhuyenMai(txt_TenKMTimKiem.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
