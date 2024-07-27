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

    public partial class Frm_HoaDon : Form
    {
        HoaDonSevices hoaDonSevices;
        HoaDonChiTietServices hoaDonChiTietServices;
        public Frm_HoaDon()
        {
            hoaDonChiTietServices = new HoaDonChiTietServices();
            hoaDonSevices = new HoaDonSevices();
            InitializeComponent();
        }
        public void LoadHoaDon()
        {
            dtgHoaDon.Controls.Clear();
            var hd = hoaDonSevices.GetAllHoaDon();
            dtgHoaDon.ColumnCount = 6;
            dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
            dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
            dtgHoaDon.Columns[3].HeaderText = "Giá được giảm";
            dtgHoaDon.Columns[4].HeaderText = "Thuế";
            dtgHoaDon.Columns[5].HeaderText = "Trạng thái";
            foreach (var item in hd)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, item.GiaDuocGiam, item.Thue, trangthai);
            }
        }
        public void LoadHoaDonChiTiet()
        {
            dtgHoaDonChiTiet.Controls.Clear();
            var hdct = hoaDonChiTietServices.GetAllHDCT();
            dtgHoaDonChiTiet.ColumnCount = 8;
            dtgHoaDonChiTiet.Columns[0].HeaderText = "Mã hóa đơn chi tiết";
            dtgHoaDonChiTiet.Columns[1].HeaderText = "Mã sản phẩm";
            dtgHoaDonChiTiet.Columns[2].HeaderText = "Mã hóa đơn";
            dtgHoaDonChiTiet.Columns[3].HeaderText = "Ngày tạo hóa đơn";
            dtgHoaDonChiTiet.Columns[4].HeaderText = "Giá";
            dtgHoaDonChiTiet.Columns[5].HeaderText = "Số lượng mua";
            dtgHoaDonChiTiet.Columns[6].HeaderText = "Thành tiền";
            dtgHoaDonChiTiet.Columns[7].HeaderText = "Ghi chú";
            foreach (var item in hdct)
            {
                //DateTime start = dateTuNgay.Value.Date;
                //DateTime end = dateDenNgay.Value.Date;
                //var hdLoc = hoaDonChiTietServices.GetAllHDCT().Where(hd => hd.NgayLapHoaDon >= start && hd.NgayLapHoaDon <= end).ToList();
                dtgHoaDonChiTiet.Rows.Add(item.Id, item.IdSanPham, item.IdHoaDon, item.NgayLapHoaDon, item.Gia, item.SoLuongMua, item.ThanhTien, item.GhiChu);
            }

        }
        //public void LocHD()
        //{
        //    DateTime start = dateTuNgay.Value.Date;
        //    DateTime end = dateDenNgay.Value.Date;
        //    var hdLoc = hoaDonChiTietServices.GetAllHDCT().Where(hd => hd.NgayLapHoaDon >= start && hd.NgayLapHoaDon <= end).ToList();
        //    dtgHoaDonChiTiet.DataSource = hdLoc;
        //}

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadHoaDonChiTiet();
            LoadHdTheoNgay();
            LoadTrangThaiHD();

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

            // Lọc danh sách hóa đơn chi tiết dựa trên khoảng thời gian
            var filteredData = hoaDonChiTietServices.GetAllHDCT()
                .Where(item => item.NgayLapHoaDon >= startDate && item.NgayLapHoaDon <= endDate)
                .ToList();
            var filteredData2 = hoaDonSevices.GetAllHoaDon()
                .Where(item => item.NgayTao >= startDate && item.NgayTao <= endDate)
                .ToList();

            // Xóa dữ liệu hiện tại trong DataGridView
            dtgHoaDonChiTiet.Rows.Clear();
            dtgHoaDon.Rows.Clear();
            // Thêm dữ liệu được lọc vào DataGridView
            foreach (var item in filteredData)
            {
                dtgHoaDonChiTiet.Rows.Add(item.Id, item.IdSanPham, item.IdHoaDon, item.NgayLapHoaDon, item.Gia, item.SoLuongMua, item.ThanhTien, item.GhiChu);
            }
            foreach (var item in filteredData2)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, item.GiaDuocGiam, item.Thue, trangthai);
            }
        }

        private void DateDenNgay_ValueChanged(object? sender, EventArgs e)
        {
            DateTime startDate = dateTuNgay.Value.Date;
            DateTime endDate = dateDenNgay.Value.Date;

            // Lọc danh sách hóa đơn chi tiết dựa trên khoảng thời gian
            var filteredData = hoaDonChiTietServices.GetAllHDCT()
                .Where(item => item.NgayLapHoaDon >= startDate && item.NgayLapHoaDon <= endDate)
                .ToList();
            var filteredData2 = hoaDonSevices.GetAllHoaDon()
                .Where(item => item.NgayTao >= startDate && item.NgayTao <= endDate)
                .ToList();

            // Xóa dữ liệu hiện tại trong DataGridView
            dtgHoaDonChiTiet.Rows.Clear();
            dtgHoaDon.Rows.Clear();

            // Thêm dữ liệu được lọc vào DataGridView
            foreach (var item in filteredData)
            {
                dtgHoaDonChiTiet.Rows.Add(item.Id, item.IdSanPham, item.IdHoaDon, item.NgayLapHoaDon, item.Gia, item.SoLuongMua, item.ThanhTien, item.GhiChu);

            }
            foreach (var item in filteredData2)
            {
                string trangthai = item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, item.GiaDuocGiam, item.Thue, trangthai);
            }
        }
        public void LoadHDById()
        {
            int id = Convert.ToInt32(txt_TimHoaDon.Text);
            var tim = hoaDonSevices.GetAllHoaDon().FirstOrDefault(item => item.Id == id);
            dtgHoaDon.Rows.Clear();
            if (tim != null)
            {
                dtgHoaDon.ColumnCount = 6;
                dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
                dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
                dtgHoaDon.Columns[3].HeaderText = "Giá được giảm";
                dtgHoaDon.Columns[4].HeaderText = "Thuế";
                dtgHoaDon.Columns[5].HeaderText = "Trạng thái";
                string trangthai = tim.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                foreach (var x in hoaDonChiTietServices.GetAllHDCT())
                {
                    cbbTrangThaiHd.Items.Add(x);

                }
                dtgHoaDon.Rows.Add(tim.Id, tim.IdTaiKhoan, tim.NgayTao, tim.GiaDuocGiam, tim.Thue, trangthai);
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
            LoadHDCTById();
        }
        public void LoadTrangThaiHD()
        {

            foreach (var x in hoaDonSevices.GetAllHoaDon())
            {
                string trangthai = x.TrangThai == 0 ? "Đã thanh toán"  : "Chưa thanh toán" ;
                if (!cbbTrangThaiHd.Items.Contains(trangthai))
                {
                    cbbTrangThaiHd.Items.Add(trangthai);
                }
            }
            cbbTrangThaiHd.Text = "Tất cả";
        }
        public void LocHoaDon()
        {
            //string trangThai = cbbTrangThaiHd.SelectedItem.ToString();
            //List<HoaDon> filteredHoaDons = new List<HoaDon>();

            //foreach (var x in hoaDonSevices.GetAllHoaDon())
            //{
            //    if ((trangThai == "Đã thanh toán" && x.TrangThai == 0) ||
            //        (trangThai == "Chưa thanh toán" && x.TrangThai != 0))
            //    {
            //        dtgHoaDon.Rows.Clear();
            //        dtgHoaDon.ColumnCount = 6;
            //        dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            //        dtgHoaDon.Columns[1].HeaderText = "Mã tài khoản";
            //        dtgHoaDon.Columns[2].HeaderText = "Ngày tạo hóa đơn";
            //        dtgHoaDon.Columns[3].HeaderText = "Giá được giảm";
            //        dtgHoaDon.Columns[4].HeaderText = "Thuế";
            //        dtgHoaDon.Columns[5].HeaderText = "Trạng thái";
            //        foreach(var item in filteredHoaDons)
            //        {
            //            dtgHoaDon.Rows.Add(item.Id, item.IdTaiKhoan, item.NgayTao, item.GiaDuocGiam, item.Thue, trangthai);
            //        }
            //        //filteredHoaDons.Add(x);
            //    }
            //}

            //dtgHoaDon.DataSource = filteredHoaDons;
        }

        private void btnLocHoaDon_Click(object sender, EventArgs e)
        {
            LocHoaDon();
        }
    }
}
