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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI.View
{
    public partial class Frm_SanPham : Form
    {
        SanPhamServices SanPhamServices;
        LoaiSanPhamServices loaiSanPhamServices;
        GiamGiaServices giamGiaServices;
        List<GiamGia> activeGiamGias;
        int id = -1;
        public Frm_SanPham()
        {
            SanPhamServices = new SanPhamServices();
            loaiSanPhamServices = new LoaiSanPhamServices();
            giamGiaServices = new GiamGiaServices();
            InitializeComponent();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            var tensp = SanPhamServices.GetAllSanPham().Select(c => c.TenSanPham).ToList();
            if (ptb_SP.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh sản phẩm", "Thông báo");
            }
            else if (txt_TenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo");
            }
            else if (tensp.Contains(txt_TenSP.Text))
            {
                MessageBox.Show("Sản phẩm này đã tồn tại !!!", "Thông báo");
            }
            else if (txt_DonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo");
            }
            else if (!int.TryParse(txt_DonGia.Text, out int donGia) || donGia <= 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ. Giá sản phẩm phải là một số nguyên lớn hơn 0.", "Thông báo");
            }
            else if (txt_SoLuongSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo");
            }
            else if (!int.TryParse(txt_SoLuongSP.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ. Số lượng sản phẩm phải là một số nguyên lớn hơn 0.", "Thông báo");
            }
            else if (cbb_LoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại sản phẩm", "Thông báo");
            }
            else if (cbb_TrangThaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái sản phẩm", "Thông báo");
            }
            else
            {
                SanPham sp = new SanPham()
                {
                    TenSanPham = txt_TenSP.Text,
                    IdLoaiSp = loaiSanPhamServices.GetLoaiSanPham().Where(c => c.TenLoaiSanPham == cbb_LoaiSP.Text).Select(c => c.Id).FirstOrDefault(),
                    GiaSanPham = Convert.ToInt32(txt_DonGia.Text),
                    SoLuong = Convert.ToInt32(txt_SoLuongSP.Text),
                    TrangThai = cbb_TrangThaiSP.SelectedIndex,
                    AnhSanPham = ptb_SP.ImageLocation,
                    giamGiaId = cbbKm.SelectedIndex != -1 ? (int?)activeGiamGias[cbbKm.SelectedIndex].Id : 1
                };
                
                MessageBox.Show(SanPhamServices.CreateSanPham(sp),"Thông báo");
                LoadSanPham();
                Clear();
            }

        }
        public void LoadSanPham()
        {
            dtg_QuanLySP.Rows.Clear();
            var sp = SanPhamServices.GetAllSanPham();
            dtg_QuanLySP.ColumnCount = 8;
            dtg_QuanLySP.Columns[0].HeaderText = "Mã sản phẩm";
            dtg_QuanLySP.Columns[1].HeaderText = "Tên sản phẩm";
            dtg_QuanLySP.Columns[2].HeaderText = "Loại sản phẩm";
            dtg_QuanLySP.Columns[3].HeaderText = "Giá sản phẩm";
            dtg_QuanLySP.Columns[4].HeaderText = "Số lượng";
            dtg_QuanLySP.Columns[5].HeaderText = "Khuyến mại";
            dtg_QuanLySP.Columns[6].HeaderText = "Trạng thái";
            dtg_QuanLySP.Columns[7].HeaderText = "Ảnh sản phẩm";
            foreach (var data in sp)
            {
                string km = giamGiaServices.GetActiveGiamGia().Where(c => c.Id == data.giamGiaId).Select(c => c.TenGiamGia).FirstOrDefault();
                string trangthai = data.TrangThai == 0 ? "Đang kinh doanh" : "Ngừng kinh doanh";
                string tenloaisp = loaiSanPhamServices.GetLoaiSanPham().Where(x => x.Id == data.IdLoaiSp).Select(x => x.TenLoaiSanPham).FirstOrDefault();
                dtg_QuanLySP.Rows.Add(data.Id, data.TenSanPham, tenloaisp, data.GiaSanPham, data.SoLuong, km, trangthai, data.AnhSanPham);
            }
        }
        public void LoadCbbLoaiSP()
        {
            cbb_LoaiSP.Items.Clear();
            foreach (var item in loaiSanPhamServices.GetLoaiSanPhamkd())
            {
                cbb_LoaiSP.Items.Add(item.TenLoaiSanPham);
            }
            cbb_LoaiSP.SelectedIndex = -1;

        }
        public void Clear()
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_DonGia.Text = "";
            txt_SoLuongSP.Text = "";
            cbb_LoaiSP.Text = "";
            cbb_TrangThaiSP.Text = "";
            cbbKm.Text = "";
        }
        public void LoadFont()
        {
            Font newfont = new Font("Segoe UI", 9);
            dtg_QuanLySP.Font = newfont;
            dtgLoaiSP.Font = newfont;
        }
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadCbbLoaiSP();
            LoadSanPham();
            LoadLoaiSP();
            LoadFont();
            LoadcbbKm();
        }
        public void LoadcbbKm()
        {
            cbbKm.Items.Clear();
            activeGiamGias = giamGiaServices.GetActiveGiamGia();
            foreach (var item in activeGiamGias)
            {
                cbbKm.Items.Add(item.TenGiamGia);
            }
            cbbKm.SelectedIndex = -1;
        }
        public void LoadLoaiSP()
        {
            dtgLoaiSP.Rows.Clear();
            var loaisp = loaiSanPhamServices.GetLoaiSanPham();
            dtgLoaiSP.ColumnCount = 3;
            dtgLoaiSP.Columns[0].HeaderText = "Mã sản phẩm";
            dtgLoaiSP.Columns[1].HeaderText = "Tên loại sản phẩm";
            dtgLoaiSP.Columns[2].HeaderText = "Trạng thái";
            foreach (var item in loaisp)
            {
                string trangthai = item.TrangThai == 0 ? "Đang kinh doanh" : "Ngừng kinh doanh";
                dtgLoaiSP.Rows.Add(item.Id, item.TenLoaiSanPham, trangthai);
            }
        }
        public void ClearLoaiSP()
        {
            cbbTrangThaiLoaiSp.Text = "";
            txtTenLoaiSP.Text = "";
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            var tenloai = loaiSanPhamServices.GetLoaiSanPham().Select(c => c.TenLoaiSanPham).ToList();
            if (txtTenLoaiSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Thông báo");
            }
            else if (tenloai.Contains(txtTenLoaiSP.Text))
            {
                MessageBox.Show("Loại sản phẩm này đã tồn tại !!!", "Thông báo");
            }
            else if (cbbTrangThaiLoaiSp.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái loại sản phẩm", "Thông báo");
            }
            else
            {
                string TenSP = txtTenLoaiSP.Text;
                int trangThai = cbbTrangThaiLoaiSp.SelectedIndex;
                LoaiSanPham lsp = new LoaiSanPham() { TenLoaiSanPham = TenSP, TrangThai = trangThai };
                MessageBox.Show(loaiSanPhamServices.CreateLoaiSP(lsp), "Thông báo");
                LoadLoaiSP();
                LoadCbbLoaiSP();
                ClearLoaiSP();
            }

        }
        private void ptb_SP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            ptb_SP.ImageLocation = open.FileName;
            ptb_SP.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void dtg_QuanLySP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_QuanLySP.Rows[e.RowIndex];
            txt_MaSP.Text = row.Cells[0].Value.ToString();
            txt_TenSP.Text = row.Cells[1].Value.ToString();
            cbb_LoaiSP.Text = row.Cells[2].Value.ToString();
            txt_DonGia.Text = row.Cells[3].Value.ToString();
            txt_SoLuongSP.Text = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value == null)
            {
                cbbKm.Text = "";
            }
            else
            {
                cbbKm.Text = row.Cells[5].Value.ToString();
            }

            cbb_TrangThaiSP.Text = row.Cells[6].Value.ToString();
            ptb_SP.ImageLocation = row.Cells[7].Value.ToString();
        }

        private void dtgLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgLoaiSP.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtTenLoaiSP.Text = row.Cells[1].Value.ToString();
            cbbTrangThaiLoaiSp.Text = row.Cells[2].Value.ToString();
        }
        private void btnCapNhatLoaiSP_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiSP.Text == "")
            {
                MessageBox.Show("Hãy chọn loại sản phẩm cần sửa", "Thông báo");
            }   
            else
            {
                string tenloai = txtTenLoaiSP.Text;
                int trangthailoai = cbbTrangThaiLoaiSp.SelectedIndex;
                LoaiSanPham lsp = new LoaiSanPham()
                {
                    TenLoaiSanPham = tenloai,
                    TrangThai = trangthailoai,
                };
                MessageBox.Show(loaiSanPhamServices.UpdateLoaiSP(lsp, id),"Thông báo");
                LoadLoaiSP();
                LoadCbbLoaiSP();
                ClearLoaiSP();
            }
        }
        private void btn_CapNhatSanPham_Click(object sender, EventArgs e)
        {
            if (txt_MaSP.Text == "")
            {
                MessageBox.Show("Hãy chọn sản phẩm cần sửa", "Thông báo");
            }
            var tensp = SanPhamServices.GetAllSanPham().Select(c => c.TenSanPham).ToList();
            if (ptb_SP.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh sản phẩm", "Thông báo");
            }
            else if (txt_TenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo");
            }
            else if (txt_DonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo");
            }
            else if (!int.TryParse(txt_DonGia.Text, out int donGia) || donGia <= 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ. Giá sản phẩm phải là một số nguyên lớn hơn 0.", "Thông báo");
            }
            else if (txt_SoLuongSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo");
            }
            else if (!int.TryParse(txt_SoLuongSP.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ. Số lượng sản phẩm phải là một số nguyên lớn hơn 0.", "Thông báo");
            }
            
            else if (cbb_TrangThaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái sản phẩm", "Thông báo");
            }
            
            else
            {
                string ten = txt_TenSP.Text;
                int loaisp = cbb_LoaiSP.SelectedIndex;
                int idlsp = loaiSanPhamServices.GetLoaiSanPham().Where(c => c.TenLoaiSanPham == cbb_LoaiSP.Text).Select(c => c.Id).FirstOrDefault();
                int trangthai = cbb_TrangThaiSP.SelectedIndex;
                int dongia = Convert.ToInt32(txt_DonGia.Text);
                int soluong = Convert.ToInt32(txt_SoLuongSP.Text);
                string image = ptb_SP.ImageLocation;
                SanPham sp = new SanPham()
                {
                    TenSanPham = ten,
                    TrangThai = trangthai,
                    IdLoaiSp = idlsp,
                    GiaSanPham = dongia,
                    SoLuong = soluong,
                    AnhSanPham = image,
                    giamGiaId = cbbKm.SelectedIndex != -1 ? (int?)activeGiamGias[cbbKm.SelectedIndex].Id : 1
                };
                MessageBox.Show(SanPhamServices.UpdateSanPham(sp, Convert.ToInt32(txt_MaSP.Text)), "Thông báo");
                LoadSanPham();
                Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Clear();
            ClearLoaiSP();
        }

        private void txt_TenSPTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txt_TenSPTimKiem.Text == "")
            {
                LoadSanPham() ;
            }
        }
        public void LoadSanPham(string tensp)
        {
            dtg_QuanLySP.Rows.Clear();
            var sp = SanPhamServices.GetAllSanPham().Where(c => c.TenSanPham.StartsWith(tensp)).ToList();
            if (sp.Any())
            {
                dtg_QuanLySP.ColumnCount = 8;
                dtg_QuanLySP.Columns[0].HeaderText = "Mã sản phẩm";
                dtg_QuanLySP.Columns[1].HeaderText = "Tên sản phẩm";
                dtg_QuanLySP.Columns[2].HeaderText = "Loại sản phẩm";
                dtg_QuanLySP.Columns[3].HeaderText = "Giá sản phẩm";
                dtg_QuanLySP.Columns[4].HeaderText = "Số lượng";
                dtg_QuanLySP.Columns[5].HeaderText = "Khuyến mại";
                dtg_QuanLySP.Columns[6].HeaderText = "Trạng thái";
                dtg_QuanLySP.Columns[7].HeaderText = "Ảnh sản phẩm";
                foreach (var data in sp)
                {
                    string km = giamGiaServices.GetActiveGiamGia().Where(c => c.Id == data.giamGiaId).Select(c => c.TenGiamGia).FirstOrDefault();
                    string trangthai = data.TrangThai == 0 ? "Đang kinh doanh" : "Ngừng kinh doanh";
                    string tenloaisp = loaiSanPhamServices.GetLoaiSanPham().Where(x => x.Id == data.IdLoaiSp).Select(x => x.TenLoaiSanPham).FirstOrDefault();
                    dtg_QuanLySP.Rows.Add(data.Id, data.TenSanPham, tenloaisp, data.GiaSanPham, data.SoLuong, km, trangthai, data.AnhSanPham);
                }
            }

        }

        private void btn_TimSanPham_Click(object sender, EventArgs e)
        {
            LoadSanPham(txt_TenSPTimKiem.Text);
        }
    }
}
