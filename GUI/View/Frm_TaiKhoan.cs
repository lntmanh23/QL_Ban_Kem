using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                string trangthai = tk.TrangThai == 0 ? "Đang làm" : "Nghỉ làm";
                dtg_QuanLyNhanVien.Rows.Add(tk.Id, tk.TenTaiKhoan, tk.MatKhau, quyen, tk.SDT, gioiTinhHienThi, trangthai);
            }
            dtg_QuanLyNhanVien.Columns[6].HeaderText = "Trạng thái";
        }
        public void LoadTaiKhoan(string taikhoan)
        {
            dtg_QuanLyNhanVien.Rows.Clear();
            var nhanvien = taiKhoanServices.GetAllTaiKhoan().Where(item => item.TenTaiKhoan.StartsWith(taikhoan)).ToList();
            if (nhanvien.Any())
            {
                dtg_QuanLyNhanVien.ColumnCount = 7;
                dtg_QuanLyNhanVien.Columns[0].HeaderText = "Mã tài khoản";
                dtg_QuanLyNhanVien.Columns[1].HeaderText = "Tên tài khoản";
                dtg_QuanLyNhanVien.Columns[2].HeaderText = "Mật khẩu";
                dtg_QuanLyNhanVien.Columns[3].HeaderText = "Quyền";
                dtg_QuanLyNhanVien.Columns[4].HeaderText = "SĐT";
                dtg_QuanLyNhanVien.Columns[5].HeaderText = "Giới tính";
                dtg_QuanLyNhanVien.Columns[6].HeaderText = "Trạng thái";
                foreach(var item in nhanvien)
                {
                    string gioiTinhHienThi = item.GioiTinh == 0 ? "Nam" : "Nữ";
                    string quyen = item.Quyen == 0 ? "Quản lý" : "Nhân viên";
                    string trangthai = item.TrangThai == 0 ? "Đang làm" : "Nghỉ làm";
                    dtg_QuanLyNhanVien.Rows.Add(item.Id, item.TenTaiKhoan, item.MatKhau, quyen, item.SDT, gioiTinhHienThi, trangthai);

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo");
            }

        }
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            var ten = taiKhoanServices.GetAllTaiKhoan().Select(c => c.TenTaiKhoan).ToList();
            string phonePattern = @"^0\d{9}$";
            string passwordPattern = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{6,8}$";
            string accountPattern = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{6,10}$";
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo");
            }
            else if (!Regex.IsMatch(txt_TaiKhoan.Text, accountPattern))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ. Tên tài khoản phải có từ 6 đến 10 ký tự, bao gồm cả chữ và số.", "Thông báo");
            }
            else if (ten.Contains(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản này đã tồn tại !!!", "Thông báo");
            }
            else if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
            }
            else if (!Regex.IsMatch(txt_MatKhau.Text, passwordPattern))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Mật khẩu phải có từ 6 đến 8 ký tự, bao gồm cả chữ và số.", "Thông báo");
            }
            else if (cbbQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn quyền", "Thông báo");
            }
            else if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo");
            }
            else if (!Regex.IsMatch(txt_SDT.Text, phonePattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có 10 ký tự và bắt đầu bằng số 0.", "Thông báo");
            }
            else if (rd_Nam.Checked == false && rd_Nu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo");
            }
            else if (cbbTrangThaiTaiKhoan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo");
            }
            else
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
                MessageBox.Show(taiKhoanServices.CreateTaiKhoan(tk), "Thông báo");
                LoadTaiKhoan();
                ClearForm();
            }
        }
        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
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
            if (e.RowIndex < 0)
            {
                return;
            }
            selectedId = Convert.ToInt32(row.Cells[0].Value.ToString());
            txt_TaiKhoan.Text = row.Cells[1].Value.ToString();
            txt_MatKhau.Text = row.Cells[2].Value.ToString();
            txt_SDT.Text = row.Cells[4].Value.ToString();
            cbbQuyen.Text = row.Cells[3].Value.ToString();
            cbbTrangThaiTaiKhoan.Text = row.Cells[6].Value.ToString();
        }
        private void btn_CapNhatNhanVien_Click(object sender, EventArgs e)
        {
            
            var ten = taiKhoanServices.GetAllTaiKhoan().Select(c => c.TenTaiKhoan).ToList();
            string phonePattern = @"^0\d{9}$";
            string passwordPattern = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{6,8}$";
            if (selectedId == -1)
            {
                MessageBox.Show("Hãy chọn tài khoản muốn sửa", "Thông báo");
            }
            else if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
            }
            else if (!Regex.IsMatch(txt_MatKhau.Text, passwordPattern))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Mật khẩu phải có từ 6 đến 8 ký tự, bao gồm cả chữ và số.", "Thông báo");
            }
            else if (cbbQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn quyền", "Thông báo");
            }
            else if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo");
            }
            else if (!Regex.IsMatch(txt_SDT.Text, phonePattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải có 10 ký tự và bắt đầu bằng số 0.", "Thông báo");
            }
            else if (rd_Nam.Checked == false && rd_Nu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo");
            }
            else if (cbbTrangThaiTaiKhoan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo");
            }
            else
            {
                string matkhau = txt_MatKhau.Text;
                string SDT = txt_SDT.Text;
                int Quyen = cbbQuyen.SelectedIndex;
                int trangthai = cbbTrangThaiTaiKhoan.SelectedIndex;
                int nam = Convert.ToInt32(rd_Nam.Checked);
                int nu = Convert.ToInt32(rd_Nu.Checked);
                int gioiTinh = rd_Nam.Checked ? 0 : (rd_Nu.Checked ? 1 : -1); // Hoặc chọn giá trị mặc định hợp lý nếu không chọn giới tính
                TaiKhoan tk = new TaiKhoan()
                {
                    MatKhau = matkhau,
                    SDT = SDT,
                    Quyen = Quyen,
                    TrangThai = trangthai,
                    GioiTinh = gioiTinh,
                };
                MessageBox.Show(taiKhoanServices.UpdateTaiKhoan(tk, selectedId), "Thông báo");
                LoadTaiKhoan();
                ClearForm();
                selectedId = -1;
            }

        }

        private void btn_TimNhanVien_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan(txtSearchTaiKhoan.Text);
        }

        private void cbbTrangThaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchTaiKhoan.Text == "")
            {
                LoadTaiKhoan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
