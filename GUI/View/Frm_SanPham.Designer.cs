namespace GUI.View
{
    partial class Frm_SanPham
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
            label8 = new Label();
            cbbKm = new ComboBox();
            label5 = new Label();
            btn_CapNhatSanPham = new Button();
            txt_DonGia = new TextBox();
            btn_ThemSanPham = new Button();
            label10 = new Label();
            cbb_TrangThaiSP = new ComboBox();
            txt_SoLuongSP = new TextBox();
            cbb_LoaiSP = new ComboBox();
            txt_TenSP = new TextBox();
            txt_MaSP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_SP = new PictureBox();
            panel2 = new Panel();
            btnXoa = new Button();
            dtg_QuanLySP = new DataGridView();
            label12 = new Label();
            cbbTrangThaiLoaiSp = new ComboBox();
            btnCapNhatLoaiSP = new Button();
            btnThemLoaiSP = new Button();
            dtgLoaiSP = new DataGridView();
            label6 = new Label();
            txtTenLoaiSP = new TextBox();
            label11 = new Label();
            btn_TimSanPham = new Button();
            txt_TenSPTimKiem = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_SP).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgLoaiSP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbKm);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_CapNhatSanPham);
            panel1.Controls.Add(txt_DonGia);
            panel1.Controls.Add(btn_ThemSanPham);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbb_TrangThaiSP);
            panel1.Controls.Add(txt_SoLuongSP);
            panel1.Controls.Add(cbb_LoaiSP);
            panel1.Controls.Add(txt_TenSP);
            panel1.Controls.Add(txt_MaSP);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptb_SP);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 974);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(45, 684);
            label8.Name = "label8";
            label8.Size = new Size(147, 31);
            label8.TabIndex = 21;
            label8.Text = "Khuyến mại:";
            // 
            // cbbKm
            // 
            cbbKm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbKm.FormattingEnabled = true;
            cbbKm.Location = new Point(225, 679);
            cbbKm.Name = "cbbKm";
            cbbKm.Size = new Size(483, 39);
            cbbKm.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(45, 753);
            label5.Name = "label5";
            label5.Size = new Size(128, 31);
            label5.TabIndex = 19;
            label5.Text = "Trạng thái:";
            // 
            // btn_CapNhatSanPham
            // 
            btn_CapNhatSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_CapNhatSanPham.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CapNhatSanPham.Location = new Point(405, 821);
            btn_CapNhatSanPham.Name = "btn_CapNhatSanPham";
            btn_CapNhatSanPham.Size = new Size(237, 126);
            btn_CapNhatSanPham.TabIndex = 17;
            btn_CapNhatSanPham.Text = "Cập nhật";
            btn_CapNhatSanPham.UseVisualStyleBackColor = false;
            btn_CapNhatSanPham.Click += btn_CapNhatSanPham_Click;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DonGia.Location = new Point(225, 543);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.PlaceholderText = "Nhập đơn giá";
            txt_DonGia.Size = new Size(483, 38);
            txt_DonGia.TabIndex = 15;
            // 
            // btn_ThemSanPham
            // 
            btn_ThemSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThemSanPham.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemSanPham.Location = new Point(96, 821);
            btn_ThemSanPham.Name = "btn_ThemSanPham";
            btn_ThemSanPham.Size = new Size(237, 126);
            btn_ThemSanPham.TabIndex = 16;
            btn_ThemSanPham.Text = "Thêm";
            btn_ThemSanPham.UseVisualStyleBackColor = false;
            btn_ThemSanPham.Click += btn_ThemSanPham_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(45, 471);
            label10.Name = "label10";
            label10.Size = new Size(174, 31);
            label10.TabIndex = 14;
            label10.Text = "Loại sản phẩm:";
            // 
            // cbb_TrangThaiSP
            // 
            cbb_TrangThaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThaiSP.FormattingEnabled = true;
            cbb_TrangThaiSP.Items.AddRange(new object[] { "Đang kinh doanh", "Ngừng kinh doanh" });
            cbb_TrangThaiSP.Location = new Point(225, 748);
            cbb_TrangThaiSP.Name = "cbb_TrangThaiSP";
            cbb_TrangThaiSP.Size = new Size(483, 39);
            cbb_TrangThaiSP.TabIndex = 13;
            // 
            // txt_SoLuongSP
            // 
            txt_SoLuongSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SoLuongSP.Location = new Point(225, 612);
            txt_SoLuongSP.Name = "txt_SoLuongSP";
            txt_SoLuongSP.PlaceholderText = "Nhập số lượng";
            txt_SoLuongSP.Size = new Size(483, 38);
            txt_SoLuongSP.TabIndex = 10;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(225, 468);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(483, 39);
            cbb_LoaiSP.TabIndex = 9;
            // 
            // txt_TenSP
            // 
            txt_TenSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenSP.Location = new Point(225, 395);
            txt_TenSP.Name = "txt_TenSP";
            txt_TenSP.PlaceholderText = "Nhập tên sản phẩm";
            txt_TenSP.Size = new Size(483, 38);
            txt_TenSP.TabIndex = 8;
            // 
            // txt_MaSP
            // 
            txt_MaSP.Enabled = false;
            txt_MaSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MaSP.Location = new Point(225, 319);
            txt_MaSP.Name = "txt_MaSP";
            txt_MaSP.Size = new Size(483, 38);
            txt_MaSP.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(45, 615);
            label4.Name = "label4";
            label4.Size = new Size(117, 31);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(45, 543);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(45, 395);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(45, 322);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm:";
            // 
            // ptb_SP
            // 
            ptb_SP.BackColor = Color.FromArgb(255, 255, 192);
            ptb_SP.Location = new Point(187, 9);
            ptb_SP.Name = "ptb_SP";
            ptb_SP.Size = new Size(371, 304);
            ptb_SP.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_SP.TabIndex = 0;
            ptb_SP.TabStop = false;
            ptb_SP.Click += ptb_SP_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(dtg_QuanLySP);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cbbTrangThaiLoaiSp);
            panel2.Controls.Add(btnCapNhatLoaiSP);
            panel2.Controls.Add(btnThemLoaiSP);
            panel2.Controls.Add(dtgLoaiSP);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtTenLoaiSP);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btn_TimSanPham);
            panel2.Controls.Add(txt_TenSPTimKiem);
            panel2.Controls.Add(label7);
            panel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            panel2.Location = new Point(749, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 974);
            panel2.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(714, 148);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 38);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtg_QuanLySP
            // 
            dtg_QuanLySP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_QuanLySP.BackgroundColor = Color.White;
            dtg_QuanLySP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_QuanLySP.Location = new Point(3, 214);
            dtg_QuanLySP.Name = "dtg_QuanLySP";
            dtg_QuanLySP.RowHeadersWidth = 51;
            dtg_QuanLySP.Size = new Size(836, 292);
            dtg_QuanLySP.TabIndex = 16;
            dtg_QuanLySP.CellClick += dtg_QuanLySP_CellClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 606);
            label12.Name = "label12";
            label12.Size = new Size(128, 31);
            label12.TabIndex = 15;
            label12.Text = "Trạng thái:";
            // 
            // cbbTrangThaiLoaiSp
            // 
            cbbTrangThaiLoaiSp.FormattingEnabled = true;
            cbbTrangThaiLoaiSp.Items.AddRange(new object[] { "Đang kinh doanh", "Ngừng kinh doanh" });
            cbbTrangThaiLoaiSp.Location = new Point(234, 606);
            cbbTrangThaiLoaiSp.Name = "cbbTrangThaiLoaiSp";
            cbbTrangThaiLoaiSp.Size = new Size(592, 39);
            cbbTrangThaiLoaiSp.TabIndex = 14;
            // 
            // btnCapNhatLoaiSP
            // 
            btnCapNhatLoaiSP.BackColor = Color.FromArgb(255, 192, 192);
            btnCapNhatLoaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCapNhatLoaiSP.Location = new Point(484, 895);
            btnCapNhatLoaiSP.Name = "btnCapNhatLoaiSP";
            btnCapNhatLoaiSP.Size = new Size(234, 70);
            btnCapNhatLoaiSP.TabIndex = 13;
            btnCapNhatLoaiSP.Text = "Cập nhật";
            btnCapNhatLoaiSP.UseVisualStyleBackColor = false;
            btnCapNhatLoaiSP.Click += btnCapNhatLoaiSP_Click;
            // 
            // btnThemLoaiSP
            // 
            btnThemLoaiSP.BackColor = Color.FromArgb(255, 192, 192);
            btnThemLoaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnThemLoaiSP.Location = new Point(163, 895);
            btnThemLoaiSP.Name = "btnThemLoaiSP";
            btnThemLoaiSP.Size = new Size(234, 70);
            btnThemLoaiSP.TabIndex = 12;
            btnThemLoaiSP.Text = "Thêm";
            btnThemLoaiSP.UseVisualStyleBackColor = false;
            btnThemLoaiSP.Click += btnThemLoaiSP_Click;
            // 
            // dtgLoaiSP
            // 
            dtgLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLoaiSP.BackgroundColor = Color.White;
            dtgLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLoaiSP.Location = new Point(3, 669);
            dtgLoaiSP.Name = "dtgLoaiSP";
            dtgLoaiSP.RowHeadersWidth = 51;
            dtgLoaiSP.Size = new Size(839, 201);
            dtgLoaiSP.TabIndex = 11;
            dtgLoaiSP.CellClick += dtgLoaiSP_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 532);
            label6.Name = "label6";
            label6.Size = new Size(212, 31);
            label6.TabIndex = 10;
            label6.Text = "Tên loại sản phẩm:";
            // 
            // txtTenLoaiSP
            // 
            txtTenLoaiSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenLoaiSP.Location = new Point(234, 525);
            txtTenLoaiSP.Name = "txtTenLoaiSP";
            txtTenLoaiSP.PlaceholderText = "Nhập tên loại sản phẩm";
            txtTenLoaiSP.Size = new Size(592, 38);
            txtTenLoaiSP.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(226, 15);
            label11.Name = "label11";
            label11.Size = new Size(411, 60);
            label11.TabIndex = 8;
            label11.Text = "Quản Lý Sản Phẩm";
            // 
            // btn_TimSanPham
            // 
            btn_TimSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btn_TimSanPham.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TimSanPham.Location = new Point(578, 148);
            btn_TimSanPham.Name = "btn_TimSanPham";
            btn_TimSanPham.Size = new Size(121, 38);
            btn_TimSanPham.TabIndex = 5;
            btn_TimSanPham.Text = "Tìm";
            btn_TimSanPham.UseVisualStyleBackColor = false;
            btn_TimSanPham.Click += btn_TimSanPham_Click;
            // 
            // txt_TenSPTimKiem
            // 
            txt_TenSPTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenSPTimKiem.Location = new Point(4, 148);
            txt_TenSPTimKiem.Name = "txt_TenSPTimKiem";
            txt_TenSPTimKiem.PlaceholderText = "Tìm kiếm";
            txt_TenSPTimKiem.Size = new Size(561, 38);
            txt_TenSPTimKiem.TabIndex = 4;
            txt_TenSPTimKiem.TextChanged += txt_TenSPTimKiem_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(5, 94);
            label7.Name = "label7";
            label7.Size = new Size(166, 31);
            label7.TabIndex = 1;
            label7.Text = "Tên sản phẩm:";
            // 
            // Frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_SanPham";
            Text = "Sản phẩm";
            Load += Frm_SanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_SP).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_QuanLySP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgLoaiSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Button btn_CapNhatSanPham;
		private Button btn_ThemSanPham;
		private Label label10;
		private ComboBox cbb_TrangThaiSP;
		private TextBox txt_SoLuongSP;
		private ComboBox cbb_LoaiSP;
		private TextBox txt_TenSP;
		private TextBox txt_MaSP;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox ptb_SP;
		private TextBox txt_DonGia;
		private Label label5;
		private Panel panel2;
		private Label label11;
		private Button btn_TimSanPham;
		private TextBox txt_TenSPTimKiem;
		private Label label7;
        private TextBox txtTenLoaiSP;
        private Label label6;
        private DataGridView dtgLoaiSP;
        private Button btnCapNhatLoaiSP;
        private Button btnThemLoaiSP;
        private ComboBox cbbTrangThaiLoaiSp;
        private Label label12;
        private DataGridView dtg_QuanLySP;
        private Label label8;
        private ComboBox cbbKm;
        private Button btnXoa;
    }
}