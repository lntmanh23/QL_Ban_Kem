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
            if (txtUser != null && txtPassWord != null)
            {
                string tenTaiKhoan = txtUser.Text;
                string matKhau = txtPassWord.Text;
                if (TaiKhoanServices.Login(tenTaiKhoan, matKhau) == "0")
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                }
                else if (TaiKhoanServices.Login(tenTaiKhoan, matKhau) == "1")
                {
                    MessageBox.Show("Đăng nhập thất bại", "Trùng tài khoản");
                }
                else
                {
                    int idTk = int.Parse(TaiKhoanServices.Login(tenTaiKhoan, matKhau));
                    Frm_Main frmMain = new Frm_Main(idTk);
                    
                    frmMain.ShowDialog();
                    this.Hide();
                    frmMain.FormClosed += FrmMain_FormClosed;
                    this.Show();
                }
            }
            else
            {
                //MessageBox.Show("chưa đc khoeri tạo");
            }
        }

        private void FrmMain_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassWord.PasswordChar = '\0';
            }
            else txtPassWord.PasswordChar = '*';
        }
    }
}
