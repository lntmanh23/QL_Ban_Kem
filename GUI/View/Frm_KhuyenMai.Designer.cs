namespace GUI.View
{
    partial class Frm_KhuyenMai
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
            txt_giatri = new TextBox();
            label3 = new Label();
            dateNgayKetThucKm = new DateTimePicker();
            dateNgayBatDauKM = new DateTimePicker();
            label5 = new Label();
            btn_CapNhatKm = new Button();
            btn_ThemKM = new Button();
            label10 = new Label();
            cbb_TrangThaiKM = new ComboBox();
            cbb_LoaiKM = new ComboBox();
            txt_TenKM = new TextBox();
            txt_MaKM = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_TaiKhoan = new PictureBox();
            panel2 = new Panel();
            dtgKhuyenMai = new DataGridView();
            label11 = new Label();
            btn_TimKM = new Button();
            txt_TenKMTimKiem = new TextBox();
            label7 = new Label();
            btnXoa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhuyenMai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_giatri);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateNgayKetThucKm);
            panel1.Controls.Add(dateNgayBatDauKM);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_CapNhatKm);
            panel1.Controls.Add(btn_ThemKM);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbb_TrangThaiKM);
            panel1.Controls.Add(cbb_LoaiKM);
            panel1.Controls.Add(txt_TenKM);
            panel1.Controls.Add(txt_MaKM);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptb_TaiKhoan);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 974);
            panel1.TabIndex = 2;
            // 
            // txt_giatri
            // 
            txt_giatri.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_giatri.Location = new Point(225, 575);
            txt_giatri.Name = "txt_giatri";
            txt_giatri.PlaceholderText = "Nhập giá trị";
            txt_giatri.Size = new Size(483, 38);
            txt_giatri.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(20, 579);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 22;
            label3.Text = "Giá trị:";
            // 
            // dateNgayKetThucKm
            // 
            dateNgayKetThucKm.Font = new Font("Segoe UI", 13.8F);
            dateNgayKetThucKm.Location = new Point(225, 713);
            dateNgayKetThucKm.Name = "dateNgayKetThucKm";
            dateNgayKetThucKm.Size = new Size(483, 38);
            dateNgayKetThucKm.TabIndex = 21;
            // 
            // dateNgayBatDauKM
            // 
            dateNgayBatDauKM.Font = new Font("Segoe UI", 13.8F);
            dateNgayBatDauKM.Location = new Point(225, 642);
            dateNgayBatDauKM.Name = "dateNgayBatDauKM";
            dateNgayBatDauKM.Size = new Size(483, 38);
            dateNgayBatDauKM.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(20, 781);
            label5.Name = "label5";
            label5.Size = new Size(128, 31);
            label5.TabIndex = 19;
            label5.Text = "Trạng thái:";
            // 
            // btn_CapNhatKm
            // 
            btn_CapNhatKm.BackColor = Color.FromArgb(255, 192, 192);
            btn_CapNhatKm.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CapNhatKm.Location = new Point(405, 833);
            btn_CapNhatKm.Name = "btn_CapNhatKm";
            btn_CapNhatKm.Size = new Size(237, 119);
            btn_CapNhatKm.TabIndex = 17;
            btn_CapNhatKm.Text = "Cập nhật";
            btn_CapNhatKm.UseVisualStyleBackColor = false;
            btn_CapNhatKm.Click += btn_CapNhatKm_Click;
            // 
            // btn_ThemKM
            // 
            btn_ThemKM.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThemKM.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThemKM.Location = new Point(96, 832);
            btn_ThemKM.Name = "btn_ThemKM";
            btn_ThemKM.Size = new Size(237, 119);
            btn_ThemKM.TabIndex = 16;
            btn_ThemKM.Text = "Thêm";
            btn_ThemKM.UseVisualStyleBackColor = false;
            btn_ThemKM.Click += btn_ThemKM_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(20, 512);
            label10.Name = "label10";
            label10.Size = new Size(196, 31);
            label10.TabIndex = 14;
            label10.Text = "Loại khuyến mại:";
            // 
            // cbb_TrangThaiKM
            // 
            cbb_TrangThaiKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiKM.FormattingEnabled = true;
            cbb_TrangThaiKM.Items.AddRange(new object[] { "Đang diễn ra", "Kết thúc" });
            cbb_TrangThaiKM.Location = new Point(225, 777);
            cbb_TrangThaiKM.Name = "cbb_TrangThaiKM";
            cbb_TrangThaiKM.Size = new Size(483, 39);
            cbb_TrangThaiKM.TabIndex = 13;
            // 
            // cbb_LoaiKM
            // 
            cbb_LoaiKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiKM.FormattingEnabled = true;
            cbb_LoaiKM.Items.AddRange(new object[] { "Theo phần trăm", "Theo giá" });
            cbb_LoaiKM.Location = new Point(225, 509);
            cbb_LoaiKM.Name = "cbb_LoaiKM";
            cbb_LoaiKM.Size = new Size(483, 39);
            cbb_LoaiKM.TabIndex = 9;
            // 
            // txt_TenKM
            // 
            txt_TenKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenKM.Location = new Point(225, 440);
            txt_TenKM.Name = "txt_TenKM";
            txt_TenKM.PlaceholderText = "Nhập tên khuyến mại";
            txt_TenKM.Size = new Size(483, 38);
            txt_TenKM.TabIndex = 8;
            // 
            // txt_MaKM
            // 
            txt_MaKM.Enabled = false;
            txt_MaKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MaKM.Location = new Point(225, 364);
            txt_MaKM.Name = "txt_MaKM";
            txt_MaKM.Size = new Size(483, 38);
            txt_MaKM.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(20, 709);
            label6.Name = "label6";
            label6.Size = new Size(170, 31);
            label6.TabIndex = 6;
            label6.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(20, 638);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 4;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(20, 443);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên khuyến mại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(20, 367);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã khuyến mại:";
            // 
            // ptb_TaiKhoan
            // 
            ptb_TaiKhoan.Image = PRL.Properties.Resources.sale;
            ptb_TaiKhoan.Location = new Point(187, 9);
            ptb_TaiKhoan.Name = "ptb_TaiKhoan";
            ptb_TaiKhoan.Size = new Size(371, 332);
            ptb_TaiKhoan.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_TaiKhoan.TabIndex = 0;
            ptb_TaiKhoan.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(dtgKhuyenMai);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btn_TimKM);
            panel2.Controls.Add(txt_TenKMTimKiem);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(750, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 974);
            panel2.TabIndex = 3;
            // 
            // dtgKhuyenMai
            // 
            dtgKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgKhuyenMai.BackgroundColor = Color.White;
            dtgKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKhuyenMai.Location = new Point(13, 290);
            dtgKhuyenMai.Name = "dtgKhuyenMai";
            dtgKhuyenMai.RowHeadersWidth = 51;
            dtgKhuyenMai.Size = new Size(823, 674);
            dtgKhuyenMai.TabIndex = 9;
            dtgKhuyenMai.CellClick += dtgKhuyenMai_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(226, 51);
            label11.Name = "label11";
            label11.Size = new Size(454, 60);
            label11.TabIndex = 8;
            label11.Text = "Quản Lý Khuyến Mại";
            // 
            // btn_TimKM
            // 
            btn_TimKM.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimKM.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimKM.Location = new Point(605, 237);
            btn_TimKM.Name = "btn_TimKM";
            btn_TimKM.Size = new Size(112, 38);
            btn_TimKM.TabIndex = 5;
            btn_TimKM.Text = "Tìm";
            btn_TimKM.UseVisualStyleBackColor = false;
            btn_TimKM.Click += btn_TimKM_Click;
            // 
            // txt_TenKMTimKiem
            // 
            txt_TenKMTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenKMTimKiem.Location = new Point(13, 238);
            txt_TenKMTimKiem.Name = "txt_TenKMTimKiem";
            txt_TenKMTimKiem.PlaceholderText = "Tìm kiếm";
            txt_TenKMTimKiem.Size = new Size(586, 38);
            txt_TenKMTimKiem.TabIndex = 4;
            txt_TenKMTimKiem.TextChanged += txt_TenKMTimKiem_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(188, 31);
            label7.TabIndex = 1;
            label7.Text = "Tên khuyến mại:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(724, 237);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 38);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Frm_KhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_KhuyenMai";
            Text = "Khuyến mại";
            Load += Frm_KhuyenMai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_TaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhuyenMai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btn_CapNhatKm;
        private Button btn_ThemKM;
        private Label label10;
        private ComboBox cbb_TrangThaiKM;
        private ComboBox cbb_LoaiKM;
        private TextBox txt_TenKM;
        private TextBox txt_MaKM;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox ptb_TaiKhoan;
        private Panel panel2;
        private DataGridView dtgKhuyenMai;
        private Label label11;
        private Button btn_TimKM;
        private TextBox txt_TenKMTimKiem;
        private Label label7;
        private DateTimePicker dateNgayKetThucKm;
        private DateTimePicker dateNgayBatDauKM;
        private TextBox txt_giatri;
        private Label label3;
        private Button btnXoa;
    }
}