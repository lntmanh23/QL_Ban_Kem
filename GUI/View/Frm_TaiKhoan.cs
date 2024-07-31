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
    public partial class Frm_TaiKhoan : Form
    {
        TaiKhoanServices taiKhoanServices;
        int selectedId = -1;
        public Frm_TaiKhoan()
        {
            InitializeComponent();
            taiKhoanServices = new TaiKhoanServices();
        }
        public void LoadTaiKhoan()
        {
            dtg_QuanLyNhanVien.Rows.Clear();
            var nhanvien = taiKhoanServices.GetAllTaiKhoan();
            dtg_QuanLyNhanVien.ColumnCount = 7;
            dtg_QuanLyNhanVien.Columns[0].HeaderText = "Mã tài khoản";
            dtg_QuanLyNhanVien.Columns[1].HeaderText = "Tên tài khoản";
            dtg_QuanLyNhanVien.Columns[2].HeaderText = "Mật khẩu";
            dtg_QuanLyNhanVien.Columns[3].HeaderText = "Quyền";
            dtg_QuanLyNhanVien.Columns[4].HeaderText = "SĐT";
            dtg_QuanLyNhanVien.Columns[5].HeaderText = "Giới tính";
            foreach (var tk in nhanvien)
            {
                string gioiTinhHienThi = tk.GioiTinh == 0 ? "Nam" : "Nữ";
                string quyen = tk.Quyen == 0 ? "Quản lý" : "Nhân viên";
                string trangthai = tk.TrangThai == 0 ? "Đang làm" : "Đã nghỉ";
                dtg_QuanLyNhanVien.Rows.Add(tk.Id, tk.TenTaiKhoan, tk.MatKhau, quyen, tk.SDT, gioiTinhHienThi, trangthai);
            }
            dtg_QuanLyNhanVien.Columns[6].HeaderText = "Trạng thái";
        }
        public void LoadTaiKhoan(string taikhoan)
        {
            dtg_QuanLyNhanVien.Rows.Clear();
            var nhanvien = taiKhoanServices.GetAllTaiKhoan().FirstOrDefault(item => item.TenTaiKhoan == taikhoan);
            if (nhanvien != null)
            {
                dtg_QuanLyNhanVien.ColumnCount = 7;
                dtg_QuanLyNhanVien.Columns[0].HeaderText = "Mã tài khoản";
                dtg_QuanLyNhanVien.Columns[1].HeaderText = "Tên tài khoản";
                dtg_QuanLyNhanVien.Columns[2].HeaderText = "Mật khẩu";
                dtg_QuanLyNhanVien.Columns[3].HeaderText = "Quyền";
                dtg_QuanLyNhanVien.Columns[4].HeaderText = "SĐT";
                dtg_QuanLyNhanVien.Columns[5].HeaderText = "Giới tính";
                dtg_QuanLyNhanVien.Columns[6].HeaderText = "Trạng thái";
                string gioiTinhHienThi = nhanvien.GioiTinh == 0 ? "Nam" : "Nữ";
                string quyen = nhanvien.Quyen == 0 ? "Quản lý" : "Nhân viên";
                string trangthai = nhanvien.TrangThai == 0 ? "Đang làm" : "Đã nghỉ";               
                dtg_QuanLyNhanVien.Rows.Add(nhanvien.Id, nhanvien.TenTaiKhoan, nhanvien.MatKhau, quyen, nhanvien.SDT, gioiTinhHienThi, trangthai);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản","Thông báo");
            }
            
        }
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            string tentk = txt_TaiKhoan.Text;
            string matkhau = txt_MatKhau.Text;
            int quyen = cbbQuyen.SelectedIndex;
            string SDT = txt_SDT.Text;
            int gioitinh = -1;
            if (rd_Nam.Checked)
            {
                gioitinh = 0;

            }
            else if (rd_Nu.Checked)
            {
                gioitinh = 1;
            }
            int trangthai = cbbTrangThaiTaiKhoan.SelectedIndex;
            TaiKhoan tk = new TaiKhoan() { TenTaiKhoan = tentk, MatKhau = matkhau, Quyen = quyen, SDT = SDT, GioiTinh = gioitinh, TrangThai = trangthai };
            MessageBox.Show(taiKhoanServices.CreateTaiKhoan(tk));
            LoadTaiKhoan();
            ClearForm();
        }
        public void LoadTrangThai()
        {

        }
        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
            LoadTaiKhoan();
        }
        public void ClearForm()
        {
            txt_TaiKhoan.Text = "";
            txt_MatKhau.Text = "";
            txt_SDT.Text = "";
            cbbQuyen.Text = "";
            cbbTrangThaiTaiKhoan.Text = "";
        }

        private void dtg_QuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_QuanLyNhanVien.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
            txt_TaiKhoan.Text = row.Cells[1].Value.ToString();
            txt_MatKhau.Text = row.Cells[2].Value.ToString();
            txt_SDT.Text = row.Cells[4].Value.ToString();
            cbbQuyen.Text = row.Cells[3].Value.ToString();
            cbbTrangThaiTaiKhoan.Text = row.Cells[6].Value.ToString();

        }

        private void btn_CapNhatNhanVien_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn sửa", "Thông báo");
            }
            string matkhau = txt_MatKhau.Text;
            int SDT = Convert.ToInt32(txt_SDT.Text);
            int Quyen = Convert.ToInt32(cbbQuyen.Text);
            int trangthai = Convert.ToInt32(cbbTrangThaiTaiKhoan.Text);
            int nam = Convert.ToInt32(rd_Nam.Checked);
            int nu = Convert.ToInt32(rd_Nu.Checked);
            bool gioitinh = Convert.ToBoolean(nam) || Convert.ToBoolean(nu);
            TaiKhoan tk = new TaiKhoan()
            {
                MatKhau = matkhau,
                SDT = Convert.ToString(SDT),
                Quyen = Quyen,
                TrangThai = trangthai,
                GioiTinh = Convert.ToInt32(gioitinh),
            };
            MessageBox.Show(taiKhoanServices.UpdateTaiKhoan(tk, selectedId));
            LoadTaiKhoan();
            selectedId = -1;
            ClearForm();
        }

        private void btn_TimNhanVien_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan(txtSearchTaiKhoan.Text);
        }

        private void txtSearchTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
