namespace GUI.View
{
	partial class Frm_BanHang
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
            label1 = new Label();
            panel2 = new Panel();
            dtg_TaoHoaDon = new DataGridView();
            btn_TaoHoaDon = new Button();
            panel4 = new Panel();
            txtMaHoaDon = new TextBox();
            label2 = new Label();
            btn_ThanhToan = new Button();
            txtTienThua = new TextBox();
            txt_TienKhachTra = new TextBox();
            cbb_LoaiThanhToan = new ComboBox();
            txt_TongTienSP = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            dtg_HoaDonCho = new DataGridView();
            label3 = new Label();
            tlp_SanPham = new TableLayoutPanel();
            lbback = new Label();
            lb_page = new Label();
            lbnext = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_TaoHoaDon).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDonCho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 90);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(202, 21);
            label1.Name = "label1";
            label1.Size = new Size(424, 48);
            label1.TabIndex = 0;
            label1.Text = "Windows Ice Cream";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtg_TaoHoaDon);
            panel2.Controls.Add(btn_TaoHoaDon);
            panel2.Location = new Point(822, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 481);
            panel2.TabIndex = 2;
            // 
            // dtg_TaoHoaDon
            // 
            dtg_TaoHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_TaoHoaDon.BackgroundColor = Color.White;
            dtg_TaoHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_TaoHoaDon.Location = new Point(6, 54);
            dtg_TaoHoaDon.Name = "dtg_TaoHoaDon";
            dtg_TaoHoaDon.RowHeadersWidth = 51;
            dtg_TaoHoaDon.Size = new Size(772, 421);
            dtg_TaoHoaDon.TabIndex = 2;
            dtg_TaoHoaDon.CellClick += dtg_TaoHoaDon_CellClick;
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.BackColor = Color.FromArgb(255, 192, 192);
            btn_TaoHoaDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TaoHoaDon.Location = new Point(581, 10);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(194, 38);
            btn_TaoHoaDon.TabIndex = 0;
            btn_TaoHoaDon.Text = "Tạo hóa đơn";
            btn_TaoHoaDon.UseVisualStyleBackColor = false;
            btn_TaoHoaDon.Click += btn_TaoHoaDon_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtMaHoaDon);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btn_ThanhToan);
            panel4.Controls.Add(txtTienThua);
            panel4.Controls.Add(txt_TienKhachTra);
            panel4.Controls.Add(cbb_LoaiThanhToan);
            panel4.Controls.Add(txt_TongTienSP);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(822, 489);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 487);
            panel4.TabIndex = 4;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Enabled = false;
            txtMaHoaDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaHoaDon.Location = new Point(244, 23);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(531, 38);
            txtMaHoaDon.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 23);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 14;
            label2.Text = "Mã hóa đơn:";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 192, 192);
            btn_ThanhToan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThanhToan.Location = new Point(292, 343);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(232, 122);
            btn_ThanhToan.TabIndex = 13;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // txtTienThua
            // 
            txtTienThua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTienThua.Location = new Point(581, 190);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.Size = new Size(194, 38);
            txtTienThua.TabIndex = 11;
            // 
            // txt_TienKhachTra
            // 
            txt_TienKhachTra.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TienKhachTra.Location = new Point(244, 189);
            txt_TienKhachTra.Name = "txt_TienKhachTra";
            txt_TienKhachTra.Size = new Size(203, 38);
            txt_TienKhachTra.TabIndex = 10;
            txt_TienKhachTra.TextChanged += txt_TienKhachTra_TextChanged;
            // 
            // cbb_LoaiThanhToan
            // 
            cbb_LoaiThanhToan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbb_LoaiThanhToan.FormattingEnabled = true;
            cbb_LoaiThanhToan.Items.AddRange(new object[] { "Chuyển khoản", "Tiền mặt" });
            cbb_LoaiThanhToan.Location = new Point(244, 267);
            cbb_LoaiThanhToan.Name = "cbb_LoaiThanhToan";
            cbb_LoaiThanhToan.Size = new Size(531, 39);
            cbb_LoaiThanhToan.TabIndex = 9;
            cbb_LoaiThanhToan.SelectedIndexChanged += cbb_LoaiThanhToan_SelectedIndexChanged;
            // 
            // txt_TongTienSP
            // 
            txt_TongTienSP.Enabled = false;
            txt_TongTienSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TongTienSP.Location = new Point(244, 105);
            txt_TongTienSP.Name = "txt_TongTienSP";
            txt_TongTienSP.Size = new Size(531, 38);
            txt_TongTienSP.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 275);
            label8.Name = "label8";
            label8.Size = new Size(189, 31);
            label8.TabIndex = 4;
            label8.Text = "Loại thanh toán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(453, 192);
            label7.Name = "label7";
            label7.Size = new Size(122, 31);
            label7.TabIndex = 3;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 191);
            label6.Name = "label6";
            label6.Size = new Size(172, 31);
            label6.TabIndex = 2;
            label6.Text = "Tiền khách trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 105);
            label5.Name = "label5";
            label5.Size = new Size(218, 31);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền hóa đơn:";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtg_HoaDonCho);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 756);
            panel5.Name = "panel5";
            panel5.Size = new Size(813, 220);
            panel5.TabIndex = 5;
            // 
            // dtg_HoaDonCho
            // 
            dtg_HoaDonCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_HoaDonCho.BackgroundColor = Color.White;
            dtg_HoaDonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDonCho.Location = new Point(9, 34);
            dtg_HoaDonCho.Name = "dtg_HoaDonCho";
            dtg_HoaDonCho.RowHeadersWidth = 51;
            dtg_HoaDonCho.Size = new Size(793, 183);
            dtg_HoaDonCho.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 0;
            label3.Text = "Hóa đơn chi tiết:";
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.AutoScroll = true;
            tlp_SanPham.ColumnCount = 3;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tlp_SanPham.Location = new Point(3, 98);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(813, 606);
            tlp_SanPham.TabIndex = 7;
            // 
            // lbback
            // 
            lbback.AutoSize = true;
            lbback.Location = new Point(254, 727);
            lbback.Name = "lbback";
            lbback.Size = new Size(29, 20);
            lbback.TabIndex = 8;
            lbback.Text = "<<";
            lbback.Click += lbback_Click;
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_page.Location = new Point(395, 727);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(22, 25);
            lb_page.TabIndex = 9;
            lb_page.Text = "1";
            // 
            // lbnext
            // 
            lbnext.AutoSize = true;
            lbnext.Location = new Point(543, 727);
            lbnext.Name = "lbnext";
            lbnext.Size = new Size(29, 20);
            lbnext.TabIndex = 10;
            lbnext.Text = ">>";
            lbnext.Click += lbnext_Click;
            // 
            // Frm_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(lbnext);
            Controls.Add(lb_page);
            Controls.Add(lbback);
            Controls.Add(tlp_SanPham);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_BanHang";
            Text = "Bán hàng";
            Load += Frm_BanHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_TaoHoaDon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDonCho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
		private Panel panel2;
		private Panel panel4;
		private Panel panel5;
		private Button btn_TaoHoaDon;
		private DataGridView dtg_HoaDonCho;
		private Label label3;
		private TableLayoutPanel tlp_SanPham;
		private DataGridView dtg_TaoHoaDon;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private TextBox txt_TongTienSP;
		private TextBox txtTienThua;
		private TextBox txt_TienKhachTra;
		private ComboBox cbb_LoaiThanhToan;
		private Button btn_ThanhToan;
        private Label lbback;
        private Label lb_page;
        private Label lbnext;
        private Label label1;
        private TextBox txtMaHoaDon;
        private Label label2;
    }
}