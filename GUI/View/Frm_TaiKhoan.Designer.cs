﻿namespace GUI.View
{
    partial class Frm_TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cbbTrangThaiTaiKhoan = new ComboBox();
            cbbQuyen = new ComboBox();
            btn_CapNhatNhanVien = new Button();
            btn_ThemNhanVien = new Button();
            rd_Nu = new RadioButton();
            rd_Nam = new RadioButton();
            txt_SDT = new TextBox();
            txt_MatKhau = new TextBox();
            txt_TaiKhoan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_TaiKhoan = new PictureBox();
            panel2 = new Panel();
            label11 = new Label();
            btn_TimNhanVien = new Button();
            txtSearchTaiKhoan = new TextBox();
            label7 = new Label();
            dtg_QuanLyNhanVien = new DataGridView();
            btnXoa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLyNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbTrangThaiTaiKhoan);
            panel1.Controls.Add(cbbQuyen);
            panel1.Controls.Add(btn_CapNhatNhanVien);
            panel1.Controls.Add(btn_ThemNhanVien);
            panel1.Controls.Add(rd_Nu);
            panel1.Controls.Add(rd_Nam);
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(txt_TaiKhoan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptb_TaiKhoan);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 974);
            panel1.TabIndex = 0;
            // 
            // cbbTrangThaiTaiKhoan
            // 
            cbbTrangThaiTaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbTrangThaiTaiKhoan.FormattingEnabled = true;
            cbbTrangThaiTaiKhoan.Items.AddRange(new object[] { "Đang làm", "Nghỉ làm" });
            cbbTrangThaiTaiKhoan.Location = new Point(200, 792);
            cbbTrangThaiTaiKhoan.Name = "cbbTrangThaiTaiKhoan";
            cbbTrangThaiTaiKhoan.Size = new Size(497, 39);
            cbbTrangThaiTaiKhoan.TabIndex = 19;
            cbbTrangThaiTaiKhoan.SelectedIndexChanged += cbbTrangThaiTaiKhoan_SelectedIndexChanged;
            // 
            // cbbQuyen
            // 
            cbbQuyen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbQuyen.FormattingEnabled = true;
            cbbQuyen.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cbbQuyen.Location = new Point(200, 585);
            cbbQuyen.Name = "cbbQuyen";
            cbbQuyen.Size = new Size(497, 39);
            cbbQuyen.TabIndex = 18;
            // 
            // btn_CapNhatNhanVien
            // 
            btn_CapNhatNhanVien.BackColor = Color.FromArgb(255, 192, 192);
            btn_CapNhatNhanVien.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CapNhatNhanVien.Location = new Point(405, 862);
            btn_CapNhatNhanVien.Name = "btn_CapNhatNhanVien";
            btn_CapNhatNhanVien.Size = new Size(237, 85);
            btn_CapNhatNhanVien.TabIndex = 17;
            btn_CapNhatNhanVien.Text = "Cập nhật";
            btn_CapNhatNhanVien.UseVisualStyleBackColor = false;
            btn_CapNhatNhanVien.Click += btn_CapNhatNhanVien_Click;
            // 
            // btn_ThemNhanVien
            // 
            btn_ThemNhanVien.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThemNhanVien.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThemNhanVien.Location = new Point(96, 862);
            btn_ThemNhanVien.Name = "btn_ThemNhanVien";
            btn_ThemNhanVien.Size = new Size(237, 85);
            btn_ThemNhanVien.TabIndex = 16;
            btn_ThemNhanVien.Text = "Thêm";
            btn_ThemNhanVien.UseVisualStyleBackColor = false;
            btn_ThemNhanVien.Click += btn_ThemNhanVien_Click;
            // 
            // rd_Nu
            // 
            rd_Nu.AutoSize = true;
            rd_Nu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rd_Nu.Location = new Point(327, 730);
            rd_Nu.Name = "rd_Nu";
            rd_Nu.Size = new Size(68, 35);
            rd_Nu.TabIndex = 12;
            rd_Nu.TabStop = true;
            rd_Nu.Text = "Nữ";
            rd_Nu.UseVisualStyleBackColor = true;
            // 
            // rd_Nam
            // 
            rd_Nam.AutoSize = true;
            rd_Nam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rd_Nam.Location = new Point(200, 729);
            rd_Nam.Name = "rd_Nam";
            rd_Nam.Size = new Size(86, 35);
            rd_Nam.TabIndex = 11;
            rd_Nam.TabStop = true;
            rd_Nam.Text = "Nam";
            rd_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SDT.Location = new Point(200, 656);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.PlaceholderText = "Nhập số điện thoại";
            txt_SDT.Size = new Size(497, 38);
            txt_SDT.TabIndex = 10;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MatKhau.Location = new Point(200, 513);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.PlaceholderText = "Nhập mật khẩu";
            txt_MatKhau.Size = new Size(497, 38);
            txt_MatKhau.TabIndex = 8;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TaiKhoan.Location = new Point(200, 437);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.PlaceholderText = "Nhập tài khoản";
            txt_TaiKhoan.Size = new Size(497, 38);
            txt_TaiKhoan.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(22, 795);
            label6.Name = "label6";
            label6.Size = new Size(128, 31);
            label6.TabIndex = 6;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(22, 732);
            label5.Name = "label5";
            label5.Size = new Size(114, 31);
            label5.TabIndex = 5;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(22, 659);
            label4.Name = "label4";
            label4.Size = new Size(63, 31);
            label4.TabIndex = 4;
            label4.Text = "SĐT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(22, 588);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 3;
            label3.Text = "Quyền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(22, 516);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(22, 440);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // ptb_TaiKhoan
            // 
            ptb_TaiKhoan.Image = PRL.Properties.Resources.avatar_3637425_1280;
            ptb_TaiKhoan.Location = new Point(187, 9);
            ptb_TaiKhoan.Name = "ptb_TaiKhoan";
            ptb_TaiKhoan.Size = new Size(371, 405);
            ptb_TaiKhoan.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_TaiKhoan.TabIndex = 0;
            ptb_TaiKhoan.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btn_TimNhanVien);
            panel2.Controls.Add(txtSearchTaiKhoan);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtg_QuanLyNhanVien);
            panel2.Location = new Point(749, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 974);
            panel2.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(226, 51);
            label11.Name = "label11";
            label11.Size = new Size(423, 60);
            label11.TabIndex = 8;
            label11.Text = "Quản Lý Nhân Viên";
            // 
            // btn_TimNhanVien
            // 
            btn_TimNhanVien.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimNhanVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimNhanVien.Location = new Point(569, 238);
            btn_TimNhanVien.Name = "btn_TimNhanVien";
            btn_TimNhanVien.Size = new Size(125, 38);
            btn_TimNhanVien.TabIndex = 5;
            btn_TimNhanVien.Text = "Tìm";
            btn_TimNhanVien.UseVisualStyleBackColor = false;
            btn_TimNhanVien.Click += btn_TimNhanVien_Click;
            // 
            // txtSearchTaiKhoan
            // 
            txtSearchTaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTaiKhoan.Location = new Point(13, 238);
            txtSearchTaiKhoan.Name = "txtSearchTaiKhoan";
            txtSearchTaiKhoan.PlaceholderText = "Tìm kiếm";
            txtSearchTaiKhoan.Size = new Size(550, 38);
            txtSearchTaiKhoan.TabIndex = 4;
            txtSearchTaiKhoan.TextChanged += txtSearchTaiKhoan_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(164, 31);
            label7.TabIndex = 1;
            label7.Text = "Tên tài khoản:";
            // 
            // dtg_QuanLyNhanVien
            // 
            dtg_QuanLyNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_QuanLyNhanVien.BackgroundColor = Color.White;
            dtg_QuanLyNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_QuanLyNhanVien.Location = new Point(3, 324);
            dtg_QuanLyNhanVien.Name = "dtg_QuanLyNhanVien";
            dtg_QuanLyNhanVien.RowHeadersWidth = 51;
            dtg_QuanLyNhanVien.Size = new Size(842, 647);
            dtg_QuanLyNhanVien.TabIndex = 0;
            dtg_QuanLyNhanVien.CellClick += dtg_QuanLyNhanVien_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(710, 238);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Frm_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_TaiKhoan";
            Text = "Tài khoản";
            Load += Frm_TaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLyNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox ptb_TaiKhoan;
		private Panel panel2;
		private RadioButton rd_Nu;
		private RadioButton rd_Nam;
		private TextBox txt_SDT;
		private TextBox txt_MatKhau;
		private TextBox txt_TaiKhoan;
		private Label label7;
		private DataGridView dtg_QuanLyNhanVien;
		private Button btn_TimNhanVien;
		private TextBox txtSearchTaiKhoan;
		private Label label11;
		private Button btn_CapNhatNhanVien;
		private Button btn_ThemNhanVien;
        private ComboBox cbbTrangThaiTaiKhoan;
        private ComboBox cbbQuyen;
        private Button btnXoa;
    }
}