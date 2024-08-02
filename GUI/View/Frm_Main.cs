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
        public Frm_Main(int idTk)
        {  
            this.idTk = idTk;
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
            
        }
    }
}
