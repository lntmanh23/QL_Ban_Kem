using BUS.Services;
using BUS.ViewModels;
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

namespace GUI.View
{
    public partial class Frm_BanHang : Form
    {
        private HoaDonSevices hoaDonSevices;
        static SanPhamServices SanPhamServices;
        private HoaDonChiTietServices hoaDonChiTietServices;
        static List<SanPham> _lstSanPhams;
        int idTk;
        public int currentId = -1;
        int selectedId = -1;
        AppDbContext _context;

        public Frm_BanHang(int idTk)
        {
            _context = new AppDbContext();
            hoaDonSevices = new HoaDonSevices();
            SanPhamServices = new SanPhamServices();
            hoaDonChiTietServices = new HoaDonChiTietServices();
            _lstSanPhams = SanPhamServices.GetAllSanPham();
            //SanPhamServices = new SanPhamServices();
            //_lstSanPhams = SanPhamServices.GetAllSanPham();
            //hoaDonChiTietServices = new HoaDonChiTietServices();
            //hoaDonSevices = new HoaDonSevices();
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

            int numberOfPage = (int)Math.Ceiling((double)_lstSanPhams.Count / 6);
            if (page < 1 || page > numberOfPage) return;
            if (page * 6 - 6 < _lstSanPhams.Count)
            {
                Panel s1 = CreateSPToPanel(_lstSanPhams[page * 6 - 6]);
                tlp_SanPham.Controls.Add(s1, 0, 0);
            }
            if (page * 6 - 5 < _lstSanPhams.Count)
            {
                Panel s2 = CreateSPToPanel(_lstSanPhams[page * 6 - 5]);
                tlp_SanPham.Controls.Add(s2, 1, 0);
            }
            if (page * 6 - 4 < _lstSanPhams.Count)
            {
                Panel s3 = CreateSPToPanel(_lstSanPhams[page * 6 - 4]);
                tlp_SanPham.Controls.Add(s3, 2, 0);
            }
            if (page * 6 - 3 < _lstSanPhams.Count)
            {
                Panel s4 = CreateSPToPanel(_lstSanPhams[page * 6 - 3]);
                tlp_SanPham.Controls.Add(s4, 0, 1);
            }
            if (page * 6 - 2 < _lstSanPhams.Count)
            {
                Panel s5 = CreateSPToPanel(_lstSanPhams[page * 6 - 2]);
                tlp_SanPham.Controls.Add(s5, 1, 1);
            }
            if (page * 6 - 1 < _lstSanPhams.Count)
            {
                Panel s6 = CreateSPToPanel(_lstSanPhams[page * 6 - 1]);
                tlp_SanPham.Controls.Add(s6, 2, 1);
            }
        }
        public Panel CreateSPToPanel(SanPham sp)
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
            Label lbgia = new Label();
            lbgia.Text = "Giá:";
            lbgia.Location = new Point(12, 243);
            Label giavalue = new Label();
            Label Tensp = new Label();
            Tensp.ForeColor = Color.Red;
            Tensp.Font = new Font("Arial", 12, FontStyle.Bold);
            Tensp.Text = sp.TenSanPham.ToString();
            Tensp.Location = new Point(12, 204);
            Tensp.Name = "TenSp";
            Tensp.Size = new Size(221, 28);
            giavalue.Location = new Point(12, 270);
            giavalue.Text = sp.GiaSanPham + "";
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
            p.Controls.Add(lbgia);
            p.Controls.Add(lbsl);
            p.Controls.Add(tbSlMua);
            p.Controls.Add(Tensp);
            ptb.Click += Ptb_Click;
            return p;
        }
        private void Ptb_Click(object? sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            PictureBox p = (PictureBox)sender;
            Panel p1 = (Panel)p.Parent;
            TextBox t = p1.Controls["tblSlMua"] as TextBox;
            Label gia = p1.Controls["giaSp"] as Label;
            int Giaban = Convert.ToInt32(gia.Text);
            string soLuongMua = t.Text;
            Label ten = p1.Controls["TenSp"] as Label;
            string tensp = ten.Text;
            int soluongton = sp.SoLuong;         
            if (currentId == -1) MessageBox.Show("Bạn chưa chọn hóa đơn mua", "Thông báo");
            else if (t.Text == "") MessageBox.Show("Bạn chưa chọn số lượng mua", "Thông báo");
            //else if(soLuongMua > soluongton) MessageBox.Show($"Bạn không được mua quá {soluongton} sản phẩm", "Thông báo");
            else
            {
                int IdHD = currentId;
                int IdSp = Convert.ToInt32(p1.Name);
                int SoLuong = Convert.ToInt32(soLuongMua);
                int Gia = Giaban;
                int TrangThai = 1;
                hoaDonChiTietServices.UpdateCongDon(IdSp, IdHD, SoLuong);
                MessageBox.Show("Bạn vừa chọn mua " + ten.Text + ". Với số lượng là " + t.Text);
                long TotalMoney = hoaDonChiTietServices.TongTien(currentId);
                txt_TongTienSP.Text = TotalMoney.ToString();
                hoaDonSevices.UpdateHD(currentId, 1, TotalMoney);
                LoadHD();
                LoadHDCT();    
            }
            t.Text = "";
        }
        public void LoadHDCT()
        {
            HoaDonChiTietRepos repos = new HoaDonChiTietRepos();
            var allhdct = hoaDonChiTietServices.GetHD_HDCT(currentId);
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
                int thanhtien = data.SoLuongMua * Convert.ToInt32(data.Gia);
                dtg_HoaDonCho.Rows.Add(data.IdHd, data.IdSp,data.TenSp, data.Gia, data.SoLuongMua, thanhtien);
            }
        }
        public void LoadHD()
        {
            var allhd = hoaDonSevices.GetAllHdChuaThanhToan();
            dtg_TaoHoaDon.Rows.Clear();
            dtg_TaoHoaDon.ColumnCount = 7;
            dtg_TaoHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_TaoHoaDon.Columns[1].HeaderText = "Mã tài khoản";
            dtg_TaoHoaDon.Columns[2].HeaderText = "Ngày tạo";
            dtg_TaoHoaDon.Columns[3].HeaderText = "Giá được giảm";
            dtg_TaoHoaDon.Columns[4].HeaderText = "Thuế";
            dtg_TaoHoaDon.Columns[5].HeaderText = "Tổng tiền hóa đơn";
            dtg_TaoHoaDon.Columns[6].HeaderText = "Trạng thái";
            foreach (var hoaDon in allhd)
            {
                string trangthai = hoaDon.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                dtg_TaoHoaDon.Rows.Add(hoaDon.Id, hoaDon.IdTaiKhoan, hoaDon.NgayTao, hoaDon.GiaDuocGiam, hoaDon.Thue, hoaDon.TongTienHD, trangthai);
            }
        }
        private void dtg_TaoHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_TaoHoaDon.Rows[e.RowIndex];
            currentId = (int)row.Cells[0].Value;
            LoadHDCT();
            //MessageBox.Show("Bạn vừa chọn hóa đơn có mã là" + currentId.ToString());
        }
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonSevices.CreateHD(idTk, 4);
            LoadHD();
        }

        private void btn_HuyHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            var id = _context.HoaDons.Find(hd.Id);
            hoaDonSevices.DeleteHD(hd.Id);
            LoadHD();
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
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            
            if (currentId == -1) MessageBox.Show("Bạn chưa chọn hóa đơn thanh toán", "Thông báo");
            if (currentId > 0)
            {
                hoaDonSevices.UpdateHD(currentId, 0, null);
                MessageBox.Show("Thanh toán thành công", "Thanh toán");
                dtg_HoaDonCho.Rows.Clear();
                LoadHD();
                currentId = -1;
            }
        }
    }
}
