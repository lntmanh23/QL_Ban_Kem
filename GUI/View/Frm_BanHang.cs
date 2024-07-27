using BUS.Services;
using BUS.ViewModels;
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
    public partial class Frm_BanHang : Form
    {
        static HoaDonSevices hoaDonSevices = new HoaDonSevices();
        static SanPhamServices SanPhamServices = new SanPhamServices();
        static HoaDonChiTietServices hoaDonChiTietServices = new HoaDonChiTietServices();
        static List<SanPham> _lstSanPhams = SanPhamServices.GetAllSanPham();

        public Frm_BanHang()
        {
            //SanPhamServices = new SanPhamServices();
            //_lstSanPhams = SanPhamServices.GetAllSanPham();
            //hoaDonChiTietServices = new HoaDonChiTietServices();

            //hoaDonSevices = new HoaDonSevices();
            InitializeComponent();

        }
        public void LoadHoaDon()
        {


            dtg_TaoHoaDon.ColumnCount = 8;
            dtg_TaoHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_TaoHoaDon.Columns[1].HeaderText = "Mã sản phẩm";
            dtg_TaoHoaDon.Columns[2].HeaderText = "Tên sản phẩm";
            dtg_TaoHoaDon.Columns[3].HeaderText = "Số lượng";
            dtg_TaoHoaDon.Columns[4].HeaderText = "Giá";
            dtg_TaoHoaDon.Columns[5].HeaderText = "Thuế";
            dtg_TaoHoaDon.Columns[6].HeaderText = "Thành tiền";
            dtg_TaoHoaDon.Columns[7].HeaderText = "Mô tả";

            var hd = hoaDonChiTietServices.GetHD_HDCT();
            foreach (var data in hd)
            {
                dtg_TaoHoaDon.Rows.Add(data.IdHd, data.IdSp, data.TenSp, data.SoLuong, data.Gia, data.Thue, data.ThanhTien, data.MoTa);
            }

        }
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            //LoadView();
            LoadToSpPanel();
        }
        public void LoadToSpPanel()
        {
            tlp_SanPham.Controls.Clear();
            int page = 1;
            int numberOfPage = (int)Math.Ceiling((double)_lstSanPhams.Count / 6);
            if (page < 1 || page > numberOfPage) return;

            if (page * 6 - 6 < _lstSanPhams.Count)
            {
                Panel s1 = CreateSPToPanel(_lstSanPhams[page*6-6]);
                tlp_SanPham.Controls.Add(s1, 0, 0);
            }
            if (page * 6 - 5 < _lstSanPhams.Count)
            {
                Panel s2 = CreateSPToPanel(_lstSanPhams[page*6-5]);
                tlp_SanPham.Controls.Add(s2, 1, 0);
            }
            if (page * 6 - 4 < _lstSanPhams.Count)
            {
                Panel s3 = CreateSPToPanel(_lstSanPhams[page*6-4]);
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
            p.Name = sp.Id.ToString();
            p.Size = new Size(271, 303);
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(247, 218);
            ptb.Image = Image.FromFile(sp.AnhSanPham);
            ptb.Location = new Point(12, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            Label lbgia = new Label();
            lbgia.Text = "Giá:";
            lbgia.Location = new Point(12, 233);
            Label giavalue = new Label();
            giavalue.Location = new Point(12, 267);
            giavalue.Text = sp.GiaSanPham+"VNĐ";
            Label lbsl = new Label();
            lbsl.Text = "Số lượng mua:";
            lbsl.Location = new Point(188, 233);
           
            TextBox tbSlMua = new TextBox();
            tbSlMua.Location = new Point(138, 264);
            tbSlMua.Size = new Size(121, 27);
            tbSlMua.PlaceholderText = "Số lượng mua";
            tbSlMua.Name = "tblSlMua";
            p.Controls.Add(ptb);
            p.Controls.Add(giavalue);
            p.Controls.Add(lbgia);
            p.Controls.Add(lbsl);
            p.Controls.Add(tbSlMua);
            ptb.Click += Ptb_Click;
            return p;
        }

        private void Ptb_Click(object? sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            TextBox textBox = new TextBox();    
            Control parentControl = p.Parent;
            Panel p1 = (Panel)parentControl.Parent;
            MessageBox.Show("Bạn vừa chọn mua sản phẩm có id là " +parentControl.Name+ "Với số lượng là" +textBox.Text);     
        }
    }
}
