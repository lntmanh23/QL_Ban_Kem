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
    public partial class Frm_Main : Form
    {
        HoaDonSevices hoaDonSevices = new HoaDonSevices();
        AppDbContext _context = new AppDbContext();
        TaiKhoanServices TaiKhoanServices = new TaiKhoanServices();
        int idTk;
        string thongTinTk;
        public Frm_Main(int idTk, string thongTinTK)
        {
            this.idTk = idTk;
            this.thongTinTk = thongTinTK;
            InitializeComponent();

        }
        private Form activeForm;
        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnBody.Controls.Add(form);
            pnBody.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_BanHang(idTk));

        }
        private void btn_ThucDonMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_SanPham());
        }

        private void btn_HoaDonMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_HoaDon());
        }

        private void btn_KhuyenMaiMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_KhuyenMai());
        }

        private void btn_DoanhThuMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_DoanhThu());
        }

        private void btn_TaiKhoanMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_TaiKhoan());
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbTenTaiKhoan.Text = TaiKhoanServices.GetAllTaiKhoan().Where(p => p.Id == idTk).Select(p => p.TenTaiKhoan).FirstOrDefault();
            lbquyen.Text = TaiKhoanServices.GetAllTaiKhoan().Where(p => p.Id == idTk).Select(p => Convert.ToString(p.Quyen)).FirstOrDefault();
            if (lbquyen.Text != "0")
            {
                lbquyen.Visible = false;
                btn_DoanhThuMain.Visible = false;
                btn_TaiKhoanMain.Visible = false;
                btn_ThucDonMain.Visible = false;
                btn_HoaDonMain.Visible = false;
                btn_KhuyenMaiMain.Visible = false;
            }
            else
            {
                lbquyen.Visible = false;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Cứ sau 1000ms = 1s sẽ tái kích hoạt sk
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
