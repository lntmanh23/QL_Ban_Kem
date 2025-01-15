using BUS.Services;
using DAL.Models;
using DAL.Repositories;
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

    public partial class Frm_HoaDon : Form
    {
        HoaDonSevices hoaDonSevices;
        HoaDonChiTietServices hoaDonChiTietServices;
        int currentId = -1;
        public Frm_HoaDon()
        {
            hoaDonChiTietServices = new HoaDonChiTietServices();
            hoaDonSevices = new HoaDonSevices();
            InitializeComponent();
        }
        public void LoadHoaDon()
        {
            dtgHoaDon.Rows.Clear();
            var hd = hoaDonSevices.GetAllHoaDon();
            dtgHoaDon.ColumnCount = 4;
            dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
            dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
            dtgHoaDon.Columns[3].HeaderText = "Trạng thái";
            foreach (var item in hd)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao,  trangthai);
            }

        }
        public void LoadHoaDonChiTiet()
        {
            HoaDonChiTietRepos repos = new HoaDonChiTietRepos();
            var allhdct = repos.GetAllByHD(currentId);
            dtgHoaDonChiTiet.Rows.Clear();
            dtgHoaDonChiTiet.ColumnCount = 6;
            dtgHoaDonChiTiet.Columns[0].HeaderText = "Mã hóa đơn";
            dtgHoaDonChiTiet.Columns[1].HeaderText = "Mã sản phẩm";
            dtgHoaDonChiTiet.Columns[2].HeaderText = "Tên sản phẩm";
            dtgHoaDonChiTiet.Columns[3].HeaderText = "Giá bán";
            dtgHoaDonChiTiet.Columns[4].HeaderText = "Số lượng";
            dtgHoaDonChiTiet.Columns[5].HeaderText = "Thành tiền";
            foreach (var data in allhdct)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                string tensp = sprepo.GetAllSanPham().Where(c => c.Id == data.IdSanPham).Select(c => c.TenSanPham).FirstOrDefault();
                int thanhtien = data.SoLuongMua * Convert.ToInt32(data.Gia);
                dtgHoaDonChiTiet.Rows.Add(data.IdHoaDon, data.IdSanPham, tensp, data.Gia, data.SoLuongMua, thanhtien);
            }
        }
        
        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            //LoadHoaDonChiTiet();
            LoadHdTheoNgay();
            cbbTrangThaiHd.SelectedIndex = 0;
        }
        public void LoadHdTheoNgay()
        {
            dateDenNgay.ValueChanged += DateDenNgay_ValueChanged;
            dateTuNgay.ValueChanged += DateTuNgay_ValueChanged;
        }

        private void DateTuNgay_ValueChanged(object? sender, EventArgs e)
        {
            DateTime startDate = dateTuNgay.Value.Date;
            DateTime endDate = dateDenNgay.Value.Date;
            var filteredData2 = hoaDonSevices.GetAllHoaDon()
                .Where(item => item.NgayTao >= startDate && item.NgayTao <= endDate)
                .ToList();
            dtgHoaDonChiTiet.Rows.Clear();
            dtgHoaDon.Rows.Clear();
            foreach (var item in filteredData2)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, trangthai);
            }
        }

        private void DateDenNgay_ValueChanged(object? sender, EventArgs e)
        {
            DateTime startDate = dateTuNgay.Value.Date;
            DateTime endDate = dateDenNgay.Value.Date;     
            var filteredData2 = hoaDonSevices.GetAllHoaDon()
                .Where(item => item.NgayTao >= startDate && item.NgayTao <= endDate)
                .ToList();
            dtgHoaDonChiTiet.Rows.Clear();
            dtgHoaDon.Rows.Clear();
            foreach (var item in filteredData2)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, trangthai);
            }
        }
        public void LoadHDById()
        {
            int id = Convert.ToInt32(txt_TimHoaDon.Text);
            var tim = hoaDonSevices.GetAllHoaDon().FirstOrDefault(item => item.Id == id);
            dtgHoaDon.Rows.Clear();
            if (tim != null)
            {
                dtgHoaDon.ColumnCount = 5;
                dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
                dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
                dtgHoaDon.Columns[3].HeaderText = "Giá được giảm";

                dtgHoaDon.Columns[4].HeaderText = "Trạng thái";
                string trangthai = tim.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                foreach (var x in hoaDonChiTietServices.GetAllHDCT())
                {
                    cbbTrangThaiHd.Items.Add(x);
                }
                dtgHoaDon.Rows.Add(tim.Id, tim.IdTaiKhoan, tim.NgayTao, tim.GiaDuocGiam, trangthai);
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo");
            }
        }
        public void LoadHDCTById()
        {
            int id = Convert.ToInt32(txt_TimHoaDon.Text);
            var timhdct = hoaDonChiTietServices.GetAllHDCT().FirstOrDefault(item => item.IdHoaDon == id);
            dtgHoaDonChiTiet.Rows.Clear();
            if (timhdct != null)
            {
                dtgHoaDonChiTiet.ColumnCount = 8;
                dtgHoaDonChiTiet.Columns[0].HeaderText = "Mã hóa đơn chi tiết";
                dtgHoaDonChiTiet.Columns[1].HeaderText = "Mã sản phẩm";
                dtgHoaDonChiTiet.Columns[2].HeaderText = "Mã hóa đơn";
                dtgHoaDonChiTiet.Columns[3].HeaderText = "Ngày tạo hóa đơn";
                dtgHoaDonChiTiet.Columns[4].HeaderText = "Giá";
                dtgHoaDonChiTiet.Columns[5].HeaderText = "Số lượng mua";
                dtgHoaDonChiTiet.Columns[6].HeaderText = "Thành tiền";
                dtgHoaDonChiTiet.Columns[7].HeaderText = "Ghi chú";
                dtgHoaDonChiTiet.Rows.Add(timhdct.Id, timhdct.IdSanPham, timhdct.IdHoaDon, timhdct.NgayLapHoaDon, timhdct.Gia, timhdct.SoLuongMua, timhdct.ThanhTien, timhdct.GhiChu);

            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn chi tiết", "Thông báo");
            }
        }
        private void btn_TimHoaDon_Click(object sender, EventArgs e)
        {
            LoadHDById();
            //LoadHDCTById();

        }
        private void btnLocHoaDon_Click(object sender, EventArgs e)
        {
            if(cbbTrangThaiHd.SelectedIndex == 2)
            {
                LoadHDChuaTT();
            }
            else if(cbbTrangThaiHd.SelectedIndex == 1)
            {
                LoadHDDaTT();
            }
            else
            {
                LoadHoaDon();
            }
            
        }
        public void LoadHDChuaTT()
        {
            var hd = hoaDonSevices.GetAllHdChuaThanhToan();
            dtgHoaDon.Rows.Clear();
            if (hd != null)
            {
                dtgHoaDon.ColumnCount = 4;
                dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
                dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
                dtgHoaDon.Columns[3].HeaderText = "Trạng thái";
                foreach(var x in hd)
                {
                    string trangthai = x.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                    dtgHoaDon.Rows.Add(x.Id, x.IdTaiKhoan, x.NgayTao, trangthai);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo");
            }
        }
        public void LoadHDDaTT()
        {
            var hd = hoaDonSevices.GetAllHdDaThanhToan();
            dtgHoaDon.Rows.Clear();
            if (hd != null)
            {
                dtgHoaDon.ColumnCount = 4;
                dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
                dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
                dtgHoaDon.Columns[3].HeaderText = "Trạng thái";
                foreach (var x in hd)
                {
                    string trangthai = x.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                    dtgHoaDon.Rows.Add(x.Id, x.IdTaiKhoan, x.NgayTao, trangthai);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo");
            }
        }

        private void cbbTrangThaiHd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgHoaDon.Rows[e.RowIndex];
            currentId = (int)row.Cells[0].Value;
            LoadHoaDonChiTiet();
        }

        private void txt_TimHoaDon_TextChanged(object sender, EventArgs e)
        {
            if(txt_TimHoaDon.Text == "")
            {
                LoadHoaDon();
            }
        }
    }
}
