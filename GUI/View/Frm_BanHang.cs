using BUS.Services;
using BUS.ViewModels;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Identity.Client.NativeInterop;
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

namespace GUI.View
{
    public partial class Frm_BanHang : Form
    {
        private HoaDonSevices hoaDonSevices;
        static SanPhamServices sanPhamServices;
        private HoaDonChiTietServices hoaDonChiTietServices;
        static List<SanPham> _lstSanPhams;
        GiamGiaServices giamGiaServices;
        int idTk;
        public int currentId = -1;
        int selectedId = -1;
        AppDbContext _context;
        private HoaDonChiTietRepos repo;

        public Frm_BanHang(int idTk)
        {
            _context = new AppDbContext();
            hoaDonSevices = new HoaDonSevices();
            sanPhamServices = new SanPhamServices();
            hoaDonChiTietServices = new HoaDonChiTietServices();
            giamGiaServices = new GiamGiaServices();
            repo = new HoaDonChiTietRepos();
            _lstSanPhams = sanPhamServices.GetAllSanPham();
            this.idTk = idTk;
            InitializeComponent();
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            hoaDonSevices = new HoaDonSevices();
            //LoadView();
            LoadToSpPanel(Convert.ToInt32(lb_page.Text));
            LoadHD();

        }
        public void LoadToSpPanel(int page)
        {
            tlp_SanPham.Controls.Clear();
            _lstSanPhams = sanPhamServices.GetSpByTrangThai();
            var giamgia = giamGiaServices.GetAllGiamGia();
            var sanPhamGiamGia =
                from sp in _lstSanPhams
                join gg in giamgia on sp.giamGiaId equals gg.Id
                select new SanPhamGiamGiaVm
                {
                    Id = sp.Id,
                    IdLoaiSp = sp.IdLoaiSp,
                    TenSanPham = sp.TenSanPham,
                    GiaSanPham = sp.GiaSanPham,
                    SoLuong = sp.SoLuong,
                    TrangThai = sp.TrangThai,
                    AnhSanPham = sp.AnhSanPham,
                    GiaGiam = Convert.ToInt64(sp.GiaSanPham - sp.GiaSanPham * Convert.ToInt64(gg.GiaTri) / 100)
                };
            int numberOfPage = (int)Math.Ceiling((double)sanPhamGiamGia.ToList().Count / 6);
            if (page < 1 || page > numberOfPage) return;
            if (page * 6 - 6 < sanPhamGiamGia.ToList().Count)
            {
                Panel s1 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 6]);
                tlp_SanPham.Controls.Add(s1, 0, 0);
            }
            if (page * 6 - 5 < sanPhamGiamGia.ToList().Count)
            {
                Panel s2 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 5]);
                tlp_SanPham.Controls.Add(s2, 1, 0);
            }
            if (page * 6 - 4 < sanPhamGiamGia.ToList().Count)
            {
                Panel s3 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 4]);
                tlp_SanPham.Controls.Add(s3, 2, 0);
            }
            if (page * 6 - 3 < sanPhamGiamGia.ToList().Count)
            {
                Panel s4 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 3]);
                tlp_SanPham.Controls.Add(s4, 0, 1);
            }
            if (page * 6 - 2 < sanPhamGiamGia.ToList().Count)
            {
                Panel s5 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 2]);
                tlp_SanPham.Controls.Add(s5, 1, 1);
            }
            if (page * 6 - 1 < sanPhamGiamGia.ToList().Count)
            {
                Panel s6 = CreateSPToPanel(sanPhamGiamGia.ToList()[page * 6 - 1]);
                tlp_SanPham.Controls.Add(s6, 2, 1);
            }
        }
        public Panel CreateSPToPanel(SanPhamGiamGiaVm sp)
        {
            tlp_SanPham.ColumnCount = 3;
            tlp_SanPham.RowCount = 2;
            Panel p = new Panel();
            p.BackColor = Color.FromArgb(255, 228, 181);
            p.Name = sp.Id.ToString();
            p.Size = new Size(271, 303);
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(247, 185);
            ptb.Image = Image.FromFile(sp.AnhSanPham);
            ptb.Location = new Point(12, 7);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            Label lbgiagiam = new Label();
            lbgiagiam.Text = sp.GiaGiam.ToString("C", new CultureInfo("vi-VN"));
            lbgiagiam.Name = "giaGiam";
            lbgiagiam.Location = new Point(12, 238);
            lbgiagiam.Font = new Font("Arial", 12, FontStyle.Bold);
            lbgiagiam.ForeColor = Color.Red;
            Label giavalue = new Label();
            giavalue.Font = new Font(giavalue.Font, FontStyle.Strikeout);
            Label Tensp = new Label();
            Tensp.ForeColor = Color.Red;
            Tensp.Font = new Font("Arial", 12, FontStyle.Bold);
            Tensp.Text = sp.TenSanPham.ToString();
            Tensp.Location = new Point(12, 204);
            Tensp.Name = "TenSp";
            Tensp.Size = new Size(221, 28);
            giavalue.Location = new Point(12, 270);
            giavalue.Text = sp.GiaSanPham.ToString();
            giavalue.Name = "giaSp";
            Label lbsl = new Label();
            lbsl.Text = "Số lượng:";
            lbsl.Size = new Size(72, 20);
            lbsl.Location = new Point(153, 243);
            TextBox tbSlMua = new TextBox();
            tbSlMua.Location = new Point(153, 270);
            tbSlMua.Size = new Size(106, 27);
            tbSlMua.PlaceholderText = "Số lượng mua";
            tbSlMua.Name = "tblSlMua";
            p.Controls.Add(ptb);
            p.Controls.Add(giavalue);
            p.Controls.Add(lbgiagiam);
            p.Controls.Add(lbsl);
            p.Controls.Add(tbSlMua);
            p.Controls.Add(Tensp);
            ptb.Click += Ptb_Click;
            return p;
        }
        private void Ptb_Click(object? sender, EventArgs e)
        {
            hoaDonChiTietServices = new HoaDonChiTietServices();
            SanPham sp = new SanPham();
            PictureBox p = (PictureBox)sender;
            Panel p1 = (Panel)p.Parent;
            TextBox t = p1.Controls["tblSlMua"] as TextBox;
            Label gia = p1.Controls["giaSp"] as Label;
            Label giaGiam = p1.Controls["giaGiam"] as Label;
            int Giaban = Convert.ToInt32(gia.Text);
            string soLuongMua = t.Text;
            Label ten = p1.Controls["TenSp"] as Label;
            string tensp = ten.Text;
            int IdSp1 = Convert.ToInt32(p1.Name);
            var sl = _context.sanPhams.Find(IdSp1);
            string soluongton = Convert.ToString(sl.SoLuong);
            int soLuongMuaInt;
            bool isNumber = int.TryParse(soLuongMua, out soLuongMuaInt);
            if (currentId == -1) MessageBox.Show("Bạn chưa chọn hóa đơn mua", "Thông báo");
            else if (soLuongMua == "") MessageBox.Show("Bạn chưa chọn số lượng mua", "Thông báo");
            else if (string.IsNullOrWhiteSpace(soLuongMua) || !isNumber || soLuongMuaInt <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ", "Thông báo");
            }
            else if (Convert.ToInt32(soluongton) < 0 || Convert.ToInt32(soluongton) == 0) MessageBox.Show("Sản phẩm này đã hết", "Thông báo");
            else if (Convert.ToInt32(soLuongMua) > Convert.ToInt32(soluongton)) MessageBox.Show($"Trong kho chỉ còn{soluongton} sản phẩm", "Thông báo");
            else
            {
                int IdHD = currentId;
                int IdSp = Convert.ToInt32(p1.Name);
                int SoLuong = Convert.ToInt32(soLuongMua);
                int Gia = Giaban;
                int TrangThai = 1;
                hoaDonChiTietServices.UpdateCongDon(IdSp, IdHD, SoLuong);
                MessageBox.Show("Bạn vừa chọn mua " + ten.Text + ". Với số lượng là " + t.Text, "Thông báo");
                long toTal = hoaDonChiTietServices.TongTien(currentId);
                hoaDonSevices.UpdateHD(currentId, 1, toTal);
                LoadHD();
                LoadHDCT();
            }
            t.Text = "";
        }
        public void LoadHDCT()
        {
            HoaDonChiTietRepos repos = new HoaDonChiTietRepos();
            int sum = 0;
            var allhdct = repos.GetAllByHD(currentId);
            dtg_HoaDonCho.Rows.Clear();
            dtg_HoaDonCho.ColumnCount = 6;
            dtg_HoaDonCho.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_HoaDonCho.Columns[1].HeaderText = "Mã sản phẩm";
            dtg_HoaDonCho.Columns[2].HeaderText = "Tên sản phẩm";
            dtg_HoaDonCho.Columns[3].HeaderText = "Giá bán";
            dtg_HoaDonCho.Columns[4].HeaderText = "Số lượng";
            dtg_HoaDonCho.Columns[5].HeaderText = "Thành tiền";
            foreach (var data in allhdct)
            {
                SanPhamRepos sprepo = new SanPhamRepos();
                long giagiam = sanPhamServices.GetSanPhamGiamGia().Where(c => c.Id == data.IdSanPham).Select(c => c.GiaGiam).FirstOrDefault();
                string tensp = sprepo.GetAllSanPham().Where(c => c.Id == data.IdSanPham).Select(c => c.TenSanPham).FirstOrDefault();
                int thanhtien = data.SoLuongMua * Convert.ToInt32(giagiam);
                sum += thanhtien;
                dtg_HoaDonCho.Rows.Add(data.IdHoaDon, data.IdSanPham, tensp, giagiam, data.SoLuongMua, thanhtien);         
                txt_TongTienSP.Text = sum.ToString();
            }
            if(sum == 0)
            {
                txt_TongTienSP.Text = "";
            }
        }
        public void LoadHD()
        {
            TaiKhoanServices taiKhoanServices = new TaiKhoanServices();
            var allhd = hoaDonSevices.GetAllHdChuaThanhToan();
            //long sum = 0;
            //long giagiam = sanPhamServices.GetSanPhamGiamGia().Select(c => c.GiaGiam).FirstOrDefault();
            //long slmua = sanPhamServices.GetSanPhamGiamGia().Select(c => c.SoLuongMua).FirstOrDefault();
            //long tongtien = slmua * giagiam;
            //sum += tongtien;
            dtg_TaoHoaDon.Rows.Clear();
            dtg_TaoHoaDon.ColumnCount = 4;
            dtg_TaoHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_TaoHoaDon.Columns[1].HeaderText = "Người tạo";
            dtg_TaoHoaDon.Columns[2].HeaderText = "Ngày tạo";

            dtg_TaoHoaDon.Columns[3].HeaderText = "Trạng thái";
            foreach (var hoaDon in allhd)
            {

                string Tentk = taiKhoanServices.GetAllTaiKhoan().Where(c => c.Id == hoaDon.IdTaiKhoan).Select(c => c.TenTaiKhoan).FirstOrDefault();
                string trangthai = hoaDon.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtg_TaoHoaDon.Rows.Add(hoaDon.Id, Tentk, hoaDon.NgayTao, trangthai);
            }
        }
        private void dtg_TaoHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_TaoHoaDon.Rows[e.RowIndex];
            currentId = (int)row.Cells[0].Value;
            txtMaHoaDon.Text = currentId.ToString();
            //txt_TongTienSP.Text = row.Cells[3].Value.ToString();
            LoadHDCT();
            //MessageBox.Show("Bạn vừa chọn hóa đơn có mã là" + currentId.ToString());
        }
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonSevices.CreateHD(idTk);
            LoadHD();
        }

        private void btn_HuyHD_Click(object sender, EventArgs e)
        {
            if (currentId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần hủy", "Thông báo");
            }
            else
            {
                MessageBox.Show(hoaDonSevices.DeleteHD(currentId), "Thông báo");
                LoadHD();
                LoadHDCT();
            }

        }

        private void lbback_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) > 1)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadToSpPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void lbnext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((double)_lstSanPhams.Count / 6))
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadToSpPanel(Convert.ToInt32(lb_page.Text));
            }
        }
        public void Clear()
        {
            txtTienThua.Text = "";
            txt_TienKhachTra.Text = "";

            txt_TongTienSP.Text = "";
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(txt_TienKhachTra.Text == "")
            {
                return;
            }else if(txt_TongTienSP.Text == "")
            {
                return ;
            }else if(cbb_LoaiThanhToan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán", "Thông báo");
                return ;
            }
            int tienkhachtra = Convert.ToInt32(txt_TienKhachTra.Text);
            int tongtien = Convert.ToInt32(txt_TongTienSP.Text);
            if (currentId == -1) MessageBox.Show("Bạn chưa chọn hóa đơn thanh toán", "Thông báo");

            else if (txt_TienKhachTra.Text == "")
            {
                MessageBox.Show("Khách chưa trả tiền ?", "Thông báo");
            }
            
            else if (tienkhachtra < tongtien)
            {
                MessageBox.Show("Khách chưa trả đủ tiền, không thể thanh toán", "Thông báo");
            }
            else if (currentId > 0)
            {
                hoaDonSevices.UpdateHD(currentId, 0, null);
                MessageBox.Show("Thanh toán thành công", "Thanh toán");
                dtg_HoaDonCho.Rows.Clear();
                LoadHD();
                currentId = -1;
                Clear();
                txt_TienKhachTra.Enabled = true;
            }
        }
        private void cbb_LoaiThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiThanhToan.SelectedIndex == 0)
            {
                txt_TienKhachTra.Text = txt_TongTienSP.Text;
                txtTienThua.Text = "0";
                txt_TienKhachTra.Enabled = false;
                txtTienThua.Enabled = false;
            }
            else if (cbb_LoaiThanhToan.SelectedIndex == 1)
            {
                txt_TienKhachTra.Enabled = true;
            }
        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if(txt_TienKhachTra.Text == "")
            {
                txtTienThua.Text = "";
                return;
            }
            if(txt_TongTienSP.Text == "")
            {
                return;
            }
            decimal tienkhachtra ;
            if (!decimal.TryParse(txt_TienKhachTra.Text, out tienkhachtra) || tienkhachtra <= 0)
            {
                MessageBox.Show("Sai kiểu dữ liệu vui lòng nhập lại","Thông báo");
                txtTienThua.Text = "";
                return;
            }
            decimal tongtien = decimal.Parse(txt_TongTienSP.Text);
            decimal tienthua = tienkhachtra - tongtien;
            if (tienthua < 0)
            {
                txtTienThua.Text = "";
            }else if (txt_TongTienSP.Text == "")
            {
                return;
            }
            else
            {
                txt_TienKhachTra.Enabled = true;
                txtTienThua.Text = tienthua.ToString();
                txtTienThua.Enabled = false ;
            }
            
        }
    }
}
