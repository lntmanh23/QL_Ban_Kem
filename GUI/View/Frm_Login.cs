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
    public partial class Frm_Login : Form
    {
        AppDbContext _context;
        TaiKhoanServices TaiKhoanServices;
        public Frm_Login()
        {
            TaiKhoanServices = new TaiKhoanServices();
            _context = new AppDbContext();
            InitializeComponent();
            registerEvent();
        }
        #region
        void registerEvent()
        {
            lbClose.Click += LbClose_Click;
        }

        private void LbClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void btn_Login_Click(object sender, EventArgs e)
        {

            var tk = TaiKhoanServices.GetAllTaiKhoan();
            //string taikhoan = tk.TenTaiKhoan;
            //string matkhau = tk.MatKhau;
            
            //if(taikhoan == txtUser.Text && matkhau == txtPassWord.Text)
            //{
            //    Frm_Main frm = new Frm_Main();
            //    frm.ShowDialog();
            //}
            foreach (var t in tk)
            {
                if (t.TenTaiKhoan == txtUser.Text && t.MatKhau == txtPassWord.Text)
                {
                    Frm_Main frm = new Frm_Main();
                       frm.ShowDialog();
                }
            }
        }
    }
}
