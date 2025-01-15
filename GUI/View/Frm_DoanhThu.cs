using BUS.Services;
using DAL.Repositories;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI.View
{
    public partial class Frm_DoanhThu : Form
    {
        HoaDonChiTietServices hoaDonChiTietServices;
        HoaDonSevices hoaDonSevices;
        SanPhamServices sanPhamServices;
        public Frm_DoanhThu()
        {
            InitializeComponent();
            hoaDonSevices = new HoaDonSevices();
            hoaDonChiTietServices = new HoaDonChiTietServices();
            sanPhamServices = new SanPhamServices();
        }

        private void Frm_DoanhThu_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadTheoNgay();  
            lbTensp.Visible = false;
            lbSoluong.Visible = false;
            lbDoanhThu.Visible = false;
        }
        public void LoadThongKe()
        {
            HoaDonChiTietRepos repos = new HoaDonChiTietRepos();
            var allhdct = hoaDonChiTietServices.GetAllHDByTrangThai();
            dtgThongKeSanPham.Rows.Clear();
            dtgThongKeSanPham.ColumnCount = 6;
            dtgThongKeSanPham.Columns[0].HeaderText = "Mã hóa đơn";
            dtgThongKeSanPham.Columns[1].HeaderText = "Ngày tạo";
            dtgThongKeSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dtgThongKeSanPham.Columns[3].HeaderText = "Giá bán";
            dtgThongKeSanPham.Columns[4].HeaderText = "Số lượng";
            dtgThongKeSanPham.Columns[5].HeaderText = "Thành tiền";
            foreach (var data in allhdct)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                string tensp = sprepo.GetAllSanPham().Where(c => c.Id == data.IdSanPham).Select(c => c.TenSanPham).FirstOrDefault();
                int thanhtien = data.SoLuongMua * Convert.ToInt32(data.Gia);
                dtgThongKeSanPham.Rows.Add(data.IdHoaDon, data.NgayLapHoaDon, tensp, data.Gia, data.SoLuongMua, thanhtien);
            }
        }
        public void LoadTheoNgay()
        {
            date_TuNgayTK.ValueChanged += Date_TuNgayTK_ValueChanged;
            date_DenNgayTK.ValueChanged += Date_DenNgayTK_ValueChanged;
        }

        private void Date_DenNgayTK_ValueChanged(object? sender, EventArgs e)
        {
            DateTime startDate = date_TuNgayTK.Value.Date;
            DateTime endDate = date_DenNgayTK.Value.Date;
            var filteredData = hoaDonChiTietServices.GetAllHDCT()
                .Where(item => item.NgayLapHoaDon >= startDate && item.NgayLapHoaDon <= endDate)
                .ToList();
            dtgThongKeSanPham.Rows.Clear();
            decimal tien = 0;
            foreach (var item in filteredData)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                string tensp = sprepo.GetAllSanPham().Where(c => c.Id == item.IdSanPham).Select(c => c.TenSanPham).FirstOrDefault();
                int thanhtien = item.SoLuongMua * Convert.ToInt32(item.Gia);
                dtgThongKeSanPham.Rows.Add(item.IdHoaDon, item.NgayLapHoaDon, tensp, item.Gia, item.SoLuongMua, thanhtien);
                lbDoanhThu.Text =Convert.ToString(item.SoLuongMua * Convert.ToInt32(item.Gia));

                tien += Convert.ToDecimal(item.ThanhTien);
                lbDoanhThu.Text = tien.ToString("C", new CultureInfo("vi-VN"));
                decimal soluongmua = item.SoLuongMua;
                if(soluongmua != null && decimal.TryParse(soluongmua.ToString(),out decimal number) )
                {
                    if(number > tien)
                    {
                        tien = number;
                    }
                }      
            }
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            int productNameColumnIndex = 2;
            int quantityColumnIndex = 4;
            foreach (DataGridViewRow row in dtgThongKeSanPham.Rows)
            {
                if (row.IsNewRow) continue;
                var productNameCell = row.Cells[productNameColumnIndex].Value;
                var quantityCell = row.Cells[quantityColumnIndex].Value;
                if (productNameCell == null || quantityCell == null)
                {
                    continue;
                }
                string productName = productNameCell.ToString();
                int quantity = Convert.ToInt32(quantityCell);
                if (productSales.ContainsKey(productName))
                {
                    productSales[productName] += quantity;
                }
                else
                {
                    productSales[productName] = quantity;
                }
            }
            if (productSales.Count > 0)
            {
                var maxProduct = productSales.Aggregate((l, r) => l.Value > r.Value ? l : r);
                //MessageBox.Show($"Sản phẩm có tổng số lượng bán lớn nhất là {maxProduct.Key} với tổng số lượng {maxProduct.Value}.");
                if (tien < 0)
                {
                    lbSoluong.Visible = false;
                    lbDoanhThu.Visible = false;
                    lbTensp.Visible = false;
                }
                else
                {
                    lbTensp.Visible = true;
                    lbSoluong.Visible = true;
                    lbDoanhThu.Visible = true;
                    lbSoluong.Text = maxProduct.Value.ToString();
                    SanPhamRepos sanPhamRepos = new SanPhamRepos();
                    HoaDonChiTietRepos hdctRepo = new HoaDonChiTietRepos();
                    //int idsp = hdctRepo.GetAllHDCT().Where(c => c.SoLuongMua == Convert.ToInt32(maxQuantity)).Select(c => c.IdSanPham).FirstOrDefault();
                    //string ten = sanPhamRepos.GetAllSanPham().Where(c => c.Id == idsp).Select(c => c.TenSanPham).FirstOrDefault();
                    lbTensp.Text = maxProduct.Key;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào.", "Thông báo");
                lbDoanhThu.Visible = false;
                lbSoluong.Visible=false;
                lbTensp.Visible=false;
            }
        }

        private void Date_TuNgayTK_ValueChanged(object? sender, EventArgs e)
        {
            DateTime startDate = date_TuNgayTK.Value.Date;
            DateTime endDate = date_DenNgayTK.Value.Date;
            var filteredData = hoaDonChiTietServices.GetAllHDCT()
                .Where(item => item.NgayLapHoaDon >= startDate && item.NgayLapHoaDon <= endDate)
                .ToList();
            dtgThongKeSanPham.Rows.Clear();
            decimal tien = 0;
            foreach (var item in filteredData)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                string tensp = sprepo.GetAllSanPham().Where(c => c.Id == item.IdSanPham).Select(c => c.TenSanPham).FirstOrDefault();
                int thanhtien = item.SoLuongMua * Convert.ToInt32(item.Gia);
                dtgThongKeSanPham.Rows.Add(item.IdHoaDon, item.NgayLapHoaDon, tensp, item.Gia, item.SoLuongMua, thanhtien);
                lbDoanhThu.Text = Convert.ToString(item.SoLuongMua * Convert.ToInt32(item.Gia));
                tien += Convert.ToDecimal(item.ThanhTien);
                lbDoanhThu.Text = tien.ToString("C", new CultureInfo("vi-VN"));
                decimal soluongmua = item.SoLuongMua;
                if (soluongmua != null && decimal.TryParse(soluongmua.ToString(), out decimal number))
                {
                    if (number > tien)
                    {
                        tien = number;
                    }
                } 
            }
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            int productNameColumnIndex = 2; 
            int quantityColumnIndex = 4; 
            foreach (DataGridViewRow row in dtgThongKeSanPham.Rows)
            {
                if (row.IsNewRow) continue;
                var productNameCell = row.Cells[productNameColumnIndex].Value;
                var quantityCell = row.Cells[quantityColumnIndex].Value;

                if (productNameCell == null || quantityCell == null)
                {
                    continue;
                }
                string productName = productNameCell.ToString();
                int quantity = Convert.ToInt32(quantityCell);
                if (productSales.ContainsKey(productName))
                {
                    productSales[productName] += quantity;
                }
                else
                {
                    productSales[productName] = quantity;
                }
            }
            if (productSales.Count > 0)
            {
                var maxProduct = productSales.Aggregate((l, r) => l.Value > r.Value ? l : r);
                //MessageBox.Show($"Sản phẩm có tổng số lượng bán lớn nhất là {maxProduct.Key} với tổng số lượng {maxProduct.Value}.");
                if (tien < 0)
                {
                    lbSoluong.Visible = false;
                    lbDoanhThu.Visible = false;
                    lbTensp.Visible = false;
                }
                else
                {
                    lbTensp.Visible = true;
                    lbSoluong.Visible = true;
                    lbDoanhThu.Visible = true;
                    lbSoluong.Text = maxProduct.Value.ToString();
                    SanPhamRepos sanPhamRepos = new SanPhamRepos();
                    HoaDonChiTietRepos hdctRepo = new HoaDonChiTietRepos();
                    //int idsp = hdctRepo.GetAllHDCT().Where(c => c.SoLuongMua == Convert.ToInt32(maxQuantity)).Select(c => c.IdSanPham).FirstOrDefault();
                    //string ten = sanPhamRepos.GetAllSanPham().Where(c => c.Id == idsp).Select(c => c.TenSanPham).FirstOrDefault();
                    lbTensp.Text = maxProduct.Key;
                }
            }
            else
            {
                
                MessageBox.Show("Không tìm thấy sản phẩm nào.","Thông báo");
                lbDoanhThu.Visible = false;
                lbSoluong.Visible = false;
                lbTensp.Visible = false;
            }
            

        }
    }
}
