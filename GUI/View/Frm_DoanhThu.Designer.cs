namespace GUI.View
{
    partial class Frm_DoanhThu
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
            label1 = new Label();
            panel1 = new Panel();
            date_DenNgayTK = new DateTimePicker();
            date_TuNgayTK = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtgThongKeSanPham = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            lbSoluong = new Label();
            lbTensp = new Label();
            label11 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            panel3 = new Panel();
            lbDoanhThu = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongKeSanPham).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 60);
            label1.TabIndex = 0;
            label1.Text = "Thống kê \r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(date_DenNgayTK);
            panel1.Controls.Add(date_TuNgayTK);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtgThongKeSanPham);
            panel1.Location = new Point(12, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(1585, 496);
            panel1.TabIndex = 1;
            // 
            // date_DenNgayTK
            // 
            date_DenNgayTK.CalendarFont = new Font("Segoe UI", 9F);
            date_DenNgayTK.Font = new Font("Segoe UI", 18F);
            date_DenNgayTK.Location = new Point(987, 410);
            date_DenNgayTK.Name = "date_DenNgayTK";
            date_DenNgayTK.Size = new Size(578, 47);
            date_DenNgayTK.TabIndex = 8;
            // 
            // date_TuNgayTK
            // 
            date_TuNgayTK.CalendarFont = new Font("Segoe UI", 9F);
            date_TuNgayTK.Font = new Font("Segoe UI", 18F);
            date_TuNgayTK.Location = new Point(180, 412);
            date_TuNgayTK.Name = "date_TuNgayTK";
            date_TuNgayTK.Size = new Size(606, 47);
            date_TuNgayTK.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(801, 412);
            label4.Name = "label4";
            label4.Size = new Size(180, 46);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label3.Location = new Point(15, 412);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(283, 38);
            label2.TabIndex = 1;
            label2.Text = "Thống kê sản phẩm:";
            // 
            // dtgThongKeSanPham
            // 
            dtgThongKeSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgThongKeSanPham.BackgroundColor = Color.White;
            dtgThongKeSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongKeSanPham.Location = new Point(3, 65);
            dtgThongKeSanPham.Name = "dtgThongKeSanPham";
            dtgThongKeSanPham.RowHeadersWidth = 51;
            dtgThongKeSanPham.Size = new Size(1562, 309);
            dtgThongKeSanPham.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1585, 393);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Controls.Add(lbSoluong);
            panel4.Controls.Add(lbTensp);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(801, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 368);
            panel4.TabIndex = 1;
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lbSoluong.ForeColor = Color.White;
            lbSoluong.Location = new Point(382, 293);
            lbSoluong.Name = "lbSoluong";
            lbSoluong.Size = new Size(47, 46);
            lbSoluong.TabIndex = 5;
            lbSoluong.Text = "...";
            // 
            // lbTensp
            // 
            lbTensp.AutoSize = true;
            lbTensp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lbTensp.ForeColor = Color.White;
            lbTensp.Location = new Point(382, 206);
            lbTensp.Name = "lbTensp";
            lbTensp.Size = new Size(47, 46);
            lbTensp.TabIndex = 4;
            lbTensp.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(118, 293);
            label11.Name = "label11";
            label11.Size = new Size(174, 46);
            label11.TabIndex = 4;
            label11.Text = "Số lượng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(118, 206);
            label10.Name = "label10";
            label10.Size = new Size(247, 46);
            label10.TabIndex = 3;
            label10.Text = "Tên sản phẩm:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = PRL.Properties.Resources.banchay;
            pictureBox2.Location = new Point(32, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.IndianRed;
            label8.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(177, 70);
            label8.Name = "label8";
            label8.Size = new Size(581, 81);
            label8.TabIndex = 1;
            label8.Text = "Sản phẩm bán chạy";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(lbDoanhThu);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(15, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 368);
            panel3.TabIndex = 0;
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDoanhThu.ForeColor = Color.White;
            lbDoanhThu.Location = new Point(229, 225);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(79, 62);
            lbDoanhThu.TabIndex = 2;
            lbDoanhThu.Text = "....";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PRL.Properties.Resources.dt;
            pictureBox1.Location = new Point(152, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.IndianRed;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(288, 70);
            label7.Name = "label7";
            label7.Size = new Size(331, 81);
            label7.TabIndex = 0;
            label7.Text = "Doanh thu";
            // 
            // Frm_DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1609, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Frm_DoanhThu";
            Text = "Doanh thu";
            Load += Frm_DoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongKeSanPham).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtgThongKeSanPham;
        private DateTimePicker date_DenNgayTK;
        private DateTimePicker date_TuNgayTK;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label10;
        private Label lbDoanhThu;
        private Label lbSoluong;
        private Label lbTensp;
    }
}